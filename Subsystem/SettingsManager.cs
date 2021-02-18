using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gameloop.Vdf;
using Gameloop.Vdf.Linq;
using Newtonsoft.Json;

namespace CVL.Subsystem
{
    class SettingsManager
    {
        #region Valheim Install Directory
        public static string ValheimInstallDirectory
        {
            get
            {
                string dir = Properties.Settings.Default.CVLU_valheimInstallDir;
                try
                {
                    if (dir.Trim().Length > 0)
                    {
                        DirectoryInfo dInfo = new DirectoryInfo(dir);
                        foreach (FileInfo fInfo in dInfo.GetFiles())
                        {
                            if (fInfo.Name.ToLower().Equals("valheim.exe"))
                                return dir;
                        }
                    }
                    return ScanSystemForValheim();
                } catch (Exception e)
                {
                    if (Program.SentryEnabled) Sentry.SentrySdk.CaptureException(e);
                    return null;
                }
            }
            set
            {
                if (Directory.Exists(value) && File.Exists(string.Format("{0}\\valheim.exe", value)))
                {
                    Properties.Settings.Default.CVLU_valheimInstallDir = value;
                    Properties.Settings.Default.Save();
                }
            }
        }

        static string ScanSystemForValheim()
        {
            try
            {
                int valheimInstalled = (int)Microsoft.Win32.Registry.GetValue(Properties.Settings.Default.Registry_SteamValheimApp, "Installed", 0);
                if (valheimInstalled == 1)
                {
                    string steamInstallPath = (string)Microsoft.Win32.Registry.GetValue(Properties.Settings.Default.Registry_SteamInstallDirectory, "SteamPath", null);
                    if (steamInstallPath != null)
                    {
                        steamInstallPath = steamInstallPath.Replace('/', '\\');
                        if (Directory.Exists(string.Format("{0}{1}", steamInstallPath, @"\steamapps\common\Valheim"))) // Check inside steam install directory
                        {
                            return string.Format("{0}{1}", steamInstallPath, @"\steamapps\common\Valheim");
                        }
                        else if (File.Exists(string.Format("{0}{1}", steamInstallPath, @"\config\config.vdf"))) // Check outside libraries
                        {
                            dynamic steamConfig = VdfConvert.Deserialize(File.ReadAllText(string.Format("{0}{1}", steamInstallPath, @"\config\config.vdf")));
                            VObject sConfigObject = steamConfig.Value.Software.Valve.Steam;
                            foreach (VProperty vp in sConfigObject.Children())
                            {
                                if (vp.ToString().ToUpper().Contains("BASEINSTALLFOLDER"))
                                {
                                    string secondaryLibrary = Convert.ToString(vp.Value);
                                    if (Directory.Exists(string.Format("{0}{1}", secondaryLibrary, @"\steamapps\common\Valheim")))
                                    {
                                        return string.Format("{0}{1}", secondaryLibrary, @"\steamapps\common\Valheim");
                                    }
                                }
                            }
                        }
                    }
                }
                return null;
            }catch(Exception e)
            {
                if (Program.SentryEnabled) Sentry.SentrySdk.CaptureException(e);
                Console.WriteLine(e.StackTrace);
                return null;
            }
        }
        #endregion

        #region Backup Directory
        public static string BackupDirectory
        {
            get
            {
                string dir = Properties.Settings.Default.CVLU_backupDirectory;
                if (Directory.Exists(dir))
                    return dir;
                else
                    return CreateDefaultBackupFolder();
            }
            set
            {
                if (Directory.Exists(value))
                {
                    Properties.Settings.Default.CVLU_backupDirectory = value;
                    Properties.Settings.Default.Save();
                }
            }
        }

        static string CreateDefaultBackupFolder()
        {
            string appdata = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string defaultBackupPath = string.Format("{0}\\{1}\\ValheimBackups", appdata, Properties.Settings.Default.CVL_appdataDirectory);
            try
            {
                DirectoryInfo defaultBackupDirectory = Directory.CreateDirectory(defaultBackupPath);
                if (defaultBackupDirectory.Exists) return defaultBackupDirectory.FullName;
            }
            catch (Exception e)
            {
                Sentry.SentrySdk.CaptureException(e);
            }
            return null;
        }
        #endregion

        public static bool BackupEnabled
        {
            get
            {
                return Properties.Settings.Default.CVLU_backupEnabled;
            }
            set
            {
                Properties.Settings.Default.CVLU_backupEnabled = value;
                Properties.Settings.Default.Save();
            }
        }

        public static Dictionary<int, string> DedicatedServerAddresses
        {
            get
            {
                return JsonConvert.DeserializeObject<Dictionary<int, string>>(Properties.Settings.Default.CVLU_dedicatedServers_Addresses);
            }
            set
            {

            }
        }
        public static Dictionary<int, string> DedicatedServerPorts
        {
            get
            {
                return JsonConvert.DeserializeObject<Dictionary<int, string>>(Properties.Settings.Default.CVLU_dedicatedServers_Ports);
            }
            set
            {

            }
        }
    }
}
