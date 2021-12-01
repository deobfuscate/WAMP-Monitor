using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace wampmon
{
    public partial class frmPHPSettings : Form
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
        
        public frmPHPSettings(string configFile)
        {
            InitializeComponent();
            DoubleBuffered = true;
            //SetStyle(ControlStyles.ResizeRedraw, true);
            this.configFile = configFile;
        }

        private string ReadSetting(string filename, string setting)
        {
            return null;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void frmLogs_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
