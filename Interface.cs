using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chemaths
{
    class Interface
    {
        public static bool active_tool_tips { get; set; }// перемінна для включення/виключення підказок

        public static void OPEN_MENU_POINT(Form point_form, Form this_form)//функція відкриття форми
        {
            point_form.Show();
            //задання границь попереднього вікна
            point_form.SetBounds(this_form.Location.X, this_form.Location.Y, this_form.Width, this_form.Height);
            this_form.Hide();
        }

        public static void ACTIVE_BTN(object sender, Button current_btn, Panel side_panel)//функція виділення обраного пункту меню
        {
            if (sender != null && current_btn != (Button)sender)
            {
                current_btn = (Button)sender;
                current_btn.BackColor = Color.FromArgb(31, 34, 53);
                current_btn.ForeColor = Color.White;
                side_panel.Height = current_btn.Height;
                side_panel.Top = current_btn.Top;
            }
        }

        public static void HELP_CLOSE(Panel help_panel, TextBox input_box, TextBox output_box, PictureBox help_btn, PictureBox back_btn, PictureBox calculate_btn)
        {
            help_panel.Visible = false;//закриття допоміжних підказок
            //увімкнення відповіді елементів на дії користувача
            input_box.Enabled = help_btn.Enabled = output_box.Enabled = back_btn.Enabled = calculate_btn.Enabled = true;
        }

        public static void HELP_OPEN(Panel help_panel, TextBox input_box, TextBox output_box, PictureBox help_btn, PictureBox back_btn, PictureBox calculate_btn)
        {
            help_panel.Visible = true;//закриття допоміжних підказок
            //увімкнення відповіді елементів на дії користувача
            input_box.Enabled = help_btn.Enabled = output_box.Enabled = back_btn.Enabled = calculate_btn.Enabled = false;
        }
    }
}