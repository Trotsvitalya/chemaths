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
        }
        private void Start1()
        {
            JObject o1 = JObject.Parse(File.ReadAllText("Results.json"));
            foreach (JProperty property in o1.Properties())
            {
                ListViewItem listviewItem = new ListViewItem(new string[] { property.Name, property.Value.ToString() });
                results_list.Items.Add(listviewItem);
            }
        }
        private void back_btn_Click(object sender, EventArgs e)
        {
            ActiveMainWindow tmp = new ActiveMainWindow();
            tmp.Show();
            tmp.SetBounds(this.Location.X, this.Location.Y, this.Width, this.Height);
            this.Hide();
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void active_panel_MouseDown(object sender, MouseEventArgs e)
        {
            active_panel.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            WndProc(ref m);
        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            LevelWindow tmp = new LevelWindow();
            tmp.userName = nickname_box.Text;
            tmp.Show();
            tmp.SetBounds(this.Location.X, this.Location.Y, this.Width, this.Height);
            this.Hide();
        }

        private void GameWindow_Load(object sender, EventArgs e)
        {
            Start1();
        }

        private void clear_results_btn_Click(object sender, EventArgs e)
        {
            results_list.Items.Clear();
            File.WriteAllText("Results.json", "{}");
        }
    }
}
