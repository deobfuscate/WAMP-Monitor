namespace wampmon
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
            this.pnlTitlebar = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlApache = new System.Windows.Forms.Panel();
            this.lblApacheStatus = new System.Windows.Forms.Label();
            this.btnApache = new System.Windows.Forms.Button();
            this.lblApacheTitle = new System.Windows.Forms.Label();
            this.pnlMySQL = new System.Windows.Forms.Panel();
            this.lblMySQLStatus = new System.Windows.Forms.Label();
            this.btnMySQL = new System.Windows.Forms.Button();
            this.lblMySQLTitle = new System.Windows.Forms.Label();
            this.tmrMain = new System.Windows.Forms.Timer(this.components);
            this.pnlApacheConfig = new System.Windows.Forms.Panel();
            this.lblApacheConfig = new System.Windows.Forms.Label();
            this.pnlMySQLConfig = new System.Windows.Forms.Panel();
            this.lblMySQLConfig = new System.Windows.Forms.Label();
            this.pnlTitlebar.SuspendLayout();
            this.pnlApache.SuspendLayout();
            this.pnlMySQL.SuspendLayout();
            this.pnlApacheConfig.SuspendLayout();
            this.pnlMySQLConfig.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitlebar
            // 
            this.pnlTitlebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.pnlTitlebar.Controls.Add(this.btnMinimize);
            this.pnlTitlebar.Controls.Add(this.btnClose);
            this.pnlTitlebar.Controls.Add(this.lblTitle);
            this.pnlTitlebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitlebar.Location = new System.Drawing.Point(0, 0);
            this.pnlTitlebar.Name = "pnlTitlebar";
            this.pnlTitlebar.Size = new System.Drawing.Size(562, 31);
            this.pnlTitlebar.TabIndex = 1;
            this.pnlTitlebar.DoubleClick += new System.EventHandler(this.TitleDoubleClick);
            this.pnlTitlebar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleMouseMove);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(472, 0);
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
            this.btnClose.Location = new System.Drawing.Point(517, 0);
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
            this.lblTitle.Location = new System.Drawing.Point(8, 6);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(115, 20);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "WAMP Monitor";
            this.lblTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleLabelMouseMove);
            // 
            // pnlApache
            // 
            this.pnlApache.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pnlApache.Controls.Add(this.lblApacheStatus);
            this.pnlApache.Controls.Add(this.btnApache);
            this.pnlApache.Controls.Add(this.lblApacheTitle);
            this.pnlApache.Location = new System.Drawing.Point(12, 43);
            this.pnlApache.Name = "pnlApache";
            this.pnlApache.Size = new System.Drawing.Size(259, 134);
            this.pnlApache.TabIndex = 2;
            // 
            // lblApacheStatus
            // 
            this.lblApacheStatus.AutoSize = true;
            this.lblApacheStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lblApacheStatus.ForeColor = System.Drawing.Color.Red;
            this.lblApacheStatus.Location = new System.Drawing.Point(8, 40);
            this.lblApacheStatus.Name = "lblApacheStatus";
            this.lblApacheStatus.Size = new System.Drawing.Size(74, 25);
            this.lblApacheStatus.TabIndex = 2;
            this.lblApacheStatus.Text = "Offline";
            // 
            // btnApache
            // 
            this.btnApache.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnApache.FlatAppearance.BorderSize = 0;
            this.btnApache.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnApache.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApache.ForeColor = System.Drawing.Color.White;
            this.btnApache.Location = new System.Drawing.Point(153, 80);
            this.btnApache.Name = "btnApache";
            this.btnApache.Size = new System.Drawing.Size(94, 41);
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
            // pnlMySQL
            // 
            this.pnlMySQL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pnlMySQL.Controls.Add(this.lblMySQLStatus);
            this.pnlMySQL.Controls.Add(this.btnMySQL);
            this.pnlMySQL.Controls.Add(this.lblMySQLTitle);
            this.pnlMySQL.Location = new System.Drawing.Point(289, 43);
            this.pnlMySQL.Name = "pnlMySQL";
            this.pnlMySQL.Size = new System.Drawing.Size(259, 134);
            this.pnlMySQL.TabIndex = 2;
            // 
            // lblMySQLStatus
            // 
            this.lblMySQLStatus.AutoSize = true;
            this.lblMySQLStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lblMySQLStatus.ForeColor = System.Drawing.Color.Red;
            this.lblMySQLStatus.Location = new System.Drawing.Point(8, 40);
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
            this.pnlMySQLConfig.Location = new System.Drawing.Point(289, 76);
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
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(562, 189);
            this.Controls.Add(this.pnlMySQLConfig);
            this.Controls.Add(this.pnlApacheConfig);
            this.Controls.Add(this.pnlMySQL);
            this.Controls.Add(this.pnlApache);
            this.Controls.Add(this.pnlTitlebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(200, 150);
            this.Name = "frmMain";
            this.Text = "WAMP Monitor";
            this.pnlTitlebar.ResumeLayout(false);
            this.pnlTitlebar.PerformLayout();
            this.pnlApache.ResumeLayout(false);
            this.pnlApache.PerformLayout();
            this.pnlMySQL.ResumeLayout(false);
            this.pnlMySQL.PerformLayout();
            this.pnlApacheConfig.ResumeLayout(false);
            this.pnlMySQLConfig.ResumeLayout(false);
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
    }
}

