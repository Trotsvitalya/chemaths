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
            tool_tip.Active = Interface.active_tool_tips;
            yes_btn.Checked = true;
        } 

        private void back_btn_Click(object sender, EventArgs e)
        {
            Interface.OPEN_MENU_POINT(new GameWindow(), this);//перехід до попереднього вікна
        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (nickname_box.Text == "")
                {
                    throw new Exception();
                }

                string result_choice = "yes";
                if (no_btn.Checked == true)
                {
                    result_choice = "no";
                }

                LevelWindow tmp = new LevelWindow(this, result_choice);
                Interface.OPEN_MENU_POINT(tmp, this);//перехід до наступного вікна
                tmp.userName = nickname_box.Text; //передача ім'я користувача
            }
            catch (Exception)
            {
                MistakeWindow mistake_w = new MistakeWindow("Введіть ім'я!");
                mistake_w.ShowDialog();
            }
        }

        private void level_choice_ValueChanged(object sender, EventArgs e)
        {
            //зміна інформаційного поля в реальному часі
            info_label.Text = nickname_box.Text + "\nпочинає практику на рівні " + level_choice.Value;
        }

        private void nickname_box_TextChanged(object sender, EventArgs e)
        {
            //зміна інформаційного поля в реальному часі
            info_label.Text = nickname_box.Text + "\nпочинає практику на рівні " + level_choice.Value;
        }

        private void nickname_box_Leave(object sender, EventArgs e)
        {
            if (nickname_box.Text == "")
            {
                info_label.Text = "Невідомий\nпочинає практику на рівні " + level_choice.Value;
            }
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