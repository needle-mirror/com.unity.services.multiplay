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
using Unity.Services.Multiplay.Authoring.Editor.AdminApis.Fleets.Http;



namespace Unity.Services.Multiplay.Authoring.Editor.AdminApis.Fleets.Models
{
    /// <summary>
    /// A fleet of servers to host games.
    /// </summary>
    [Preserve]
    [DataContract(Name = "Fleet")]
    internal class Fleet
    {
        /// <summary>
        /// A fleet of servers to host games.
        /// </summary>
        /// <param name="id">ID of the Fleet.</param>
        /// <param name="name">Name of the fleet.</param>
        /// <param name="osID">ID of the Operating System used in the fleet.</param>
        /// <param name="osName">Name of the Operating System used in the fleet.</param>
        /// <param name="osFamily">The os family that the build is based on.</param>
        /// <param name="buildConfigurations">A list of build configurations associated with the fleet.</param>
        /// <param name="fleetRegions">A list of associations between the fleet and regions.</param>
        /// <param name="status">Current status of the fleet.</param>
        /// <param name="deleteTTL">A delete time-to-live in seconds.</param>
        /// <param name="shutdownTTL">A shutdown time-to-live in seconds.</param>
        /// <param name="disabledDeleteTTL">A disabled delete time-to-live in seconds.</param>
        [Preserve]
        public Fleet(System.Guid id, string name, System.Guid osID, string osName, OsFamilyOptions osFamily, List<BuildConfiguration1> buildConfigurations, List<FleetRegion1> fleetRegions, StatusOptions status, long deleteTTL = default, long shutdownTTL = default, long disabledDeleteTTL = default)
        {
            Id = id;
            Name = name;
            OsID = osID;
            OsName = osName;
            OsFamily = osFamily;
            BuildConfigurations = buildConfigurations;
            FleetRegions = fleetRegions;
            Status = status;
            DeleteTTL = deleteTTL;
            ShutdownTTL = shutdownTTL;
            DisabledDeleteTTL = disabledDeleteTTL;
        }

        /// <summary>
        /// ID of the Fleet.
        /// </summary>
        [Preserve]
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public System.Guid Id{ get; }
        
        /// <summary>
        /// Name of the fleet.
        /// </summary>
        [Preserve]
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name{ get; }
        
        /// <summary>
        /// ID of the Operating System used in the fleet.
        /// </summary>
        [Preserve]
        [DataMember(Name = "osID", IsRequired = true, EmitDefaultValue = true)]
        public System.Guid OsID{ get; }
        
        /// <summary>
        /// Name of the Operating System used in the fleet.
        /// </summary>
        [Preserve]
        [DataMember(Name = "osName", IsRequired = true, EmitDefaultValue = true)]
        public string OsName{ get; }
        
        /// <summary>
        /// The os family that the build is based on.
        /// </summary>
        [Preserve]
        [JsonConverter(typeof(StringEnumConverter))]
        [DataMember(Name = "osFamily", IsRequired = true, EmitDefaultValue = true)]
        public OsFamilyOptions OsFamily{ get; }
        
        /// <summary>
        /// A list of build configurations associated with the fleet.
        /// </summary>
        [Preserve]
        [DataMember(Name = "buildConfigurations", IsRequired = true, EmitDefaultValue = true)]
        public List<BuildConfiguration1> BuildConfigurations{ get; }
        
        /// <summary>
        /// A list of associations between the fleet and regions.
        /// </summary>
        [Preserve]
        [DataMember(Name = "fleetRegions", IsRequired = true, EmitDefaultValue = true)]
        public List<FleetRegion1> FleetRegions{ get; }
        
        /// <summary>
        /// Current status of the fleet.
        /// </summary>
        [Preserve]
        [JsonConverter(typeof(StringEnumConverter))]
        [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = true)]
        public StatusOptions Status{ get; }
        
        /// <summary>
        /// A delete time-to-live in seconds.
        /// </summary>
        [Preserve]
        [DataMember(Name = "deleteTTL", EmitDefaultValue = false)]
        public long DeleteTTL{ get; }
        
        /// <summary>
        /// A shutdown time-to-live in seconds.
        /// </summary>
        [Preserve]
        [DataMember(Name = "shutdownTTL", EmitDefaultValue = false)]
        public long ShutdownTTL{ get; }
        
        /// <summary>
        /// A disabled delete time-to-live in seconds.
        /// </summary>
        [Preserve]
        [DataMember(Name = "disabledDeleteTTL", EmitDefaultValue = false)]
        public long DisabledDeleteTTL{ get; }
    
        /// <summary>
        /// The os family that the build is based on.
        /// </summary>
        /// <value>The os family that the build is based on.</value>
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
            /// Enum WINDOWS for value: WINDOWS
            /// </summary>
            [EnumMember(Value = "WINDOWS")]
            WINDOWS = 2,
            /// <summary>
            /// Enum LINUX for value: LINUX
            /// </summary>
            [EnumMember(Value = "LINUX")]
            LINUX = 3
        }

        /// <summary>
        /// Current status of the fleet.
        /// </summary>
        /// <value>Current status of the fleet.</value>
        [Preserve]
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusOptions
        {
            /// <summary>
            /// Enum ONLINE for value: ONLINE
            /// </summary>
            [EnumMember(Value = "ONLINE")]
            ONLINE = 1,
            /// <summary>
            /// Enum DRAINING for value: DRAINING
            /// </summary>
            [EnumMember(Value = "DRAINING")]
            DRAINING = 2,
            /// <summary>
            /// Enum OFFLINE for value: OFFLINE
            /// </summary>
            [EnumMember(Value = "OFFLINE")]
            OFFLINE = 3
        }

        /// <summary>
        /// Formats a Fleet into a string of key-value pairs for use as a path parameter.
        /// </summary>
        /// <returns>Returns a string representation of the key-value pairs.</returns>
        internal string SerializeAsPathParam()
        {
            var serializedModel = "";

            if (Id != null)
            {
                serializedModel += "id," + Id + ",";
            }
            if (Name != null)
            {
                serializedModel += "name," + Name + ",";
            }
            if (OsID != null)
            {
                serializedModel += "osID," + OsID + ",";
            }
            if (OsName != null)
            {
                serializedModel += "osName," + OsName + ",";
            }
            serializedModel += "osFamily," + OsFamily + ",";
            if (BuildConfigurations != null)
            {
                serializedModel += "buildConfigurations," + BuildConfigurations.ToString() + ",";
            }
            if (FleetRegions != null)
            {
                serializedModel += "fleetRegions," + FleetRegions.ToString() + ",";
            }
            serializedModel += "status," + Status + ",";
            serializedModel += "deleteTTL," + DeleteTTL.ToString() + ",";
            serializedModel += "shutdownTTL," + ShutdownTTL.ToString() + ",";
            serializedModel += "disabledDeleteTTL," + DisabledDeleteTTL.ToString();
            return serializedModel;
        }

        /// <summary>
        /// Returns a Fleet as a dictionary of key-value pairs for use as a query parameter.
        /// </summary>
        /// <returns>Returns a dictionary of string key-value pairs.</returns>
        internal Dictionary<string, string> GetAsQueryParam()
        {
            var dictionary = new Dictionary<string, string>();

            if (Id != null)
            {
                var idStringValue = Id.ToString();
                dictionary.Add("id", idStringValue);
            }
            
            if (Name != null)
            {
                var nameStringValue = Name.ToString();
                dictionary.Add("name", nameStringValue);
            }
            
            if (OsID != null)
            {
                var osIDStringValue = OsID.ToString();
                dictionary.Add("osID", osIDStringValue);
            }
            
            if (OsName != null)
            {
                var osNameStringValue = OsName.ToString();
                dictionary.Add("osName", osNameStringValue);
            }
            
            var osFamilyStringValue = OsFamily.ToString();
            dictionary.Add("osFamily", osFamilyStringValue);
            
            var statusStringValue = Status.ToString();
            dictionary.Add("status", statusStringValue);
            
            var deleteTTLStringValue = DeleteTTL.ToString();
            dictionary.Add("deleteTTL", deleteTTLStringValue);
            
            var shutdownTTLStringValue = ShutdownTTL.ToString();
            dictionary.Add("shutdownTTL", shutdownTTLStringValue);
            
            var disabledDeleteTTLStringValue = DisabledDeleteTTL.ToString();
            dictionary.Add("disabledDeleteTTL", disabledDeleteTTLStringValue);
            
            return dictionary;
        }
    }
}
