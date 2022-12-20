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
    public partial class ActiveMainWindow : Form
    {
        private Button current_btn;

        public ActiveMainWindow()
        {
            InitializeComponent();
            ACTIVE_BTN(subject_btn);
        }
        private void ACTIVE_BTN(object sender)
        {
            if (sender != null && current_btn != (Button)sender)
            {
                INACTIVE_BTN();

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
            point_form.SetBounds(this.Location.X, this.Location.Y, this.Width, this.Height);
            this.Hide();
        }

        private void help_btn_Click(object sender, EventArgs e)
        {
            OPEN_MENU_POINT(new HelpWindow(), sender);
        }

        private void info_btn_Click(object sender, EventArgs e)
        {
            OPEN_MENU_POINT(new InfoWindow(), sender);
        }

        private void main_btn_Click(object sender, EventArgs e)
        {
            INACTIVE_BTN();
            MainWindow tmp = new MainWindow();
            tmp.Show();
            tmp.SetBounds(this.Location.X, this.Location.Y, this.Width, this.Height);
            this.Hide();
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void coefficient_btn_Click(object sender, EventArgs e)
        {
            OPEN_MENU_POINT(new CalculatorWindow(), sender);
        }

        private void game_btn_Click(object sender, EventArgs e)
        {
            OPEN_MENU_POINT(new GameWindow(), sender);
        }

        private void active_panel_MouseDown(object sender, MouseEventArgs e)
        {
            active_panel.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            WndProc(ref m);
        }
    }
}
