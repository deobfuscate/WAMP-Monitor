using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace wampmon
{
    public partial class frmApacheSettings : Form
    {
        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();
        [DllImport("dwmapi.dll")]
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, int[] attrValue, int attrSize);

        private string configFile;

        protected override void OnHandleCreated(EventArgs e)
        {
            try
            {
                if (DwmSetWindowAttribute(Handle, 19, new[] { 1 }, 4) != 0)
                    DwmSetWindowAttribute(Handle, 20, new[] { 1 }, 4);
            }
            catch { return; }
        }

        public frmApacheSettings(string configFile)
        {
            InitializeComponent();
            DoubleBuffered = true;
            //SetStyle(ControlStyles.ResizeRedraw, true);
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
            //btnCloseWindow.Left = Width - btnCloseWindow.Width;
            //btnMinimize.Left = Width - btnCloseWindow.Width - btnMinimize.Width;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
