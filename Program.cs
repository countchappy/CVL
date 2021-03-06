using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;
using Microsoft.Win32;
using AutoUpdaterDotNET;
using Sentry;
using CVL.Subsystem;
using CVL.Forms;

namespace CVL
{
    static class Program
    {
        #region Initialization
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Starting up");
                try
                {
                    string sUrl = (string)Registry.GetValue(Properties.Settings.Default.Registry_CVLKeyAddress, "sentry_url", null);
                    if (sUrl != null) {
                        Console.Write("Sentry configured. Initializing ... ");
                        using (SentrySdk.Init(sUrl))
                        {
                            _sentryEnabled = true;
#if DEBUG
                            SentryManager.SetScope(SentryManager.Scope.Development);
#else
                            SentryManager.SetScope(SentryManager.Scope.Production);
#endif
                            Console.WriteLine("complete");
                            Initialize(args);
                        }
                    } else
                    {
                        Console.WriteLine("Sentry disabled");
                        Initialize(args);
                    }
                } catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine(e.StackTrace);
                }
            } catch (IOException ioe)
            {
                throw ioe;
            }
        }
        static bool _sentryEnabled = false;
        static List<string> launcherWriteQueue = new List<string>();
        public static bool SentryEnabled
        {
            get
            {
                return _sentryEnabled;
            }
        }
        static void Initialize(string[] args)
        {
            UpgradeSettings();
            CheckForUpdates();
            Console.WriteLine("Processing launch arguments");
            ProcessLaunchArguments(args);
            Console.WriteLine("Launching GUI");
            RunLauncherForm();
        }
        static void UpgradeSettings()
        {
            if (Properties.Settings.Default.CVL_UpgradeFlag)
            {
                try
                {
                    Properties.Settings.Default.Upgrade();
                    Properties.Settings.Default.CVL_UpgradeFlag = false;
                    Properties.Settings.Default.Save();
                    Console.WriteLine("Settings migrated from previous version");
                    launcherWriteQueue.Add(Properties.Resources.info_SettingsUpgraded);
                } catch (Exception e)
                {
                    if (SentryEnabled) SentrySdk.CaptureException(e);
                    Console.WriteLine(e.Message);
                    launcherWriteQueue.Add(Properties.Resources.err_FailedSettingsUpgrade);
                }
            }
        }
        static void CheckForUpdates()
        {
            try
            {
                string aUrl = (string)Registry.GetValue(Properties.Settings.Default.Registry_CVLKeyAddress, "autoupdater_url", null);
                if(aUrl != null)
                {
                    Console.WriteLine("Running AutoUpdater.Net");
                    AutoUpdater.Start(aUrl);
                } else
                {
                    Console.WriteLine("AutoUpdater.Net disabled");
                }
            } catch (Exception e)
            {
                if (SentryEnabled) SentrySdk.CaptureException(e);
                Console.WriteLine(e.Message);
            }
        }
        static void ProcessLaunchArguments(string[] args)
        {
            if (args == null) return;

            int i_vInsDir = -1;
            i_vInsDir = Array.IndexOf(args, "-VD") > -1 ? Array.IndexOf(args, "-VD") + 1 : i_vInsDir;
            i_vInsDir = Array.IndexOf(args, "--ValheimDirectory") > -1 ? Array.IndexOf(args, "-VD") + 1 : i_vInsDir;
            if (i_vInsDir > -1 && i_vInsDir <= args.Length)
                SettingsManager.ValheimInstallDirectory = args[i_vInsDir];
        }
        static void RunLauncherForm()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                if (SentryEnabled) Application.SetUnhandledExceptionMode(UnhandledExceptionMode.ThrowException);
                Application.Run(launcher = new Launcher());
            }
            catch (InvalidOperationException IOE)
            {
                if (SentryEnabled) SentrySdk.CaptureException(IOE);
                Console.WriteLine(IOE.Message);
            }
        }
        #endregion

        static Launcher launcher;

        public static void LauncherFormLoaded(object sender, EventArgs e)
        {
            Console.WriteLine("Launcher form loaded");
            foreach (string log in launcherWriteQueue) launcher.WriteLine(log);
            launcher.WriteLine(Properties.Resources.info_InitializationComplete);


            bool valheimReady;
            bool backupReady;

            valheimReady = SettingsManager.ValheimInstallDirectory != null;
            if (!valheimReady)
                launcher.WriteLine(Properties.Resources.err_ValheimNotConfigured);
            else
                launcher.WriteLine(Properties.Resources.info_ValheimReady);

            backupReady = SettingsManager.BackupDirectory != null;
            if (!SettingsManager.BackupEnabled)
                launcher.WriteLine(Properties.Resources.info_BackupsDisabled);
            else if (!backupReady)
                launcher.WriteLine(Properties.Resources.err_BackupNotConfigured);
            else
                launcher.WriteLine(Properties.Resources.info_BackupsReady);

            launcher.Write(Properties.Resources.info_LoadingServers);
            launcher.LoadServerList();
            launcher.WriteLine(Properties.Resources.keyword_Complete);

            if (valheimReady && (backupReady || !SettingsManager.BackupEnabled)) launcher.EnableLaunchButton();
        }



        public static void LaunchValheim(Launcher l, int selectedIndex)
        {
            try
            {
                if (SettingsManager.BackupEnabled)
                {
                    l.Write(Properties.Resources.info_BackupRunning);
                    BackupManager.RunBackups();
                    l.WriteLine(Properties.Resources.keyword_Complete);
                    l.Write(Properties.Resources.info_BackupsClearingOld);
                    BackupManager.ClearOldBackups();
                    l.WriteLine(Properties.Resources.keyword_Complete);
                }

                DirectoryInfo valheimInstallDirectoryInfo = new DirectoryInfo(SettingsManager.ValheimInstallDirectory);
                FileInfo file = null;
                foreach(FileInfo f in valheimInstallDirectoryInfo.GetFiles()) { 
                    if (f.Name.ToLower().Equals("valheim.exe"))
                    {
                        file = f;
                        break;
                    }
                }
                if (file != null)
                {
                    ProcessStartInfo startInfo = new ProcessStartInfo(file.FullName);

                    startInfo.UseShellExecute = true;
                    startInfo.WorkingDirectory = SettingsManager.ValheimInstallDirectory;

                    if (selectedIndex > 0)
                    {
                        startInfo.Arguments = string.Format("+connect {0}:{1}",
                            SettingsManager.DedicatedServerAddresses.Values.ElementAt(selectedIndex - 1),
                            SettingsManager.DedicatedServerPorts.Values.ElementAt(selectedIndex - 1)
                        );
                    }

                    try
                    {
                        if (Process.Start(startInfo) is Process)
                            Shutdown();
                        else
                            l.WriteLine(Properties.Resources.err_LaunchValheimProcessFailed);
                    } catch (Exception error)
                    {
                        if (SentryEnabled) SentrySdk.CaptureException(error);
                        Console.WriteLine(error.Message);
                        l.WriteLine(Properties.Resources.err_FailedLaunchValheim);
                    }
                } else
                    l.WriteLine(Properties.Resources.err_LaunchValheimMissing);
            } catch (Exception err)
            {
                if (SentryEnabled) SentrySdk.CaptureException(err);
                Console.WriteLine(err.Message);
                l.WriteLine(Properties.Resources.err_FailedLaunchValheim);
            }
        }

        public static void Shutdown(int exitCode = 0)
        {
            if (Application.MessageLoop)
                Application.Exit();
            else
                Environment.Exit(exitCode);
        }
    }
}
