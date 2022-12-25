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
            if(input_box.Text == "Введіть рівняння")
            {
                input_box.Text = null;
                input_box.ForeColor = Color.FromArgb(31, 34, 53);
            }
        }

        private void input_box_Leave(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(input_box.Text))
            {
                input_box.Text = "Введіть рівняння";
                input_box.ForeColor = Color.DimGray;
            }
        }

        private void active_panel_MouseDown(object sender, MouseEventArgs e)
        {
            active_panel.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            WndProc(ref m);
        }

        private void on_off_items(bool commutator)
        {
            input_box.Enabled = output_box.Enabled = calculate_btn.Enabled = 
            back_btn.Enabled = help_btn.Enabled = commutator;
        }

        private void help_btn_Click(object sender, EventArgs e)
        {
            help_panel.Visible = true;
            on_off_items(false);
        }

        private void help_close_btn_Click(object sender, EventArgs e)
        {
            help_panel.Visible = false;
            on_off_items(true);
        }

        private void calculate_btn_Click_1(object sender, EventArgs e)
        {
            Balancer.eq = input_box.Text;
            Balancer.runs();
            output_box.Text = Balancer.final;
        }
    }
}
