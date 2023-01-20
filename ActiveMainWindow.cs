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
            Interface.ACTIVE_BTN(subject_btn, current_btn, side_panel);//виділення обраного пункту меню
            tool_tip.Active = Interface.active_tool_tips; 
        }

        private void help_btn_Click(object sender, EventArgs e)
        {
            Interface.OPEN_MENU_POINT(new HelpWindow(), this);//перехід до іншого пункту меню
        }

        private void info_btn_Click(object sender, EventArgs e)
        {
            Interface.OPEN_MENU_POINT(new InfoWindow(), this);//перехід до іншого пункту меню
        }

        private void main_btn_Click(object sender, EventArgs e)
        {
            Interface.OPEN_MENU_POINT(new MainWindow(), this);//перехід до головного вікна
        }

        private void coefficient_btn_Click(object sender, EventArgs e)
        {
            Interface.OPEN_MENU_POINT(new CalculatorWindow(), this);//перехід до вікна активності
        }

        private void game_btn_Click(object sender, EventArgs e)
        {
            Interface.OPEN_MENU_POINT(new GameWindow(), this);//перехід до вікна активності
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