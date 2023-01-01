
namespace chemaths
{
    partial class LevelWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LevelWindow));
            this.active_panel = new System.Windows.Forms.Panel();
            this.help_btn = new System.Windows.Forms.PictureBox();
            this.close_btn = new System.Windows.Forms.PictureBox();
            this.output_box = new System.Windows.Forms.TextBox();
            this.input_box = new System.Windows.Forms.TextBox();
            this.check_btn = new System.Windows.Forms.PictureBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox_confirm = new System.Windows.Forms.PictureBox();
            this.pictureBox_start = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.help_panel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.help_close_btn = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.back_btn = new System.Windows.Forms.PictureBox();
            this.active_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.help_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.check_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_confirm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_start)).BeginInit();
            this.help_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.help_close_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.back_btn)).BeginInit();
            this.SuspendLayout();
            // 
            // active_panel
            // 
            this.active_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.active_panel.Controls.Add(this.back_btn);
            this.active_panel.Controls.Add(this.help_btn);
            this.active_panel.Controls.Add(this.close_btn);
            this.active_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.active_panel.Location = new System.Drawing.Point(0, 0);
            this.active_panel.Name = "active_panel";
            this.active_panel.Size = new System.Drawing.Size(951, 49);
            this.active_panel.TabIndex = 20;
            this.active_panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.active_panel_MouseDown);
            // 
            // help_btn
            // 
            this.help_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.help_btn.Image = global::chemaths.Properties.Resources.help;
            this.help_btn.Location = new System.Drawing.Point(426, 12);
            this.help_btn.Name = "help_btn";
            this.help_btn.Size = new System.Drawing.Size(25, 25);
            this.help_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.help_btn.TabIndex = 14;
            this.help_btn.TabStop = false;
            this.help_btn.Click += new System.EventHandler(this.help_btn_Click);
            // 
            // close_btn
            // 
            this.close_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close_btn.Image = global::chemaths.Properties.Resources.close;
            this.close_btn.Location = new System.Drawing.Point(914, 12);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(25, 25);
            this.close_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close_btn.TabIndex = 13;
            this.close_btn.TabStop = false;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // output_box
            // 
            this.output_box.Cursor = System.Windows.Forms.Cursors.Default;
            this.output_box.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output_box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(53)))));
            this.output_box.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.output_box.Location = new System.Drawing.Point(160, 132);
            this.output_box.Multiline = true;
            this.output_box.Name = "output_box";
            this.output_box.ReadOnly = true;
            this.output_box.Size = new System.Drawing.Size(611, 53);
            this.output_box.TabIndex = 22;
            this.output_box.TabStop = false;
            // 
            // input_box
            // 
            this.input_box.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_box.ForeColor = System.Drawing.Color.DimGray;
            this.input_box.Location = new System.Drawing.Point(160, 266);
            this.input_box.Multiline = true;
            this.input_box.Name = "input_box";
            this.input_box.Size = new System.Drawing.Size(611, 53);
            this.input_box.TabIndex = 21;
            this.input_box.TabStop = false;
            // 
            // check_btn
            // 
            this.check_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.check_btn.Image = global::chemaths.Properties.Resources.clipboard;
            this.check_btn.Location = new System.Drawing.Point(404, 383);
            this.check_btn.Name = "check_btn";
            this.check_btn.Size = new System.Drawing.Size(126, 83);
            this.check_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.check_btn.TabIndex = 23;
            this.check_btn.TabStop = false;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(16, 71);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(101, 20);
            this.numericUpDown1.TabIndex = 33;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(15, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "ВИБЕРІТЬ РІВЕНЬ";
            // 
            // pictureBox_confirm
            // 
            this.pictureBox_confirm.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_confirm.Image")));
            this.pictureBox_confirm.Location = new System.Drawing.Point(16, 97);
            this.pictureBox_confirm.Name = "pictureBox_confirm";
            this.pictureBox_confirm.Size = new System.Drawing.Size(101, 22);
            this.pictureBox_confirm.TabIndex = 37;
            this.pictureBox_confirm.TabStop = false;
            this.pictureBox_confirm.Click += new System.EventHandler(this.pictureBox_confirm_Click);
            // 
            // pictureBox_start
            // 
            this.pictureBox_start.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_start.Image")));
            this.pictureBox_start.Location = new System.Drawing.Point(404, 472);
            this.pictureBox_start.Name = "pictureBox_start";
            this.pictureBox_start.Size = new System.Drawing.Size(126, 44);
            this.pictureBox_start.TabIndex = 36;
            this.pictureBox_start.TabStop = false;
            this.pictureBox_start.Click += new System.EventHandler(this.pictureBox_start_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(411, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 25);
            this.label1.TabIndex = 38;
            this.label1.Text = "РІВЕНЬ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(164, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 25);
            this.label5.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(379, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 25);
            this.label4.TabIndex = 39;
            // 
            // help_panel
            // 
            this.help_panel.Controls.Add(this.help_close_btn);
            this.help_panel.Controls.Add(this.label11);
            this.help_panel.Controls.Add(this.label10);
            this.help_panel.Controls.Add(this.label6);
            this.help_panel.Controls.Add(this.label9);
            this.help_panel.Controls.Add(this.label8);
            this.help_panel.Controls.Add(this.label7);
            this.help_panel.Controls.Add(this.label2);
            this.help_panel.Location = new System.Drawing.Point(0, 55);
            this.help_panel.Name = "help_panel";
            this.help_panel.Size = new System.Drawing.Size(951, 525);
            this.help_panel.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(53)))));
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(216)))), ((int)(((byte)(214)))));
            this.label2.Location = new System.Drawing.Point(3, 417);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(875, 96);
            this.label2.TabIndex = 41;
            this.label2.Text = "Щоб повернутись до попереднього вікна, натисніть кнопку повернення⁴.\r\nЩоб закрити" +
    " програму, натисніть кнопку закриття програми⁵.\r\nЩоб закрити підказку, натисніть" +
    " кнопку закриття підказки⁶.";
            // 
            // help_close_btn
            // 
            this.help_close_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.help_close_btn.Image = global::chemaths.Properties.Resources.help_close;
            this.help_close_btn.Location = new System.Drawing.Point(887, 434);
            this.help_close_btn.Name = "help_close_btn";
            this.help_close_btn.Size = new System.Drawing.Size(61, 62);
            this.help_close_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.help_close_btn.TabIndex = 18;
            this.help_close_btn.TabStop = false;
            this.help_close_btn.Click += new System.EventHandler(this.help_close_btn_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(53)))));
            this.label11.Font = new System.Drawing.Font("Nirmala UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(216)))), ((int)(((byte)(214)))));
            this.label11.Location = new System.Drawing.Point(364, 349);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 40);
            this.label11.TabIndex = 37;
            this.label11.Text = "3";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(53)))));
            this.label10.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(216)))), ((int)(((byte)(214)))));
            this.label10.Location = new System.Drawing.Point(222, 267);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(489, 50);
            this.label10.TabIndex = 6;
            this.label10.Text = "Для перевірки правильності результату обчислення \r\n                 коефіціентів " +
    "натисніть на кнопку³";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(53)))));
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(216)))), ((int)(((byte)(214)))));
            this.label6.Location = new System.Drawing.Point(236, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(475, 75);
            this.label6.TabIndex = 5;
            this.label6.Text = " У другому полі² Вам необхідно ввести коефіціенти\r\n (без крапок, пробілів та інши" +
    "х додаткових знаків), \r\nякі повинні стояти у дужках ( ) для урівнення сторін";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(53)))));
            this.label9.Font = new System.Drawing.Font("Nirmala UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(216)))), ((int)(((byte)(214)))));
            this.label9.Location = new System.Drawing.Point(124, 218);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 40);
            this.label9.TabIndex = 4;
            this.label9.Text = "2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(53)))));
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(216)))), ((int)(((byte)(214)))));
            this.label8.Location = new System.Drawing.Point(124, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 40);
            this.label8.TabIndex = 2;
            this.label8.Text = "1\r\n";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(53)))));
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(216)))), ((int)(((byte)(214)))));
            this.label7.Location = new System.Drawing.Point(265, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(420, 25);
            this.label7.TabIndex = 1;
            this.label7.Text = "У першому полі¹ з\'являється хімічне рівняння";
            // 
            // back_btn
            // 
            this.back_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back_btn.Image = global::chemaths.Properties.Resources.arrow;
            this.back_btn.Location = new System.Drawing.Point(9, 12);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(25, 25);
            this.back_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.back_btn.TabIndex = 15;
            this.back_btn.TabStop = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // LevelWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.check_btn);
            this.Controls.Add(this.input_box);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.pictureBox_confirm);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.active_panel);
            this.Controls.Add(this.output_box);
            this.Controls.Add(this.pictureBox_start);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.help_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LevelWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.LevelWindow_Load);
            this.active_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.help_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.check_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_confirm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_start)).EndInit();
            this.help_panel.ResumeLayout(false);
            this.help_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.help_close_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.back_btn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel active_panel;
        private System.Windows.Forms.PictureBox help_btn;
        private System.Windows.Forms.PictureBox close_btn;
        private System.Windows.Forms.TextBox output_box;
        private System.Windows.Forms.TextBox input_box;
        private System.Windows.Forms.PictureBox check_btn;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox_confirm;
        private System.Windows.Forms.PictureBox pictureBox_start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel help_panel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox help_close_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox back_btn;
    }
}