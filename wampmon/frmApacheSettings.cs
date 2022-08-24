using System;
using System.IO;
using System.Windows.Forms;

namespace wampmon
{
    public partial class frmApacheSettings : Form
    {
        private string configFile;

        public frmApacheSettings(string configFile) {
            InitializeComponent();
            DoubleBuffered = true;
            this.configFile = configFile;
        }

        private string ReadSetting(string filename, string setting) {
            string line;
            StreamReader file = new StreamReader(filename);
            while ((line = file.ReadLine()) != null) {
                if (line == "" || line[0] == '#') continue;
                var split = line.Split(' ');
                if (split[0] == setting)
                    return split[1];
            }
            return null;
        }

        private bool SaveSetting(string filename, string setting, string value) {
            string text = "";
            using (StreamReader sr = new StreamReader(filename)) {
                do {
                    string line = sr.ReadLine();
                    var split = line.Split(' ');
                    if (line != "" && line[0] != '#' && split[0] == setting)
                        line = line.Replace(split[1], value);
                    text += line + Environment.NewLine;
                } while (!sr.EndOfStream);
            }
            text = text.TrimEnd('\r', '\n');
            if (text == "")
                return false;
            try {
                File.WriteAllText(filename, text);
            }
            catch {
                return false;
            }
            return true;
        }

        private void frmLogs_Load(object sender, EventArgs e) {
            txtDocRoot.Text = ReadSetting(configFile, "DocumentRoot");
            txtServerName.Text = ReadSetting(configFile, "ServerName");
            txtServerAdmin.Text = ReadSetting(configFile, "ServerAdmin");
            txtPort.Text = ReadSetting(configFile, "Listen");
            txtErrorLog.Text = ReadSetting(configFile, "ErrorLog");
            txtLogLevel.Text = ReadSetting(configFile, "LogLevel");
        }

        private void btnCloseWindow_Click(object sender, EventArgs e) {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e) {
            SaveSetting(configFile, "DocumentRoot", txtDocRoot.Text);
            SaveSetting(configFile, "ServerName", txtServerName.Text);
            SaveSetting(configFile, "ServerAdmin", txtServerAdmin.Text);
            SaveSetting(configFile, "Listen", txtPort.Text);
            SaveSetting(configFile, "ErrorLog", txtErrorLog.Text);
            SaveSetting(configFile, "LogLevel", txtLogLevel.Text);
        }
    }
}
