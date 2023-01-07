
namespace chemaths
{
    partial class MessageWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageWindow));
            this.result_label = new System.Windows.Forms.Label();
            this.ok_btn = new System.Windows.Forms.PictureBox();
            this.active_panel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ok_btn)).BeginInit();
            this.SuspendLayout();
            // 
            // result_label
            // 
            this.result_label.AutoSize = true;
            this.result_label.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.result_label.ForeColor = System.Drawing.Color.White;
            this.result_label.Location = new System.Drawing.Point(53, 87);
            this.result_label.Name = "result_label";
            this.result_label.Size = new System.Drawing.Size(352, 37);
            this.result_label.TabIndex = 21;
            this.result_label.Text = "Відповідь правильна!";
            // 
            // ok_btn
            // 
            this.ok_btn.Image = global::chemaths.Properties.Resources.like;
            this.ok_btn.Location = new System.Drawing.Point(155, 156);
            this.ok_btn.Name = "ok_btn";
            this.ok_btn.Size = new System.Drawing.Size(128, 116);
            this.ok_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ok_btn.TabIndex = 22;
            this.ok_btn.TabStop = false;
            this.ok_btn.Click += new System.EventHandler(this.ok_btn_Click);
            // 
            // active_panel
            // 
            this.active_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.active_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.active_panel.Location = new System.Drawing.Point(0, 0);
            this.active_panel.Name = "active_panel";
            this.active_panel.Size = new System.Drawing.Size(462, 49);
            this.active_panel.TabIndex = 23;
            this.active_panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.active_panel_MouseDown);
            // 
            // MessageWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(76)))), ((int)(((byte)(149)))));
            this.ClientSize = new System.Drawing.Size(462, 284);
            this.Controls.Add(this.active_panel);
            this.Controls.Add(this.ok_btn);
            this.Controls.Add(this.result_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MessageWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MessageWindow";
            ((System.ComponentModel.ISupportInitialize)(this.ok_btn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label result_label;
        private System.Windows.Forms.PictureBox ok_btn;
        private System.Windows.Forms.Panel active_panel;
    }
}