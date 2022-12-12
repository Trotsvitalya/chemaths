﻿using System;
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
    public partial class InfoWindow : Form
    {
        private Button current_btn;

        public InfoWindow()
        {
            InitializeComponent();
            ACTIVE_BTN(info_btn);
        }

        private void ACTIVE_BTN(object sender)
        {
            if (sender != null && current_btn != (Button)sender)
            {
                current_btn = (Button)sender;
                current_btn.BackColor = Color.FromArgb(31, 34, 53);
                current_btn.ForeColor = Color.White;
                side_panel.Height = current_btn.Height;
                side_panel.Top = current_btn.Top;
            }
        }

        private void INACTIVE_BTN()
        {
            foreach (Control previous_btn in menu_panel.Controls)
            {
                if (previous_btn.GetType() == typeof(Button))
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
            OPEN_MENU_POINT(new SubjectMainWindow(), sender);
        }

        private void main_btn_Click(object sender, EventArgs e)
        {
            INACTIVE_BTN();
            MainWindow tmp = new MainWindow();
            tmp.Show();
            this.Hide();
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
