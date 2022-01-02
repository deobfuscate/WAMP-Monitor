using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace wampmon
{
    public partial class frmLogs : Form
    {
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

        private void frmLogs_Load(object sender, EventArgs e)
        {
            if (File.Exists(apacheLogFile))
                txtLogs.Text = File.ReadAllText(apacheLogFile);
        }

        private void btnClearLogs_Click(object sender, EventArgs e)
        {
            try
            {
                File.WriteAllText(apacheLogFile, "");
            }
            catch (Exception)
            {
                MessageBox.Show("Error, could not write to Apache log file.");
                return;
            }
            txtLogs.Text = File.ReadAllText(apacheLogFile);
        }

        private void btnCloseWindow_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
