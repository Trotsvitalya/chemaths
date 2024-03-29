﻿
namespace chemaths
{
    partial class InfoWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoWindow));
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
            this.close_btn = new System.Windows.Forms.PictureBox();
            this.active_panel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.tool_tip = new System.Windows.Forms.ToolTip(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.site_link = new System.Windows.Forms.LinkLabel();
            this.author1_link = new System.Windows.Forms.LinkLabel();
            this.site2_link = new System.Windows.Forms.LinkLabel();
            this.site4_link = new System.Windows.Forms.LinkLabel();
            this.site3_link = new System.Windows.Forms.LinkLabel();
            this.site5_link = new System.Windows.Forms.LinkLabel();
            this.author2_link = new System.Windows.Forms.LinkLabel();
            this.author3_link = new System.Windows.Forms.LinkLabel();
            this.author4_link = new System.Windows.Forms.LinkLabel();
            this.author5_link = new System.Windows.Forms.LinkLabel();
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
            this.menu_panel.TabIndex = 6;
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
            this.tool_tip.SetToolTip(this.info_btn, "Інформація про розробників");
            this.info_btn.UseVisualStyleBackColor = true;
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
            this.label2.TabIndex = 4;
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
            this.tool_tip.SetToolTip(this.main_btn, "Повернутись до головного вікна");
            this.main_btn.Click += new System.EventHandler(this.main_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(270, 37);
            this.label3.TabIndex = 7;
            this.label3.Text = "Про розробників";
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
            // active_panel
            // 
            this.active_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(107)))), ((int)(((byte)(210)))));
            this.active_panel.Controls.Add(this.label3);
            this.active_panel.Controls.Add(this.close_btn);
            this.active_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.active_panel.Location = new System.Drawing.Point(186, 0);
            this.active_panel.Name = "active_panel";
            this.active_panel.Size = new System.Drawing.Size(765, 49);
            this.active_panel.TabIndex = 12;
            this.tool_tip.SetToolTip(this.active_panel, "Затисніть ліву клавішу миші для перетягування вікна");
            this.active_panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.active_panel_MouseDown);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(226)))), ((int)(((byte)(255)))));
            this.label4.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(107)))), ((int)(((byte)(210)))));
            this.label4.Location = new System.Drawing.Point(186, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(765, 296);
            this.label4.TabIndex = 13;
            this.label4.Text = resources.GetString("label4.Text");
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
            this.label5.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(107)))), ((int)(((byte)(210)))));
            this.label5.Location = new System.Drawing.Point(186, 383);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(765, 167);
            this.label5.TabIndex = 14;
            this.label5.Text = resources.GetString("label5.Text");
            // 
            // site_link
            // 
            this.site_link.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(53)))));
            this.site_link.AutoSize = true;
            this.site_link.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(226)))), ((int)(((byte)(255)))));
            this.site_link.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.site_link.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(107)))), ((int)(((byte)(210)))));
            this.site_link.Location = new System.Drawing.Point(715, 383);
            this.site_link.Name = "site_link";
            this.site_link.Size = new System.Drawing.Size(236, 32);
            this.site_link.TabIndex = 15;
            this.site_link.TabStop = true;
            this.site_link.Text = "www.flaticon.com";
            this.tool_tip.SetToolTip(this.site_link, "Перейти за посиланням");
            this.site_link.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(53)))));
            this.site_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.site_link_LinkClicked);
            // 
            // author1_link
            // 
            this.author1_link.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(53)))));
            this.author1_link.AutoSize = true;
            this.author1_link.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(226)))), ((int)(((byte)(255)))));
            this.author1_link.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.author1_link.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(107)))), ((int)(((byte)(210)))));
            this.author1_link.Location = new System.Drawing.Point(452, 383);
            this.author1_link.Name = "author1_link";
            this.author1_link.Size = new System.Drawing.Size(243, 32);
            this.author1_link.TabIndex = 16;
            this.author1_link.TabStop = true;
            this.author1_link.Text = "Rizki Ahmad Fauzi";
            this.tool_tip.SetToolTip(this.author1_link, "Перейти за посиланням");
            this.author1_link.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(53)))));
            this.author1_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.author1_link_LinkClicked);
            // 
            // site2_link
            // 
            this.site2_link.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(53)))));
            this.site2_link.AutoSize = true;
            this.site2_link.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(226)))), ((int)(((byte)(255)))));
            this.site2_link.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.site2_link.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(107)))), ((int)(((byte)(210)))));
            this.site2_link.Location = new System.Drawing.Point(589, 415);
            this.site2_link.Name = "site2_link";
            this.site2_link.Size = new System.Drawing.Size(236, 32);
            this.site2_link.TabIndex = 17;
            this.site2_link.TabStop = true;
            this.site2_link.Text = "www.flaticon.com";
            this.tool_tip.SetToolTip(this.site2_link, "Перейти за посиланням");
            this.site2_link.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(53)))));
            this.site2_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.site2_link_LinkClicked);
            // 
            // site4_link
            // 
            this.site4_link.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(53)))));
            this.site4_link.AutoSize = true;
            this.site4_link.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(226)))), ((int)(((byte)(255)))));
            this.site4_link.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.site4_link.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(107)))), ((int)(((byte)(210)))));
            this.site4_link.Location = new System.Drawing.Point(686, 479);
            this.site4_link.Name = "site4_link";
            this.site4_link.Size = new System.Drawing.Size(236, 32);
            this.site4_link.TabIndex = 19;
            this.site4_link.TabStop = true;
            this.site4_link.Text = "www.flaticon.com";
            this.tool_tip.SetToolTip(this.site4_link, "Перейти за посиланням");
            this.site4_link.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(53)))));
            this.site4_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.site4_link_LinkClicked);
            // 
            // site3_link
            // 
            this.site3_link.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(53)))));
            this.site3_link.AutoSize = true;
            this.site3_link.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(226)))), ((int)(((byte)(255)))));
            this.site3_link.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.site3_link.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(107)))), ((int)(((byte)(210)))));
            this.site3_link.Location = new System.Drawing.Point(558, 447);
            this.site3_link.Name = "site3_link";
            this.site3_link.Size = new System.Drawing.Size(236, 32);
            this.site3_link.TabIndex = 18;
            this.site3_link.TabStop = true;
            this.site3_link.Text = "www.flaticon.com";
            this.tool_tip.SetToolTip(this.site3_link, "Перейти за посиланням");
            this.site3_link.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(53)))));
            this.site3_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.site3_link_LinkClicked);
            // 
            // site5_link
            // 
            this.site5_link.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(53)))));
            this.site5_link.AutoSize = true;
            this.site5_link.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(226)))), ((int)(((byte)(255)))));
            this.site5_link.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.site5_link.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(107)))), ((int)(((byte)(210)))));
            this.site5_link.Location = new System.Drawing.Point(607, 511);
            this.site5_link.Name = "site5_link";
            this.site5_link.Size = new System.Drawing.Size(236, 32);
            this.site5_link.TabIndex = 20;
            this.site5_link.TabStop = true;
            this.site5_link.Text = "www.flaticon.com";
            this.tool_tip.SetToolTip(this.site5_link, "Перейти за посиланням");
            this.site5_link.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(53)))));
            this.site5_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.site5_link_LinkClicked);
            // 
            // author2_link
            // 
            this.author2_link.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(53)))));
            this.author2_link.AutoSize = true;
            this.author2_link.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(226)))), ((int)(((byte)(255)))));
            this.author2_link.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.author2_link.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(107)))), ((int)(((byte)(210)))));
            this.author2_link.Location = new System.Drawing.Point(452, 415);
            this.author2_link.Name = "author2_link";
            this.author2_link.Size = new System.Drawing.Size(109, 32);
            this.author2_link.TabIndex = 21;
            this.author2_link.TabStop = true;
            this.author2_link.Text = "Freepik";
            this.tool_tip.SetToolTip(this.author2_link, "Перейти за посиланням");
            this.author2_link.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(53)))));
            this.author2_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.author2_link_LinkClicked);
            // 
            // author3_link
            // 
            this.author3_link.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(53)))));
            this.author3_link.AutoSize = true;
            this.author3_link.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(226)))), ((int)(((byte)(255)))));
            this.author3_link.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.author3_link.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(107)))), ((int)(((byte)(210)))));
            this.author3_link.Location = new System.Drawing.Point(452, 447);
            this.author3_link.Name = "author3_link";
            this.author3_link.Size = new System.Drawing.Size(89, 32);
            this.author3_link.TabIndex = 22;
            this.author3_link.TabStop = true;
            this.author3_link.Text = "alfanz";
            this.tool_tip.SetToolTip(this.author3_link, "Перейти за посиланням");
            this.author3_link.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(53)))));
            this.author3_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.author3_link_LinkClicked);
            // 
            // author4_link
            // 
            this.author4_link.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(53)))));
            this.author4_link.AutoSize = true;
            this.author4_link.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(226)))), ((int)(((byte)(255)))));
            this.author4_link.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.author4_link.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(107)))), ((int)(((byte)(210)))));
            this.author4_link.Location = new System.Drawing.Point(452, 479);
            this.author4_link.Name = "author4_link";
            this.author4_link.Size = new System.Drawing.Size(212, 32);
            this.author4_link.TabIndex = 23;
            this.author4_link.TabStop = true;
            this.author4_link.Text = "Muhammad Atif";
            this.tool_tip.SetToolTip(this.author4_link, "Перейти за посиланням");
            this.author4_link.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(53)))));
            this.author4_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.author4_link_LinkClicked);
            // 
            // author5_link
            // 
            this.author5_link.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(53)))));
            this.author5_link.AutoSize = true;
            this.author5_link.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(226)))), ((int)(((byte)(255)))));
            this.author5_link.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.author5_link.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(107)))), ((int)(((byte)(210)))));
            this.author5_link.Location = new System.Drawing.Point(452, 511);
            this.author5_link.Name = "author5_link";
            this.author5_link.Size = new System.Drawing.Size(135, 32);
            this.author5_link.TabIndex = 24;
            this.author5_link.TabStop = true;
            this.author5_link.Text = "icon wind";
            this.tool_tip.SetToolTip(this.author5_link, "Перейти за посиланням");
            this.author5_link.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(53)))));
            this.author5_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.author5_link_LinkClicked);
            // 
            // InfoWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.author5_link);
            this.Controls.Add(this.author4_link);
            this.Controls.Add(this.author3_link);
            this.Controls.Add(this.author2_link);
            this.Controls.Add(this.site5_link);
            this.Controls.Add(this.site4_link);
            this.Controls.Add(this.site3_link);
            this.Controls.Add(this.site2_link);
            this.Controls.Add(this.author1_link);
            this.Controls.Add(this.site_link);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.active_panel);
            this.Controls.Add(this.menu_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InfoWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.menu_panel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.main_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_btn)).EndInit();
            this.active_panel.ResumeLayout(false);
            this.active_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.LinkLabel site_link;
        private System.Windows.Forms.LinkLabel author1_link;
        private System.Windows.Forms.LinkLabel site2_link;
        private System.Windows.Forms.LinkLabel site4_link;
        private System.Windows.Forms.LinkLabel site3_link;
        private System.Windows.Forms.LinkLabel site5_link;
        private System.Windows.Forms.LinkLabel author2_link;
        private System.Windows.Forms.LinkLabel author3_link;
        private System.Windows.Forms.LinkLabel author4_link;
        private System.Windows.Forms.LinkLabel author5_link;
    }
}