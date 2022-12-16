
namespace chemaths
{
    partial class ActiveMainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActiveMainWindow));
            this.menu_panel = new System.Windows.Forms.Panel();
            this.side_panel = new System.Windows.Forms.Panel();
            this.info_btn = new System.Windows.Forms.Button();
            this.subject_btn = new System.Windows.Forms.Button();
            this.help_btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.main_btn = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.game_btn = new System.Windows.Forms.Button();
            this.coefficient_btn = new System.Windows.Forms.Button();
            this.close_btn = new System.Windows.Forms.PictureBox();
            this.active_panel = new System.Windows.Forms.Panel();
            this.menu_panel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.main_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_btn)).BeginInit();
            this.active_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu_panel
            // 
            this.menu_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.menu_panel.Controls.Add(this.side_panel);
            this.menu_panel.Controls.Add(this.info_btn);
            this.menu_panel.Controls.Add(this.subject_btn);
            this.menu_panel.Controls.Add(this.help_btn);
            this.menu_panel.Controls.Add(this.panel2);
            this.menu_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu_panel.Location = new System.Drawing.Point(0, 0);
            this.menu_panel.Name = "menu_panel";
            this.menu_panel.Size = new System.Drawing.Size(186, 577);
            this.menu_panel.TabIndex = 2;
            // 
            // side_panel
            // 
            this.side_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(107)))), ((int)(((byte)(210)))));
            this.side_panel.Location = new System.Drawing.Point(0, 152);
            this.side_panel.Name = "side_panel";
            this.side_panel.Size = new System.Drawing.Size(3, 100);
            this.side_panel.TabIndex = 5;
            // 
            // info_btn
            // 
            this.info_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.info_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.info_btn.FlatAppearance.BorderSize = 0;
            this.info_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.info_btn.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(107)))), ((int)(((byte)(210)))));
            this.info_btn.Image = global::chemaths.Properties.Resources.dev;
            this.info_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.info_btn.Location = new System.Drawing.Point(0, 228);
            this.info_btn.Name = "info_btn";
            this.info_btn.Size = new System.Drawing.Size(186, 42);
            this.info_btn.TabIndex = 4;
            this.info_btn.Text = "Розробники";
            this.info_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.info_btn.UseVisualStyleBackColor = true;
            this.info_btn.Click += new System.EventHandler(this.info_btn_Click);
            // 
            // subject_btn
            // 
            this.subject_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.subject_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.subject_btn.FlatAppearance.BorderSize = 0;
            this.subject_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subject_btn.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subject_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(107)))), ((int)(((byte)(210)))));
            this.subject_btn.Image = global::chemaths.Properties.Resources.subjects;
            this.subject_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.subject_btn.Location = new System.Drawing.Point(0, 186);
            this.subject_btn.Name = "subject_btn";
            this.subject_btn.Size = new System.Drawing.Size(186, 42);
            this.subject_btn.TabIndex = 3;
            this.subject_btn.Text = "Активність";
            this.subject_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.subject_btn.UseVisualStyleBackColor = true;
            // 
            // help_btn
            // 
            this.help_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.help_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.help_btn.FlatAppearance.BorderSize = 0;
            this.help_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.help_btn.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.help_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(107)))), ((int)(((byte)(210)))));
            this.help_btn.Image = global::chemaths.Properties.Resources.help;
            this.help_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.help_btn.Location = new System.Drawing.Point(0, 144);
            this.help_btn.Name = "help_btn";
            this.help_btn.Size = new System.Drawing.Size(186, 42);
            this.help_btn.TabIndex = 2;
            this.help_btn.Text = "Допомога";
            this.help_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.help_btn.UseVisualStyleBackColor = true;
            this.help_btn.Click += new System.EventHandler(this.help_btn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.main_btn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(186, 144);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(67, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Хімія";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(107)))), ((int)(((byte)(210)))));
            this.label1.Location = new System.Drawing.Point(54, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Посібник";
            // 
            // main_btn
            // 
            this.main_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.main_btn.Image = global::chemaths.Properties.Resources.manual_icon;
            this.main_btn.Location = new System.Drawing.Point(60, 22);
            this.main_btn.Name = "main_btn";
            this.main_btn.Size = new System.Drawing.Size(63, 63);
            this.main_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.main_btn.TabIndex = 0;
            this.main_btn.TabStop = false;
            this.main_btn.Click += new System.EventHandler(this.main_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 37);
            this.label3.TabIndex = 3;
            this.label3.Text = "Активність";
            // 
            // game_btn
            // 
            this.game_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(53)))));
            this.game_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.game_btn.FlatAppearance.BorderSize = 0;
            this.game_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.game_btn.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.game_btn.ForeColor = System.Drawing.Color.White;
            this.game_btn.Image = global::chemaths.Properties.Resources.puzzle;
            this.game_btn.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.game_btn.Location = new System.Drawing.Point(607, 198);
            this.game_btn.Name = "game_btn";
            this.game_btn.Size = new System.Drawing.Size(136, 185);
            this.game_btn.TabIndex = 10;
            this.game_btn.Text = "Практика\r\nкоефіцієнтів";
            this.game_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.game_btn.UseVisualStyleBackColor = false;
            this.game_btn.Click += new System.EventHandler(this.game_btn_Click);
            // 
            // coefficient_btn
            // 
            this.coefficient_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(53)))));
            this.coefficient_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.coefficient_btn.FlatAppearance.BorderSize = 0;
            this.coefficient_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.coefficient_btn.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coefficient_btn.ForeColor = System.Drawing.Color.White;
            this.coefficient_btn.Image = global::chemaths.Properties.Resources.biology__1_;
            this.coefficient_btn.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.coefficient_btn.Location = new System.Drawing.Point(398, 198);
            this.coefficient_btn.Name = "coefficient_btn";
            this.coefficient_btn.Size = new System.Drawing.Size(136, 185);
            this.coefficient_btn.TabIndex = 9;
            this.coefficient_btn.Text = "Калькулятор\r\nкоефіцієнтів";
            this.coefficient_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.coefficient_btn.UseVisualStyleBackColor = false;
            this.coefficient_btn.Click += new System.EventHandler(this.coefficient_btn_Click);
            // 
            // close_btn
            // 
            this.close_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close_btn.Image = global::chemaths.Properties.Resources.close;
            this.close_btn.Location = new System.Drawing.Point(728, 12);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(25, 25);
            this.close_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close_btn.TabIndex = 8;
            this.close_btn.TabStop = false;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // active_panel
            // 
            this.active_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(107)))), ((int)(((byte)(210)))));
            this.active_panel.Controls.Add(this.close_btn);
            this.active_panel.Controls.Add(this.label3);
            this.active_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.active_panel.Location = new System.Drawing.Point(186, 0);
            this.active_panel.Name = "active_panel";
            this.active_panel.Size = new System.Drawing.Size(765, 49);
            this.active_panel.TabIndex = 11;
            this.active_panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.active_panel_MouseDown);
            // 
            // ActiveMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.active_panel);
            this.Controls.Add(this.game_btn);
            this.Controls.Add(this.coefficient_btn);
            this.Controls.Add(this.menu_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ActiveMainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.menu_panel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.main_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_btn)).EndInit();
            this.active_panel.ResumeLayout(false);
            this.active_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menu_panel;
        private System.Windows.Forms.Panel side_panel;
        private System.Windows.Forms.Button info_btn;
        private System.Windows.Forms.Button subject_btn;
        private System.Windows.Forms.Button help_btn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox main_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox close_btn;
        private System.Windows.Forms.Button coefficient_btn;
        private System.Windows.Forms.Button game_btn;
        private System.Windows.Forms.Panel active_panel;
    }
}