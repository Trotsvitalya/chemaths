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
        int index, countR = 0, countW = 0, k = 0;
        XmlDocument doc = new XmlDocument();
        XmlNodeList tasks, tasksR;
        XmlNode[] taskArray, taskArrayR;
        bool randomized = false;
        public int N_Results1;
        public int N_Results2;
        ActiveMainWindow tmp = new ActiveMainWindow();
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
            lvl_panel.Enabled = lvl_panel.Visible = false;
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
            //input_box.Enabled = output_box.Enabled = calculate_btn.Enabled =
            //back_btn.Enabled = help_btn.Enabled = commutator;
            pictureBox_confirm.Enabled = commutator;

        }

        private void help_btn_Click(object sender, EventArgs e)
        {

        }


        public LevelWindow()
        {
            InitializeComponent();
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
            lvl_panel.Enabled = true;
            check_btn.Visible = false;
            pictureBox_start.Visible = false;
        }

        private void pictureBox_confirm_Click(object sender, EventArgs e)
        {
            Start();
            label2.Text = numericUpDown1.Value.ToString();
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
