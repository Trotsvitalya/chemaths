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
            ACTIVE_BTN(subject_btn);//виділення обраного пункту меню
            tool_tip.Active = Program.active_tool_tips; 
        }

        private void ACTIVE_BTN(object sender)//функція виділення обраного пункту меню
        {
            if (sender != null && current_btn != (Button)sender)
            {
                current_btn = (Button)sender;
                current_btn.BackColor = Color.FromArgb(31, 34, 53);//зміна кольору фону
                current_btn.ForeColor = Color.White;//зміна кольору тексту
                side_panel.Height = current_btn.Height;//зміна розміру додаткової панелі виділення
                side_panel.Top = current_btn.Top;//зміна розташування додаткової панелі на рівні обраного пункту
            }
        }

        public void OPEN_MENU_POINT(Form point_form, object sender)//функція відкриття форми
        {
            point_form.Show();
            //задання границь попереднього вікна
            point_form.SetBounds(this.Location.X, this.Location.Y, this.Width, this.Height);
            this.Hide();
        }

        private void help_btn_Click(object sender, EventArgs e)
        {
            OPEN_MENU_POINT(new HelpWindow(), sender);//перехід до іншого пункту меню
        }

        private void info_btn_Click(object sender, EventArgs e)
        {
            OPEN_MENU_POINT(new InfoWindow(), sender);//перехід до іншого пункту меню
        }

        private void main_btn_Click(object sender, EventArgs e)
        {
            OPEN_MENU_POINT(new MainWindow(), sender);//перехід до головного вікна
        }

        private void coefficient_btn_Click(object sender, EventArgs e)
        {
            OPEN_MENU_POINT(new CalculatorWindow(), sender);//перехід до вікна активності
        }

        private void game_btn_Click(object sender, EventArgs e)
        {
            OPEN_MENU_POINT(new GameWindow(), sender);//перехід до вікна активності
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
