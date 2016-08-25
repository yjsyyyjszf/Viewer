
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

namespace Macro.ImageViewer.Tools.Standard.PresetVoiLuts {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
    internal sealed partial class AvailablePresetVoiLutKeyStrokeSettings : global::System.Configuration.ApplicationSettingsBase {
        
        private static AvailablePresetVoiLutKeyStrokeSettings defaultInstance = ((AvailablePresetVoiLutKeyStrokeSettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new AvailablePresetVoiLutKeyStrokeSettings())));
        
        public static AvailablePresetVoiLutKeyStrokeSettings Default {
            get {
                return defaultInstance;
            }
        }
        
        /// <summary>
        /// A list of keystrokes to use for user-defined LUT (e.g. window/level) presets.
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("A list of keystrokes to use for user-defined LUT (e.g. window/level) presets.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfString xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <string>F3</string>
  <string>F4</string>
  <string>F5</string>
  <string>F6</string>
  <string>F7</string>
  <string>F8</string>
  <string>F9</string>
  <string>F10</string>
  <string>F11</string>
  <string>F12</string>
</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection AvailableKeyStrokes {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["AvailableKeyStrokes"]));
            }
        }
    }
}