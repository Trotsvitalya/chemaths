﻿
namespace chemaths
{
    partial class HelpWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpWindow));
            this.menu_panel = new System.Windows.Forms.Panel();
            this.side_panel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.active_panel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.tool_tip = new System.Windows.Forms.ToolTip(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.activate_tool_tips = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.close_btn = new System.Windows.Forms.PictureBox();
            this.info_btn = new System.Windows.Forms.Button();
            this.subject_btn = new System.Windows.Forms.Button();
            this.help_btn = new System.Windows.Forms.Button();
            this.main_btn = new System.Windows.Forms.PictureBox();
            this.menu_panel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.active_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.main_btn)).BeginInit();
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
            this.menu_panel.TabIndex = 4;
            // 
            // side_panel
            // 
            this.side_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(107)))), ((int)(((byte)(210)))));
            this.side_panel.Location = new System.Drawing.Point(0, 152);
            this.side_panel.Name = "side_panel";
            this.side_panel.Size = new System.Drawing.Size(3, 100);
            this.side_panel.TabIndex = 5;
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
            this.label2.TabIndex = 3;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 37);
            this.label3.TabIndex = 5;
            this.label3.Text = "Допомога";
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
            this.active_panel.TabIndex = 12;
            this.active_panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.active_panel_MouseDown);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(226)))), ((int)(((byte)(255)))));
            this.label4.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(107)))), ((int)(((byte)(210)))));
            this.label4.Location = new System.Drawing.Point(186, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(765, 100);
            this.label4.TabIndex = 14;
            this.label4.Text = "    Кожне вікно активності містить допоміжні підказки.\r\n  Щоб їх отримати, натисн" +
    "іть кнопку, яка розташована\r\n  у верхній частині вікна в центрі. Виглядає вона т" +
    "ак:";
            // 
            // tool_tip
            // 
            this.tool_tip.Active = false;
            this.tool_tip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tool_tip.ToolTipTitle = "Підказка";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(226)))), ((int)(((byte)(255)))));
            this.label5.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(107)))), ((int)(((byte)(210)))));
            this.label5.Location = new System.Drawing.Point(186, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(765, 100);
            this.label5.TabIndex = 15;
            this.label5.Text = "    Після цього, на екрані з\'являться допоміжні підказки,\r\n  а усі кнопки стануть" +
    " неактивними, окрім кнопки\r\n  закриття програми та кнопки закриття підказки.";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(226)))), ((int)(((byte)(255)))));
            this.label6.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(107)))), ((int)(((byte)(210)))));
            this.label6.Location = new System.Drawing.Point(186, 334);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(765, 100);
            this.label6.TabIndex = 17;
            this.label6.Text = "    Також Ви можете активувати спливаючі підказки, які\r\n  будуть відображені при " +
    "наведенні та утриманні курсору\r\n  на активному елементі.";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(107)))), ((int)(((byte)(210)))));
            this.label7.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(236, 477);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(531, 64);
            this.label7.TabIndex = 18;
            this.label7.Text = "Активувати спливаючі підказки:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // activate_tool_tips
            // 
            this.activate_tool_tips.Appearance = System.Windows.Forms.Appearance.Button;
            this.activate_tool_tips.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(53)))));
            this.activate_tool_tips.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.activate_tool_tips.Cursor = System.Windows.Forms.Cursors.Hand;
            this.activate_tool_tips.FlatAppearance.BorderSize = 0;
            this.activate_tool_tips.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.activate_tool_tips.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.activate_tool_tips.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.activate_tool_tips.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.activate_tool_tips.Font = new System.Drawing.Font("OpenSymbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activate_tool_tips.ForeColor = System.Drawing.Color.White;
            this.activate_tool_tips.Image = global::chemaths.Properties.Resources.stop__1_;
            this.activate_tool_tips.Location = new System.Drawing.Point(773, 477);
            this.activate_tool_tips.Name = "activate_tool_tips";
            this.activate_tool_tips.Size = new System.Drawing.Size(77, 64);
            this.activate_tool_tips.TabIndex = 19;
            this.activate_tool_tips.TabStop = false;
            this.tool_tip.SetToolTip(this.activate_tool_tips, "Управління спливаючими підказками");
            this.activate_tool_tips.UseVisualStyleBackColor = false;
            this.activate_tool_tips.Click += new System.EventHandler(this.activate_tool_tips_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(226)))), ((int)(((byte)(255)))));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::chemaths.Properties.Resources.help;
            this.pictureBox1.Location = new System.Drawing.Point(882, 154);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
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
            this.tool_tip.SetToolTip(this.close_btn, "Закрити програму");
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
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
            this.tool_tip.SetToolTip(this.info_btn, "Інформація про розробників");
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
            this.tool_tip.SetToolTip(this.subject_btn, "Перейти до вікна активності");
            this.subject_btn.UseVisualStyleBackColor = true;
            this.subject_btn.Click += new System.EventHandler(this.subject_btn_Click);
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
            this.tool_tip.SetToolTip(this.help_btn, "Допомога з експлуатації");
            this.help_btn.UseVisualStyleBackColor = true;
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
            this.tool_tip.SetToolTip(this.main_btn, "Повернутись до головного вікна");
            this.main_btn.Click += new System.EventHandler(this.main_btn_Click);
            // 
            // HelpWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.activate_tool_tips);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.active_panel);
            this.Controls.Add(this.menu_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HelpWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = " ";
            this.menu_panel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.active_panel.ResumeLayout(false);
            this.active_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.main_btn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menu_panel;
        private System.Windows.Forms.Panel side_panel;
        private System.Windows.Forms.Button info_btn;
        private System.Windows.Forms.Button subject_btn;
        private System.Windows.Forms.Button help_btn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox main_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox close_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel active_panel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolTip tool_tip;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox activate_tool_tips;
    }
}