using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CVL.Forms
{
    public partial class SettingAddServer : Form
    {
        private Settings settings;

        public SettingAddServer(Settings settings)
        {
            this.settings = settings;
            InitializeComponent();
        }

        private void button_AddServer_Click(object sender, EventArgs e)
        {
            Finish();
        }

        void Finish()
        {
            List<string> server = new List<string>();
            string fn = textBox_FriendlyName.Text.Trim();
            string ad = textBox_ServerAddress.Text.Trim();
            string pt = textBox_ServerPort.Text.Trim();

            if (fn.Length > 0 && ad.Length > 0 && pt.Length > 0)
            {
                server.Add(fn);
                server.Add(ad);
                server.Add(pt);
                settings.AddServer(server);
            }

            Dispose();
        }

        private void textBox_FriendlyName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return || e.KeyCode == Keys.Enter) Finish();
        }

        private void textBox_ServerAddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return || e.KeyCode == Keys.Enter) Finish();
        }

        private void textBox_ServerPort_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return || e.KeyCode == Keys.Enter) Finish();
        }
    }
}
