using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace wampmon
{
    public partial class frmMain : Form
    {
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;
        private const int GRIP_SIZE = 14;
        private const bool APACHE = true;
        private const bool MYSQL = false;

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
            if (!string.IsNullOrEmpty(Properties.Settings.Default.apachePath))
            {
                pnlApacheConfig.Hide();
            }
            if (!string.IsNullOrEmpty(Properties.Settings.Default.mysqlPath))
            {
                pnlMySQLConfig.Hide();
            }
        }

        private void StartService(bool svc)
        {
            Process proc = new Process();
            proc.StartInfo.UseShellExecute = false;
            proc.StartInfo.RedirectStandardOutput = true;
            proc.StartInfo.CreateNoWindow = true;
            if (svc == APACHE)
            { // apache
                proc.StartInfo.WorkingDirectory = Properties.Settings.Default.apachePath;
                proc.StartInfo.FileName = $"{Properties.Settings.Default.apachePath}\\httpd.exe";
            }
            else // mysql
                proc.StartInfo.FileName = $"{Properties.Settings.Default.apachePath}\\mysqld.exe";
            proc.Start();
        }

        private void KillService(string target)
        {
            foreach (var process in Process.GetProcessesByName(target))
                process.Kill();
        }

        private void btnApache_Click(object sender, EventArgs e)
        {
            if (IsRunning("httpd"))
                KillService("httpd");
            else
                StartService(APACHE);
        }

        private void btnMySQL_Click(object sender, EventArgs e)
        {
            if (IsRunning("mysqld"))
                KillService("mysqld");
            else
                StartService(MYSQL);
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
        }

        private void CheckServices()
        {
            CheckService("httpd", lblApacheStatus, btnApache);
            CheckService("mysqld", lblMySQLStatus, btnMySQL);
        }

        private void TitleDoubleClick(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal) WindowState = FormWindowState.Maximized;
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

        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle rc = new Rectangle(ClientSize.Width - GRIP_SIZE, ClientSize.Height - GRIP_SIZE, GRIP_SIZE, GRIP_SIZE);
            ControlPaint.DrawSizeGrip(e.Graphics, BackColor, rc);
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {  // Trap WM_NCHITTEST
                Point pos = new Point(m.LParam.ToInt32());
                pos = PointToClient(pos);

                if (pos.X >= ClientSize.Width - GRIP_SIZE && pos.Y >= ClientSize.Height - GRIP_SIZE)
                {
                    m.Result = (IntPtr)17; // HTBOTTOMRIGHT
                    return;
                }
            }
            base.WndProc(ref m);
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
    }
}