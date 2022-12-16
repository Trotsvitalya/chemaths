
namespace chemaths
{
    partial class CalculatorWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.input_box = new System.Windows.Forms.TextBox();
            this.output_box = new System.Windows.Forms.TextBox();
            this.calculate_btn = new System.Windows.Forms.PictureBox();
            this.close_btn = new System.Windows.Forms.PictureBox();
            this.back_btn = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calculate_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.back_btn)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.panel1.Controls.Add(this.back_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(951, 49);
            this.panel1.TabIndex = 10;
            // 
            // input_box
            // 
            this.input_box.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_box.ForeColor = System.Drawing.Color.DimGray;
            this.input_box.Location = new System.Drawing.Point(170, 199);
            this.input_box.Multiline = true;
            this.input_box.Name = "input_box";
            this.input_box.Size = new System.Drawing.Size(611, 53);
            this.input_box.TabIndex = 11;
            this.input_box.TabStop = false;
            this.input_box.Text = "Введіть рівняння";
            this.input_box.Click += new System.EventHandler(this.input_box_Click);
            this.input_box.Leave += new System.EventHandler(this.input_box_Leave);
            // 
            // output_box
            // 
            this.output_box.Cursor = System.Windows.Forms.Cursors.Default;
            this.output_box.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output_box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(53)))));
            this.output_box.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.output_box.Location = new System.Drawing.Point(170, 322);
            this.output_box.Multiline = true;
            this.output_box.Name = "output_box";
            this.output_box.ReadOnly = true;
            this.output_box.Size = new System.Drawing.Size(611, 53);
            this.output_box.TabIndex = 12;
            // 
            // calculate_btn
            // 
            this.calculate_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.calculate_btn.Image = global::chemaths.Properties.Resources.down_arrow1;
            this.calculate_btn.Location = new System.Drawing.Point(447, 258);
            this.calculate_btn.Name = "calculate_btn";
            this.calculate_btn.Size = new System.Drawing.Size(65, 58);
            this.calculate_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.calculate_btn.TabIndex = 12;
            this.calculate_btn.TabStop = false;
            this.calculate_btn.Click += new System.EventHandler(this.calculate_btn_Click);
            // 
            // close_btn
            // 
            this.close_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close_btn.Image = global::chemaths.Properties.Resources.close;
            this.close_btn.Location = new System.Drawing.Point(914, 12);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(25, 25);
            this.close_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close_btn.TabIndex = 9;
            this.close_btn.TabStop = false;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // back_btn
            // 
            this.back_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back_btn.Image = global::chemaths.Properties.Resources.arrow;
            this.back_btn.Location = new System.Drawing.Point(12, 12);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(25, 25);
            this.back_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.back_btn.TabIndex = 11;
            this.back_btn.TabStop = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // CalculatorWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.calculate_btn);
            this.Controls.Add(this.output_box);
            this.Controls.Add(this.input_box);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(53)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CalculatorWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.calculate_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.back_btn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox close_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox back_btn;
        private System.Windows.Forms.TextBox input_box;
        private System.Windows.Forms.TextBox output_box;
        private System.Windows.Forms.PictureBox calculate_btn;
    }
}