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
    public partial class LevelWindow : Form
    {
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
    }
}
