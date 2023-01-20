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
            tool_tip.Active = Program.active_tool_tips;
            INACTIVE_BTN();
        }

        private void INACTIVE_BTN()//функція зняття виділення пунктів меню
        {
            //для кожної кнопки на панелі menu_panel зміна кольору тексту та заднього фону
            foreach (Control previous_btn in menu_panel.Controls)
            {
                if(previous_btn.GetType() == typeof(Button))
                {
                    previous_btn.BackColor = Color.FromArgb(36, 41, 61);
                    previous_btn.ForeColor = Color.FromArgb(11, 107, 210);
                }
            }
        }

        private void help_btn_Click(object sender, EventArgs e)
        {
            OPEN_MENU_POINT(new HelpWindow(), sender);//перехід до іншого пункту меню
        }

        private void subject_btn_Click(object sender, EventArgs e)
        {
            OPEN_MENU_POINT(new ActiveMainWindow(), sender);//перехід до іншого пункту меню
        }

        private void info_btn_Click(object sender, EventArgs e)
        {
            OPEN_MENU_POINT(new InfoWindow(), sender);//перехід до іншого пункту меню
        }

        public void OPEN_MENU_POINT(Form point_form, object sender)//функція відкриття форми
        {
            point_form.Show();
            //задання границь попереднього вікна
            point_form.SetBounds(this.Location.X, this.Location.Y, this.Width, this.Height);
            this.Hide();
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
