
namespace chemaths
{
    partial class GameWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameWindow));
            this.active_panel = new System.Windows.Forms.Panel();
            this.help_btn = new System.Windows.Forms.PictureBox();
            this.back_btn = new System.Windows.Forms.PictureBox();
            this.close_btn = new System.Windows.Forms.PictureBox();
            this.active_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.help_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.back_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_btn)).BeginInit();
            this.SuspendLayout();
            // 
            // active_panel
            // 
            this.active_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.active_panel.Controls.Add(this.help_btn);
            this.active_panel.Controls.Add(this.back_btn);
            this.active_panel.Controls.Add(this.close_btn);
            this.active_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.active_panel.Location = new System.Drawing.Point(0, 0);
            this.active_panel.Name = "active_panel";
            this.active_panel.Size = new System.Drawing.Size(951, 49);
            this.active_panel.TabIndex = 14;
            this.active_panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.active_panel_MouseDown);
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
            // GameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.active_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GameWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.active_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.help_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.back_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_btn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox close_btn;
        private System.Windows.Forms.Panel active_panel;
        private System.Windows.Forms.PictureBox back_btn;
        private System.Windows.Forms.PictureBox help_btn;
    }
}