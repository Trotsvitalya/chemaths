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
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            ActiveMainWindow tmp = new ActiveMainWindow();
            tmp.Show();
            tmp.SetBounds(this.Location.X, this.Location.Y, this.Width, this.Height);
            this.Hide();
        }

        private void input_box_Click(object sender, EventArgs e)
        {
            if(input_box.Text == "Cu + O2 -> CuO")
            {
                input_box.Text = null;
                input_box.Font = new Font(input_box.Font, FontStyle.Regular);
                input_box.ForeColor = Color.FromArgb(31, 34, 53);
            }
        }

        private void input_box_Leave(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(input_box.Text))
            {
                input_box.Text = "Cu + O2 -> CuO";
                input_box.Font = new Font(input_box.Font, FontStyle.Italic);
                input_box.ForeColor = Color.DimGray;
            }
        }

        private void active_panel_MouseDown(object sender, MouseEventArgs e)
        {
            active_panel.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            WndProc(ref m);
        }

        private void help_btn_Click(object sender, EventArgs e)
        {
            help_panel.Visible = true;
            input_box.Enabled = help_btn.Enabled = output_box.Enabled = back_btn.Enabled = calculate_btn.Enabled = false;
        }

        private void help_close_btn_Click(object sender, EventArgs e)
        {
            help_panel.Visible = false;
            input_box.Enabled = help_btn.Enabled = output_box.Enabled = back_btn.Enabled = calculate_btn.Enabled = true;
        }
        
        private void calculate_btn_Click_1(object sender, EventArgs e)
        {
            Balancer.eq = input_box.Text;
            Balancer.runs();
            output_box.Text = Balancer.final;
        }
    }
}
