
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
//     运行时版本:4.0.30319.1008
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Macro.Common {
    using System;
    
    
    /// <summary>
    ///   一个强类型的资源类，用于查找本地化的字符串等。
    /// </summary>
    // 此类是由 StronglyTypedResourceBuilder
    // 类通过类似于 ResGen 或 Visual Studio 的工具自动生成的。
    // 若要添加或移除成员，请编辑 .ResX 文件，然后重新运行 ResGen
    // (以 /str 作为命令选项)，或重新生成 VS 项目。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class SR {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal SR() {
        }
        
        /// <summary>
        ///   返回此类使用的缓存的 ResourceManager 实例。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Macro.Common.SR", typeof(SR).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   使用此强类型资源类，为所有资源查找
        ///   重写当前线程的 CurrentUICulture 属性。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   查找类似 Unable to resolve application root class {0} - multiple matches. 的本地化字符串。
        /// </summary>
        public static string ExceptionApplicationRootMultipleMatches {
            get {
                return ResourceManager.GetString("ExceptionApplicationRootMultipleMatches", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Unable to resolve application root class {0} - no matches. 的本地化字符串。
        /// </summary>
        public static string ExceptionApplicationRootNoMatches {
            get {
                return ResourceManager.GetString("ExceptionApplicationRootNoMatches", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Value must be non-negative. 的本地化字符串。
        /// </summary>
        public static string ExceptionArgumentNegative {
            get {
                return ResourceManager.GetString("ExceptionArgumentNegative", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Value must be greater than zero. 的本地化字符串。
        /// </summary>
        public static string ExceptionArgumentNotPositive {
            get {
                return ResourceManager.GetString("ExceptionArgumentNotPositive", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 {3} = {0} is invalid. {3} must be &gt;= {1} and &lt;= {2}. 的本地化字符串。
        /// </summary>
        public static string ExceptionArgumentOutOfRange {
            get {
                return ResourceManager.GetString("ExceptionArgumentOutOfRange", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 The background task is already running 的本地化字符串。
        /// </summary>
        public static string ExceptionBackgroundTaskAlreadyRunning {
            get {
                return ResourceManager.GetString("ExceptionBackgroundTaskAlreadyRunning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Expression must evaluate to Array, ICollection, or IEnumerable type. 的本地化字符串。
        /// </summary>
        public static string ExceptionCastExpressionArrayCollectionEnumerable {
            get {
                return ResourceManager.GetString("ExceptionCastExpressionArrayCollectionEnumerable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Expression must evaluate to Boolean type. 的本地化字符串。
        /// </summary>
        public static string ExceptionCastExpressionBoolean {
            get {
                return ResourceManager.GetString("ExceptionCastExpressionBoolean", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Expression must evaluate to IEnumerable type. 的本地化字符串。
        /// </summary>
        public static string ExceptionCastExpressionEnumerable {
            get {
                return ResourceManager.GetString("ExceptionCastExpressionEnumerable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Expression must evaluate to String type. 的本地化字符串。
        /// </summary>
        public static string ExceptionCastExpressionString {
            get {
                return ResourceManager.GetString("ExceptionCastExpressionString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Condition is not met :{0} 的本地化字符串。
        /// </summary>
        public static string ExceptionConditionIsNotMet {
            get {
                return ResourceManager.GetString("ExceptionConditionIsNotMet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Duplicate plugin {0} found. 的本地化字符串。
        /// </summary>
        public static string ExceptionDuplicatePluginFound {
            get {
                return ResourceManager.GetString("ExceptionDuplicatePluginFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 {0} cannot be empty. 的本地化字符串。
        /// </summary>
        public static string ExceptionEmptyString {
            get {
                return ResourceManager.GetString("ExceptionEmptyString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Expected type {0}. 的本地化字符串。
        /// </summary>
        public static string ExceptionExpectedType {
            get {
                return ResourceManager.GetString("ExceptionExpectedType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Extension class {0} does not implement required interface {1}. 的本地化字符串。
        /// </summary>
        public static string ExceptionExtensionDoesNotImplementRequiredInterface {
            get {
                return ResourceManager.GetString("ExceptionExtensionDoesNotImplementRequiredInterface", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Extension class {0} must be a concrete class. 的本地化字符串。
        /// </summary>
        public static string ExceptionExtensionMustBeConcreteClass {
            get {
                return ResourceManager.GetString("ExceptionExtensionMustBeConcreteClass", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 The extension point {0} is invalid because it is not a direct subclass of ExtensionPoint&lt;&gt; 的本地化字符串。
        /// </summary>
        public static string ExceptionExtensionPointMustSubclassExtensionPoint {
            get {
                return ResourceManager.GetString("ExceptionExtensionPointMustSubclassExtensionPoint", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Failed to transfer file from {0} to {1}. 的本地化字符串。
        /// </summary>
        public static string ExceptionFailedToTransferFile {
            get {
                return ResourceManager.GetString("ExceptionFailedToTransferFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 We&apos;re sorry, but an error has occurred that Macro Workstation cannot recover from.  Please check the log and restart. 的本地化字符串。
        /// </summary>
        public static string ExceptionFatalApplicationError {
            get {
                return ResourceManager.GetString("ExceptionFatalApplicationError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Unable to convert from String to {0} 的本地化字符串。
        /// </summary>
        public static string ExceptionFormatCannotConvertFromStringToType {
            get {
                return ResourceManager.GetString("ExceptionFormatCannotConvertFromStringToType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Unable to convert from {0} to String 的本地化字符串。
        /// </summary>
        public static string ExceptionFormatCannotConvertFromTypeToString {
            get {
                return ResourceManager.GetString("ExceptionFormatCannotConvertFromTypeToString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Deserialization failed for object type &apos;{0}&apos; 的本地化字符串。
        /// </summary>
        public static string ExceptionFormatDeserializationFailedForType {
            get {
                return ResourceManager.GetString("ExceptionFormatDeserializationFailedForType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Serialization failed for object type &apos;{0}&apos; 的本地化字符串。
        /// </summary>
        public static string ExceptionFormatSerializationFailedForType {
            get {
                return ResourceManager.GetString("ExceptionFormatSerializationFailedForType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 {3}[{0}] is invalid.  Index must be &gt;= {1} and &lt;= {2}. 的本地化字符串。
        /// </summary>
        public static string ExceptionIndexOutOfRange {
            get {
                return ResourceManager.GetString("ExceptionIndexOutOfRange", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 {0} must be of type {1}. 的本地化字符串。
        /// </summary>
        public static string ExceptionInvalidCast {
            get {
                return ResourceManager.GetString("ExceptionInvalidCast", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 {0} is not a valid specification id. 的本地化字符串。
        /// </summary>
        public static string ExceptionInvalidSpecificationId {
            get {
                return ResourceManager.GetString("ExceptionInvalidSpecificationId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 JScript evaluation error on: {0} 的本地化字符串。
        /// </summary>
        public static string ExceptionJScriptEvaluation {
            get {
                return ResourceManager.GetString("ExceptionJScriptEvaluation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 {0} has not been set.  Object state is invalid. 的本地化字符串。
        /// </summary>
        public static string ExceptionMemberNotSet {
            get {
                return ResourceManager.GetString("ExceptionMemberNotSet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 {0} has not been set.  {1} 的本地化字符串。
        /// </summary>
        public static string ExceptionMemberNotSetVerbose {
            get {
                return ResourceManager.GetString("ExceptionMemberNotSetVerbose", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 More than one model plugin found. 的本地化字符串。
        /// </summary>
        public static string ExceptionMoreThanOneModelPluginFound {
            get {
                return ResourceManager.GetString("ExceptionMoreThanOneModelPluginFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 No extensions found for extension point {0}, or the extensions could not be instantiated.  Please see the log for more information. 的本地化字符串。
        /// </summary>
        public static string ExceptionNoExtensionsCreated {
            get {
                return ResourceManager.GetString("ExceptionNoExtensionsCreated", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 No plugins could be found. 的本地化字符串。
        /// </summary>
        public static string ExceptionNoPluginsFound {
            get {
                return ResourceManager.GetString("ExceptionNoPluginsFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 No plugins have been loaded. 的本地化字符串。
        /// </summary>
        public static string ExceptionNoPluginsLoaded {
            get {
                return ResourceManager.GetString("ExceptionNoPluginsLoaded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Assembly {0} is not a plugin. 的本地化字符串。
        /// </summary>
        public static string ExceptionNotAPlugin {
            get {
                return ResourceManager.GetString("ExceptionNotAPlugin", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 {0} does not exist. 的本地化字符串。
        /// </summary>
        public static string ExceptionPathDoesNotExist {
            get {
                return ResourceManager.GetString("ExceptionPathDoesNotExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Plugin {0} could not be found.  Unable to start plugin. 的本地化字符串。
        /// </summary>
        public static string ExceptionPluginCouldNotBeFound {
            get {
                return ResourceManager.GetString("ExceptionPluginCouldNotBeFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Plugin directory could not be found. 的本地化字符串。
        /// </summary>
        public static string ExceptionPluginDirectoryNotFound {
            get {
                return ResourceManager.GetString("ExceptionPluginDirectoryNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 There was a problem loading one or more plugins. Please see the log for more information. 的本地化字符串。
        /// </summary>
        public static string ExceptionPluginWarning {
            get {
                return ResourceManager.GetString("ExceptionPluginWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Resource {0}  not found. 的本地化字符串。
        /// </summary>
        public static string ExceptionResourceNotFound {
            get {
                return ResourceManager.GetString("ExceptionResourceNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 No script engine available for language {0}. 的本地化字符串。
        /// </summary>
        public static string ExceptionScriptEngineLanguage {
            get {
                return ResourceManager.GetString("ExceptionScriptEngineLanguage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Template evaluation generated an exception. 的本地化字符串。
        /// </summary>
        public static string ExceptionTemplateEvaluation {
            get {
                return ResourceManager.GetString("ExceptionTemplateEvaluation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 The thread pool has already been started. 的本地化字符串。
        /// </summary>
        public static string ExceptionThreadPoolAlreadyStarted {
            get {
                return ResourceManager.GetString("ExceptionThreadPoolAlreadyStarted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 The thread pool must be stopped before setting the {0} parameter. 的本地化字符串。
        /// </summary>
        public static string ExceptionThreadPoolMustBeStopped {
            get {
                return ResourceManager.GetString("ExceptionThreadPoolMustBeStopped", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 The thread pool has not been started.  Unable to enqueue the specified item. 的本地化字符串。
        /// </summary>
        public static string ExceptionThreadPoolNotStarted {
            get {
                return ResourceManager.GetString("ExceptionThreadPoolNotStarted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Exception thrown 的本地化字符串。
        /// </summary>
        public static string ExceptionThrown {
            get {
                return ResourceManager.GetString("ExceptionThrown", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Unable to load any plugins.  Please see the log for more information. 的本地化字符串。
        /// </summary>
        public static string ExceptionUnableToLoadPlugins {
            get {
                return ResourceManager.GetString("ExceptionUnableToLoadPlugins", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 {0} Bytes 的本地化字符串。
        /// </summary>
        public static string FormatFileSizeBytes {
            get {
                return ResourceManager.GetString("FormatFileSizeBytes", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 {0:f2} GB 的本地化字符串。
        /// </summary>
        public static string FormatFileSizeGB {
            get {
                return ResourceManager.GetString("FormatFileSizeGB", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 {0:f2} KB 的本地化字符串。
        /// </summary>
        public static string FormatFileSizeKB {
            get {
                return ResourceManager.GetString("FormatFileSizeKB", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 {0:f2} MB 的本地化字符串。
        /// </summary>
        public static string FormatFileSizeMB {
            get {
                return ResourceManager.GetString("FormatFileSizeMB", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 {0:f2} TB 的本地化字符串。
        /// </summary>
        public static string FormatFileSizeTB {
            get {
                return ResourceManager.GetString("FormatFileSizeTB", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Loaded plugin: {0} 的本地化字符串。
        /// </summary>
        public static string FormatLoadedPlugin {
            get {
                return ResourceManager.GetString("FormatLoadedPlugin", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Processing plugin: {0} 的本地化字符串。
        /// </summary>
        public static string FormatProcessingPlugin {
            get {
                return ResourceManager.GetString("FormatProcessingPlugin", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 ({0}) 的本地化字符串。
        /// </summary>
        public static string FormatReleaseType {
            get {
                return ResourceManager.GetString("FormatReleaseType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 {0} seconds 的本地化字符串。
        /// </summary>
        public static string FormatSeconds {
            get {
                return ResourceManager.GetString("FormatSeconds", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 &apos;{0}&apos; must be an interface. 的本地化字符串。
        /// </summary>
        public static string FormatTypeMustBeInterface {
            get {
                return ResourceManager.GetString("FormatTypeMustBeInterface", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Type &apos;{0}&apos; must implement interface &apos;{1}&apos;. 的本地化字符串。
        /// </summary>
        public static string FormatTypeMustImplementInterface {
            get {
                return ResourceManager.GetString("FormatTypeMustImplementInterface", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Unable to find matching action for &apos;{0}&apos; node in script.  Unable to perform action. 的本地化字符串。
        /// </summary>
        public static string FormatUnableToFindMatchingAction {
            get {
                return ResourceManager.GetString("FormatUnableToFindMatchingAction", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Configuration store not found - defaulting to LocalFileSettingsProvider 的本地化字符串。
        /// </summary>
        public static string LogConfigurationStoreNotFound {
            get {
                return ResourceManager.GetString("LogConfigurationStoreNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Failed to process plugin assembly {0} with the following exception(s): 的本地化字符串。
        /// </summary>
        public static string LogFailedToProcessPluginAssembly {
            get {
                return ResourceManager.GetString("LogFailedToProcessPluginAssembly", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Found unmanaged DLL: {0} 的本地化字符串。
        /// </summary>
        public static string LogFoundUnmanagedDLL {
            get {
                return ResourceManager.GetString("LogFoundUnmanagedDLL", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 License provider not found - defaulting to local license provider. 的本地化字符串。
        /// </summary>
        public static string LogLicenseProviderNotFound {
            get {
                return ResourceManager.GetString("LogLicenseProviderNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Local configuration store not found - defaulting to LocalFileSettingsProvider 的本地化字符串。
        /// </summary>
        public static string LogLocalConfigurationStoreNotFound {
            get {
                return ResourceManager.GetString("LogLocalConfigurationStoreNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Loaded plugin: {0} 的本地化字符串。
        /// </summary>
        public static string LogPluginLoaded {
            get {
                return ResourceManager.GetString("LogPluginLoaded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Time provider not found - defaulting to local machine time. 的本地化字符串。
        /// </summary>
        public static string LogTimeProviderNotFound {
            get {
                return ResourceManager.GetString("LogTimeProviderNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 An extension point cannot extend IExtensionPoint. 的本地化字符串。
        /// </summary>
        public static string MessageCannotExtendIExtensionPoint {
            get {
                return ResourceManager.GetString("MessageCannotExtendIExtensionPoint", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Finding plugins... 的本地化字符串。
        /// </summary>
        public static string MessageFindingPlugins {
            get {
                return ResourceManager.GetString("MessageFindingPlugins", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Settings scope not defined. 的本地化字符串。
        /// </summary>
        public static string MessageSettingsScopeNotDefined {
            get {
                return ResourceManager.GetString("MessageSettingsScopeNotDefined", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 The {0} shred has failed to start.  Please check the log for more details. 的本地化字符串。
        /// </summary>
        public static string ShredFailedToStart {
            get {
                return ResourceManager.GetString("ShredFailedToStart", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 The {0} shred has failed to stop.  Please check the log for more details. 的本地化字符串。
        /// </summary>
        public static string ShredFailedToStop {
            get {
                return ResourceManager.GetString("ShredFailedToStop", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 The {0} shred has started successfully. 的本地化字符串。
        /// </summary>
        public static string ShredStartedSuccessfully {
            get {
                return ResourceManager.GetString("ShredStartedSuccessfully", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Starting {0} Shred 的本地化字符串。
        /// </summary>
        public static string ShredStarting {
            get {
                return ResourceManager.GetString("ShredStarting", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 The {0} shred has stopped successfully. 的本地化字符串。
        /// </summary>
        public static string ShredStoppedSuccessfully {
            get {
                return ResourceManager.GetString("ShredStoppedSuccessfully", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Stopping {0} Shred 的本地化字符串。
        /// </summary>
        public static string ShredStopping {
            get {
                return ResourceManager.GetString("ShredStopping", resourceCulture);
            }
        }
    }
}