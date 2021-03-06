﻿namespace wampmon
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnlTitlebar = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlApache = new System.Windows.Forms.Panel();
            this.btnApacheSettings = new System.Windows.Forms.Button();
            this.lblApacheVer = new System.Windows.Forms.Label();
            this.lblApacheStatus = new System.Windows.Forms.Label();
            this.btnLogs = new System.Windows.Forms.Button();
            this.btnApache = new System.Windows.Forms.Button();
            this.lblApacheTitle = new System.Windows.Forms.Label();
            this.lblPHPVer = new System.Windows.Forms.Label();
            this.pnlMySQL = new System.Windows.Forms.Panel();
            this.lblMySQLVer = new System.Windows.Forms.Label();
            this.lblMySQLStatus = new System.Windows.Forms.Label();
            this.btnMySQL = new System.Windows.Forms.Button();
            this.lblMySQLTitle = new System.Windows.Forms.Label();
            this.tmrMain = new System.Windows.Forms.Timer(this.components);
            this.pnlApacheConfig = new System.Windows.Forms.Panel();
            this.lblApacheConfig = new System.Windows.Forms.Label();
            this.pnlMySQLConfig = new System.Windows.Forms.Panel();
            this.lblMySQLConfig = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPHPSettings = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlTitlebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlApache.SuspendLayout();
            this.pnlMySQL.SuspendLayout();
            this.pnlApacheConfig.SuspendLayout();
            this.pnlMySQLConfig.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitlebar
            // 
            this.pnlTitlebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.pnlTitlebar.Controls.Add(this.pictureBox1);
            this.pnlTitlebar.Controls.Add(this.btnMinimize);
            this.pnlTitlebar.Controls.Add(this.btnClose);
            this.pnlTitlebar.Controls.Add(this.lblTitle);
            this.pnlTitlebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitlebar.Location = new System.Drawing.Point(0, 0);
            this.pnlTitlebar.Name = "pnlTitlebar";
            this.pnlTitlebar.Size = new System.Drawing.Size(284, 31);
            this.pnlTitlebar.TabIndex = 1;
            this.pnlTitlebar.DoubleClick += new System.EventHandler(this.TitleDoubleClick);
            this.pnlTitlebar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleMouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::wampmon.Properties.Resources.app;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 22);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(194, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(45, 31);
            this.btnMinimize.TabIndex = 3;
            this.btnMinimize.Text = "＿";
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(239, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(45, 31);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "✕";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(41, 6);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(115, 20);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "WAMP Monitor";
            this.lblTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleLabelMouseMove);
            // 
            // pnlApache
            // 
            this.pnlApache.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pnlApache.Controls.Add(this.btnApacheSettings);
            this.pnlApache.Controls.Add(this.lblApacheVer);
            this.pnlApache.Controls.Add(this.lblApacheStatus);
            this.pnlApache.Controls.Add(this.btnLogs);
            this.pnlApache.Controls.Add(this.btnApache);
            this.pnlApache.Controls.Add(this.lblApacheTitle);
            this.pnlApache.Location = new System.Drawing.Point(12, 43);
            this.pnlApache.Name = "pnlApache";
            this.pnlApache.Size = new System.Drawing.Size(259, 134);
            this.pnlApache.TabIndex = 2;
            // 
            // btnApacheSettings
            // 
            this.btnApacheSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnApacheSettings.FlatAppearance.BorderSize = 0;
            this.btnApacheSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnApacheSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApacheSettings.ForeColor = System.Drawing.Color.White;
            this.btnApacheSettings.Location = new System.Drawing.Point(75, 80);
            this.btnApacheSettings.Name = "btnApacheSettings";
            this.btnApacheSettings.Size = new System.Drawing.Size(69, 41);
            this.btnApacheSettings.TabIndex = 5;
            this.btnApacheSettings.Text = "Settings";
            this.btnApacheSettings.UseVisualStyleBackColor = false;
            this.btnApacheSettings.Click += new System.EventHandler(this.btnApacheSettings_Click);
            // 
            // lblApacheVer
            // 
            this.lblApacheVer.AutoSize = true;
            this.lblApacheVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApacheVer.ForeColor = System.Drawing.Color.DarkGray;
            this.lblApacheVer.Location = new System.Drawing.Point(91, 10);
            this.lblApacheVer.Name = "lblApacheVer";
            this.lblApacheVer.Size = new System.Drawing.Size(0, 20);
            this.lblApacheVer.TabIndex = 3;
            // 
            // lblApacheStatus
            // 
            this.lblApacheStatus.AutoSize = true;
            this.lblApacheStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lblApacheStatus.ForeColor = System.Drawing.Color.Red;
            this.lblApacheStatus.Location = new System.Drawing.Point(8, 38);
            this.lblApacheStatus.Name = "lblApacheStatus";
            this.lblApacheStatus.Size = new System.Drawing.Size(74, 25);
            this.lblApacheStatus.TabIndex = 2;
            this.lblApacheStatus.Text = "Offline";
            // 
            // btnLogs
            // 
            this.btnLogs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnLogs.FlatAppearance.BorderSize = 0;
            this.btnLogs.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnLogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogs.ForeColor = System.Drawing.Color.White;
            this.btnLogs.Location = new System.Drawing.Point(13, 80);
            this.btnLogs.Name = "btnLogs";
            this.btnLogs.Size = new System.Drawing.Size(56, 41);
            this.btnLogs.TabIndex = 1;
            this.btnLogs.Text = "Logs";
            this.btnLogs.UseVisualStyleBackColor = false;
            this.btnLogs.Click += new System.EventHandler(this.btnLogs_Click);
            // 
            // btnApache
            // 
            this.btnApache.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnApache.FlatAppearance.BorderSize = 0;
            this.btnApache.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnApache.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApache.ForeColor = System.Drawing.Color.White;
            this.btnApache.Location = new System.Drawing.Point(150, 80);
            this.btnApache.Name = "btnApache";
            this.btnApache.Size = new System.Drawing.Size(97, 41);
            this.btnApache.TabIndex = 1;
            this.btnApache.Text = "Start";
            this.btnApache.UseVisualStyleBackColor = false;
            this.btnApache.Click += new System.EventHandler(this.btnApache_Click);
            // 
            // lblApacheTitle
            // 
            this.lblApacheTitle.AutoSize = true;
            this.lblApacheTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApacheTitle.ForeColor = System.Drawing.Color.White;
            this.lblApacheTitle.Location = new System.Drawing.Point(8, 5);
            this.lblApacheTitle.Name = "lblApacheTitle";
            this.lblApacheTitle.Size = new System.Drawing.Size(85, 25);
            this.lblApacheTitle.TabIndex = 0;
            this.lblApacheTitle.Text = "Apache";
            // 
            // lblPHPVer
            // 
            this.lblPHPVer.AutoSize = true;
            this.lblPHPVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPHPVer.ForeColor = System.Drawing.Color.DarkGray;
            this.lblPHPVer.Location = new System.Drawing.Point(69, 10);
            this.lblPHPVer.Name = "lblPHPVer";
            this.lblPHPVer.Size = new System.Drawing.Size(0, 20);
            this.lblPHPVer.TabIndex = 4;
            // 
            // pnlMySQL
            // 
            this.pnlMySQL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pnlMySQL.Controls.Add(this.lblMySQLVer);
            this.pnlMySQL.Controls.Add(this.lblMySQLStatus);
            this.pnlMySQL.Controls.Add(this.btnMySQL);
            this.pnlMySQL.Controls.Add(this.lblMySQLTitle);
            this.pnlMySQL.Location = new System.Drawing.Point(12, 183);
            this.pnlMySQL.Name = "pnlMySQL";
            this.pnlMySQL.Size = new System.Drawing.Size(259, 134);
            this.pnlMySQL.TabIndex = 2;
            // 
            // lblMySQLVer
            // 
            this.lblMySQLVer.AutoSize = true;
            this.lblMySQLVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMySQLVer.ForeColor = System.Drawing.Color.DarkGray;
            this.lblMySQLVer.Location = new System.Drawing.Point(89, 9);
            this.lblMySQLVer.Name = "lblMySQLVer";
            this.lblMySQLVer.Size = new System.Drawing.Size(0, 20);
            this.lblMySQLVer.TabIndex = 4;
            // 
            // lblMySQLStatus
            // 
            this.lblMySQLStatus.AutoSize = true;
            this.lblMySQLStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lblMySQLStatus.ForeColor = System.Drawing.Color.Red;
            this.lblMySQLStatus.Location = new System.Drawing.Point(8, 38);
            this.lblMySQLStatus.Name = "lblMySQLStatus";
            this.lblMySQLStatus.Size = new System.Drawing.Size(74, 25);
            this.lblMySQLStatus.TabIndex = 3;
            this.lblMySQLStatus.Text = "Offline";
            // 
            // btnMySQL
            // 
            this.btnMySQL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnMySQL.FlatAppearance.BorderSize = 0;
            this.btnMySQL.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnMySQL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMySQL.ForeColor = System.Drawing.Color.White;
            this.btnMySQL.Location = new System.Drawing.Point(152, 80);
            this.btnMySQL.Name = "btnMySQL";
            this.btnMySQL.Size = new System.Drawing.Size(94, 41);
            this.btnMySQL.TabIndex = 2;
            this.btnMySQL.Text = "Start";
            this.btnMySQL.UseVisualStyleBackColor = false;
            this.btnMySQL.Click += new System.EventHandler(this.btnMySQL_Click);
            // 
            // lblMySQLTitle
            // 
            this.lblMySQLTitle.AutoSize = true;
            this.lblMySQLTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMySQLTitle.ForeColor = System.Drawing.Color.White;
            this.lblMySQLTitle.Location = new System.Drawing.Point(8, 5);
            this.lblMySQLTitle.Name = "lblMySQLTitle";
            this.lblMySQLTitle.Size = new System.Drawing.Size(83, 25);
            this.lblMySQLTitle.TabIndex = 0;
            this.lblMySQLTitle.Text = "MySQL";
            // 
            // tmrMain
            // 
            this.tmrMain.Enabled = true;
            this.tmrMain.Interval = 10000;
            this.tmrMain.Tick += new System.EventHandler(this.tmrMain_Tick);
            // 
            // pnlApacheConfig
            // 
            this.pnlApacheConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pnlApacheConfig.Controls.Add(this.lblApacheConfig);
            this.pnlApacheConfig.Location = new System.Drawing.Point(12, 76);
            this.pnlApacheConfig.Name = "pnlApacheConfig";
            this.pnlApacheConfig.Size = new System.Drawing.Size(259, 101);
            this.pnlApacheConfig.TabIndex = 3;
            this.pnlApacheConfig.Click += new System.EventHandler(this.ApacheConfigClick);
            // 
            // lblApacheConfig
            // 
            this.lblApacheConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApacheConfig.ForeColor = System.Drawing.Color.White;
            this.lblApacheConfig.Location = new System.Drawing.Point(13, 30);
            this.lblApacheConfig.Name = "lblApacheConfig";
            this.lblApacheConfig.Size = new System.Drawing.Size(234, 42);
            this.lblApacheConfig.TabIndex = 0;
            this.lblApacheConfig.Text = "Apache directory is not found. Click here to configure.";
            this.lblApacheConfig.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblApacheConfig.Click += new System.EventHandler(this.ApacheLabelConfigClick);
            // 
            // pnlMySQLConfig
            // 
            this.pnlMySQLConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pnlMySQLConfig.Controls.Add(this.lblMySQLConfig);
            this.pnlMySQLConfig.Location = new System.Drawing.Point(12, 216);
            this.pnlMySQLConfig.Name = "pnlMySQLConfig";
            this.pnlMySQLConfig.Size = new System.Drawing.Size(259, 101);
            this.pnlMySQLConfig.TabIndex = 4;
            this.pnlMySQLConfig.Click += new System.EventHandler(this.MySQLConfigClick);
            // 
            // lblMySQLConfig
            // 
            this.lblMySQLConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMySQLConfig.ForeColor = System.Drawing.Color.White;
            this.lblMySQLConfig.Location = new System.Drawing.Point(13, 30);
            this.lblMySQLConfig.Name = "lblMySQLConfig";
            this.lblMySQLConfig.Size = new System.Drawing.Size(234, 42);
            this.lblMySQLConfig.TabIndex = 0;
            this.lblMySQLConfig.Text = "MySQL directory is not found. Click here to configure.";
            this.lblMySQLConfig.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMySQLConfig.Click += new System.EventHandler(this.MySQLLabelConfigClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblPHPVer);
            this.panel1.Controls.Add(this.btnPHPSettings);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(12, 326);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 97);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(89, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 4;
            // 
            // btnPHPSettings
            // 
            this.btnPHPSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnPHPSettings.FlatAppearance.BorderSize = 0;
            this.btnPHPSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnPHPSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPHPSettings.ForeColor = System.Drawing.Color.White;
            this.btnPHPSettings.Location = new System.Drawing.Point(152, 44);
            this.btnPHPSettings.Name = "btnPHPSettings";
            this.btnPHPSettings.Size = new System.Drawing.Size(94, 41);
            this.btnPHPSettings.TabIndex = 2;
            this.btnPHPSettings.Text = "Settings";
            this.btnPHPSettings.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(8, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "PHP";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(284, 436);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlMySQL);
            this.Controls.Add(this.pnlTitlebar);
            this.Controls.Add(this.pnlApache);
            this.Controls.Add(this.pnlApacheConfig);
            this.Controls.Add(this.pnlMySQLConfig);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(200, 150);
            this.Name = "frmMain";
            this.Text = "WAMP Monitor";
            this.pnlTitlebar.ResumeLayout(false);
            this.pnlTitlebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlApache.ResumeLayout(false);
            this.pnlApache.PerformLayout();
            this.pnlMySQL.ResumeLayout(false);
            this.pnlMySQL.PerformLayout();
            this.pnlApacheConfig.ResumeLayout(false);
            this.pnlMySQLConfig.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitlebar;
        private System.Windows.Forms.Panel pnlApache;
        private System.Windows.Forms.Label lblApacheTitle;
        private System.Windows.Forms.Panel pnlMySQL;
        private System.Windows.Forms.Label lblMySQLTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnApache;
        private System.Windows.Forms.Label lblApacheStatus;
        private System.Windows.Forms.Button btnMySQL;
        private System.Windows.Forms.Label lblMySQLStatus;
        private System.Windows.Forms.Timer tmrMain;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Panel pnlApacheConfig;
        private System.Windows.Forms.Label lblApacheConfig;
        private System.Windows.Forms.Panel pnlMySQLConfig;
        private System.Windows.Forms.Label lblMySQLConfig;
        private System.Windows.Forms.Label lblApacheVer;
        private System.Windows.Forms.Label lblMySQLVer;
        private System.Windows.Forms.Button btnLogs;
        private System.Windows.Forms.Label lblPHPVer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnApacheSettings;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPHPSettings;
        private System.Windows.Forms.Label label3;
    }
}

