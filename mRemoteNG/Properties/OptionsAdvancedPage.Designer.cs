﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace mRemoteNG.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.1.0.0")]
    internal sealed partial class OptionsAdvancedPage : global::System.Configuration.ApplicationSettingsBase {
        
        private static OptionsAdvancedPage defaultInstance = ((OptionsAdvancedPage)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new OptionsAdvancedPage())));
        
        public static OptionsAdvancedPage Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool ReconnectOnDisconnect {
            get {
                return ((bool)(this["ReconnectOnDisconnect"]));
            }
            set {
                this["ReconnectOnDisconnect"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string CustomPuttyPath {
            get {
                return ((string)(this["CustomPuttyPath"]));
            }
            set {
                this["CustomPuttyPath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool UseCustomPuttyPath {
            get {
                return ((bool)(this["UseCustomPuttyPath"]));
            }
            set {
                this["UseCustomPuttyPath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("2")]
        public int MaxPuttyWaitTime {
            get {
                return ((int)(this["MaxPuttyWaitTime"]));
            }
            set {
                this["MaxPuttyWaitTime"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("5500")]
        public int UVNCSCPort {
            get {
                return ((int)(this["UVNCSCPort"]));
            }
            set {
                this["UVNCSCPort"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool RdpLoadBalanceInfoUseUtf8 {
            get {
                return ((bool)(this["RdpLoadBalanceInfoUseUtf8"]));
            }
            set {
                this["RdpLoadBalanceInfoUseUtf8"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool cbAdvancedPageInOptionMenu {
            get {
                return ((bool)(this["cbAdvancedPageInOptionMenu"]));
            }
            set {
                this["cbAdvancedPageInOptionMenu"] = value;
            }
        }
    }
}