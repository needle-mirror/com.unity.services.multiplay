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
    /// SearchLogs500Response model
    /// </summary>
    [Preserve]
    [DataContract(Name = "searchLogs_500_response")]
    internal class SearchLogs500Response
    {
        /// <summary>
        /// Creates an instance of SearchLogs500Response.
        /// </summary>
        /// <param name="title">title param</param>
        /// <param name="status">status param</param>
        /// <param name="requestId">requestId param</param>
        [Preserve]
        public SearchLogs500Response(string title = default, int status = default, string requestId = default)
        {
            Title = title;
            Status = status;
            RequestId = requestId;
        }

        /// <summary>
        /// Parameter title of SearchLogs500Response
        /// </summary>
        [Preserve]
        [DataMember(Name = "title", EmitDefaultValue = false)]
        public string Title{ get; }
        
        /// <summary>
        /// Parameter status of SearchLogs500Response
        /// </summary>
        [Preserve]
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public int Status{ get; }
        
        /// <summary>
        /// Parameter requestId of SearchLogs500Response
        /// </summary>
        [Preserve]
        [DataMember(Name = "requestId", EmitDefaultValue = false)]
        public string RequestId{ get; }
    
        /// <summary>
        /// Formats a SearchLogs500Response into a string of key-value pairs for use as a path parameter.
        /// </summary>
        /// <returns>Returns a string representation of the key-value pairs.</returns>
        internal string SerializeAsPathParam()
        {
            var serializedModel = "";

            if (Title != null)
            {
                serializedModel += "title," + Title + ",";
            }
            serializedModel += "status," + Status.ToString() + ",";
            if (RequestId != null)
            {
                serializedModel += "requestId," + RequestId;
            }
            return serializedModel;
        }

        /// <summary>
        /// Returns a SearchLogs500Response as a dictionary of key-value pairs for use as a query parameter.
        /// </summary>
        /// <returns>Returns a dictionary of string key-value pairs.</returns>
        internal Dictionary<string, string> GetAsQueryParam()
        {
            var dictionary = new Dictionary<string, string>();

            if (Title != null)
            {
                var titleStringValue = Title.ToString();
                dictionary.Add("title", titleStringValue);
            }
            
            var statusStringValue = Status.ToString();
            dictionary.Add("status", statusStringValue);
            
            if (RequestId != null)
            {
                var requestIdStringValue = RequestId.ToString();
                dictionary.Add("requestId", requestIdStringValue);
            }
            
            return dictionary;
        }
    }
}
