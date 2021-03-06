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

        public static bool ClearOldBackups()
        {
#if DEBUG
            return true;
#endif
            try
            {
                DirectoryInfo backupDirectory = new DirectoryInfo(SettingsManager.BackupDirectory);
                foreach (FileInfo file in backupDirectory.GetFiles())
                {
                    if (file.LastAccessTime.AddMonths(1) < DateTime.Now)
                    {
                        file.Delete();
                        return true;
                    }
                }
            } catch (Exception e)
            {
                if (Program.SentryEnabled) Sentry.SentrySdk.CaptureException(e);
                Console.WriteLine(e.Message);
            }
            return false;
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
