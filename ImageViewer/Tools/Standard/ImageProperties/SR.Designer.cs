
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

namespace Macro.ImageViewer.Tools.Standard.ImageProperties {
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
    internal class SR {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal SR() {
        }
        
        /// <summary>
        ///   返回此类使用的缓存的 ResourceManager 实例。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Macro.ImageViewer.Tools.Standard.ImageProperties.SR", typeof(SR).Assembly);
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
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   查找类似 Equipment 的本地化字符串。
        /// </summary>
        internal static string CategoryEquipment {
            get {
                return ResourceManager.GetString("CategoryEquipment", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Image 的本地化字符串。
        /// </summary>
        internal static string CategoryImage {
            get {
                return ResourceManager.GetString("CategoryImage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Key Image Equipment 的本地化字符串。
        /// </summary>
        internal static string CategoryKeyImageEquipment {
            get {
                return ResourceManager.GetString("CategoryKeyImageEquipment", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Key Image Series 的本地化字符串。
        /// </summary>
        internal static string CategoryKeyImageSeries {
            get {
                return ResourceManager.GetString("CategoryKeyImageSeries", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Patient 的本地化字符串。
        /// </summary>
        internal static string CategoryPatient {
            get {
                return ResourceManager.GetString("CategoryPatient", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Series 的本地化字符串。
        /// </summary>
        internal static string CategorySeries {
            get {
                return ResourceManager.GetString("CategorySeries", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Study 的本地化字符串。
        /// </summary>
        internal static string CategoryStudy {
            get {
                return ResourceManager.GetString("CategoryStudy", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 The date on which the image was acquired 的本地化字符串。
        /// </summary>
        internal static string DescriptionAcquisitionDate {
            get {
                return ResourceManager.GetString("DescriptionAcquisitionDate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 A number indicating the order of acquisition of images in the parent series 的本地化字符串。
        /// </summary>
        internal static string DescriptionAcquisitionNumber {
            get {
                return ResourceManager.GetString("DescriptionAcquisitionNumber", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 The time at which the image was acquired 的本地化字符串。
        /// </summary>
        internal static string DescriptionAcquisitionTime {
            get {
                return ResourceManager.GetString("DescriptionAcquisitionTime", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Relevant patient history 的本地化字符串。
        /// </summary>
        internal static string DescriptionAdditionalPatientHistory {
            get {
                return ResourceManager.GetString("DescriptionAdditionalPatientHistory", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Diagnoses made at the time the patient was admitted 的本地化字符串。
        /// </summary>
        internal static string DescriptionAdmittingDiagnosesDescription {
            get {
                return ResourceManager.GetString("DescriptionAdmittingDiagnosesDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 The body part examined 的本地化字符串。
        /// </summary>
        internal static string DescriptionBodyPartExamined {
            get {
                return ResourceManager.GetString("DescriptionBodyPartExamined", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 The meaning of the coded identifier value 的本地化字符串。
        /// </summary>
        internal static string DescriptionCodeMeaning {
            get {
                return ResourceManager.GetString("DescriptionCodeMeaning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 The coded identifier value 的本地化字符串。
        /// </summary>
        internal static string DescriptionCodeValue {
            get {
                return ResourceManager.GetString("DescriptionCodeValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 The identifier of the coding scheme 的本地化字符串。
        /// </summary>
        internal static string DescriptionCodingSchemeDesignator {
            get {
                return ResourceManager.GetString("DescriptionCodingSchemeDesignator", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 The serial number of the equipment on which the study/exam was performed 的本地化字符串。
        /// </summary>
        internal static string DescriptionDeviceSerialNumber {
            get {
                return ResourceManager.GetString("DescriptionDeviceSerialNumber", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Comments about the image at the time of acquisition 的本地化字符串。
        /// </summary>
        internal static string DescriptionImageComments {
            get {
                return ResourceManager.GetString("DescriptionImageComments", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 The laterality of this image 的本地化字符串。
        /// </summary>
        internal static string DescriptionImageLaterality {
            get {
                return ResourceManager.GetString("DescriptionImageLaterality", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 The type of the image 的本地化字符串。
        /// </summary>
        internal static string DescriptionImageType {
            get {
                return ResourceManager.GetString("DescriptionImageType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 A numeric identifier for the image 的本地化字符串。
        /// </summary>
        internal static string DescriptionInstanceNumber {
            get {
                return ResourceManager.GetString("DescriptionInstanceNumber", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 The address of the institution where the study/exam was performed 的本地化字符串。
        /// </summary>
        internal static string DescriptionInstitutionAddress {
            get {
                return ResourceManager.GetString("DescriptionInstitutionAddress", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 The name of the department where the study/exam was performed 的本地化字符串。
        /// </summary>
        internal static string DescriptionInstitutionalDepartmentName {
            get {
                return ResourceManager.GetString("DescriptionInstitutionalDepartmentName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 The name of the institution where the study/exam was performed 的本地化字符串。
        /// </summary>
        internal static string DescriptionInstitutionName {
            get {
                return ResourceManager.GetString("DescriptionInstitutionName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 User defined description of the Key Image series 的本地化字符串。
        /// </summary>
        internal static string DescriptionKeyImageDocumentDescription {
            get {
                return ResourceManager.GetString("DescriptionKeyImageDocumentDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 A coded description of the purpose of the Key Image document 的本地化字符串。
        /// </summary>
        internal static string DescriptionKeyImageDocumentTitle {
            get {
                return ResourceManager.GetString("DescriptionKeyImageDocumentTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 The laterality of all images in the parent series 的本地化字符串。
        /// </summary>
        internal static string DescriptionLaterality {
            get {
                return ResourceManager.GetString("DescriptionLaterality", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Indicates whether or not the image has been lossy compressed 的本地化字符串。
        /// </summary>
        internal static string DescriptionLossyImageCompression {
            get {
                return ResourceManager.GetString("DescriptionLossyImageCompression", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 The method(s) used to perform any lossy compressions on this image 的本地化字符串。
        /// </summary>
        internal static string DescriptionLossyImageCompressionMethod {
            get {
                return ResourceManager.GetString("DescriptionLossyImageCompressionMethod", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 The ratio(s) of any lossy compressions that have been performed on this image 的本地化字符串。
        /// </summary>
        internal static string DescriptionLossyImageCompressionRatio {
            get {
                return ResourceManager.GetString("DescriptionLossyImageCompressionRatio", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 The manufacturer of the equipment on which the study/exam was performed 的本地化字符串。
        /// </summary>
        internal static string DescriptionManufacturer {
            get {
                return ResourceManager.GetString("DescriptionManufacturer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 The model name of the equipment on which the study/exam was performed 的本地化字符串。
        /// </summary>
        internal static string DescriptionManufacturersModelName {
            get {
                return ResourceManager.GetString("DescriptionManufacturersModelName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 The modality of all images in the series 的本地化字符串。
        /// </summary>
        internal static string DescriptionModality {
            get {
                return ResourceManager.GetString("DescriptionModality", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 The name(s) of people operating the equipment on which the series was acquired 的本地化字符串。
        /// </summary>
        internal static string DescriptionOperatorsName {
            get {
                return ResourceManager.GetString("DescriptionOperatorsName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Coded identifier of the breed of the patient 的本地化字符串。
        /// </summary>
        internal static string DescriptionPatientBreedCodeSequence {
            get {
                return ResourceManager.GetString("DescriptionPatientBreedCodeSequence", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Description of the breed of the patient 的本地化字符串。
        /// </summary>
        internal static string DescriptionPatientBreedDescription {
            get {
                return ResourceManager.GetString("DescriptionPatientBreedDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 A unique identifier for the patient (e.g. Medical Record Number (MRN)) 的本地化字符串。
        /// </summary>
        internal static string DescriptionPatientId {
            get {
                return ResourceManager.GetString("DescriptionPatientId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 The age of the patient 的本地化字符串。
        /// </summary>
        internal static string DescriptionPatientsAge {
            get {
                return ResourceManager.GetString("DescriptionPatientsAge", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 The patient&apos;s birth date 的本地化字符串。
        /// </summary>
        internal static string DescriptionPatientsBirthDate {
            get {
                return ResourceManager.GetString("DescriptionPatientsBirthDate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 The time of day at which the patient was born 的本地化字符串。
        /// </summary>
        internal static string DescriptionPatientsBirthTime {
            get {
                return ResourceManager.GetString("DescriptionPatientsBirthTime", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 The patient&apos;s name 的本地化字符串。
        /// </summary>
        internal static string DescriptionPatientsName {
            get {
                return ResourceManager.GetString("DescriptionPatientsName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Coded identifier of the species of the patient 的本地化字符串。
        /// </summary>
        internal static string DescriptionPatientSpeciesCodeSequence {
            get {
                return ResourceManager.GetString("DescriptionPatientSpeciesCodeSequence", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Description of the species of the patient 的本地化字符串。
        /// </summary>
        internal static string DescriptionPatientSpeciesDescription {
            get {
                return ResourceManager.GetString("DescriptionPatientSpeciesDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 The sex/gender of the patient 的本地化字符串。
        /// </summary>
        internal static string DescriptionPatientsSex {
            get {
                return ResourceManager.GetString("DescriptionPatientsSex", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 The name(s) of the physician(s) performing the exam 的本地化字符串。
        /// </summary>
        internal static string DescriptionPerformingPhysiciansName {
            get {
                return ResourceManager.GetString("DescriptionPerformingPhysiciansName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 The protocol name for the series 的本地化字符串。
        /// </summary>
        internal static string DescriptionProtocolName {
            get {
                return ResourceManager.GetString("DescriptionProtocolName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 The name of the referring physician 的本地化字符串。
        /// </summary>
        internal static string DescriptionReferringPhysiciansName {
            get {
                return ResourceManager.GetString("DescriptionReferringPhysiciansName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 The organization responsible for the patient 的本地化字符串。
        /// </summary>
        internal static string DescriptionResponsibleOrganization {
            get {
                return ResourceManager.GetString("DescriptionResponsibleOrganization", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 The person responsible for the patient (e.g. the owner) 的本地化字符串。
        /// </summary>
        internal static string DescriptionResponsiblePerson {
            get {
                return ResourceManager.GetString("DescriptionResponsiblePerson", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 The date on which the series was acquired 的本地化字符串。
        /// </summary>
        internal static string DescriptionSeriesDate {
            get {
                return ResourceManager.GetString("DescriptionSeriesDate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 A description of the series 的本地化字符串。
        /// </summary>
        internal static string DescriptionSeriesDescription {
            get {
                return ResourceManager.GetString("DescriptionSeriesDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 A DICOM unique identifier for the series 的本地化字符串。
        /// </summary>
        internal static string DescriptionSeriesInstanceUid {
            get {
                return ResourceManager.GetString("DescriptionSeriesInstanceUid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 A numeric identifier for the series 的本地化字符串。
        /// </summary>
        internal static string DescriptionSeriesNumber {
            get {
                return ResourceManager.GetString("DescriptionSeriesNumber", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 The time at which the series was acquired 的本地化字符串。
        /// </summary>
        internal static string DescriptionSeriesTime {
            get {
                return ResourceManager.GetString("DescriptionSeriesTime", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 The version of the software that created the data 的本地化字符串。
        /// </summary>
        internal static string DescriptionSoftwareVersions {
            get {
                return ResourceManager.GetString("DescriptionSoftwareVersions", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 The DICOM unique identifier of the image 的本地化字符串。
        /// </summary>
        internal static string DescriptionSopInstanceUid {
            get {
                return ResourceManager.GetString("DescriptionSopInstanceUid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 The name/identifier of the station where the study/exam was performed 的本地化字符串。
        /// </summary>
        internal static string DescriptionStationName {
            get {
                return ResourceManager.GetString("DescriptionStationName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 The date the study/exam was performed 的本地化字符串。
        /// </summary>
        internal static string DescriptionStudyDate {
            get {
                return ResourceManager.GetString("DescriptionStudyDate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 A description of the study 的本地化字符串。
        /// </summary>
        internal static string DescriptionStudyDescription {
            get {
                return ResourceManager.GetString("DescriptionStudyDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 An identification number for the study 的本地化字符串。
        /// </summary>
        internal static string DescriptionStudyId {
            get {
                return ResourceManager.GetString("DescriptionStudyId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 A DICOM unique identifier for the study 的本地化字符串。
        /// </summary>
        internal static string DescriptionStudyInstanceUid {
            get {
                return ResourceManager.GetString("DescriptionStudyInstanceUid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 The time of day the study/exam was performed 的本地化字符串。
        /// </summary>
        internal static string DescriptionStudyTime {
            get {
                return ResourceManager.GetString("DescriptionStudyTime", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Acquisition Date 的本地化字符串。
        /// </summary>
        internal static string NameAcquisitionDate {
            get {
                return ResourceManager.GetString("NameAcquisitionDate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Acquisition Number 的本地化字符串。
        /// </summary>
        internal static string NameAcquisitionNumber {
            get {
                return ResourceManager.GetString("NameAcquisitionNumber", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Acquisition Time 的本地化字符串。
        /// </summary>
        internal static string NameAcquisitionTime {
            get {
                return ResourceManager.GetString("NameAcquisitionTime", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Addtional Patient History 的本地化字符串。
        /// </summary>
        internal static string NameAdditionalPatientHistory {
            get {
                return ResourceManager.GetString("NameAdditionalPatientHistory", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Admitting Diagnoses 的本地化字符串。
        /// </summary>
        internal static string NameAdmittingDiagnosesDescription {
            get {
                return ResourceManager.GetString("NameAdmittingDiagnosesDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Body Part Examined 的本地化字符串。
        /// </summary>
        internal static string NameBodyPartExamined {
            get {
                return ResourceManager.GetString("NameBodyPartExamined", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Code Meaning 的本地化字符串。
        /// </summary>
        internal static string NameCodeMeaning {
            get {
                return ResourceManager.GetString("NameCodeMeaning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Code Value 的本地化字符串。
        /// </summary>
        internal static string NameCodeValue {
            get {
                return ResourceManager.GetString("NameCodeValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Coding Scheme Designator 的本地化字符串。
        /// </summary>
        internal static string NameCodingSchemeDesignator {
            get {
                return ResourceManager.GetString("NameCodingSchemeDesignator", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Device Serial Number 的本地化字符串。
        /// </summary>
        internal static string NameDeviceSerialNumber {
            get {
                return ResourceManager.GetString("NameDeviceSerialNumber", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Image Comments 的本地化字符串。
        /// </summary>
        internal static string NameImageComments {
            get {
                return ResourceManager.GetString("NameImageComments", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Image Laterality 的本地化字符串。
        /// </summary>
        internal static string NameImageLaterality {
            get {
                return ResourceManager.GetString("NameImageLaterality", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Image Type 的本地化字符串。
        /// </summary>
        internal static string NameImageType {
            get {
                return ResourceManager.GetString("NameImageType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Instance Number 的本地化字符串。
        /// </summary>
        internal static string NameInstanceNumber {
            get {
                return ResourceManager.GetString("NameInstanceNumber", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Institution Address 的本地化字符串。
        /// </summary>
        internal static string NameInstitutionAddress {
            get {
                return ResourceManager.GetString("NameInstitutionAddress", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Institutional Department 的本地化字符串。
        /// </summary>
        internal static string NameInstitutionalDepartmentName {
            get {
                return ResourceManager.GetString("NameInstitutionalDepartmentName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Institution Name 的本地化字符串。
        /// </summary>
        internal static string NameInstitutionName {
            get {
                return ResourceManager.GetString("NameInstitutionName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Key Image Document Description 的本地化字符串。
        /// </summary>
        internal static string NameKeyImageDocumentDescription {
            get {
                return ResourceManager.GetString("NameKeyImageDocumentDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Key Image Document Title 的本地化字符串。
        /// </summary>
        internal static string NameKeyImageDocumentTitle {
            get {
                return ResourceManager.GetString("NameKeyImageDocumentTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Laterality 的本地化字符串。
        /// </summary>
        internal static string NameLaterality {
            get {
                return ResourceManager.GetString("NameLaterality", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Lossy Image Compression 的本地化字符串。
        /// </summary>
        internal static string NameLossyImageCompression {
            get {
                return ResourceManager.GetString("NameLossyImageCompression", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Lossy Image Compression Method 的本地化字符串。
        /// </summary>
        internal static string NameLossyImageCompressionMethod {
            get {
                return ResourceManager.GetString("NameLossyImageCompressionMethod", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Lossy Image Compression Ratio 的本地化字符串。
        /// </summary>
        internal static string NameLossyImageCompressionRatio {
            get {
                return ResourceManager.GetString("NameLossyImageCompressionRatio", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Manufacturer 的本地化字符串。
        /// </summary>
        internal static string NameManufacturer {
            get {
                return ResourceManager.GetString("NameManufacturer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Manufacturer&apos;s Model 的本地化字符串。
        /// </summary>
        internal static string NameManufacturersModelName {
            get {
                return ResourceManager.GetString("NameManufacturersModelName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Modality 的本地化字符串。
        /// </summary>
        internal static string NameModality {
            get {
                return ResourceManager.GetString("NameModality", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Operator&apos;s Name 的本地化字符串。
        /// </summary>
        internal static string NameOperatorsName {
            get {
                return ResourceManager.GetString("NameOperatorsName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Patient Breed Code Sequence 的本地化字符串。
        /// </summary>
        internal static string NamePatientBreedCodeSequence {
            get {
                return ResourceManager.GetString("NamePatientBreedCodeSequence", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Patient Breed Description 的本地化字符串。
        /// </summary>
        internal static string NamePatientBreedDescription {
            get {
                return ResourceManager.GetString("NamePatientBreedDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Patient ID 的本地化字符串。
        /// </summary>
        internal static string NamePatientId {
            get {
                return ResourceManager.GetString("NamePatientId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Patient&apos;s Age 的本地化字符串。
        /// </summary>
        internal static string NamePatientsAge {
            get {
                return ResourceManager.GetString("NamePatientsAge", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Patient&apos;s Birth Date 的本地化字符串。
        /// </summary>
        internal static string NamePatientsBirthDate {
            get {
                return ResourceManager.GetString("NamePatientsBirthDate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Patient&apos;s Birth Time 的本地化字符串。
        /// </summary>
        internal static string NamePatientsBirthTime {
            get {
                return ResourceManager.GetString("NamePatientsBirthTime", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Patient&apos;s Name 的本地化字符串。
        /// </summary>
        internal static string NamePatientsName {
            get {
                return ResourceManager.GetString("NamePatientsName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Patient Species Code Sequence 的本地化字符串。
        /// </summary>
        internal static string NamePatientSpeciesCodeSequence {
            get {
                return ResourceManager.GetString("NamePatientSpeciesCodeSequence", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Patient Species Description 的本地化字符串。
        /// </summary>
        internal static string NamePatientSpeciesDescription {
            get {
                return ResourceManager.GetString("NamePatientSpeciesDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Patient&apos;s Sex 的本地化字符串。
        /// </summary>
        internal static string NamePatientsSex {
            get {
                return ResourceManager.GetString("NamePatientsSex", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Performing Physician 的本地化字符串。
        /// </summary>
        internal static string NamePerformingPhysiciansName {
            get {
                return ResourceManager.GetString("NamePerformingPhysiciansName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Protocol Name 的本地化字符串。
        /// </summary>
        internal static string NameProtocolName {
            get {
                return ResourceManager.GetString("NameProtocolName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Referring Physician(s) 的本地化字符串。
        /// </summary>
        internal static string NameReferringPhysiciansName {
            get {
                return ResourceManager.GetString("NameReferringPhysiciansName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Responsible Organization 的本地化字符串。
        /// </summary>
        internal static string NameResponsibleOrganization {
            get {
                return ResourceManager.GetString("NameResponsibleOrganization", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Responsible Person 的本地化字符串。
        /// </summary>
        internal static string NameResponsiblePerson {
            get {
                return ResourceManager.GetString("NameResponsiblePerson", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Series Date 的本地化字符串。
        /// </summary>
        internal static string NameSeriesDate {
            get {
                return ResourceManager.GetString("NameSeriesDate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Series Description 的本地化字符串。
        /// </summary>
        internal static string NameSeriesDescription {
            get {
                return ResourceManager.GetString("NameSeriesDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Series Instance UID 的本地化字符串。
        /// </summary>
        internal static string NameSeriesInstanceUid {
            get {
                return ResourceManager.GetString("NameSeriesInstanceUid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Series Number 的本地化字符串。
        /// </summary>
        internal static string NameSeriesNumber {
            get {
                return ResourceManager.GetString("NameSeriesNumber", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Series Time 的本地化字符串。
        /// </summary>
        internal static string NameSeriesTime {
            get {
                return ResourceManager.GetString("NameSeriesTime", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Software Version(s) 的本地化字符串。
        /// </summary>
        internal static string NameSoftwareVersions {
            get {
                return ResourceManager.GetString("NameSoftwareVersions", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Sop Instance UID 的本地化字符串。
        /// </summary>
        internal static string NameSopInstanceUid {
            get {
                return ResourceManager.GetString("NameSopInstanceUid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Station Name 的本地化字符串。
        /// </summary>
        internal static string NameStationName {
            get {
                return ResourceManager.GetString("NameStationName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Study Date 的本地化字符串。
        /// </summary>
        internal static string NameStudyDate {
            get {
                return ResourceManager.GetString("NameStudyDate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Study Description 的本地化字符串。
        /// </summary>
        internal static string NameStudyDescription {
            get {
                return ResourceManager.GetString("NameStudyDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Study ID 的本地化字符串。
        /// </summary>
        internal static string NameStudyId {
            get {
                return ResourceManager.GetString("NameStudyId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Study Instance UID 的本地化字符串。
        /// </summary>
        internal static string NameStudyInstanceUid {
            get {
                return ResourceManager.GetString("NameStudyInstanceUid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Study Time 的本地化字符串。
        /// </summary>
        internal static string NameStudyTime {
            get {
                return ResourceManager.GetString("NameStudyTime", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Image Properties 的本地化字符串。
        /// </summary>
        internal static string TitleImageProperties {
            get {
                return ResourceManager.GetString("TitleImageProperties", resourceCulture);
            }
        }
    }
}