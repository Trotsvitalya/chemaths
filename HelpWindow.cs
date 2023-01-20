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
            tool_tip.Active = Program.active_tool_tips;
            CheckedChanged();
            ACTIVE_BTN(help_btn);
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

        private void subject_btn_Click(object sender, EventArgs e)
        {
            InterHelpWindow obj = new InterHelpWindow();
            obj.OPEN_MENU_POINT(new ActiveMainWindow(), sender);//перехід до іншого пункту меню
        }

        private void info_btn_Click(object sender, EventArgs e)
        {
            InterHelpWindow obj = new InterHelpWindow();
            obj.OPEN_MENU_POINT(new InfoWindow(), sender);//перехід до іншого пункту меню
        }

        private void main_btn_Click(object sender, EventArgs e)
        {
            InterHelpWindow obj = new InterHelpWindow();
            obj.OPEN_MENU_POINT(new MainWindow(), sender);//перехід до головного вікна
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
            Program.active_tool_tips = !Program.active_tool_tips;

            tool_tip.Active = Program.active_tool_tips;
            CheckedChanged();
        }

    }

    class InterHelpWindow : Interface
    {
        public override void OPEN_MENU_POINT(Form point_form, object sender)//функція відкриття форми
        {
            point_form.Show();
            //задання границь попереднього вікна
            point_form.SetBounds(this.Location.X, this.Location.Y, this.Width, this.Height);
            this.Hide();
        }

        public override void close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();//закриття програми
        }

        public override void active_panel_MouseDown(object sender, MouseEventArgs e)
        {
            //функція перетягування безрамкового вікна за допоміжну активну панель
            active_panel.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            WndProc(ref m);
        }
    }
}
 