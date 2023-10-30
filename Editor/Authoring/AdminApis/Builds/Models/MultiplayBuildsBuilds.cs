//-----------------------------------------------------------------------------
// <auto-generated>
//     This file was generated by the C# SDK Code Generator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//-----------------------------------------------------------------------------


using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.Scripting;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Unity.Services.Multiplay.Authoring.Editor.AdminApis.Builds.Http;



namespace Unity.Services.Multiplay.Authoring.Editor.AdminApis.Builds.Models
{
    /// <summary>
    /// A single build within a build list response.
    /// </summary>
    [Preserve]
    [DataContract(Name = "multiplay.builds.builds")]
    internal class MultiplayBuildsBuilds
    {
        /// <summary>
        /// A single build within a build list response.
        /// </summary>
        /// <param name="buildName">The name of a build within an environment.</param>
        /// <param name="buildID">The ID of a build within an environment.</param>
        /// <param name="buildType">The upload type of the build:   * &#x60;FILE_UPLOAD&#x60; - The build is created using directly uploaded game files, backed by CCD as the storage driver.   * &#x60;CONTAINER&#x60; - The build is created using a container image containing game files.   * &#x60;S3&#x60; - The build is created using an external Amazon S3 Bucket containing game files. </param>
        /// <param name="buildConfigurations">The number of build configurations for a build within an environment.</param>
        /// <param name="syncStatus">CCD Bucket Synchronisation Status: * &#x60;PENDING&#x60;: Source bucket synchronisation is pending * &#x60;SYNCING&#x60;: Source bucket synchronisation is in progress * &#x60;SYNCED&#x60;: The source bucket has been synchronised * &#x60;FAILED&#x60;: Source bucket synchronisation has failed </param>
        /// <param name="updated">The date-time of the last update to a build within an environment.</param>
        /// <param name="ccd">ccd param</param>
        /// <param name="container">container param</param>
        /// <param name="s3">s3 param</param>
        /// <param name="osFamily">The operating system family of the build: * &#x60;ANY&#x60; - Deprecated, for legacy builds. * &#x60;LINUX&#x60; - The build is for Linux. </param>
        [Preserve]
        public MultiplayBuildsBuilds(string buildName, long buildID, BuildTypeOptions buildType, long buildConfigurations, SyncStatusOptions syncStatus, DateTime updated, CCDDetails ccd = default, ContainerImage container = default, AmazonS3Details s3 = default, OsFamilyOptions osFamily = default)
        {
            BuildName = buildName;
            BuildID = buildID;
            BuildType = buildType;
            Ccd = ccd;
            Container = container;
            S3 = s3;
            BuildConfigurations = buildConfigurations;
            SyncStatus = syncStatus;
            Updated = updated;
            OsFamily = osFamily;
        }

        /// <summary>
        /// The name of a build within an environment.
        /// </summary>
        [Preserve]
        [DataMember(Name = "buildName", IsRequired = true, EmitDefaultValue = true)]
        public string BuildName{ get; }
        
        /// <summary>
        /// The ID of a build within an environment.
        /// </summary>
        [Preserve]
        [DataMember(Name = "buildID", IsRequired = true, EmitDefaultValue = true)]
        public long BuildID{ get; }
        
        /// <summary>
        /// The upload type of the build:   * &#x60;FILE_UPLOAD&#x60; - The build is created using directly uploaded game files, backed by CCD as the storage driver.   * &#x60;CONTAINER&#x60; - The build is created using a container image containing game files.   * &#x60;S3&#x60; - The build is created using an external Amazon S3 Bucket containing game files. 
        /// </summary>
        [Preserve]
        [JsonConverter(typeof(StringEnumConverter))]
        [DataMember(Name = "buildType", IsRequired = true, EmitDefaultValue = true)]
        public BuildTypeOptions BuildType{ get; }
        
        /// <summary>
        /// Parameter ccd of MultiplayBuildsBuilds
        /// </summary>
        [Preserve]
        [DataMember(Name = "ccd", EmitDefaultValue = false)]
        public CCDDetails Ccd{ get; }
        
        /// <summary>
        /// Parameter container of MultiplayBuildsBuilds
        /// </summary>
        [Preserve]
        [DataMember(Name = "container", EmitDefaultValue = false)]
        public ContainerImage Container{ get; }
        
        /// <summary>
        /// Parameter s3 of MultiplayBuildsBuilds
        /// </summary>
        [Preserve]
        [DataMember(Name = "s3", EmitDefaultValue = false)]
        public AmazonS3Details S3{ get; }
        
        /// <summary>
        /// The number of build configurations for a build within an environment.
        /// </summary>
        [Preserve]
        [DataMember(Name = "buildConfigurations", IsRequired = true, EmitDefaultValue = true)]
        public long BuildConfigurations{ get; }
        
        /// <summary>
        /// CCD Bucket Synchronisation Status: * &#x60;PENDING&#x60;: Source bucket synchronisation is pending * &#x60;SYNCING&#x60;: Source bucket synchronisation is in progress * &#x60;SYNCED&#x60;: The source bucket has been synchronised * &#x60;FAILED&#x60;: Source bucket synchronisation has failed 
        /// </summary>
        [Preserve]
        [JsonConverter(typeof(StringEnumConverter))]
        [DataMember(Name = "syncStatus", IsRequired = true, EmitDefaultValue = true)]
        public SyncStatusOptions SyncStatus{ get; }
        
        /// <summary>
        /// The date-time of the last update to a build within an environment.
        /// </summary>
        [Preserve]
        [DataMember(Name = "updated", IsRequired = true, EmitDefaultValue = true)]
        public DateTime Updated{ get; }
        
        /// <summary>
        /// The operating system family of the build: * &#x60;ANY&#x60; - Deprecated, for legacy builds. * &#x60;LINUX&#x60; - The build is for Linux. 
        /// </summary>
        [Preserve]
        [JsonConverter(typeof(StringEnumConverter))]
        [DataMember(Name = "osFamily", EmitDefaultValue = false)]
        public OsFamilyOptions OsFamily{ get; }
    
        /// <summary>
        /// The upload type of the build:   * &#x60;FILE_UPLOAD&#x60; - The build is created using directly uploaded game files, backed by CCD as the storage driver.   * &#x60;CONTAINER&#x60; - The build is created using a container image containing game files.   * &#x60;S3&#x60; - The build is created using an external Amazon S3 Bucket containing game files. 
        /// </summary>
        /// <value>The upload type of the build:   * &#x60;FILE_UPLOAD&#x60; - The build is created using directly uploaded game files, backed by CCD as the storage driver.   * &#x60;CONTAINER&#x60; - The build is created using a container image containing game files.   * &#x60;S3&#x60; - The build is created using an external Amazon S3 Bucket containing game files. </value>
        [Preserve]
        [JsonConverter(typeof(StringEnumConverter))]
        public enum BuildTypeOptions
        {
            /// <summary>
            /// Enum FILEUPLOAD for value: FILE_UPLOAD
            /// </summary>
            [EnumMember(Value = "FILE_UPLOAD")]
            FILEUPLOAD = 1,
            /// <summary>
            /// Enum CONTAINER for value: CONTAINER
            /// </summary>
            [EnumMember(Value = "CONTAINER")]
            CONTAINER = 2,
            /// <summary>
            /// Enum S3 for value: S3
            /// </summary>
            [EnumMember(Value = "S3")]
            S3 = 3
        }

        /// <summary>
        /// CCD Bucket Synchronisation Status: * &#x60;PENDING&#x60;: Source bucket synchronisation is pending * &#x60;SYNCING&#x60;: Source bucket synchronisation is in progress * &#x60;SYNCED&#x60;: The source bucket has been synchronised * &#x60;FAILED&#x60;: Source bucket synchronisation has failed 
        /// </summary>
        /// <value>CCD Bucket Synchronisation Status: * &#x60;PENDING&#x60;: Source bucket synchronisation is pending * &#x60;SYNCING&#x60;: Source bucket synchronisation is in progress * &#x60;SYNCED&#x60;: The source bucket has been synchronised * &#x60;FAILED&#x60;: Source bucket synchronisation has failed </value>
        [Preserve]
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SyncStatusOptions
        {
            /// <summary>
            /// Enum PENDING for value: PENDING
            /// </summary>
            [EnumMember(Value = "PENDING")]
            PENDING = 1,
            /// <summary>
            /// Enum SYNCING for value: SYNCING
            /// </summary>
            [EnumMember(Value = "SYNCING")]
            SYNCING = 2,
            /// <summary>
            /// Enum SYNCED for value: SYNCED
            /// </summary>
            [EnumMember(Value = "SYNCED")]
            SYNCED = 3,
            /// <summary>
            /// Enum FAILED for value: FAILED
            /// </summary>
            [EnumMember(Value = "FAILED")]
            FAILED = 4
        }

        /// <summary>
        /// The operating system family of the build: * &#x60;ANY&#x60; - Deprecated, for legacy builds. * &#x60;LINUX&#x60; - The build is for Linux. 
        /// </summary>
        /// <value>The operating system family of the build: * &#x60;ANY&#x60; - Deprecated, for legacy builds. * &#x60;LINUX&#x60; - The build is for Linux. </value>
        [Preserve]
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OsFamilyOptions
        {
            /// <summary>
            /// Enum ANY for value: ANY
            /// </summary>
            [EnumMember(Value = "ANY")]
            ANY = 1,
            /// <summary>
            /// Enum LINUX for value: LINUX
            /// </summary>
            [EnumMember(Value = "LINUX")]
            LINUX = 2
        }

        /// <summary>
        /// Formats a MultiplayBuildsBuilds into a string of key-value pairs for use as a path parameter.
        /// </summary>
        /// <returns>Returns a string representation of the key-value pairs.</returns>
        internal string SerializeAsPathParam()
        {
            var serializedModel = "";

            if (BuildName != null)
            {
                serializedModel += "buildName," + BuildName + ",";
            }
            serializedModel += "buildID," + BuildID.ToString() + ",";
            serializedModel += "buildType," + BuildType + ",";
            if (Ccd != null)
            {
                serializedModel += "ccd," + Ccd.ToString() + ",";
            }
            if (Container != null)
            {
                serializedModel += "container," + Container.ToString() + ",";
            }
            if (S3 != null)
            {
                serializedModel += "s3," + S3.ToString() + ",";
            }
            serializedModel += "buildConfigurations," + BuildConfigurations.ToString() + ",";
            serializedModel += "syncStatus," + SyncStatus + ",";
            if (Updated != null)
            {
                serializedModel += "updated," + Updated.ToString() + ",";
            }
            serializedModel += "osFamily," + OsFamily;
            return serializedModel;
        }

        /// <summary>
        /// Returns a MultiplayBuildsBuilds as a dictionary of key-value pairs for use as a query parameter.
        /// </summary>
        /// <returns>Returns a dictionary of string key-value pairs.</returns>
        internal Dictionary<string, string> GetAsQueryParam()
        {
            var dictionary = new Dictionary<string, string>();

            if (BuildName != null)
            {
                var buildNameStringValue = BuildName.ToString();
                dictionary.Add("buildName", buildNameStringValue);
            }
            
            var buildIDStringValue = BuildID.ToString();
            dictionary.Add("buildID", buildIDStringValue);
            
            var buildTypeStringValue = BuildType.ToString();
            dictionary.Add("buildType", buildTypeStringValue);
            
            var buildConfigurationsStringValue = BuildConfigurations.ToString();
            dictionary.Add("buildConfigurations", buildConfigurationsStringValue);
            
            var syncStatusStringValue = SyncStatus.ToString();
            dictionary.Add("syncStatus", syncStatusStringValue);
            
            if (Updated != null)
            {
                var updatedStringValue = Updated.ToString();
                dictionary.Add("updated", updatedStringValue);
            }
            
            var osFamilyStringValue = OsFamily.ToString();
            dictionary.Add("osFamily", osFamilyStringValue);
            
            return dictionary;
        }
    }
}
