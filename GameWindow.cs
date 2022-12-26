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
    public partial class GameWindow : Form
    {
        public GameWindow()
        {
            InitializeComponent();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            ActiveMainWindow tmp = new ActiveMainWindow();
            tmp.Show();
            tmp.SetBounds(this.Location.X, this.Location.Y, this.Width, this.Height);
            this.Hide();
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void active_panel_MouseDown(object sender, MouseEventArgs e)
        {
            active_panel.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            WndProc(ref m);
        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            LevelWindow tmp = new LevelWindow();
            tmp.Show();
            tmp.SetBounds(this.Location.X, this.Location.Y, this.Width, this.Height);
            this.Hide();
        }
    }
}
