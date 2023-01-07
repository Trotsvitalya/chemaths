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
    public partial class MessageWindow : Form
    {
        public MessageWindow(string result, string answer)
        {
            InitializeComponent();
            result_label.Text = result;
            if(answer == "right")
            {
                answer_label.Visible = false;
            }
            else
            {
                answer_label.Text = "Правильна відповідь: " + answer;
            }
        }

        private void ok_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void active_panel_MouseDown(object sender, MouseEventArgs e)
        {
            active_panel.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            WndProc(ref m);
        }
    }
}
