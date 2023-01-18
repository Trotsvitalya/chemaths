
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LevelWindow));
            this.active_panel = new System.Windows.Forms.Panel();
            this.back_btn = new System.Windows.Forms.PictureBox();
            this.help_btn = new System.Windows.Forms.PictureBox();
            this.close_btn = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.help_panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.help_close_btn = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.check_btn = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.input_box = new System.Windows.Forms.TextBox();
            this.output_box = new System.Windows.Forms.TextBox();
            this.label_end = new System.Windows.Forms.Label();
            this.tool_tip = new System.Windows.Forms.ToolTip(this.components);
            this.active_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.back_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.help_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_btn)).BeginInit();
            this.help_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.help_close_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.check_btn)).BeginInit();
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
            this.tool_tip.SetToolTip(this.active_panel, "Затисніть ліву клавішу миші для перетягування вікна");
            this.active_panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.active_panel_MouseDown);
            // 
            // back_btn
            // 
            this.back_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back_btn.Image = global::chemaths.Properties.Resources.arrow;
            this.back_btn.Location = new System.Drawing.Point(12, 12);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(25, 25);
            this.back_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.back_btn.TabIndex = 15;
            this.back_btn.TabStop = false;
            this.tool_tip.SetToolTip(this.back_btn, "Повернутись до попереднього вікна");
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // help_btn
            // 
            this.help_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.help_btn.Image = global::chemaths.Properties.Resources.help;
            this.help_btn.Location = new System.Drawing.Point(462, 12);
            this.help_btn.Name = "help_btn";
            this.help_btn.Size = new System.Drawing.Size(25, 25);
            this.help_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.help_btn.TabIndex = 14;
            this.help_btn.TabStop = false;
            this.tool_tip.SetToolTip(this.help_btn, "Відкрити вікно допомоги");
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
            this.tool_tip.SetToolTip(this.close_btn, "Закрити програму");
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
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
            this.help_panel.Controls.Add(this.label1);
            this.help_panel.Controls.Add(this.label14);
            this.help_panel.Controls.Add(this.label13);
            this.help_panel.Controls.Add(this.label12);
            this.help_panel.Controls.Add(this.help_close_btn);
            this.help_panel.Controls.Add(this.label11);
            this.help_panel.Controls.Add(this.label6);
            this.help_panel.Controls.Add(this.label9);
            this.help_panel.Controls.Add(this.label8);
            this.help_panel.Controls.Add(this.label2);
            this.help_panel.Location = new System.Drawing.Point(0, 55);
            this.help_panel.Name = "help_panel";
            this.help_panel.Size = new System.Drawing.Size(951, 510);
            this.help_panel.TabIndex = 42;
            this.help_panel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(53)))));
            this.label1.Font = new System.Drawing.Font("Cambria", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(216)))), ((int)(((byte)(214)))));
            this.label1.Location = new System.Drawing.Point(560, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 81);
            this.label1.TabIndex = 46;
            this.label1.Text = "Для перевірки правильності\r\nрезультату обчислення\r\nкоефіцієнтів натисніть на кноп" +
    "ку³";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(53)))));
            this.label14.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(216)))), ((int)(((byte)(214)))));
            this.label14.Location = new System.Drawing.Point(901, 399);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(31, 32);
            this.label14.TabIndex = 44;
            this.label14.Text = "6";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(53)))));
            this.label13.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(216)))), ((int)(((byte)(214)))));
            this.label13.Location = new System.Drawing.Point(908, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 32);
            this.label13.TabIndex = 43;
            this.label13.Text = "5";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(53)))));
            this.label12.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(216)))), ((int)(((byte)(214)))));
            this.label12.Location = new System.Drawing.Point(6, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 32);
            this.label12.TabIndex = 42;
            this.label12.Text = "4";
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
            this.tool_tip.SetToolTip(this.help_close_btn, "Закрити вікно допомоги");
            this.help_close_btn.Click += new System.EventHandler(this.help_close_btn_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(53)))));
            this.label11.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(216)))), ((int)(((byte)(214)))));
            this.label11.Location = new System.Drawing.Point(394, 336);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 32);
            this.label11.TabIndex = 37;
            this.label11.Text = "3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(53)))));
            this.label6.Font = new System.Drawing.Font("Cambria", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(216)))), ((int)(((byte)(214)))));
            this.label6.Location = new System.Drawing.Point(73, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(829, 81);
            this.label6.TabIndex = 5;
            this.label6.Text = resources.GetString("label6.Text");
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(53)))));
            this.label9.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(216)))), ((int)(((byte)(214)))));
            this.label9.Location = new System.Drawing.Point(139, 237);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 32);
            this.label9.TabIndex = 4;
            this.label9.Text = "2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(53)))));
            this.label8.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(216)))), ((int)(((byte)(214)))));
            this.label8.Location = new System.Drawing.Point(139, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 32);
            this.label8.TabIndex = 2;
            this.label8.Text = "1\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(53)))));
            this.label2.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(216)))), ((int)(((byte)(214)))));
            this.label2.Location = new System.Drawing.Point(12, 426);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(813, 84);
            this.label2.TabIndex = 41;
            this.label2.Text = "Щоб повернутись до попереднього вікна, натисніть кнопку повернення⁴.\r\nЩоб закрити" +
    " програму, натисніть кнопку закриття програми⁵.\r\nЩоб закрити підказку, натисніть" +
    " кнопку закриття підказки⁶.";
            // 
            // check_btn
            // 
            this.check_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.check_btn.Image = global::chemaths.Properties.Resources.clipboard;
            this.check_btn.Location = new System.Drawing.Point(416, 354);
            this.check_btn.Name = "check_btn";
            this.check_btn.Size = new System.Drawing.Size(150, 99);
            this.check_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.check_btn.TabIndex = 49;
            this.check_btn.TabStop = false;
            this.tool_tip.SetToolTip(this.check_btn, "Перевірити відповідь");
            this.check_btn.Click += new System.EventHandler(this.check_btn_Click_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(317, 239);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(342, 37);
            this.label10.TabIndex = 50;
            this.label10.Text = "Введіть коефіцієнти:";
            // 
            // input_box
            // 
            this.input_box.Font = new System.Drawing.Font("Cambria", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.input_box.ForeColor = System.Drawing.Color.DimGray;
            this.input_box.Location = new System.Drawing.Point(176, 279);
            this.input_box.Multiline = true;
            this.input_box.Name = "input_box";
            this.input_box.Size = new System.Drawing.Size(611, 53);
            this.input_box.TabIndex = 48;
            this.input_box.TabStop = false;
            this.input_box.Text = "123456";
            this.tool_tip.SetToolTip(this.input_box, "Введіть відповідь у форматі: 1234");
            this.input_box.Click += new System.EventHandler(this.input_box_Click);
            this.input_box.Leave += new System.EventHandler(this.input_box_Leave);
            // 
            // output_box
            // 
            this.output_box.Cursor = System.Windows.Forms.Cursors.Default;
            this.output_box.Font = new System.Drawing.Font("Cambria", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.output_box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(53)))));
            this.output_box.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.output_box.Location = new System.Drawing.Point(176, 171);
            this.output_box.Multiline = true;
            this.output_box.Name = "output_box";
            this.output_box.ReadOnly = true;
            this.output_box.Size = new System.Drawing.Size(611, 53);
            this.output_box.TabIndex = 47;
            this.output_box.TabStop = false;
            this.tool_tip.SetToolTip(this.output_box, "Отримане завдання");
            // 
            // label_end
            // 
            this.label_end.AutoSize = true;
            this.label_end.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_end.ForeColor = System.Drawing.Color.White;
            this.label_end.Location = new System.Drawing.Point(31, 239);
            this.label_end.Name = "label_end";
            this.label_end.Size = new System.Drawing.Size(899, 37);
            this.label_end.TabIndex = 51;
            this.label_end.Text = "Натисніть на кнопку ще раз та дізнайтесь свій результат!";
            // 
            // tool_tip
            // 
            this.tool_tip.Active = false;
            this.tool_tip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tool_tip.ToolTipTitle = "Підказка";
            // 
            // LevelWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.check_btn);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.input_box);
            this.Controls.Add(this.output_box);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.active_panel);
            this.Controls.Add(this.help_panel);
            this.Controls.Add(this.label_end);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LevelWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.LevelWindow_Load);
            this.active_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.back_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.help_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_btn)).EndInit();
            this.help_panel.ResumeLayout(false);
            this.help_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.help_close_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.check_btn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel active_panel;
        private System.Windows.Forms.PictureBox help_btn;
        private System.Windows.Forms.PictureBox close_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel help_panel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox help_close_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox back_btn;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox check_btn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox input_box;
        private System.Windows.Forms.TextBox output_box;
        private System.Windows.Forms.Label label_end;
        private System.Windows.Forms.ToolTip tool_tip;
    }
}