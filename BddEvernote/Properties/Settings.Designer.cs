﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BddEvernote.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.1.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("PleaseEnterExistingUserName")]
        public string ExistingUserName {
            get {
                return ((string)(this["ExistingUserName"]));
            }
            set {
                this["ExistingUserName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("PleaseEnterExistingUserPass")]
        public string ExistingUserPass {
            get {
                return ((string)(this["ExistingUserPass"]));
            }
            set {
                this["ExistingUserPass"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("nonexistingemail@nonexistingdomain.com")]
        public string NonExistingUserName {
            get {
                return ((string)(this["NonExistingUserName"]));
            }
            set {
                this["NonExistingUserName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("password")]
        public string NonExistingUserPass {
            get {
                return ((string)(this["NonExistingUserPass"]));
            }
            set {
                this["NonExistingUserPass"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("C:/Program Files (x86)/Google/ChromeDriver")]
        public string DriverPathChrome {
            get {
                return ((string)(this["DriverPathChrome"]));
            }
            set {
                this["DriverPathChrome"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("60")]
        public string WebDriverTimeout {
            get {
                return ((string)(this["WebDriverTimeout"]));
            }
            set {
                this["WebDriverTimeout"] = value;
            }
        }
    }
}
