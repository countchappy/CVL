using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CVL.Forms
{
    public partial class Launcher : Form
    {
        public Launcher()
        {
            InitializeComponent();
        }

        public void EnableLaunchButton()
        {
            btnLaunch.Cursor = Cursors.Hand;
            btnLaunch.ForeColor = System.Drawing.Color.Gainsboro;
            btnLaunch.Enabled = true;
        }

        private bool nl = true;
        public void WriteLine(string text)
        {
            if (nl) textBoxLog.Text += string.Format("[{0}] ", DateTime.Now.ToLongTimeString());
            textBoxLog.Text += string.Format("{0}\r\n", text);
            nl = true;
        }
        public void Write(string text)
        {
            if (nl) textBoxLog.Text += string.Format("[{0}] ", DateTime.Now.ToLongTimeString());
            textBoxLog.Text += text;
            nl = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Program.Shutdown();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            new Settings(this).ShowDialog(this);
            LoadServerList();
        }

        public int SelectedLaunchTo()
        {
            return comboBox_LaunchTo.SelectedIndex;
        }

        public void LoadServerList()
        {
            comboBox_LaunchTo.Items.Clear();
            comboBox_LaunchTo.Items.Add("Single Player");

            Dictionary<int, string> n = JsonConvert.DeserializeObject<Dictionary<int, string>>(Properties.Settings.Default.CVLU_dedicatedServers_Names);

            if (n != null)
                for (int i = 0; i < n.Count; i++)
                    comboBox_LaunchTo.Items.Add(n.Values.ElementAt(i));

            comboBox_LaunchTo.SelectedIndex = 0;
        }

        string launchTextPrevious = "Launching ...";
        bool isLaunchingToggle = false;
        public void ToggleLaunching()
        {
            btnLaunch.Enabled = isLaunchingToggle = !isLaunchingToggle;
            string tmp = btnLaunch.Text;
            btnLaunch.Text = launchTextPrevious;
            launchTextPrevious = tmp;

        }

        private void comboBox_LaunchTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string text = "Launch Valheim";
            if (comboBox_LaunchTo.SelectedIndex > 0)
                text += string.Format(" - {0}", comboBox_LaunchTo.SelectedItem);
            else
                text += " - Solo";
            btnLaunch.Text = text;
        }
    }
}
