using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace wampmon
{
    public partial class frmLogs : Form
    {
        private readonly string apacheLogFile;

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
