using System;
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
        [DllImport("dwmapi.dll")]
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, int[] attrValue, int attrSize);

        protected override void OnHandleCreated(EventArgs e)
        {
            try
            {
                if (DwmSetWindowAttribute(Handle, 19, new[] { 1 }, 4) != 0)
                    DwmSetWindowAttribute(Handle, 20, new[] { 1 }, 4);
            }
            catch { return; }
        }

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
            Console.WriteLine(Properties.Settings.Default.mysqlPath);
            if (File.Exists($"{Properties.Settings.Default.phpPath}\\php.exe")) { 
                output = GetPHPVer();
                lblPHPVer.Text = "v" + output.Split(' ')[1];
            }
        }

        private static string GetApacheVer()
        {
            Process p = new Process();
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.Arguments = "-v";
            p.StartInfo.WorkingDirectory = $"{Properties.Settings.Default.apachePath}\\bin";
            p.StartInfo.FileName = $"{Properties.Settings.Default.apachePath}\\bin\\httpd.exe";
            p.Start();
            string output = p.StandardOutput.ReadToEnd();
            p.WaitForExit();
            return output;
        }

        private static string GetMySQLVer()
        {
            Process p = new Process();
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.Arguments = "-V";
            p.StartInfo.FileName = $"{Properties.Settings.Default.mysqlPath}\\bin\\mysql.exe";
            p.Start();
            string output = p.StandardOutput.ReadToEnd();
            p.WaitForExit();
            return output;
        }

        private static string GetPHPVer()
        {
            Process p = new Process();
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.Arguments = "-v";
            p.StartInfo.FileName = $"{Properties.Settings.Default.phpPath}\\php.exe";
            p.Start();
            string output = p.StandardOutput.ReadToEnd();
            p.WaitForExit();
            Console.WriteLine($"{Properties.Settings.Default.phpPath}\\php.exe");
            return output;
        }

        private void StartService(string svc)
        {
            string apacheExe = $"{Properties.Settings.Default.apachePath}\\bin\\httpd.exe";
            string mysqlExe = $"{Properties.Settings.Default.mysqlPath}\\bin\\mysqld.exe";
            if (!File.Exists(apacheExe))
            {
                ApacheConfigClick(null, null);
                return;
            }

            if (!File.Exists(mysqlExe))
            {
                MySQLConfigClick(null, null);
                return;
            }

            Process p = new Process();
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.CreateNoWindow = true;
            if (svc == "httpd.exe")
            { // apache
                p.StartInfo.WorkingDirectory = $"{Properties.Settings.Default.apachePath}\\bin";
                p.StartInfo.FileName = apacheExe;
            }
            else
            { // mysql
                p.StartInfo.WorkingDirectory = $"{Properties.Settings.Default.mysqlPath}\\bin";
                p.StartInfo.FileName = mysqlExe;
            }
            p.Start();
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
            if (IsRunning("httpd")) { 
                btnLogs.Enabled = false;
                btnApacheSettings.Enabled = false;
            }
            else { 
                btnLogs.Enabled = true;
                btnApacheSettings.Enabled = true;
            }
        }

        private void CheckServices()
        {
            CheckService("httpd", lblApacheStatus, btnApache);
            CheckService("mysqld", lblMySQLStatus, btnMySQL);
        }

        private void ApacheConfigClick(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            folderBrowser.Description = "Choose Apache directory.\nUsually C:\\Program Files\\Apache";
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(folderBrowser.SelectedPath + "\\bin\\httpd.exe"))
                {
                    Properties.Settings.Default.apachePath = folderBrowser.SelectedPath;
                    Properties.Settings.Default.Save();
                    pnlApacheConfig.Hide();
                }
                else
                {
                    MessageBox.Show("Could not find httpd.exe.");
                }
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
            string logFile = Properties.Settings.Default.apachePath + "\\logs\\access.log";

            if (!File.Exists(logFile))
            {
                MessageBox.Show("Eroor. Could not find Apache log file.");
                return;
            }
            var logsWindow = new frmLogs(logFile);
            logsWindow.Show();
        }

        private void btnApacheSettings_Click(object sender, EventArgs e)
        {
            string configFile = Properties.Settings.Default.apachePath + "\\conf\\httpd.conf";
            if (!File.Exists(configFile))
            {
                MessageBox.Show("Eroor. Could not find Apache config file. (httpd.conf)");
                return;
            }
            var settings = new frmApacheSettings(configFile);
            settings.Show();
        }

        private void btnFolder_Click(object sender, EventArgs e)
        {
            Process.Start(Properties.Settings.Default.apachePath+"\\htdocs");
        }

        private void btnWebView_Click(object sender, EventArgs e)
        {
            Process.Start("http://localhost/");
        }

        private void btnPHPSettings_Click(object sender, EventArgs e)
        {
            var settings = new frmPHPSettings(Properties.Settings.Default.phpPath + "\\php.ini");
            settings.Show();
        }
    }
}