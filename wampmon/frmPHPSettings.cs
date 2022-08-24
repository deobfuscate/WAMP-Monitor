using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace wampmon
{
    public partial class frmPHPSettings : Form
    {
        private string configFile;

        public frmPHPSettings(string configFile) {
            InitializeComponent();
            DoubleBuffered = true;
            this.configFile = configFile;
        }

        private void btnMinimize_Click(object sender, EventArgs e) {
            WindowState = FormWindowState.Minimized;
        }

        private void frmLogs_Load(object sender, EventArgs e) {
            comboBox2.SelectedIndex = 0;
        }

        private void btnSave_Click(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
