
namespace chemaths
{
    partial class MistakeWindow
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
            this.active_panel = new System.Windows.Forms.Panel();
            this.ok_btn = new System.Windows.Forms.PictureBox();
            this.mistake_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ok_btn)).BeginInit();
            this.SuspendLayout();
            // 
            // active_panel
            // 
            this.active_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.active_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.active_panel.Location = new System.Drawing.Point(0, 0);
            this.active_panel.Name = "active_panel";
            this.active_panel.Size = new System.Drawing.Size(462, 49);
            this.active_panel.TabIndex = 24;
            this.active_panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.active_panel_MouseDown);
            // 
            // ok_btn
            // 
            this.ok_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ok_btn.Image = global::chemaths.Properties.Resources.like;
            this.ok_btn.Location = new System.Drawing.Point(155, 166);
            this.ok_btn.Name = "ok_btn";
            this.ok_btn.Size = new System.Drawing.Size(128, 116);
            this.ok_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ok_btn.TabIndex = 25;
            this.ok_btn.TabStop = false;
            this.ok_btn.Click += new System.EventHandler(this.ok_btn_Click);
            // 
            // mistake_label
            // 
            this.mistake_label.AutoSize = true;
            this.mistake_label.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mistake_label.ForeColor = System.Drawing.Color.White;
            this.mistake_label.Location = new System.Drawing.Point(30, 52);
            this.mistake_label.Name = "mistake_label";
            this.mistake_label.Size = new System.Drawing.Size(388, 111);
            this.mistake_label.TabIndex = 26;
            this.mistake_label.Text = "Виникла помилка!\r\nПеревірте правильність\r\nвведених даних!";
            this.mistake_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MistakeWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(76)))), ((int)(((byte)(149)))));
            this.ClientSize = new System.Drawing.Size(462, 284);
            this.Controls.Add(this.mistake_label);
            this.Controls.Add(this.ok_btn);
            this.Controls.Add(this.active_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MistakeWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)(this.ok_btn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel active_panel;
        private System.Windows.Forms.PictureBox ok_btn;
        private System.Windows.Forms.Label mistake_label;
    }
}