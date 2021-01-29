using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace wampmon
{
    public partial class frmApacheSettings : Form
    {
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;
        private const int GRIP_SIZE = 14;

        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();
        private string configFile;
        
        public frmApacheSettings(string configFile)
        {
            InitializeComponent();
            DoubleBuffered = true;
            SetStyle(ControlStyles.ResizeRedraw, true);
            this.configFile = configFile;
        }

        private string ReadSetting(string filename, string setting)
        {
            string line;
            StreamReader file = new StreamReader(filename);
            while ((line = file.ReadLine()) != null)
            {
                if (line == "" || line[0] == '#') continue;
                var split = line.Split(' ');
                if (split[0] == setting)
                    return split[1];
            }
            return null;
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
            Close();
        }

        private void frmLogs_Load(object sender, EventArgs e)
        {
            txtDocRoot.Text = ReadSetting(configFile, "DocumentRoot");
            txtServerName.Text = ReadSetting(configFile, "ServerName");
            txtServerAdmin.Text = ReadSetting(configFile, "ServerAdmin");
            txtPort.Text = ReadSetting(configFile, "Listen");
            txtErrorLog.Text = ReadSetting(configFile, "ErrorLog");
            txtLogLevel.Text = ReadSetting(configFile, "LogLevel");
        }

        private void btnCloseWindow_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ResizeLogWindow(object sender, EventArgs e)
        {
            btnSave.Top = Height - 44;
            button1.Top = Height - 44;
            btnCloseWindow.Left = Width - btnCloseWindow.Width;
            btnMinimize.Left = Width - btnCloseWindow.Width - btnMinimize.Width;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
