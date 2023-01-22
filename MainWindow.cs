using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
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
            tool_tip.Active = Interface.active_tool_tips;
            Interface.INACTIVE_BTN(menu_panel);
        }

        private void help_btn_Click(object sender, EventArgs e)
        {
            Interface.OPEN_MENU_POINT(new HelpWindow(), this);//перехід до іншого пункту меню
        }

        private void subject_btn_Click(object sender, EventArgs e)
        {
            Interface.OPEN_MENU_POINT(new ActiveMainWindow(), this);//перехід до іншого пункту меню
        }

        private void info_btn_Click(object sender, EventArgs e)
        {
            Interface.OPEN_MENU_POINT(new InfoWindow(), this);//перехід до іншого пункту меню
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

        private void mail_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clipboard.SetText("chemaths.project@gmail.com");//копіювання пошти в буфер обміну
        }
    }
}
