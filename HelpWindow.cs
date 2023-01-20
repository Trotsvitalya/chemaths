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
    public partial class HelpWindow : Form
    {
        private Button current_btn;

        public HelpWindow()
        {
            InitializeComponent();
            tool_tip.Active = Interface.active_tool_tips;
            CheckedChanged();
            Interface.ACTIVE_BTN(help_btn, current_btn, side_panel);
        }

        private void subject_btn_Click(object sender, EventArgs e)
        {
            Interface.OPEN_MENU_POINT(new ActiveMainWindow(), this);//перехід до іншого пункту меню
        }

        private void info_btn_Click(object sender, EventArgs e)
        {
            Interface.OPEN_MENU_POINT(new InfoWindow(), this);//перехід до іншого пункту меню
        }

        private void main_btn_Click(object sender, EventArgs e)
        {
            Interface.OPEN_MENU_POINT(new MainWindow(), this);//перехід до головного вікна
        }

        //зміна фото чекбоксу в залежності від його стану
        private void CheckedChanged()
        {
            if (tool_tip.Active)
            {
                activate_tool_tips.Image = Properties.Resources.checkbox__1_;
            }
            else
            {
                activate_tool_tips.Image = Properties.Resources.stop__1_;
            }
        }

        private void activate_tool_tips_Click(object sender, EventArgs e)
        {
            Interface.active_tool_tips = !Interface.active_tool_tips;

            tool_tip.Active = Interface.active_tool_tips;
            CheckedChanged();
        }

        private void close_btn_Click(object sender, EventArgs e)//закриття програми
        {
            Application.Exit();
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
 