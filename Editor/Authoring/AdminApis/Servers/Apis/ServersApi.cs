//-----------------------------------------------------------------------------
// <auto-generated>
//     This file was generated by the C# SDK Code Generator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//-----------------------------------------------------------------------------


using System.Threading.Tasks;
using System.Collections.Generic;
using Unity.Services.Multiplay.Authoring.Editor.AdminApis.Servers.Models;
using Unity.Services.Multiplay.Authoring.Editor.AdminApis.Servers.Http;
using Unity.Services.Multiplay.Authoring.Editor.AdminApis.Servers.Servers;

namespace Unity.Services.Multiplay.Authoring.Editor.AdminApis.Servers.Apis.Servers
{
    /// <summary>
    /// Interface for the ServersApiClient
    /// </summary>
    internal interface IServersApiClient
    {
            /// <summary>
            /// Async Operation.
            /// View a server.
            /// </summary>
            /// <param name="request">Request object for GetServer.</param>
            /// <param name="operationConfiguration">Configuration for GetServer.</param>
            /// <returns>Task for a Response object containing status code, headers, and Models.Server object.</returns>
            /// <exception cref="Unity.Services.Multiplay.Authoring.Editor.AdminApis.Servers.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
            Task<Response<Models.Server>> GetServerAsync(Unity.Services.Multiplay.Authoring.Editor.AdminApis.Servers.Servers.GetServerRequest request, Configuration operationConfiguration = null);

            /// <summary>
            /// Async Operation.
            /// List action logs.
            /// </summary>
            /// <param name="request">Request object for GetServerActions.</param>
            /// <param name="operationConfiguration">Configuration for GetServerActions.</param>
            /// <returns>Task for a Response object containing status code, headers, and List&lt;ActionLog&gt; object.</returns>
            /// <exception cref="Unity.Services.Multiplay.Authoring.Editor.AdminApis.Servers.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
            Task<Response<List<ActionLog>>> GetServerActionsAsync(Unity.Services.Multiplay.Authoring.Editor.AdminApis.Servers.Servers.GetServerActionsRequest request, Configuration operationConfiguration = null);

            /// <summary>
            /// Async Operation.
            /// View server CCU.
            /// </summary>
            /// <param name="request">Request object for GetServerCCU.</param>
            /// <param name="operationConfiguration">Configuration for GetServerCCU.</param>
            /// <returns>Task for a Response object containing status code, headers, and List&lt;TimeSeriesInt64&gt; object.</returns>
            /// <exception cref="Unity.Services.Multiplay.Authoring.Editor.AdminApis.Servers.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
            Task<Response<List<TimeSeriesInt64>>> GetServerCCUAsync(Unity.Services.Multiplay.Authoring.Editor.AdminApis.Servers.Servers.GetServerCCURequest request, Configuration operationConfiguration = null);

            /// <summary>
            /// Async Operation.
            /// View server compute.
            /// </summary>
            /// <param name="request">Request object for GetServerCompute.</param>
            /// <param name="operationConfiguration">Configuration for GetServerCompute.</param>
            /// <returns>Task for a Response object containing status code, headers, and List&lt;TimeSeriesFloat64&gt; object.</returns>
            /// <exception cref="Unity.Services.Multiplay.Authoring.Editor.AdminApis.Servers.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
            Task<Response<List<TimeSeriesFloat64>>> GetServerComputeAsync(Unity.Services.Multiplay.Authoring.Editor.AdminApis.Servers.Servers.GetServerComputeRequest request, Configuration operationConfiguration = null);

            /// <summary>
            /// Async Operation.
            /// View server crashes.
            /// </summary>
            /// <param name="request">Request object for GetServerCrashes.</param>
            /// <param name="operationConfiguration">Configuration for GetServerCrashes.</param>
            /// <returns>Task for a Response object containing status code, headers, and List&lt;TimeSeriesInt64&gt; object.</returns>
            /// <exception cref="Unity.Services.Multiplay.Authoring.Editor.AdminApis.Servers.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
            Task<Response<List<TimeSeriesInt64>>> GetServerCrashesAsync(Unity.Services.Multiplay.Authoring.Editor.AdminApis.Servers.Servers.GetServerCrashesRequest request, Configuration operationConfiguration = null);

            /// <summary>
            /// Async Operation.
            /// View server events.
            /// </summary>
            /// <param name="request">Request object for GetServerEvents.</param>
            /// <param name="operationConfiguration">Configuration for GetServerEvents.</param>
            /// <returns>Task for a Response object containing status code, headers, and List&lt;TimeSeriesInt64&gt; object.</returns>
            /// <exception cref="Unity.Services.Multiplay.Authoring.Editor.AdminApis.Servers.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
            Task<Response<List<TimeSeriesInt64>>> GetServerEventsAsync(Unity.Services.Multiplay.Authoring.Editor.AdminApis.Servers.Servers.GetServerEventsRequest request, Configuration operationConfiguration = null);

            /// <summary>
            /// Async Operation.
            /// Get Log File Link.
            /// </summary>
            /// <param name="request">Request object for GetServerLogsLink.</param>
            /// <param name="operationConfiguration">Configuration for GetServerLogsLink.</param>
            /// <returns>Task for a Response object containing status code, headers, and LogFileLink object.</returns>
            /// <exception cref="Unity.Services.Multiplay.Authoring.Editor.AdminApis.Servers.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
            Task<Response<LogFileLink>> GetServerLogsLinkAsync(Unity.Services.Multiplay.Authoring.Editor.AdminApis.Servers.Servers.GetServerLogsLinkRequest request, Configuration operationConfiguration = null);

            /// <summary>
            /// Async Operation.
            /// Get Preview of Log File.
            /// </summary>
            /// <param name="request">Request object for GetServerLogsPreview.</param>
            /// <param name="operationConfiguration">Configuration for GetServerLogsPreview.</param>
            /// <returns>Task for a Response object containing status code, headers, and string object.</returns>
            /// <exception cref="Unity.Services.Multiplay.Authoring.Editor.AdminApis.Servers.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
            Task<Response<string>> GetServerLogsPreviewAsync(Unity.Services.Multiplay.Authoring.Editor.AdminApis.Servers.Servers.GetServerLogsPreviewRequest request, Configuration operationConfiguration = null);

            /// <summary>
            /// Async Operation.
            /// List server locations.
            /// </summary>
            /// <param name="request">Request object for ListServerLocations.</param>
            /// <param name="operationConfiguration">Configuration for ListServerLocations.</param>
            /// <returns>Task for a Response object containing status code, headers, and List&lt;Models.Location&gt; object.</returns>
            /// <exception cref="Unity.Services.Multiplay.Authoring.Editor.AdminApis.Servers.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
            Task<Response<List<Models.Location>>> ListServerLocationsAsync(Unity.Services.Multiplay.Authoring.Editor.AdminApis.Servers.Servers.ListServerLocationsRequest request, Configuration operationConfiguration = null);

            /// <summary>
            /// Async Operation.
            /// List log files.
            /// </summary>
            /// <param name="request">Request object for ListServerLogs.</param>
            /// <param name="operationConfiguration">Configuration for ListServerLogs.</param>
            /// <returns>Task for a Response object containing status code, headers, and List&lt;ServerLogFile&gt; object.</returns>
            /// <exception cref="Unity.Services.Multiplay.Authoring.Editor.AdminApis.Servers.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
            Task<Response<List<ServerLogFile>>> ListServerLogsAsync(Unity.Services.Multiplay.Authoring.Editor.AdminApis.Servers.Servers.ListServerLogsRequest request, Configuration operationConfiguration = null);

            /// <summary>
            /// Async Operation.
            /// List servers.
            /// </summary>
            /// <param name="request">Request object for ListServers.</param>
            /// <param name="operationConfiguration">Configuration for ListServers.</param>
            /// <returns>Task for a Response object containing status code, headers, and List&lt;Models.Server&gt; object.</returns>
            /// <exception cref="Unity.Services.Multiplay.Authoring.Editor.AdminApis.Servers.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
            Task<Response<List<Models.Server>>> ListServersAsync(Unity.Services.Multiplay.Authoring.Editor.AdminApis.Servers.Servers.ListServersRequest request, Configuration operationConfiguration = null);

            /// <summary>
            /// Async Operation.
            /// Trigger action.
            /// </summary>
            /// <param name="request">Request object for TriggerServerAction.</param>
            /// <param name="operationConfiguration">Configuration for TriggerServerAction.</param>
            /// <returns>Task for a Response object containing status code, headers, and ActionResponse object.</returns>
            /// <exception cref="Unity.Services.Multiplay.Authoring.Editor.AdminApis.Servers.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
            Task<Response<ActionResponse>> TriggerServerActionAsync(Unity.Services.Multiplay.Authoring.Editor.AdminApis.Servers.Servers.TriggerServerActionRequest request, Configuration operationConfiguration = null);

    }

    ///<inheritdoc cref="IServersApiClient"/>
    internal class ServersApiClient : BaseApiClient, IServersApiClient
    {
        private const int _baseTimeout = 10;
        private Configuration _configuration;
        /// <summary>
        /// Accessor for the client configuration object. This returns a merge
        /// between the current configuration and the global configuration to
        /// ensure the correct combination of headers and a base path (if it is
        /// set) are returned.
        /// </summary>
        public Configuration Configuration
        {
            get {
                // We return a merge between the current configuration and the
                // global configuration to ensure we have the correct
                // combination of headers and a base path (if it is set).
                Configuration globalConfiguration = new Configuration("https://services.unity.com", 10, 4, null);
                return Configuration.MergeConfigurations(_configuration, globalConfiguration);
            }
            set { _configuration = value; }
        }

        /// <summary>
        /// ServersApiClient Constructor.
        /// </summary>
        /// <param name="httpClient">The HttpClient for ServersApiClient.</param>
        /// <param name="configuration"> ServersApiClient Configuration object.</param>
        public ServersApiClient(IHttpClient httpClient,
            Configuration configuration = null) : base(httpClient)
        {
            // We don't need to worry about the configuration being null at
            // this stage, we will check this in the accessor.
            _configuration = configuration;

            
        }


        /// <summary>
        /// Async Operation.
        /// View a server.
        /// </summary>
        /// <param name="request">Request object for GetServer.</param>
        /// <param name="operationConfiguration">Configuration for GetServer.</param>
        /// <returns>Task for a Response object containing status code, headers, and Models.Server object.</returns>
        /// <exception cref="Unity.Services.Multiplay.Authoring.Editor.AdminApis.Servers.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
        public async Task<Response<Models.Server>> GetServerAsync(Unity.Services.Multiplay.Authoring.Editor.AdminApis.Servers.Servers.GetServerRequest request,
            Configuration operationConfiguration = null)
        {
            var statusCodeToTypeMap = new Dictionary<string, System.Type>() { {"200", typeof(Models.Server)   },{"400", typeof(InlineResponse400)   },{"401", typeof(InlineResponse401)   },{"403", typeof(InlineResponse403)   },{"404", typeof(InlineResponse404)   },{"429", typeof(InlineResponse429)   },{"500", typeof(InlineResponse500)   } };

            // Merge the operation/request level configuration with the client level configuration.
            var finalConfiguration = Configuration.MergeConfigurations(operationConfiguration, Configuration);

            var response = await HttpClient.MakeRequestAsync("GET",
                request.ConstructUrl(finalConfiguration.BasePath),
                request.ConstructBody(),
                request.ConstructHeaders(finalConfiguration),
                finalConfiguration.RequestTimeout ?? _baseTimeout);

            var handledResponse = ResponseHandler.HandleAsyncResponse<Models.Server>(response, statusCodeToTypeMap);
            return new Response<Models.Server>(response, handledResponse);
        }


        /// <summary>
        /// Async Operation.
        /// List action logs.
        /// </summary>
        /// <param name="request">Request object for GetServerActions.</param>
        /// <param name="operationConfiguration">Configuration for GetServerActions.</param>
        /// <returns>Task for a Response object containing status code, headers, and List&lt;ActionLog&gt; object.</returns>
        /// <exception cref="Unity.Services.Multiplay.Authoring.Editor.AdminApis.Servers.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
        public async Task<Response<List<ActionLog>>> GetServerActionsAsync(Unity.Services.Multiplay.Authoring.Editor.AdminApis.Servers.Servers.GetServerActionsRequest request,
            Configuration operationConfiguration = null)
        {
            var statusCodeToTypeMap = new Dictionary<string, System.Type>() { {"200", typeof(List<ActionLog>)   },{"400", typeof(InlineResponse400)   },{"401", typeof(InlineResponse401)   },{"403", typeof(InlineResponse403)   },{"404", typeof(InlineResponse404)   },{"429", typeof(InlineResponse429)   },{"500", typeof(InlineResponse500)   } };

            // Merge the operation/request level configuration with the client level configuration.
            var finalConfiguration = Configuration.MergeConfigurations(operationConfiguration, Configuration);

            var response = await HttpClient.MakeRequestAsync("GET",
                request.ConstructUrl(finalConfiguration.BasePath),
                request.ConstructBody(),
                request.ConstructHeaders(finalConfiguration),
                finalConfiguration.RequestTimeout ?? _baseTimeout);

            var handledResponse = ResponseHandler.HandleAsyncResponse<List<ActionLog>>(response, statusCodeToTypeMap);
            return new Response<List<ActionLog>>(response, handledResponse);
        }


        /// <summary>
        /// Async Operation.
        /// View server CCU.
        /// </summary>
        /// <param name="request">Request object for GetServerCCU.</param>
        /// <param name="operationConfiguration">Configuration for GetServerCCU.</param>
        /// <returns>Task for a Response object containing status code, headers, and List&lt;TimeSeriesInt64&gt; object.</returns>
        /// <exception cref="Unity.Services.Multiplay.Authoring.Editor.AdminApis.Servers.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
        public async Task<Response<List<TimeSeriesInt64>>> GetServerCCUAsync(Unity.Services.Multiplay.Authoring.Editor.AdminApis.Servers.Servers.GetServerCCURequest request,
            Configuration operationConfiguration = null)
        {
            var statusCodeToTypeMap = new Dictionary<string, System.Type>() { {"200", typeof(List<TimeSeriesInt64>)   },{"400", typeof(InlineResponse400)   },{"401", typeof(InlineResponse401)   },{"403", typeof(InlineResponse403)   },{"404", typeof(InlineResponse404)   },{"429", typeof(InlineResponse429)   },{"500", typeof(InlineResponse500)   } };

            // Merge the operation/request level configuration with the client level configuration.
            var finalConfiguration = Configuration.MergeConfigurations(operationConfiguration, Configuration);

            var response = await HttpClient.MakeRequestAsync("GET",
                request.ConstructUrl(finalConfiguration.BasePath),
                request.ConstructBody(),
                request.ConstructHeaders(finalConfiguration),
                finalConfiguration.RequestTimeout ?? _baseTimeout);

            var handledResponse = ResponseHandler.HandleAsyncResponse<List<TimeSeriesInt64>>(response, statusCodeToTypeMap);
            return new Response<List<TimeSeriesInt64>>(response, handledResponse);
        }


        /// <summary>
        /// Async Operation.
        /// View server compute.
        /// </summary>
        /// <param name="request">Request object for GetServerCompute.</param>
        /// <param name="operationConfiguration">Configuration for GetServerCompute.</param>
        /// <returns>Task for a Response object containing status code, headers, and List&lt;TimeSeriesFloat64&gt; object.</returns>
        /// <exception cref="Unity.Services.Multiplay.Authoring.Editor.AdminApis.Servers.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
        public async Task<Response<List<TimeSeriesFloat64>>> GetServerComputeAsync(Unity.Services.Multiplay.Authoring.Editor.AdminApis.Servers.Servers.GetServerComputeRequest request,
            Configuration operationConfiguration = null)
        {
            var statusCodeToTypeMap = new Dictionary<string, System.Type>() { {"200", typeof(List<TimeSeriesFloat64>)   },{"400", typeof(InlineResponse400)   },{"401", typeof(InlineResponse401)   },{"403", typeof(InlineResponse403)   },{"404", typeof(InlineResponse404)   },{"429", typeof(InlineResponse429)   },{"500", typeof(InlineResponse500)   } };

            // Merge the operation/request level configuration with the client level configuration.
            var finalConfiguration = Configuration.MergeConfigurations(operationConfiguration, Configuration);

            var response = await HttpClient.MakeRequestAsync("GET",
                request.ConstructUrl(finalConfiguration.BasePath),
                request.ConstructBody(),
                request.ConstructHeaders(finalConfiguration),
                finalConfiguration.RequestTimeout ?? _baseTimeout);

            var handledResponse = ResponseHandler.HandleAsyncResponse<List<TimeSeriesFloat64>>(response, statusCodeToTypeMap);
            return new Response<List<TimeSeriesFloat64>>(response, handledResponse);
        }


        /// <summary>
        /// Async Operation.
        /// View server crashes.
        /// </summary>
        /// <param name="request">Request object for GetServerCrashes.</param>
        /// <param name="operationConfiguration">Configuration for GetServerCrashes.</param>
        /// <returns>Task for a Response object containing status code, headers, and List&lt;TimeSeriesInt64&gt; object.</returns>
        /// <exception cref="Unity.Services.Multiplay.Authoring.Editor.AdminApis.Servers.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
        public async Task<Response<List<TimeSeriesInt64>>> GetServerCrashesAsync(Unity.Services.Multiplay.Authoring.Editor.AdminApis.Servers.Servers.GetServerCrashesRequest request,
            Configuration operationConfiguration = null)
        {
            var statusCodeToTypeMap = new Dictionary<string, System.Type>() { {"200", typeof(List<TimeSeriesInt64>)   },{"400", typeof(InlineResponse400)   },{"401", typeof(InlineResponse401)   },{"403", typeof(InlineResponse403)   },{"404", typeof(InlineResponse404)   },{"429", typeof(InlineResponse429)   },{"500", typeof(InlineResponse500)   } };

            // Merge the operation/request level configuration with the client level configuration.
            var finalConfiguration = Configuration.MergeConfigurations(operationConfiguration, Configuration);

            var response = await HttpClient.MakeRequestAsync("GET",
                request.ConstructUrl(finalConfiguration.BasePath),
                request.ConstructBody(),
                request.ConstructHeaders(finalConfiguration),
                finalConfiguration.RequestTimeout ?? _baseTimeout);

            var handledResponse = ResponseHandler.HandleAsyncResponse<List<TimeSeriesInt64>>(response, statusCodeToTypeMap);
            return new Response<List<TimeSeriesInt64>>(response, handledResponse);
        }


        /// <summary>
        /// Async Operation.
        /// View server events.
        /// </summary>
        /// <param name="request">Request object for GetServerEvents.</param>
        /// <param name="operationConfiguration">Configuration for GetServerEvents.</param>
        /// <returns>Task for a Response object containing status code, headers, and List&lt;TimeSeriesInt64&gt; object.</returns>
        /// <exception cref="Unity.Services.Multiplay.Authoring.Editor.AdminApis.Servers.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
        public async Task<Response<List<TimeSeriesInt64>>> GetServerEventsAsync(Unity.Services.Multiplay.Authoring.Editor.AdminApis.Servers.Servers.GetServerEventsRequest request,
            Configuration operationConfiguration = null)
        {
            var statusCodeToTypeMap = new Dictionary<string, System.Type>() { {"200", typeof(List<TimeSeriesInt64>)   },{"400", typeof(InlineResponse400)   },{"401", typeof(InlineResponse401)   },{"403", typeof(InlineResponse403)   },{"404", typeof(InlineResponse404)   },{"429", typeof(InlineResponse429)   },{"500", typeof(InlineResponse500)   } };

            // Merge the operation/request level configuration with the client level configuration.
            var finalConfiguration = Configuration.MergeConfigurations(operationConfiguration, Configuration);

            var response = await HttpClient.MakeRequestAsync("GET",
                request.ConstructUrl(finalConfiguration.BasePath),
                request.ConstructBody(),
                request.ConstructHeaders(finalConfiguration),
                finalConfiguration.RequestTimeout ?? _baseTimeout);

            var handledResponse = ResponseHandler.HandleAsyncResponse<List<TimeSeriesInt64>>(response, statusCodeToTypeMap);
            return new Response<List<TimeSeriesInt64>>(response, handledResponse);
        }


        /// <summary>
        /// Async Operation.
        /// Get Log File Link.
        /// </summary>
        /// <param name="request">Request object for GetServerLogsLink.</param>
        /// <param name="operationConfiguration">Configuration for GetServerLogsLink.</param>
        /// <returns>Task for a Response object containing status code, headers, and LogFileLink object.</returns>
        /// <exception cref="Unity.Services.Multiplay.Authoring.Editor.AdminApis.Servers.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
        public async Task<Response<LogFileLink>> GetServerLogsLinkAsync(Unity.Services.Multiplay.Authoring.Editor.AdminApis.Servers.Servers.GetServerLogsLinkRequest request,
            Configuration operationConfiguration = null)
        {
            var statusCodeToTypeMap = new Dictionary<string, System.Type>() { {"200", typeof(LogFileLink)   },{"400", typeof(InlineResponse400)   },{"401", typeof(InlineResponse401)   },{"403", typeof(InlineResponse403)   },{"404", typeof(InlineResponse404)   },{"429", typeof(InlineResponse429)   },{"500", typeof(InlineResponse500)   } };

            // Merge the operation/request level configuration with the client level configuration.
            var finalConfiguration = Configuration.MergeConfigurations(operationConfiguration, Configuration);

            var response = await HttpClient.MakeRequestAsync("GET",
                request.ConstructUrl(finalConfiguration.BasePath),
                request.ConstructBody(),
                request.ConstructHeaders(finalConfiguration),
                finalConfiguration.RequestTimeout ?? _baseTimeout);

            var handledResponse = ResponseHandler.HandleAsyncResponse<LogFileLink>(response, statusCodeToTypeMap);
            return new Response<LogFileLink>(response, handledResponse);
        }


        /// <summary>
        /// Async Operation.
        /// Get Preview of Log File.
        /// </summary>
        /// <param name="request">Request object for GetServerLogsPreview.</param>
        /// <param name="operationConfiguration">Configuration for GetServerLogsPreview.</param>
        /// <returns>Task for a Response object containing status code, headers, and string object.</returns>
        /// <exception cref="Unity.Services.Multiplay.Authoring.Editor.AdminApis.Servers.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
        public async Task<Response<string>> GetServerLogsPreviewAsync(Unity.Services.Multiplay.Authoring.Editor.AdminApis.Servers.Servers.GetServerLogsPreviewRequest request,
            Configuration operationConfiguration = null)
        {
            var statusCodeToTypeMap = new Dictionary<string, System.Type>() { {"200", typeof(string)   },{"400", typeof(InlineResponse400)   },{"401", typeof(InlineResponse401)   },{"403", typeof(InlineResponse403)   },{"404", typeof(InlineResponse404)   },{"429", typeof(InlineResponse429)   },{"500", typeof(InlineResponse500)   } };

            // Merge the operation/request level configuration with the client level configuration.
            var finalConfiguration = Configuration.MergeConfigurations(operationConfiguration, Configuration);

            var response = await HttpClient.MakeRequestAsync("GET",
                request.ConstructUrl(finalConfiguration.BasePath),
                request.ConstructBody(),
                request.ConstructHeaders(finalConfiguration),
                finalConfiguration.RequestTimeout ?? _baseTimeout);

            var handledResponse = ResponseHandler.HandleAsyncResponse<string>(response, statusCodeToTypeMap);
            return new Response<string>(response, handledResponse);
        }


        /// <summary>
        /// Async Operation.
        /// List server locations.
        /// </summary>
        /// <param name="request">Request object for ListServerLocations.</param>
        /// <param name="operationConfiguration">Configuration for ListServerLocations.</param>
        /// <returns>Task for a Response object containing status code, headers, and List&lt;Models.Location&gt; object.</returns>
        /// <exception cref="Unity.Services.Multiplay.Authoring.Editor.AdminApis.Servers.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
        public async Task<Response<List<Models.Location>>> ListServerLocationsAsync(Unity.Services.Multiplay.Authoring.Editor.AdminApis.Servers.Servers.ListServerLocationsRequest request,
            Configuration operationConfiguration = null)
        {
            var statusCodeToTypeMap = new Dictionary<string, System.Type>() { {"200", typeof(List<Models.Location>)   },{"400", typeof(InlineResponse400)   },{"401", typeof(InlineResponse401)   },{"403", typeof(InlineResponse403)   },{"404", typeof(InlineResponse404)   },{"429", typeof(InlineResponse429)   },{"500", typeof(InlineResponse500)   } };

            // Merge the operation/request level configuration with the client level configuration.
            var finalConfiguration = Configuration.MergeConfigurations(operationConfiguration, Configuration);

            var response = await HttpClient.MakeRequestAsync("GET",
                request.ConstructUrl(finalConfiguration.BasePath),
                request.ConstructBody(),
                request.ConstructHeaders(finalConfiguration),
                finalConfiguration.RequestTimeout ?? _baseTimeout);

            var handledResponse = ResponseHandler.HandleAsyncResponse<List<Models.Location>>(response, statusCodeToTypeMap);
            return new Response<List<Models.Location>>(response, handledResponse);
        }


        /// <summary>
        /// Async Operation.
        /// List log files.
        /// </summary>
        /// <param name="request">Request object for ListServerLogs.</param>
        /// <param name="operationConfiguration">Configuration for ListServerLogs.</param>
        /// <returns>Task for a Response object containing status code, headers, and List&lt;ServerLogFile&gt; object.</returns>
        /// <exception cref="Unity.Services.Multiplay.Authoring.Editor.AdminApis.Servers.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
        public async Task<Response<List<ServerLogFile>>> ListServerLogsAsync(Unity.Services.Multiplay.Authoring.Editor.AdminApis.Servers.Servers.ListServerLogsRequest request,
            Configuration operationConfiguration = null)
        {
            var statusCodeToTypeMap = new Dictionary<string, System.Type>() { {"200", typeof(List<ServerLogFile>)   },{"400", typeof(InlineResponse400)   },{"401", typeof(InlineResponse401)   },{"403", typeof(InlineResponse403)   },{"404", typeof(InlineResponse404)   },{"429", typeof(InlineResponse429)   },{"500", typeof(InlineResponse500)   } };

            // Merge the operation/request level configuration with the client level configuration.
            var finalConfiguration = Configuration.MergeConfigurations(operationConfiguration, Configuration);

            var response = await HttpClient.MakeRequestAsync("GET",
                request.ConstructUrl(finalConfiguration.BasePath),
                request.ConstructBody(),
                request.ConstructHeaders(finalConfiguration),
                finalConfiguration.RequestTimeout ?? _baseTimeout);

            var handledResponse = ResponseHandler.HandleAsyncResponse<List<ServerLogFile>>(response, statusCodeToTypeMap);
            return new Response<List<ServerLogFile>>(response, handledResponse);
        }


        /// <summary>
        /// Async Operation.
        /// List servers.
        /// </summary>
        /// <param name="request">Request object for ListServers.</param>
        /// <param name="operationConfiguration">Configuration for ListServers.</param>
        /// <returns>Task for a Response object containing status code, headers, and List&lt;Models.Server&gt; object.</returns>
        /// <exception cref="Unity.Services.Multiplay.Authoring.Editor.AdminApis.Servers.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
        public async Task<Response<List<Models.Server>>> ListServersAsync(Unity.Services.Multiplay.Authoring.Editor.AdminApis.Servers.Servers.ListServersRequest request,
            Configuration operationConfiguration = null)
        {
            var statusCodeToTypeMap = new Dictionary<string, System.Type>() { {"200", typeof(List<Models.Server>)   },{"400", typeof(InlineResponse400)   },{"401", typeof(InlineResponse401)   },{"403", typeof(InlineResponse403)   },{"404", typeof(InlineResponse404)   },{"429", typeof(InlineResponse429)   },{"500", typeof(InlineResponse500)   } };

            // Merge the operation/request level configuration with the client level configuration.
            var finalConfiguration = Configuration.MergeConfigurations(operationConfiguration, Configuration);

            var response = await HttpClient.MakeRequestAsync("GET",
                request.ConstructUrl(finalConfiguration.BasePath),
                request.ConstructBody(),
                request.ConstructHeaders(finalConfiguration),
                finalConfiguration.RequestTimeout ?? _baseTimeout);

            var handledResponse = ResponseHandler.HandleAsyncResponse<List<Models.Server>>(response, statusCodeToTypeMap);
            return new Response<List<Models.Server>>(response, handledResponse);
        }


        /// <summary>
        /// Async Operation.
        /// Trigger action.
        /// </summary>
        /// <param name="request">Request object for TriggerServerAction.</param>
        /// <param name="operationConfiguration">Configuration for TriggerServerAction.</param>
        /// <returns>Task for a Response object containing status code, headers, and ActionResponse object.</returns>
        /// <exception cref="Unity.Services.Multiplay.Authoring.Editor.AdminApis.Servers.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
        public async Task<Response<ActionResponse>> TriggerServerActionAsync(Unity.Services.Multiplay.Authoring.Editor.AdminApis.Servers.Servers.TriggerServerActionRequest request,
            Configuration operationConfiguration = null)
        {
            var statusCodeToTypeMap = new Dictionary<string, System.Type>() { {"200", typeof(ActionResponse)   },{"400", typeof(InlineResponse400)   },{"401", typeof(InlineResponse401)   },{"403", typeof(InlineResponse403)   },{"404", typeof(InlineResponse404)   },{"424", typeof(InlineResponse424)   },{"429", typeof(InlineResponse429)   },{"500", typeof(InlineResponse500)   } };

            // Merge the operation/request level configuration with the client level configuration.
            var finalConfiguration = Configuration.MergeConfigurations(operationConfiguration, Configuration);

            var response = await HttpClient.MakeRequestAsync("POST",
                request.ConstructUrl(finalConfiguration.BasePath),
                request.ConstructBody(),
                request.ConstructHeaders(finalConfiguration),
                finalConfiguration.RequestTimeout ?? _baseTimeout);

            var handledResponse = ResponseHandler.HandleAsyncResponse<ActionResponse>(response, statusCodeToTypeMap);
            return new Response<ActionResponse>(response, handledResponse);
        }

    }
}
