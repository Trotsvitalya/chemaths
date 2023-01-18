﻿using System;
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
            yes_btn.Checked = true;
        }

        private void OPEN_MENU_POINT(Form point_form, object sender)//функція відкриття форми
        {
            point_form.Show();
            //задання границь попереднього вікна
            point_form.SetBounds(this.Location.X, this.Location.Y, this.Width, this.Height);
            this.Hide();
        }

        private void nickname_box_Leave(object sender, EventArgs e)
        {
            //якщо поле порожнє
            if (string.IsNullOrWhiteSpace(nickname_box.Text))
            {
                nickname_box.Text = "Куриленко Дмитро";//виведення допоміжної підказки
                //встановлення курсиву
                nickname_box.Font = new Font(nickname_box.Font, FontStyle.Italic);
                nickname_box.ForeColor = Color.DimGray;//зміна кольору
            }
        }

        private void nickname_box_Click(object sender, EventArgs e)
        {
            //якщо вміст поля дорівнює вмісту допоміжної підказки
            if (nickname_box.Text == "Куриленко Дмитро")
            {
                nickname_box.Text = null;//очищення поля
                //зняття курсиву
                nickname_box.Font = new Font(nickname_box.Font, FontStyle.Regular);
                nickname_box.ForeColor = Color.FromArgb(31, 34, 53);//зміна кольору
            }
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();//закриття програми
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            OPEN_MENU_POINT(new GameWindow(), sender);//перехід до попереднього вікна
        }

        private void active_panel_MouseDown(object sender, MouseEventArgs e)
        {
            //функція перетягування безрамкового вікна за допоміжну активну панель
            active_panel.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            WndProc(ref m);
        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            string result_choice = "yes";
            if (no_btn.Checked == true)
            {
                result_choice = "no";
            }

            LevelWindow tmp = new LevelWindow(this, result_choice);
            OPEN_MENU_POINT(tmp, sender);//перехід до наступного вікна
            tmp.userName = nickname_box.Text;//передача ім'я користувача
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
    }
}