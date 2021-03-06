﻿using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace wampmon
{
    public partial class frmMain : Form
    {
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        public frmMain()
        {
            InitializeComponent();
            DoubleBuffered = true;
            SetStyle(ControlStyles.ResizeRedraw, true);
            CheckServices();
            pnlApacheConfig.BringToFront();
            pnlMySQLConfig.BringToFront();
            string output;
            if (!string.IsNullOrEmpty(Properties.Settings.Default.apachePath))
            {
                output = GetApacheVer();
                lblApacheVer.Text = "v" + output.Split(' ')[2].Split('/')[1];
                pnlApacheConfig.Hide();
            }
            if (!string.IsNullOrEmpty(Properties.Settings.Default.mysqlPath))
            {
                output = GetMySQLVer();
                lblMySQLVer.Text = "v" + output.Split(' ')[3];
                pnlMySQLConfig.Hide();
            }
            if (File.Exists($"{Properties.Settings.Default.phpPath}\\php.exe")) { 
                output = GetPHPVer();
                lblPHPVer.Text = "v" + output.Split(' ')[1];
            }
        }

        private static string GetApacheVer()
        {
            Process proc = new Process();
            proc.StartInfo.UseShellExecute = false;
            proc.StartInfo.RedirectStandardOutput = true;
            proc.StartInfo.CreateNoWindow = true;
            proc.StartInfo.Arguments = "-v";
            proc.StartInfo.WorkingDirectory = $"{Properties.Settings.Default.apachePath}\\bin";
            proc.StartInfo.FileName = $"{Properties.Settings.Default.apachePath}\\bin\\httpd.exe";
            proc.Start();
            string output = proc.StandardOutput.ReadToEnd();
            proc.WaitForExit();
            return output;
        }

        private static string GetMySQLVer()
        {
            Process proc = new Process();
            proc.StartInfo.UseShellExecute = false;
            proc.StartInfo.RedirectStandardOutput = true;
            proc.StartInfo.CreateNoWindow = true;
            proc.StartInfo.Arguments = "-V";
            proc.StartInfo.FileName = $"{Properties.Settings.Default.mysqlPath}\\bin\\mysql.exe";
            proc.Start();
            string output = proc.StandardOutput.ReadToEnd();
            proc.WaitForExit();
            return output;
        }

        private static string GetPHPVer()
        {
            Process proc = new Process();
            proc.StartInfo.UseShellExecute = false;
            proc.StartInfo.RedirectStandardOutput = true;
            proc.StartInfo.CreateNoWindow = true;
            proc.StartInfo.Arguments = "-v";
            proc.StartInfo.FileName = $"{Properties.Settings.Default.phpPath}\\php.exe";
            proc.Start();
            string output = proc.StandardOutput.ReadToEnd();
            proc.WaitForExit();
            return output;
        }

        private void StartService(string svc)
        {
            string apacheExe = $"{Properties.Settings.Default.apachePath}\\bin\\httpd.exe";
            string mysqlExe = $"{Properties.Settings.Default.mysqlPath}\\bin\\mysqld.exe";
            if (!File.Exists(apacheExe) || !File.Exists(mysqlExe)) return;
            Process proc = new Process();
            proc.StartInfo.UseShellExecute = false;
            proc.StartInfo.RedirectStandardOutput = true;
            proc.StartInfo.CreateNoWindow = true;
            if (svc == "httpd.exe")
            { // apache
                proc.StartInfo.WorkingDirectory = $"{Properties.Settings.Default.apachePath}\\bin";
                proc.StartInfo.FileName = apacheExe;
            }
            else // mysql
            {
                proc.StartInfo.WorkingDirectory = $"{Properties.Settings.Default.mysqlPath}\\bin";
                proc.StartInfo.FileName = mysqlExe;
            }
            proc.Start();
            CheckServices();
        }

        private void KillService(string target)
        {
            foreach (var process in Process.GetProcessesByName(target))
                process.Kill();
            CheckServices();
        }

        private void btnApache_Click(object sender, EventArgs e)
        {
            if (IsRunning("httpd"))
                KillService("httpd");
            else
                StartService("httpd.exe");
        }

        private void btnMySQL_Click(object sender, EventArgs e)
        {
            if (IsRunning("mysqld"))
                KillService("mysqld");
            else
                StartService("mysqld.exe");
        }

        private bool IsRunning(string target)
        {
            return Process.GetProcessesByName(target).Length != 0;
        }

        private void tmrMain_Tick(object sender, EventArgs e)
        {
            CheckServices();
        }

        private void CheckService(string svc, Label svcLabel, Button svcButton)
        {
            if (IsRunning(svc))
            {
                svcLabel.ForeColor = Color.Green;
                svcLabel.Text = "Online";
                svcButton.Text = "Stop";
            }
            else
            {
                svcLabel.ForeColor = Color.Red;
                svcLabel.Text = "Offline";
                svcButton.Text = "Start";
            }
            if (IsRunning("httpd"))
                btnLogs.Enabled = false;
            else
                btnLogs.Enabled = true;
        }

        private void CheckServices()
        {
            CheckService("httpd", lblApacheStatus, btnApache);
            CheckService("mysqld", lblMySQLStatus, btnMySQL);
        }

        private void TitleDoubleClick(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else WindowState = FormWindowState.Normal;
        }

        private void TitleMouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void TitleLabelMouseMove(object sender, MouseEventArgs e)
        {
            TitleMouseMove(sender, e);
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void ApacheConfigClick(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            folderBrowser.Description = "Choose Apache directory.\nUsually C:\\Program Files\\Apache";
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.apachePath = folderBrowser.SelectedPath;
                Properties.Settings.Default.Save();
                pnlApacheConfig.Hide();
            }
        }

        private void ApacheLabelConfigClick(object sender, EventArgs e)
        {
            ApacheConfigClick(sender, e);
        }

        private void MySQLConfigClick(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            folderBrowser.Description = "Choose MySQL directory.\nUsually C:\\Program Files\\MySQL";
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.mysqlPath = folderBrowser.SelectedPath;
                Properties.Settings.Default.Save();
                pnlMySQLConfig.Hide();
            }
        }

        private void MySQLLabelConfigClick(object sender, EventArgs e)
        {
            MySQLConfigClick(sender, e);
        }

        private void btnLogs_Click(object sender, EventArgs e)
        {
            var logsWindow = new frmLogs(Properties.Settings.Default.apachePath + "\\logs\\access.log");
            logsWindow.Show();
        }

        private void btnApacheSettings_Click(object sender, EventArgs e)
        {
            var settings = new frmApacheSettings(Properties.Settings.Default.apachePath + "\\conf\\httpd.conf");
            settings.Show();
        }
    }
}