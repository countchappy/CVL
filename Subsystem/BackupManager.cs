using System;
using System.IO;
using System.IO.Compression;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVL.Subsystem
{
    class BackupManager
    {

        private void ClearOldBackups()
        {
            string pAppData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string pPrData = Properties.Settings.Default.CVLU_backupDirectory;
            string bkDir = string.Format("{0}{1}\\Valheim Backups", pAppData, pPrData);
            foreach (string file in Directory.GetFiles(bkDir))
            {
                FileInfo fi = new FileInfo(file);
                if (fi.LastAccessTime < DateTime.Now.AddMonths(-1))
                    fi.Delete();
            }
        }

        public static bool RunBackups()
        {
#if DEBUG
            return true;
#endif
            // Get valheim appdata directory
            string dir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            foreach (DirectoryInfo di in Directory.GetParent(dir).GetDirectories())
            {
                if (di.Name == "LocalLow" && di.Exists)
                {
                    string valheimDataPath = string.Format("{0}\\IronGate\\Valheim", di.FullName);
                    if (Directory.Exists(valheimDataPath))
                    {
                        string bkDir = SettingsManager.BackupDirectory;
                        if (Directory.CreateDirectory(bkDir).Exists)
                        {
                            string buZipFile = string.Format("{0}\\{1}.zip", bkDir, DateTime.Now.ToString("yyyy-dd-M--HH-mm-ss"));
                            ZipFile.CreateFromDirectory(valheimDataPath, buZipFile);
                            return true;
                        }
                    }
                    break;
                }
            }
            return false;
        }
    }
}
