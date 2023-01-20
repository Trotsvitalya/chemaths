using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;

namespace chemaths
{
    public partial class GameWindow : Form
    {
        public GameWindow()
        {
            InitializeComponent();
            tool_tip.Active = Program.active_tool_tips; 
            Start1();
        }

        private void Start1()
        {
            //заповнення таблиці результатів даними з файлу
            JObject o1 = JObject.Parse(File.ReadAllText("Results.json"));
            foreach (JProperty property in o1.Properties())
            {
                ListViewItem listviewItem = new ListViewItem(new string[] { property.Name, property.Value.ToString() });
                results_list.Items.Add(listviewItem);
            }
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            OPEN_MENU_POINT(new ActiveMainWindow(), sender);//перехід до попереднього вікна
        }

        private void clear_results_btn_Click(object sender, EventArgs e)
        {
            //очищення таблиці результатів
            results_list.Items.Clear();
            File.WriteAllText("Results.json", "{}");
        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            OPEN_MENU_POINT(new RegisterWindow(), sender);//перехід до наступного вікна
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
