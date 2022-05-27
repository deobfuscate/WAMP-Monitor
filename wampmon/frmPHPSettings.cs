using System;
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

        private string configFile;
        
        public frmPHPSettings(string configFile)
        {
            InitializeComponent();
            DoubleBuffered = true;
            //SetStyle(ControlStyles.ResizeRedraw, true);
            this.configFile = configFile;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void frmLogs_Load(object sender, EventArgs e)
        {
            comboBox2.SelectedIndex= 0;
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
