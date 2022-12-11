
namespace chemaths
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.help_btn = new System.Windows.Forms.Button();
            this.subject_btn = new System.Windows.Forms.Button();
            this.info_btn = new System.Windows.Forms.Button();
            this.side_panel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.close_btn = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_btn)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.panel1.Controls.Add(this.side_panel);
            this.panel1.Controls.Add(this.info_btn);
            this.panel1.Controls.Add(this.subject_btn);
            this.panel1.Controls.Add(this.help_btn);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 577);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(186, 144);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(60, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(34, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Хімія. Математика";
            // 
            // help_btn
            // 
            this.help_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.help_btn.FlatAppearance.BorderSize = 0;
            this.help_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.help_btn.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.help_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(107)))), ((int)(((byte)(210)))));
            this.help_btn.Image = ((System.Drawing.Image)(resources.GetObject("help_btn.Image")));
            this.help_btn.Location = new System.Drawing.Point(0, 144);
            this.help_btn.Name = "help_btn";
            this.help_btn.Size = new System.Drawing.Size(186, 42);
            this.help_btn.TabIndex = 2;
            this.help_btn.Text = "Допомога";
            this.help_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.help_btn.UseVisualStyleBackColor = true;
            this.help_btn.Click += new System.EventHandler(this.help_btn_Click);
            this.help_btn.Leave += new System.EventHandler(this.help_btn_Leave);
            // 
            // subject_btn
            // 
            this.subject_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.subject_btn.FlatAppearance.BorderSize = 0;
            this.subject_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subject_btn.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subject_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(107)))), ((int)(((byte)(210)))));
            this.subject_btn.Image = ((System.Drawing.Image)(resources.GetObject("subject_btn.Image")));
            this.subject_btn.Location = new System.Drawing.Point(0, 186);
            this.subject_btn.Name = "subject_btn";
            this.subject_btn.Size = new System.Drawing.Size(186, 42);
            this.subject_btn.TabIndex = 3;
            this.subject_btn.Text = "Предмети";
            this.subject_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.subject_btn.UseVisualStyleBackColor = true;
            this.subject_btn.Click += new System.EventHandler(this.subject_btn_Click);
            this.subject_btn.Leave += new System.EventHandler(this.subject_btn_Leave);
            // 
            // info_btn
            // 
            this.info_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.info_btn.FlatAppearance.BorderSize = 0;
            this.info_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.info_btn.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(107)))), ((int)(((byte)(210)))));
            this.info_btn.Image = ((System.Drawing.Image)(resources.GetObject("info_btn.Image")));
            this.info_btn.Location = new System.Drawing.Point(0, 228);
            this.info_btn.Name = "info_btn";
            this.info_btn.Size = new System.Drawing.Size(186, 42);
            this.info_btn.TabIndex = 4;
            this.info_btn.Text = "Розробники";
            this.info_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.info_btn.UseVisualStyleBackColor = true;
            this.info_btn.Click += new System.EventHandler(this.info_btn_Click);
            this.info_btn.Leave += new System.EventHandler(this.info_btn_Leave);
            // 
            // side_panel
            // 
            this.side_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(107)))), ((int)(((byte)(210)))));
            this.side_panel.Location = new System.Drawing.Point(0, 152);
            this.side_panel.Name = "side_panel";
            this.side_panel.Size = new System.Drawing.Size(3, 100);
            this.side_panel.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label3.Location = new System.Drawing.Point(202, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "Допомога";
            // 
            // close_btn
            // 
            this.close_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close_btn.Image = ((System.Drawing.Image)(resources.GetObject("close_btn.Image")));
            this.close_btn.Location = new System.Drawing.Point(918, 6);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(27, 27);
            this.close_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close_btn.TabIndex = 2;
            this.close_btn.TabStop = false;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_btn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button info_btn;
        private System.Windows.Forms.Button subject_btn;
        private System.Windows.Forms.Button help_btn;
        private System.Windows.Forms.Panel side_panel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox close_btn;
    }
}