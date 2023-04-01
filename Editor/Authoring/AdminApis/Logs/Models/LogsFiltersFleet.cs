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
using Unity.Services.Multiplay.Authoring.Editor.AdminApis.Logs.Http;



namespace Unity.Services.Multiplay.Authoring.Editor.AdminApis.Logs.Models
{
    /// <summary>
    /// A single fleet in the project that can be used for filtering.
    /// </summary>
    [Preserve]
    [DataContract(Name = "Logs_Filters_Fleet")]
    internal class LogsFiltersFleet
    {
        /// <summary>
        /// A single fleet in the project that can be used for filtering.
        /// </summary>
        /// <param name="id">ID of the Fleet.</param>
        /// <param name="name">Name of the Fleet.</param>
        /// <param name="deleted">Whether or not the fleet has been deleted.</param>
        /// <param name="deletedOn">Date-time when the fleet was deleted.</param>
        [Preserve]
        public LogsFiltersFleet(System.Guid id, string name, bool deleted, DateTime deletedOn = default)
        {
            Id = id;
            Name = name;
            Deleted = deleted;
            DeletedOn = deletedOn;
        }

        /// <summary>
        /// ID of the Fleet.
        /// </summary>
        [Preserve]
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public System.Guid Id{ get; }
        
        /// <summary>
        /// Name of the Fleet.
        /// </summary>
        [Preserve]
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name{ get; }
        
        /// <summary>
        /// Whether or not the fleet has been deleted.
        /// </summary>
        [Preserve]
        [DataMember(Name = "deleted", IsRequired = true, EmitDefaultValue = true)]
        public bool Deleted{ get; }
        
        /// <summary>
        /// Date-time when the fleet was deleted.
        /// </summary>
        [Preserve]
        [DataMember(Name = "deletedOn", EmitDefaultValue = false)]
        public DateTime DeletedOn{ get; }
    
        /// <summary>
        /// Formats a LogsFiltersFleet into a string of key-value pairs for use as a path parameter.
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
            serializedModel += "deleted," + Deleted.ToString() + ",";
            if (DeletedOn != null)
            {
                serializedModel += "deletedOn," + DeletedOn.ToString();
            }
            return serializedModel;
        }

        /// <summary>
        /// Returns a LogsFiltersFleet as a dictionary of key-value pairs for use as a query parameter.
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
            
            var deletedStringValue = Deleted.ToString();
            dictionary.Add("deleted", deletedStringValue);
            
            if (DeletedOn != null)
            {
                var deletedOnStringValue = DeletedOn.ToString();
                dictionary.Add("deletedOn", deletedOnStringValue);
            }
            
            return dictionary;
        }
    }
}