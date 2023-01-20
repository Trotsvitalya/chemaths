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
    public partial class CalculatorWindow : Form
    {
        public CalculatorWindow()
        {
            InitializeComponent();
            tool_tip.Active = Interface.active_tool_tips;
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Interface.OPEN_MENU_POINT(new ActiveMainWindow(), this);//перехід до попереднього вікна
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
            if (string.IsNullOrWhiteSpace(input_box.Text))
            {
                input_box.Text = "Cu + O2 -> CuO";//виведення допоміжної підказки
                input_box.Font = new Font(input_box.Font, FontStyle.Italic);//встановлення курсиву
                input_box.ForeColor = Color.DimGray;//зміна кольору
            }
        }

        private void help_btn_Click(object sender, EventArgs e)
        {
            Interface.HELP_OPEN(help_panel, input_box, output_box, help_btn, back_btn, calculate_btn);
        }

        private void help_close_btn_Click(object sender, EventArgs e)
        {
            Interface.HELP_CLOSE(help_panel, input_box, output_box, help_btn, back_btn, calculate_btn);
        }

        private void calculate_btn_Click_1(object sender, EventArgs e)
        {
            //розстановка коефіцієнтів рівняння та виведення результату
            try
            {
                Balancer.eq = input_box.Text;
                Balancer.runs();
                output_box.Text = Balancer.final;
            }
            catch (Exception exc)
            {
                if (exc.Message == "sides_mistake")
                {
                    MistakeWindow mistake_w = new MistakeWindow("Тут має бути один -> символ з пробілами з обох боків");
                    mistake_w.ShowDialog();
                }
                if (exc.Message == "atom_mistake")
                {
                    MistakeWindow mistake_w = new MistakeWindow("Не існує такого елемента!\nПеревірте введені дані!");
                    mistake_w.ShowDialog();
                }
                if (exc.Message == "space_mistake")
                {
                    MistakeWindow mistake_w = new MistakeWindow("Невірна кількість пробілів!\nПеревірте введені дані!");
                    mistake_w.ShowDialog();
                }
                if (exc.Message == "alphabet_mistake")
                {
                    MistakeWindow mistake_w = new MistakeWindow("Рівняння має містити тільки латиницю!");
                    mistake_w.ShowDialog();
                }
                if (exc.Message == "plus_mistake")
                {
                    MistakeWindow mistake_w = new MistakeWindow("Тут має бути хоча б один символ + з пробілами з обох боків");
                    mistake_w.ShowDialog();
                }
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