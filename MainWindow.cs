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
            INACTIVE_BTN();
        }

        private void INACTIVE_BTN()
        {
            foreach(Control previous_btn in menu_panel.Controls)
            {
                if(previous_btn.GetType() == typeof(Button))
                {
                    previous_btn.BackColor = Color.FromArgb(36, 41, 61);
                    previous_btn.ForeColor = Color.FromArgb(11, 107, 210);
                }
            }
        }

        private void OPEN_MENU_POINT(Form point_form, object sender)
        {
            point_form.Show();
            this.Hide();
        }

        private void help_btn_Click(object sender, EventArgs e)
        {
            OPEN_MENU_POINT(new HelpWindow(), sender);
        }

        private void subject_btn_Click(object sender, EventArgs e)
        {
            OPEN_MENU_POINT(new ActiveMainWindow(), sender);
        }

        private void info_btn_Click(object sender, EventArgs e)
        {
            OPEN_MENU_POINT(new InfoWindow(), sender);
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
