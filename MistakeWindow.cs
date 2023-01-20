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
    public partial class MistakeWindow : Form
    {
        public MistakeWindow(string mistake)
        {
            InitializeComponent();
            tool_tip.Active = Interface.active_tool_tips; 
            mistake_label.Text = "Виникла помилка!\n" + mistake;
        }

        private void ok_btn_Click(object sender, EventArgs e)
        {
            this.Close();//закриття форми
        }

        private void active_panel_MouseDown(object sender, MouseEventArgs e)
        {
            //функція перетягування безрамкового вікна за допоміжну активну панель
            active_panel.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            WndProc(ref m);
        }
    }
}
