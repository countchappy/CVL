using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Windows.Forms;
using CVL.Subsystem;
using Newtonsoft.Json;

namespace CVL.Forms
{
    public partial class Settings : Form
    {
        private Launcher launcher;

        public Settings(Launcher launcher)
        {
            this.launcher = launcher;
            InitializeComponent();
            textBox_ValheimInstallDirectory.Text = SettingsManager.ValheimInstallDirectory ?? "";
            textBox_BackupDirectory.Text = SettingsManager.BackupDirectory ?? "";
            checkBox_BackupEnabled.Checked = SettingsManager.BackupEnabled;

            Dictionary<int, string> n = new Dictionary<int, string>();
            Dictionary<int, string> a = new Dictionary<int, string>();
            Dictionary<int, string> p = new Dictionary<int, string>();

            n = JsonConvert.DeserializeObject<Dictionary<int, string>>(Properties.Settings.Default.CVLU_dedicatedServers_Names);
            a = JsonConvert.DeserializeObject<Dictionary<int, string>>(Properties.Settings.Default.CVLU_dedicatedServers_Addresses);
            p = JsonConvert.DeserializeObject<Dictionary<int, string>>(Properties.Settings.Default.CVLU_dedicatedServers_Ports);

            if (n != null && a != null && p != null)
            {
                if (n.Count == a.Count && a.Count == p.Count)
                {
                    for (int i = 0; i < n.Count; i++)
                    {
                        List<string> server = new List<string>();
                        server.Add(n.Values.ElementAt(i));
                        server.Add(a.Values.ElementAt(i));
                        server.Add(p.Values.ElementAt(i));
                        AddServer(server);
                    }
                }
            }
        }

        private void button_ValheimInstallDirectory_Click(object sender, EventArgs e)
        {
            fbd_ValheimInstallDirectory.ShowDialog(this);
            string s = fbd_ValheimInstallDirectory.SelectedPath;
            if (!s.Equals(""))
            {
                bool installDetected = false;
                DirectoryInfo sDir = new DirectoryInfo(s);

                foreach(FileInfo file in sDir.GetFiles())
                    if (installDetected = file.Name.ToUpper().Equals("VALHEIM.EXE"))
                        break;

                if (installDetected)
                {
                    SettingsManager.ValheimInstallDirectory = (textBox_ValheimInstallDirectory.Text = s);
                    launcher.WriteLine("Valheim install directory updated");
                }
                else
                    MessageBox.Show("No Valheim installation was detected at this location.", "Valheim Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_BackupDirectory_Click(object sender, EventArgs e)
        {
            fbd_BackupDirectory.ShowDialog(this);
            string s = fbd_BackupDirectory.SelectedPath;

            if (!s.Equals(""))
            {
                SettingsManager.BackupDirectory = (textBox_BackupDirectory.Text = s);
                launcher.WriteLine("Backup directory updated");
            }
        }

        private void checkBox_BackupEnabled_CheckedChanged(object sender, EventArgs e)
        {
            SettingsManager.BackupEnabled = checkBox_BackupEnabled.Checked;
        }

        private void button_DedicatedServerAdd_Click(object sender, EventArgs e)
        {
            new SettingAddServer(this).ShowDialog(this);
        }

        public void AddServer(List<string> server)
        {
            dgv_DedicatedServers.Rows.Add(server.ToArray());
        }

        private void dgv_DedicatedServers_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            ExportDedicatedServers();
        }

        private void dgv_DedicatedServers_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            ExportDedicatedServers();
        }

        private void dgv_DedicatedServers_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            ExportDedicatedServers();
        }

        void ExportDedicatedServers()
        {
            Dictionary<int, string> n = new Dictionary<int, string>();
            Dictionary<int, string> a = new Dictionary<int, string>();
            Dictionary<int, string> p = new Dictionary<int, string>();

            int i = 0;
            foreach (DataGridViewRow row in dgv_DedicatedServers.Rows)
            {
                n.Add(i, (string)row.Cells[0].Value);
                a.Add(i, (string)row.Cells[1].Value);
                p.Add(i, (string)row.Cells[2].Value);
                i++;
            }

            Properties.Settings.Default.CVLU_dedicatedServers_Names = JsonConvert.SerializeObject(n, Formatting.None);
            Properties.Settings.Default.CVLU_dedicatedServers_Addresses = JsonConvert.SerializeObject(a, Formatting.None);
            Properties.Settings.Default.CVLU_dedicatedServers_Ports = JsonConvert.SerializeObject(p, Formatting.None);
            Properties.Settings.Default.Save();
        }
    }
}
