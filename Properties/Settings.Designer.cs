﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CVL.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.8.1.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("HKEY_CURRENT_USER\\Software\\CountChappy\\CVL")]
        public string Registry_CVLKeyAddress {
            get {
                return ((string)(this["Registry_CVLKeyAddress"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("\\CountChappy\\CVL\\")]
        public string CVL_appdataDirectory {
            get {
                return ((string)(this["CVL_appdataDirectory"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string CVLU_valheimInstallDir {
            get {
                return ((string)(this["CVLU_valheimInstallDir"]));
            }
            set {
                this["CVLU_valheimInstallDir"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string CVLU_backupDirectory {
            get {
                return ((string)(this["CVLU_backupDirectory"]));
            }
            set {
                this["CVLU_backupDirectory"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool CVLU_backupEnabled {
            get {
                return ((bool)(this["CVLU_backupEnabled"]));
            }
            set {
                this["CVLU_backupEnabled"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string CVLU_dedicatedServers_Names {
            get {
                return ((string)(this["CVLU_dedicatedServers_Names"]));
            }
            set {
                this["CVLU_dedicatedServers_Names"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string CVLU_dedicatedServers_Addresses {
            get {
                return ((string)(this["CVLU_dedicatedServers_Addresses"]));
            }
            set {
                this["CVLU_dedicatedServers_Addresses"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string CVLU_dedicatedServers_Ports {
            get {
                return ((string)(this["CVLU_dedicatedServers_Ports"]));
            }
            set {
                this["CVLU_dedicatedServers_Ports"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("HKEY_CURRENT_USER\\Software\\Valve\\Steam\\Apps\\892970")]
        public string Registry_SteamValheimApp {
            get {
                return ((string)(this["Registry_SteamValheimApp"]));
            }
            set {
                this["Registry_SteamValheimApp"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("HKEY_CURRENT_USER\\Software\\Valve\\Steam")]
        public string Registry_SteamInstallDirectory {
            get {
                return ((string)(this["Registry_SteamInstallDirectory"]));
            }
            set {
                this["Registry_SteamInstallDirectory"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool CVL_UpgradeFlag {
            get {
                return ((bool)(this["CVL_UpgradeFlag"]));
            }
            set {
                this["CVL_UpgradeFlag"] = value;
            }
        }
    }
}
