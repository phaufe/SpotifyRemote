﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VSIXSpotifyRemote {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.1.0.0")]
    internal sealed partial class ApplicationData : global::System.Configuration.ApplicationSettingsBase {
        
        private static ApplicationData defaultInstance = ((ApplicationData)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new ApplicationData())));
        
        public static ApplicationData Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string SpotifyToken {
            get {
                return ((string)(this["SpotifyToken"]));
            }
            set {
                this["SpotifyToken"] = value;
            }
        }
    }
}
