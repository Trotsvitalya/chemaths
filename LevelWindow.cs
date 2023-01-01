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

namespace chemaths
{
    public partial class LevelWindow : Form
    {
        int index, countR = 0, countW = 0;
        XmlDocument doc = new XmlDocument();
        XmlNodeList tasks, tasksR;
        XmlNode[] taskArray, taskArrayR;
        bool randomized = false;
        public int N_Results1;
        public int N_Results2;
        ActiveMainWindow tmp = new ActiveMainWindow();
        GameWindow tmp12 = new GameWindow();
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
            //lvl_panel.Enabled = lvl_panel.Visible = false;
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
            help_panel.Visible = commutator;
            label5.Visible = check_btn.Enabled = !commutator;

        }

        private void help_btn_Click(object sender, EventArgs e)
        {
            on_off_items(true);
            //help_panel.Visible = check_btn.Visible = true;
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
            //lvl_panel.Enabled = true;
            check_btn.Visible = false;
            pictureBox_start.Visible = false;
        }

        private void pictureBox_confirm_Click(object sender, EventArgs e)
        {
            Start();
            label1.Text = "РІВЕНЬ: " + numericUpDown1.Value.ToString();
            label4.Text = "";
            label5.Text = "НАТИСНІТЬ КНОПКУ РОЗПОЧАТИ ЩОБ ПОЧАТИ!";
            output_box.Text = "";
            index = 1;
            pictureBox_confirm.Visible = false;
            pictureBox_start.Visible = true;
            check_btn.Visible = false;
            randomized = false;
        }
    }
}
