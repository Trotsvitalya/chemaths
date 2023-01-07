
namespace chemaths
{
    partial class RegisterWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterWindow));
            this.active_panel = new System.Windows.Forms.Panel();
            this.info_label = new System.Windows.Forms.Label();
            this.level_choice = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nickname_box = new System.Windows.Forms.TextBox();
            this.back_btn = new System.Windows.Forms.PictureBox();
            this.close_btn = new System.Windows.Forms.PictureBox();
            this.start_btn = new System.Windows.Forms.PictureBox();
            this.help_btn = new System.Windows.Forms.PictureBox();
            this.active_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.level_choice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.back_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.start_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.help_btn)).BeginInit();
            this.SuspendLayout();
            // 
            // active_panel
            // 
            this.active_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.active_panel.Controls.Add(this.back_btn);
            this.active_panel.Controls.Add(this.close_btn);
            this.active_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.active_panel.Location = new System.Drawing.Point(0, 0);
            this.active_panel.Name = "active_panel";
            this.active_panel.Size = new System.Drawing.Size(951, 49);
            this.active_panel.TabIndex = 36;
            this.active_panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.active_panel_MouseDown);
            // 
            // info_label
            // 
            this.info_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(107)))), ((int)(((byte)(210)))));
            this.info_label.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.info_label.ForeColor = System.Drawing.Color.White;
            this.info_label.Location = new System.Drawing.Point(246, 110);
            this.info_label.Name = "info_label";
            this.info_label.Size = new System.Drawing.Size(471, 85);
            this.info_label.TabIndex = 44;
            this.info_label.Text = "Куриленко Дмитро\r\nпочинає практику на рівні 1";
            this.info_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // level_choice
            // 
            this.level_choice.Font = new System.Drawing.Font("Cambria", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.level_choice.Location = new System.Drawing.Point(462, 344);
            this.level_choice.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.level_choice.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.level_choice.Name = "level_choice";
            this.level_choice.Size = new System.Drawing.Size(101, 51);
            this.level_choice.TabIndex = 43;
            this.level_choice.TabStop = false;
            this.level_choice.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.level_choice.ValueChanged += new System.EventHandler(this.level_choice_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(199, 351);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 37);
            this.label2.TabIndex = 42;
            this.label2.Text = "Оберіть рівень:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(199, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 37);
            this.label1.TabIndex = 39;
            this.label1.Text = "Введіть ім\'я:";
            // 
            // nickname_box
            // 
            this.nickname_box.Font = new System.Drawing.Font("Cambria", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nickname_box.ForeColor = System.Drawing.Color.DimGray;
            this.nickname_box.Location = new System.Drawing.Point(462, 257);
            this.nickname_box.Multiline = true;
            this.nickname_box.Name = "nickname_box";
            this.nickname_box.Size = new System.Drawing.Size(381, 55);
            this.nickname_box.TabIndex = 38;
            this.nickname_box.TabStop = false;
            this.nickname_box.Text = "Куриленко Дмитро";
            this.nickname_box.Click += new System.EventHandler(this.nickname_box_Click);
            this.nickname_box.TextChanged += new System.EventHandler(this.nickname_box_TextChanged);
            this.nickname_box.Leave += new System.EventHandler(this.nickname_box_Leave);
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
            // start_btn
            // 
            this.start_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.start_btn.Image = global::chemaths.Properties.Resources.start;
            this.start_btn.Location = new System.Drawing.Point(398, 460);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(161, 105);
            this.start_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.start_btn.TabIndex = 40;
            this.start_btn.TabStop = false;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // help_btn
            // 
            this.help_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.help_btn.Image = ((System.Drawing.Image)(resources.GetObject("help_btn.Image")));
            this.help_btn.Location = new System.Drawing.Point(12, 65);
            this.help_btn.Name = "help_btn";
            this.help_btn.Size = new System.Drawing.Size(65, 71);
            this.help_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.help_btn.TabIndex = 45;
            this.help_btn.TabStop = false;
            this.help_btn.Click += new System.EventHandler(this.help_btn_Click);
            // 
            // RegisterWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.help_btn);
            this.Controls.Add(this.active_panel);
            this.Controls.Add(this.info_label);
            this.Controls.Add(this.level_choice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.start_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nickname_box);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.active_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.level_choice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.back_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.start_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.help_btn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel active_panel;
        private System.Windows.Forms.PictureBox back_btn;
        private System.Windows.Forms.PictureBox close_btn;
        private System.Windows.Forms.Label info_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox start_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nickname_box;
        private System.Windows.Forms.PictureBox help_btn;
        public System.Windows.Forms.NumericUpDown level_choice;
    }
}