
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
            this.results_list = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nickname_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.start_btn = new System.Windows.Forms.PictureBox();
            this.help_btn = new System.Windows.Forms.PictureBox();
            this.back_btn = new System.Windows.Forms.PictureBox();
            this.close_btn = new System.Windows.Forms.PictureBox();
            this.active_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.start_btn)).BeginInit();
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
            // results_list
            // 
            this.results_list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.results_list.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.results_list.HideSelection = false;
            this.results_list.Location = new System.Drawing.Point(30, 65);
            this.results_list.Name = "results_list";
            this.results_list.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.results_list.Size = new System.Drawing.Size(441, 488);
            this.results_list.TabIndex = 15;
            this.results_list.UseCompatibleStateImageBehavior = false;
            this.results_list.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Користувач";
            this.columnHeader1.Width = 214;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Результат";
            this.columnHeader2.Width = 450;
            // 
            // nickname_box
            // 
            this.nickname_box.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nickname_box.Location = new System.Drawing.Point(525, 268);
            this.nickname_box.Multiline = true;
            this.nickname_box.Name = "nickname_box";
            this.nickname_box.Size = new System.Drawing.Size(381, 55);
            this.nickname_box.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(616, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 37);
            this.label1.TabIndex = 18;
            this.label1.Text = "Введіть ім\'я:";
            // 
            // start_btn
            // 
            this.start_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.start_btn.Image = global::chemaths.Properties.Resources.start;
            this.start_btn.Location = new System.Drawing.Point(623, 329);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(192, 132);
            this.start_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.start_btn.TabIndex = 19;
            this.start_btn.TabStop = false;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
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
            this.Controls.Add(this.start_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nickname_box);
            this.Controls.Add(this.results_list);
            this.Controls.Add(this.active_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GameWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.active_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.start_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.help_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.back_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_btn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox close_btn;
        private System.Windows.Forms.Panel active_panel;
        private System.Windows.Forms.PictureBox back_btn;
        private System.Windows.Forms.PictureBox help_btn;
        private System.Windows.Forms.ListView results_list;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TextBox nickname_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox start_btn;
    }
}