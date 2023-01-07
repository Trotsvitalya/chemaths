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
        public string userName;
        string result_choice;

        public void Start()
        {
            doc.Load("Levels.xml");
            tasks = doc.SelectNodes($"/root/level[@number='{(int)register_w.level_choice.Value}']/task");
            tasksR = doc.SelectNodes($"/root/level[@number='results{(int)register_w.level_choice.Value}']/task");
            taskArray = tasks.OfType<XmlNode>().ToArray();
            taskArrayR = tasksR.OfType<XmlNode>().ToArray();
        }

        private void help_btn_Click(object sender, EventArgs e)
        {
            help_panel.Visible = true;
        }

        RegisterWindow register_w;

        public LevelWindow(RegisterWindow tmp, string tmp_s)
        {
            InitializeComponent();
            register_w = tmp;
            result_choice = tmp_s;

            Start();
            Fisher_Yates(taskArray, taskArrayR);
            output_box.Text = "";
            index = 1;
            output_box.Text = taskArray[0].InnerText;
        }

        private void help_close_btn_Click(object sender, EventArgs e)
        {
            help_panel.Visible = false;
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            RegisterWindow tmp = new RegisterWindow();
            tmp.Show();
            tmp.SetBounds(this.Location.X, this.Location.Y, this.Width, this.Height);
            this.Hide();
        }

        private void check_btn_Click_1(object sender, EventArgs e)
        {
            if (index != taskArray.Length)
            {
                if (input_box.Text == taskArrayR[index - 1].InnerText)
                {
                    countR++;
                    if(result_choice == "yes")
                    {
                        MessageWindow message = new MessageWindow("Відповідь правильна!", "right");
                        message.ShowDialog();
                    }
                    output_box.Text = "";
                    input_box.Text = "";
                }
                else
                {
                    countW++;
                    if (result_choice == "yes")
                    {
                        MessageWindow message = new MessageWindow("Відповідь неправильна!", taskArrayR[index - 1].InnerText);
                        message.ShowDialog();
                    }
                    output_box.Text = "";
                    input_box.Text = "";
                }
                if (index != taskArray.Length)
                {
                    output_box.Text = taskArray[index].InnerText;
                }
                index++;
            }
            else
            {
                N_Results1 = countW; N_Results2 = countR;
                JObject file1 = JObject.Parse(File.ReadAllText("Results.json"));
                JObject file2 = new JObject();
                file2[userName] = countR;
                file1.Merge(file2, new JsonMergeSettings
                {
                    MergeArrayHandling = MergeArrayHandling.Union
                });
                File.WriteAllText(@"Results.json", file1.ToString());

                GameWindow tmp = new GameWindow();
                tmp.Show();
                tmp.SetBounds(this.Location.X, this.Location.Y, this.Width, this.Height);
                this.Hide();
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
    }
}
