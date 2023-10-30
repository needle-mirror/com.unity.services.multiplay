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
using Unity.Services.Multiplay.Authoring.Editor.AdminApis.Ccd.Http;



namespace Unity.Services.Multiplay.Authoring.Editor.AdminApis.Ccd.Models
{
    /// <summary>
    /// CcdReleaseentryCreate model
    /// </summary>
    [Preserve]
    [DataContract(Name = "ccd.releaseentryCreate")]
    internal class CcdReleaseentryCreate
    {
        /// <summary>
        /// Creates an instance of CcdReleaseentryCreate.
        /// </summary>
        /// <param name="entryid">entryid param</param>
        /// <param name="versionid">versionid param</param>
        [Preserve]
        public CcdReleaseentryCreate(System.Guid entryid, System.Guid versionid)
        {
            Entryid = entryid;
            Versionid = versionid;
        }

        /// <summary>
        /// Parameter entryid of CcdReleaseentryCreate
        /// </summary>
        [Preserve]
        [DataMember(Name = "entryid", IsRequired = true, EmitDefaultValue = true)]
        public System.Guid Entryid{ get; }
        
        /// <summary>
        /// Parameter versionid of CcdReleaseentryCreate
        /// </summary>
        [Preserve]
        [DataMember(Name = "versionid", IsRequired = true, EmitDefaultValue = true)]
        public System.Guid Versionid{ get; }
    
        /// <summary>
        /// Formats a CcdReleaseentryCreate into a string of key-value pairs for use as a path parameter.
        /// </summary>
        /// <returns>Returns a string representation of the key-value pairs.</returns>
        internal string SerializeAsPathParam()
        {
            var serializedModel = "";

            if (Entryid != null)
            {
                serializedModel += "entryid," + Entryid + ",";
            }
            if (Versionid != null)
            {
                serializedModel += "versionid," + Versionid;
            }
            return serializedModel;
        }

        /// <summary>
        /// Returns a CcdReleaseentryCreate as a dictionary of key-value pairs for use as a query parameter.
        /// </summary>
        /// <returns>Returns a dictionary of string key-value pairs.</returns>
        internal Dictionary<string, string> GetAsQueryParam()
        {
            var dictionary = new Dictionary<string, string>();

            if (Entryid != null)
            {
                var entryidStringValue = Entryid.ToString();
                dictionary.Add("entryid", entryidStringValue);
            }
            
            if (Versionid != null)
            {
                var versionidStringValue = Versionid.ToString();
                dictionary.Add("versionid", versionidStringValue);
            }
            
            return dictionary;
        }
    }
}
