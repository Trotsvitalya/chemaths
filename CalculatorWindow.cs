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
    }
}
