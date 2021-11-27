using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace wampmon
{
    public partial class frmLogs : Form
    {
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;
        private const int GRIP_SIZE = 14;

        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();
        [DllImport("dwmapi.dll")]
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, int[] attrValue, int attrSize);

        private string apacheLogFile;

        protected override void OnHandleCreated(EventArgs e)
        {
            try
            {
                if (DwmSetWindowAttribute(Handle, 19, new[] { 1 }, 4) != 0)
                    DwmSetWindowAttribute(Handle, 20, new[] { 1 }, 4);
            }
            catch { return; }
        }

        public frmLogs(string logFile)
        {
            InitializeComponent();
            DoubleBuffered = true;
            SetStyle(ControlStyles.ResizeRedraw, true);
            apacheLogFile = logFile;
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
            if (File.Exists(apacheLogFile))
                txtLogs.Text = File.ReadAllText(apacheLogFile);
        }

        private void btnClearLogs_Click(object sender, EventArgs e)
        {
            File.WriteAllText(apacheLogFile, "");
            txtLogs.Text = File.ReadAllText(apacheLogFile);
        }

        private void btnCloseWindow_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
