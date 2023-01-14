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
    public partial class CalculatorWindow : Form
    {
        public CalculatorWindow()
        {
            InitializeComponent();
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();//закриття програми
        }

        private void OPEN_MENU_POINT(Form point_form, object sender)//функція відкриття форми
        {
            point_form.Show();
            //задання границь попереднього вікна
            point_form.SetBounds(this.Location.X, this.Location.Y, this.Width, this.Height);
            this.Hide();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            OPEN_MENU_POINT(new ActiveMainWindow(), sender);//перехід до попереднього вікна
        }

        private void input_box_Click(object sender, EventArgs e)
        {
            //якщо користувач не вводив нічого в поле та вміст поля дорівнює допоміжній підказці
            if (input_box.Text == "Cu + O2 -> CuO")
            {
                input_box.Text = null;//очищення поля
                input_box.Font = new Font(input_box.Font, FontStyle.Regular);//зняття курсиву
                input_box.ForeColor = Color.FromArgb(31, 34, 53);//зміна кольору
            }
        }

        private void input_box_Leave(object sender, EventArgs e)
        {
            //якщо поле порожнє
            if(string.IsNullOrWhiteSpace(input_box.Text))
            {
                input_box.Text = "Cu + O2 -> CuO";//виведення допоміжної підказки
                input_box.Font = new Font(input_box.Font, FontStyle.Italic);//встановлення курсиву
                input_box.ForeColor = Color.DimGray;//зміна кольору
            }
        }

        private void active_panel_MouseDown(object sender, MouseEventArgs e)
        {
            //функція перетягування безрамкового вікна за допоміжну активну панель
            active_panel.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            WndProc(ref m);
        }

        private void help_btn_Click(object sender, EventArgs e)
        {
            help_panel.Visible = true;//відображення допоміжних підказок
            //вимкнення відповіді елементів на дії користувача
            input_box.Enabled = help_btn.Enabled = output_box.Enabled = back_btn.Enabled = calculate_btn.Enabled = false;
        }

        private void help_close_btn_Click(object sender, EventArgs e)
        {
            help_panel.Visible = false;//закриття допоміжних підказок
            //увімкнення відповіді елементів на дії користувача
            input_box.Enabled = help_btn.Enabled = output_box.Enabled = back_btn.Enabled = calculate_btn.Enabled = true;
        }
        
        private void calculate_btn_Click_1(object sender, EventArgs e)
        {
            //розстановка коефіцієнтів рівняння та виведення результату
            Balancer.eq = input_box.Text;
            Balancer.runs();
            output_box.Text = Balancer.final;
        }
    }
}
