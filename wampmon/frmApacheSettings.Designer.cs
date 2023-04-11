namespace wampmon
{
    partial class frmApacheSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmApacheSettings));
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.lblServerName = new System.Windows.Forms.Label();
            this.txtServerName = new System.Windows.Forms.TextBox();
            this.lblServerAddr = new System.Windows.Forms.Label();
            this.txtServerAdmin = new System.Windows.Forms.TextBox();
            this.lblLogLvl = new System.Windows.Forms.Label();
            this.txtLogLevel = new System.Windows.Forms.TextBox();
            this.lblDocRoot = new System.Windows.Forms.Label();
            this.txtDocRoot = new System.Windows.Forms.TextBox();
            this.lblErrorLog = new System.Windows.Forms.Label();
            this.txtErrorLog = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(12, 186);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 36);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(112, 186);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 36);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnCloseWindow_Click);
            // 
            // txtPort
            // 
            this.txtPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPort.ForeColor = System.Drawing.Color.White;
            this.txtPort.Location = new System.Drawing.Point(103, 95);
            this.txtPort.Name = "txtPort";
            this.txtPort.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPort.Size = new System.Drawing.Size(61, 22);
            this.txtPort.TabIndex = 4;
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.ForeColor = System.Drawing.Color.White;
            this.lblPort.Location = new System.Drawing.Point(68, 99);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(29, 13);
            this.lblPort.TabIndex = 5;
            this.lblPort.Text = "Port:";
            // 
            // lblServerName
            // 
            this.lblServerName.AutoSize = true;
            this.lblServerName.ForeColor = System.Drawing.Color.White;
            this.lblServerName.Location = new System.Drawing.Point(25, 43);
            this.lblServerName.Name = "lblServerName";
            this.lblServerName.Size = new System.Drawing.Size(72, 13);
            this.lblServerName.TabIndex = 7;
            this.lblServerName.Text = "Server Name:";
            // 
            // txtServerName
            // 
            this.txtServerName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtServerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtServerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServerName.ForeColor = System.Drawing.Color.White;
            this.txtServerName.Location = new System.Drawing.Point(103, 39);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtServerName.Size = new System.Drawing.Size(207, 22);
            this.txtServerName.TabIndex = 2;
            // 
            // lblServerAddr
            // 
            this.lblServerAddr.AutoSize = true;
            this.lblServerAddr.ForeColor = System.Drawing.Color.White;
            this.lblServerAddr.Location = new System.Drawing.Point(24, 71);
            this.lblServerAddr.Name = "lblServerAddr";
            this.lblServerAddr.Size = new System.Drawing.Size(73, 13);
            this.lblServerAddr.TabIndex = 9;
            this.lblServerAddr.Text = "Server Admin:";
            // 
            // txtServerAdmin
            // 
            this.txtServerAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtServerAdmin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtServerAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServerAdmin.ForeColor = System.Drawing.Color.White;
            this.txtServerAdmin.Location = new System.Drawing.Point(103, 67);
            this.txtServerAdmin.Name = "txtServerAdmin";
            this.txtServerAdmin.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtServerAdmin.Size = new System.Drawing.Size(207, 22);
            this.txtServerAdmin.TabIndex = 3;
            // 
            // lblLogLvl
            // 
            this.lblLogLvl.AutoSize = true;
            this.lblLogLvl.ForeColor = System.Drawing.Color.White;
            this.lblLogLvl.Location = new System.Drawing.Point(40, 153);
            this.lblLogLvl.Name = "lblLogLvl";
            this.lblLogLvl.Size = new System.Drawing.Size(57, 13);
            this.lblLogLvl.TabIndex = 11;
            this.lblLogLvl.Text = "Log Level:";
            // 
            // txtLogLevel
            // 
            this.txtLogLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtLogLevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLogLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogLevel.ForeColor = System.Drawing.Color.White;
            this.txtLogLevel.Location = new System.Drawing.Point(103, 149);
            this.txtLogLevel.Name = "txtLogLevel";
            this.txtLogLevel.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLogLevel.Size = new System.Drawing.Size(207, 22);
            this.txtLogLevel.TabIndex = 6;
            // 
            // lblDocRoot
            // 
            this.lblDocRoot.AutoSize = true;
            this.lblDocRoot.ForeColor = System.Drawing.Color.White;
            this.lblDocRoot.Location = new System.Drawing.Point(12, 15);
            this.lblDocRoot.Name = "lblDocRoot";
            this.lblDocRoot.Size = new System.Drawing.Size(85, 13);
            this.lblDocRoot.TabIndex = 13;
            this.lblDocRoot.Text = "Document Root:";
            // 
            // txtDocRoot
            // 
            this.txtDocRoot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtDocRoot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDocRoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocRoot.ForeColor = System.Drawing.Color.White;
            this.txtDocRoot.Location = new System.Drawing.Point(103, 11);
            this.txtDocRoot.Name = "txtDocRoot";
            this.txtDocRoot.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDocRoot.Size = new System.Drawing.Size(207, 22);
            this.txtDocRoot.TabIndex = 1;
            // 
            // lblErrorLog
            // 
            this.lblErrorLog.AutoSize = true;
            this.lblErrorLog.ForeColor = System.Drawing.Color.White;
            this.lblErrorLog.Location = new System.Drawing.Point(44, 126);
            this.lblErrorLog.Name = "lblErrorLog";
            this.lblErrorLog.Size = new System.Drawing.Size(53, 13);
            this.lblErrorLog.TabIndex = 15;
            this.lblErrorLog.Text = "Error Log:";
            // 
            // txtErrorLog
            // 
            this.txtErrorLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtErrorLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtErrorLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtErrorLog.ForeColor = System.Drawing.Color.White;
            this.txtErrorLog.Location = new System.Drawing.Point(103, 121);
            this.txtErrorLog.Name = "txtErrorLog";
            this.txtErrorLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtErrorLog.Size = new System.Drawing.Size(207, 22);
            this.txtErrorLog.TabIndex = 5;
            // 
            // frmApacheSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(324, 234);
            this.Controls.Add(this.lblErrorLog);
            this.Controls.Add(this.txtErrorLog);
            this.Controls.Add(this.lblDocRoot);
            this.Controls.Add(this.txtDocRoot);
            this.Controls.Add(this.lblLogLvl);
            this.Controls.Add(this.txtLogLevel);
            this.Controls.Add(this.lblServerAddr);
            this.Controls.Add(this.txtServerAdmin);
            this.Controls.Add(this.lblServerName);
            this.Controls.Add(this.txtServerName);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtPort);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 250);
            this.Name = "frmApacheSettings";
            this.Text = "Apache Settings - WAMP Monitor";
            this.Load += new System.EventHandler(this.frmLogs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Label lblServerName;
        private System.Windows.Forms.TextBox txtServerName;
        private System.Windows.Forms.Label lblServerAddr;
        private System.Windows.Forms.TextBox txtServerAdmin;
        private System.Windows.Forms.Label lblLogLvl;
        private System.Windows.Forms.TextBox txtLogLevel;
        private System.Windows.Forms.Label lblDocRoot;
        private System.Windows.Forms.TextBox txtDocRoot;
        private System.Windows.Forms.Label lblErrorLog;
        private System.Windows.Forms.TextBox txtErrorLog;
    }
}