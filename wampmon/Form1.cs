using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace wampmon
{
    public partial class Form1 : Form
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

        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
            SetStyle(ControlStyles.ResizeRedraw, true);
            CheckServices();
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void TitleLabelMouseMove(object sender, MouseEventArgs e)
        {
            TitleMouseMove(sender, e);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void StartService(bool svc)
        {
            Process proc = new Process();
            proc.StartInfo.UseShellExecute = false;
            proc.StartInfo.RedirectStandardOutput = true;
            proc.StartInfo.CreateNoWindow = true;
            if (svc == APACHE)
            { // apache
                proc.StartInfo.WorkingDirectory = "apache\\bin";
                proc.StartInfo.FileName = "apache\\bin\\httpd.exe";
            }
            else // mysql
                proc.StartInfo.FileName = "mysql\\bin\\mysqld.exe";
            proc.Start();
        }
        private void KillService(string target)
        {
            foreach (var process in Process.GetProcessesByName(target))
                process.Kill();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsRunning("httpd"))
                KillService("httpd");
            else
                StartService(APACHE);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (IsRunning("mysqld"))
                KillService("mysqld");
            else
                StartService(MYSQL);
        }

        private bool IsRunning(string target)
        {
            return (Process.GetProcessesByName(target).Length == 0) ? false : true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CheckServices();
        }

        private void CheckServices()
        {
            if (IsRunning("httpd"))
            {
                label4.ForeColor = Color.Green;
                label4.Text = "Online";
                button1.Text = "Stop";
            }
            else
            {
                label4.ForeColor = Color.Red;
                label4.Text = "Offline";
                button1.Text = "Start";
            }

            if (IsRunning("mysqld"))
            {
                label5.ForeColor = Color.Green;
                label5.Text = "Online";
                button2.Text = "Stop";
            }
            else
            {
                label5.ForeColor = Color.Red;
                label5.Text = "Offline";
                button2.Text = "Start";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
