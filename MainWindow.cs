using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chemaths
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            side_panel.Height = help_btn.Height;
            side_panel.Top = help_btn.Top;
            side_panel.Left = help_btn.Left;
            help_btn.BackColor = Color.FromArgb(31, 34, 53);
        }

        private void help_btn_Click(object sender, EventArgs e)
        {
            side_panel.Height = help_btn.Height;
            side_panel.Top = help_btn.Top;
            help_btn.BackColor = Color.FromArgb(31, 34, 53);
        }

        private void subject_btn_Click(object sender, EventArgs e)
        {
            side_panel.Height = subject_btn.Height;
            side_panel.Top = subject_btn.Top;
            subject_btn.BackColor = Color.FromArgb(31, 34, 53);

            SubjectMainWindow window = new SubjectMainWindow();
            window.Show();
        }

        private void info_btn_Click(object sender, EventArgs e)
        {
            side_panel.Height = info_btn.Height;
            side_panel.Top = info_btn.Top;
            info_btn.BackColor = Color.FromArgb(31, 34, 53);
        }

        private void help_btn_Leave(object sender, EventArgs e)
        {
            help_btn.BackColor = Color.FromArgb(36, 41, 61);
        }

        private void subject_btn_Leave(object sender, EventArgs e)
        {
            subject_btn.BackColor = Color.FromArgb(36, 41, 61);
        }

        private void info_btn_Leave(object sender, EventArgs e)
        {
            info_btn.BackColor = Color.FromArgb(36, 41, 61);
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
