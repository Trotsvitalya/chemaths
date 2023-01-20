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
    public partial class InfoWindow : Form
    {
        private Button current_btn;

        public InfoWindow()
        {
            InitializeComponent();
            ACTIVE_BTN(info_btn);
            tool_tip.Active = Program.active_tool_tips; 
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

        private void help_btn_Click(object sender, EventArgs e)
        {
            OPEN_MENU_POINT(new HelpWindow(), sender);//перехід до іншого пункту меню
        }

        private void subject_btn_Click(object sender, EventArgs e)
        {
            OPEN_MENU_POINT(new ActiveMainWindow(), sender);//перехід до іншого пункту меню
        }

        private void main_btn_Click(object sender, EventArgs e)
        {
            OPEN_MENU_POINT(new MainWindow(), sender);//перехід до головного вікна
        }

        void site_click()//функція відкриття сайту
        {
            site_link.LinkVisited = site2_link.LinkVisited = site3_link.LinkVisited = site4_link.LinkVisited = site5_link.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.flaticon.com/");
        }

        private void site_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            site_click();
        }

        private void author1_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            author1_link.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.flaticon.com/authors/rizki-ahmad-fauzi");
        }

        private void author2_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            author2_link.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.flaticon.com/authors/freepik");
        }

        private void author3_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            author3_link.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.flaticon.com/authors/alfanz");
        }

        private void author4_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            author4_link.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.flaticon.com/authors/muhammad-atif");
        }

        private void author5_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            author5_link.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.flaticon.com/authors/icon-wind");
        }

        private void site2_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            site_click();
        }

        private void site3_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            site_click();
        }

        private void site4_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            site_click();
        }

        private void site5_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            site_click();
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
