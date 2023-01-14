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
            ACTIVE_BTN(help_btn);
            activate_tool_tips.Checked = active_tool_tips;
            tool_tip.Active = active_tool_tips;
        }

        private void ACTIVE_BTN(object sender)//функція виділення обраного пункту меню
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

        private void OPEN_MENU_POINT(Form point_form, object sender)//функція відкриття форми
        {
            point_form.Show();
            //задання границь попереднього вікна
            point_form.SetBounds(this.Location.X, this.Location.Y, this.Width, this.Height);
            this.Hide();
        }

        private void subject_btn_Click(object sender, EventArgs e)
        {
            OPEN_MENU_POINT(new ActiveMainWindow(), sender);//перехід до іншого пункту меню
        }

        private void info_btn_Click(object sender, EventArgs e)
        {
            OPEN_MENU_POINT(new InfoWindow(), sender);//перехід до іншого пункту меню
        }

        private void main_btn_Click(object sender, EventArgs e)
        {
            OPEN_MENU_POINT(new MainWindow(), sender);//перехід до головного вікна
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();//закриття програми
        }

        private void active_panel_MouseDown(object sender, MouseEventArgs e)
        {
            //функція перетягування безрамкового вікна за допоміжну активну панель
            active_panel.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            WndProc(ref m);
        }

        bool active_tool_tips = false;

        private void activate_tool_tips_Click(object sender, EventArgs e)
        {
            active_tool_tips = !active_tool_tips;
            tool_tip.Active = active_tool_tips;
            //зміна фото чекбоксу в залежності від його стану
            if(activate_tool_tips.Checked)
            {
                activate_tool_tips.Image = Properties.Resources.checkbox__1_;
            }
            else
            {
                activate_tool_tips.Image = Properties.Resources.stop__1_;
            }
        }
    }
}
