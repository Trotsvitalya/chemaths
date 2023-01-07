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
    public partial class RegisterWindow : Form
    {
        public RegisterWindow()
        {
            InitializeComponent();
        }

        private void nickname_box_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nickname_box.Text))
            {
                nickname_box.Text = "Куриленко Дмитро";
                nickname_box.Font = new Font(nickname_box.Font, FontStyle.Italic);
                nickname_box.ForeColor = Color.DimGray;
            }
        }

        private void nickname_box_Click(object sender, EventArgs e)
        {
            if (nickname_box.Text == "Куриленко Дмитро")
            {
                nickname_box.Text = null;
                nickname_box.Font = new Font(nickname_box.Font, FontStyle.Regular);
                nickname_box.ForeColor = Color.FromArgb(31, 34, 53);
            }
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            GameWindow tmp = new GameWindow();
            tmp.Show();
            tmp.SetBounds(this.Location.X, this.Location.Y, this.Width, this.Height);
            this.Hide();
        }

        private void active_panel_MouseDown(object sender, MouseEventArgs e)
        {
            active_panel.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            WndProc(ref m);
        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            LevelWindow tmp = new LevelWindow(this);
            tmp.userName = nickname_box.Text;
            tmp.Show();
            tmp.SetBounds(this.Location.X, this.Location.Y, this.Width, this.Height);
            this.Hide();
        }

        private void level_choice_ValueChanged(object sender, EventArgs e)
        {
            info_label.Text = nickname_box.Text + "\nпочинає практику на рівні " + level_choice.Value;
        }

        private void nickname_box_TextChanged(object sender, EventArgs e)
        {
            info_label.Text = nickname_box.Text + "\nпочинає практику на рівні " + level_choice.Value;
        }

        private void help_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
