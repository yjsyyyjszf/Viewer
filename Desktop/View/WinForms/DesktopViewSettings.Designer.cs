
#region License

// Copyright (c) 2013, ClearCanvas Inc.
// All rights reserved.
// http://www.clearcanvas.ca
//
// This file is part of the ClearCanvas RIS/PACS open source project.
//
// The ClearCanvas RIS/PACS open source project is free software: you can
// redistribute it and/or modify it under the terms of the GNU General Public
// License as published by the Free Software Foundation, either version 3 of the
// License, or (at your option) any later version.
//
// The ClearCanvas RIS/PACS open source project is distributed in the hope that it
// will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU General
// Public License for more details.
//
// You should have received a copy of the GNU General Public License along with
// the ClearCanvas RIS/PACS open source project.  If not, see
// <http://www.gnu.org/licenses/>.

#endregion

//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.296
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Macro.Desktop.View.WinForms {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
    internal sealed partial class DesktopViewSettings : global::System.Configuration.ApplicationSettingsBase {
        
        private static DesktopViewSettings defaultInstance = ((DesktopViewSettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new DesktopViewSettings())));
        
        public static DesktopViewSettings Default {
            get {
                return defaultInstance;
            }
        }
        
        /// <summary>
        /// Controls appearance of local toolbars
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Controls appearance of local toolbars")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Left")]
        public global::System.Windows.Forms.ToolStripItemAlignment LocalToolStripItemAlignment {
            get {
                return ((global::System.Windows.Forms.ToolStripItemAlignment)(this["LocalToolStripItemAlignment"]));
            }
        }
        
        /// <summary>
        /// Controls appearance of local toolbars
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Controls appearance of local toolbars")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("ImageBeforeText")]
        public global::System.Windows.Forms.TextImageRelation LocalToolStripItemTextImageRelation {
            get {
                return ((global::System.Windows.Forms.TextImageRelation)(this["LocalToolStripItemTextImageRelation"]));
            }
        }
        
        /// <summary>
        /// Controls whether protected actions are visible in the desktop
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Controls whether protected actions are visible in the desktop")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool ShowNonPermissibleActions {
            get {
                return ((bool)(this["ShowNonPermissibleActions"]));
            }
        }
        
        /// <summary>
        /// Controls whether protected actions are enabled in the desktop - this should neve be enabled in a production environment
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Controls whether protected actions are enabled in the desktop - this should neve " +
            "be enabled in a production environment")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool EnableNonPermissibleActions {
            get {
                return ((bool)(this["EnableNonPermissibleActions"]));
            }
        }
        
        /// <summary>
        /// XML document that stores information about window locations
        /// </summary>
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("XML document that stores information about window locations")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n<desktops />")]
        public global::System.Xml.XmlDocument DesktopViewSettingsXml {
            get {
                return ((global::System.Xml.XmlDocument)(this["DesktopViewSettingsXml"]));
            }
            set {
                this["DesktopViewSettingsXml"] = value;
            }
        }
    }
}