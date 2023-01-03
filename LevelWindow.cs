using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Newtonsoft.Json.Linq;
using System.IO;

namespace chemaths
{
    public partial class LevelWindow : Form
    {
        int index, countR = 0, countW = 0;
        XmlDocument doc = new XmlDocument();
        XmlNodeList tasks, tasksR;
        XmlNode[] taskArray, taskArrayR;
        public int N_Results1;
        public int N_Results2;
        ActiveMainWindow tmp = new ActiveMainWindow();
        GameWindow tmp12 = new GameWindow();
        public string userName;
        public void Start()
        {
            doc.Load("Levels.xml");
            tasks = doc.SelectNodes($"/root/level[@number='{(int)numericUpDown1.Value}']/task");
            tasksR = doc.SelectNodes($"/root/level[@number='results{(int)numericUpDown1.Value}']/task");
            taskArray = tasks.OfType<XmlNode>().ToArray();
            taskArrayR = tasksR.OfType<XmlNode>().ToArray();
        }

        private void pictureBox_start_Click(object sender, EventArgs e)
        {
            label3.Visible = numericUpDown1.Visible = pictureBox_confirm.Visible = false;
            label5.Visible = true;
            label5.Text = "Рівняння: 1";
            input_box.Visible = true;
            output_box.Visible = true;
            pictureBox_start.Visible = false;
            output_box.Text = taskArray[0].InnerText;
            check_btn.Visible = true;
            label4.Visible = true;
        }

        private void on_off_items(bool commutator)
        {
            check_btn.Visible = true;
            help_panel.Visible = commutator;
            label5.Visible = check_btn.Enabled = !commutator;

        }

        private void help_btn_Click(object sender, EventArgs e)
        {
            on_off_items(true);
        }


        public LevelWindow()
        {
            InitializeComponent();
        }

        private void help_close_btn_Click(object sender, EventArgs e)
        {
            on_off_items(false);
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            tmp12.Show();
        }

        private void check_btn_Click(object sender, EventArgs e)
        {
            if (index != taskArray.Length + 1)
            {
                if (index == taskArray.Length) { }
                else { label5.Text = "Рівняння: " + (index + 1).ToString(); }
                if (input_box.Text == taskArrayR[index - 1].InnerText)
                {
                    countR++;
                    MessageBox.Show("ВІДПОВІДЬ ПРАВИЛЬНА!");
                    output_box.Text = "";
                    input_box.Text = "";
                }
                else
                {
                    countW++;
                    MessageBox.Show("ВІДПОВІДЬ НЕПРАВИЛЬНА!");
                    output_box.Text = "";
                    input_box.Text = "";
                }
                if (index == taskArray.Length)
                {
                    input_box.Visible = false; output_box.Visible = false; label4.Visible = false;
                    label5.Text = "НАТИСНІТЬ НА КНОПКУ ЩЕ РАЗ ЩОБ ДІЗНАТИСЬ СВІЙ РЕЗУЛЬТАТ";
                }
                else output_box.Text = taskArray[index].InnerText;
                index++;
            }
            else
            {
                MessageBox.Show("Результат: " + countR + "/15");
                N_Results1 = countW; N_Results2 = countR;
                JObject file1 = JObject.Parse(File.ReadAllText("Results.json"));
                JObject file2 = new JObject();
                file2[userName] = countR; 
                file1.Merge(file2, new JsonMergeSettings
                {
                    MergeArrayHandling = MergeArrayHandling.Union
                });
                File.WriteAllText(@"Results.json", file1.ToString());
                this.Close();
                tmp.Show();
            }
        }
        public void Fisher_Yates(XmlNode[] taskArray, XmlNode[] taskArrayR)
        {
            Random rnd = new Random();
            for (int i = taskArray.Length - 1; i >= 1; i--)
            {
                int j = rnd.Next(i + 1);
                XmlNode temp1 = taskArray[j];
                XmlNode temp2 = taskArrayR[j];
                taskArray[j] = taskArray[i]; taskArrayR[j] = taskArrayR[i];
                taskArray[i] = temp1; taskArrayR[i] = temp2;
            }
        }
        private void active_panel_MouseDown(object sender, MouseEventArgs e)
        {
            active_panel.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            WndProc(ref m);
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LevelWindow_Load(object sender, EventArgs e)
        {
            help_panel.Visible = false;
            check_btn.Visible = false;
            pictureBox_start.Visible = false;
        }

        private void pictureBox_confirm_Click(object sender, EventArgs e)
        {
            Start();
            Fisher_Yates(taskArray, taskArrayR);
            label1.Text = "РІВЕНЬ: " + numericUpDown1.Value.ToString();
            label4.Text = "";
            label5.Text = "НАТИСНІТЬ КНОПКУ РОЗПОЧАТИ ЩОБ ПОЧАТИ!";
            output_box.Text = "";
            index = 1;
            pictureBox_confirm.Visible = false;
            pictureBox_start.Visible = true;
            check_btn.Visible = false;
        }
    }
}
