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
using Unity.Services.Multiplay.Authoring.Editor.AdminApis.Ccd.Models;
using Unity.Services.Multiplay.Authoring.Editor.AdminApis.Ccd.Http;
using Unity.Services.Multiplay.Authoring.Editor.AdminApis.Ccd.Content;

namespace Unity.Services.Multiplay.Authoring.Editor.AdminApis.Ccd.Apis.Content
{
    /// <summary>
    /// Interface for the ContentApiClient
    /// </summary>
    internal interface IContentApiClient
    {
            /// <summary>
            /// Async Operation.
            /// Create content upload for TUS.
            /// </summary>
            /// <param name="request">Request object for CreateContent.</param>
            /// <param name="operationConfiguration">Configuration for CreateContent.</param>
            /// <returns>Task for a Response object containing status code, headers.</returns>
            /// <exception cref="Unity.Services.Multiplay.Authoring.Editor.AdminApis.Ccd.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
            Task<Response> CreateContentAsync(Unity.Services.Multiplay.Authoring.Editor.AdminApis.Ccd.Content.CreateContentRequest request, Configuration operationConfiguration = null);

            /// <summary>
            /// Async Operation.
            /// Create content upload for TUS.
            /// </summary>
            /// <param name="request">Request object for CreateContentEnv.</param>
            /// <param name="operationConfiguration">Configuration for CreateContentEnv.</param>
            /// <returns>Task for a Response object containing status code, headers.</returns>
            /// <exception cref="Unity.Services.Multiplay.Authoring.Editor.AdminApis.Ccd.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
            Task<Response> CreateContentEnvAsync(Unity.Services.Multiplay.Authoring.Editor.AdminApis.Ccd.Content.CreateContentEnvRequest request, Configuration operationConfiguration = null);

            /// <summary>
            /// Async Operation.
            /// Get content by entryid.
            /// </summary>
            /// <param name="request">Request object for GetContent.</param>
            /// <param name="operationConfiguration">Configuration for GetContent.</param>
            /// <returns>Task for a Response object containing status code, headers, and System.IO.Stream object.</returns>
            /// <exception cref="Unity.Services.Multiplay.Authoring.Editor.AdminApis.Ccd.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
            Task<Response<System.IO.Stream>> GetContentAsync(Unity.Services.Multiplay.Authoring.Editor.AdminApis.Ccd.Content.GetContentRequest request, Configuration operationConfiguration = null);

            /// <summary>
            /// Async Operation.
            /// Get content by entryid.
            /// </summary>
            /// <param name="request">Request object for GetContentEnv.</param>
            /// <param name="operationConfiguration">Configuration for GetContentEnv.</param>
            /// <returns>Task for a Response object containing status code, headers, and System.IO.Stream object.</returns>
            /// <exception cref="Unity.Services.Multiplay.Authoring.Editor.AdminApis.Ccd.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
            Task<Response<System.IO.Stream>> GetContentEnvAsync(Unity.Services.Multiplay.Authoring.Editor.AdminApis.Ccd.Content.GetContentEnvRequest request, Configuration operationConfiguration = null);

            /// <summary>
            /// Async Operation.
            /// Get content status by entryid.
            /// </summary>
            /// <param name="request">Request object for GetContentStatus.</param>
            /// <param name="operationConfiguration">Configuration for GetContentStatus.</param>
            /// <returns>Task for a Response object containing status code, headers.</returns>
            /// <exception cref="Unity.Services.Multiplay.Authoring.Editor.AdminApis.Ccd.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
            Task<Response> GetContentStatusAsync(Unity.Services.Multiplay.Authoring.Editor.AdminApis.Ccd.Content.GetContentStatusRequest request, Configuration operationConfiguration = null);

            /// <summary>
            /// Async Operation.
            /// Get content status by entryid.
            /// </summary>
            /// <param name="request">Request object for GetContentStatusEnv.</param>
            /// <param name="operationConfiguration">Configuration for GetContentStatusEnv.</param>
            /// <returns>Task for a Response object containing status code, headers.</returns>
            /// <exception cref="Unity.Services.Multiplay.Authoring.Editor.AdminApis.Ccd.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
            Task<Response> GetContentStatusEnvAsync(Unity.Services.Multiplay.Authoring.Editor.AdminApis.Ccd.Content.GetContentStatusEnvRequest request, Configuration operationConfiguration = null);

            /// <summary>
            /// Async Operation.
            /// Get content status for version of entry.
            /// </summary>
            /// <param name="request">Request object for GetContentStatusVersion.</param>
            /// <param name="operationConfiguration">Configuration for GetContentStatusVersion.</param>
            /// <returns>Task for a Response object containing status code, headers.</returns>
            /// <exception cref="Unity.Services.Multiplay.Authoring.Editor.AdminApis.Ccd.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
            Task<Response> GetContentStatusVersionAsync(Unity.Services.Multiplay.Authoring.Editor.AdminApis.Ccd.Content.GetContentStatusVersionRequest request, Configuration operationConfiguration = null);

            /// <summary>
            /// Async Operation.
            /// Get content status for version of entry.
            /// </summary>
            /// <param name="request">Request object for GetContentStatusVersionEnv.</param>
            /// <param name="operationConfiguration">Configuration for GetContentStatusVersionEnv.</param>
            /// <returns>Task for a Response object containing status code, headers.</returns>
            /// <exception cref="Unity.Services.Multiplay.Authoring.Editor.AdminApis.Ccd.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
            Task<Response> GetContentStatusVersionEnvAsync(Unity.Services.Multiplay.Authoring.Editor.AdminApis.Ccd.Content.GetContentStatusVersionEnvRequest request, Configuration operationConfiguration = null);

            /// <summary>
            /// Async Operation.
            /// Get content for version of entry.
            /// </summary>
            /// <param name="request">Request object for GetContentVersion.</param>
            /// <param name="operationConfiguration">Configuration for GetContentVersion.</param>
            /// <returns>Task for a Response object containing status code, headers, and System.IO.Stream object.</returns>
            /// <exception cref="Unity.Services.Multiplay.Authoring.Editor.AdminApis.Ccd.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
            Task<Response<System.IO.Stream>> GetContentVersionAsync(Unity.Services.Multiplay.Authoring.Editor.AdminApis.Ccd.Content.GetContentVersionRequest request, Configuration operationConfiguration = null);

            /// <summary>
            /// Async Operation.
            /// Get content for version of entry.
            /// </summary>
            /// <param name="request">Request object for GetContentVersionEnv.</param>
            /// <param name="operationConfiguration">Configuration for GetContentVersionEnv.</param>
            /// <returns>Task for a Response object containing status code, headers, and System.IO.Stream object.</returns>
            /// <exception cref="Unity.Services.Multiplay.Authoring.Editor.AdminApis.Ccd.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
            Task<Response<System.IO.Stream>> GetContentVersionEnvAsync(Unity.Services.Multiplay.Authoring.Editor.AdminApis.Ccd.Content.GetContentVersionEnvRequest request, Configuration operationConfiguration = null);

            /// <summary>
            /// Async Operation.
            /// Upload content for entry.
            /// </summary>
            /// <param name="request">Request object for UploadContent.</param>
            /// <param name="operationConfiguration">Configuration for UploadContent.</param>
            /// <returns>Task for a Response object containing status code, headers.</returns>
            /// <exception cref="Unity.Services.Multiplay.Authoring.Editor.AdminApis.Ccd.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
            Task<Response> UploadContentAsync(Unity.Services.Multiplay.Authoring.Editor.AdminApis.Ccd.Content.UploadContentRequest request, Configuration operationConfiguration = null);

            /// <summary>
            /// Async Operation.
            /// Upload content for entry.
            /// </summary>
            /// <param name="request">Request object for UploadContentEnv.</param>
            /// <param name="operationConfiguration">Configuration for UploadContentEnv.</param>
            /// <returns>Task for a Response object containing status code, headers.</returns>
            /// <exception cref="Unity.Services.Multiplay.Authoring.Editor.AdminApis.Ccd.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
            Task<Response> UploadContentEnvAsync(Unity.Services.Multiplay.Authoring.Editor.AdminApis.Ccd.Content.UploadContentEnvRequest request, Configuration operationConfiguration = null);

    }

    ///<inheritdoc cref="IContentApiClient"/>
    internal class ContentApiClient : BaseApiClient, IContentApiClient
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
        /// ContentApiClient Constructor.
        /// </summary>
        /// <param name="httpClient">The HttpClient for ContentApiClient.</param>
        /// <param name="configuration"> ContentApiClient Configuration object.</param>
        public ContentApiClient(IHttpClient httpClient,
            Configuration configuration = null) : base(httpClient)
        {
            // We don't need to worry about the configuration being null at
            // this stage, we will check this in the accessor.
            _configuration = configuration;

            
        }


        /// <summary>
        /// Async Operation.
        /// Create content upload for TUS.
        /// </summary>
        /// <param name="request">Request object for CreateContent.</param>
        /// <param name="operationConfiguration">Configuration for CreateContent.</param>
        /// <returns>Task for a Response object containing status code, headers.</returns>
        /// <exception cref="Unity.Services.Multiplay.Authoring.Editor.AdminApis.Ccd.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
        public async Task<Response> CreateContentAsync(Unity.Services.Multiplay.Authoring.Editor.AdminApis.Ccd.Content.CreateContentRequest request,
            Configuration operationConfiguration = null)
        {
            var statusCodeToTypeMap = new Dictionary<string, System.Type>() { {"201",  null },{"400", typeof(InlineResponse400)   },{"401", typeof(InlineResponse401)   },{"403", typeof(InlineResponse403)   },{"404", typeof(InlineResponse404)   },{"429", typeof(InlineResponse429)   },{"500", typeof(InlineResponse500)   },{"503", typeof(InlineResponse503)   } };

            // Merge the operation/request level configuration with the client level configuration.
            var finalConfiguration = Configuration.MergeConfigurations(operationConfiguration, Configuration);

            var response = await HttpClient.MakeRequestAsync("POST",
                request.ConstructUrl(finalConfiguration.BasePath),
                request.ConstructBody(),
                request.ConstructHeaders(finalConfiguration),
                finalConfiguration.RequestTimeout ?? _baseTimeout);

            ResponseHandler.HandleAsyncResponse(response, statusCodeToTypeMap);
            return new Response(response);
        }


        /// <summary>
        /// Async Operation.
        /// Create content upload for TUS.
        /// </summary>
        /// <param name="request">Request object for CreateContentEnv.</param>
        /// <param name="operationConfiguration">Configuration for CreateContentEnv.</param>
        /// <returns>Task for a Response object containing status code, headers.</returns>
        /// <exception cref="Unity.Services.Multiplay.Authoring.Editor.AdminApis.Ccd.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
        public async Task<Response> CreateContentEnvAsync(Unity.Services.Multiplay.Authoring.Editor.AdminApis.Ccd.Content.CreateContentEnvRequest request,
            Configuration operationConfiguration = null)
        {
            var statusCodeToTypeMap = new Dictionary<string, System.Type>() { {"201",  null },{"400", typeof(InlineResponse400)   },{"401", typeof(InlineResponse401)   },{"403", typeof(InlineResponse403)   },{"404", typeof(InlineResponse404)   },{"429", typeof(InlineResponse429)   },{"500", typeof(InlineResponse500)   },{"503", typeof(InlineResponse503)   } };

            // Merge the operation/request level configuration with the client level configuration.
            var finalConfiguration = Configuration.MergeConfigurations(operationConfiguration, Configuration);

            var response = await HttpClient.MakeRequestAsync("POST",
                request.ConstructUrl(finalConfiguration.BasePath),
                request.ConstructBody(),
                request.ConstructHeaders(finalConfiguration),
                finalConfiguration.RequestTimeout ?? _baseTimeout);

            ResponseHandler.HandleAsyncResponse(response, statusCodeToTypeMap);
            return new Response(response);
        }


        /// <summary>
        /// Async Operation.
        /// Get content by entryid.
        /// </summary>
        /// <param name="request">Request object for GetContent.</param>
        /// <param name="operationConfiguration">Configuration for GetContent.</param>
        /// <returns>Task for a Response object containing status code, headers, and System.IO.Stream object.</returns>
        /// <exception cref="Unity.Services.Multiplay.Authoring.Editor.AdminApis.Ccd.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
        public async Task<Response<System.IO.Stream>> GetContentAsync(Unity.Services.Multiplay.Authoring.Editor.AdminApis.Ccd.Content.GetContentRequest request,
            Configuration operationConfiguration = null)
        {
            var statusCodeToTypeMap = new Dictionary<string, System.Type>() { {"200", typeof(System.IO.Stream)   },{"206", typeof(System.IO.Stream)   },{"307",  null },{"400", typeof(InlineResponse400)   },{"401", typeof(InlineResponse401)   },{"403", typeof(InlineResponse403)   },{"404", typeof(InlineResponse404)   },{"429", typeof(InlineResponse429)   },{"500", typeof(InlineResponse500)   },{"503", typeof(InlineResponse503)   } };

            // Merge the operation/request level configuration with the client level configuration.
            var finalConfiguration = Configuration.MergeConfigurations(operationConfiguration, Configuration);

            var response = await HttpClient.MakeRequestAsync("GET",
                request.ConstructUrl(finalConfiguration.BasePath),
                request.ConstructBody(),
                request.ConstructHeaders(finalConfiguration),
                finalConfiguration.RequestTimeout ?? _baseTimeout);

            var handledResponse = ResponseHandler.HandleAsyncResponse<System.IO.Stream>(response, statusCodeToTypeMap);
            return new Response<System.IO.Stream>(response, handledResponse);
        }


        /// <summary>
        /// Async Operation.
        /// Get content by entryid.
        /// </summary>
        /// <param name="request">Request object for GetContentEnv.</param>
        /// <param name="operationConfiguration">Configuration for GetContentEnv.</param>
        /// <returns>Task for a Response object containing status code, headers, and System.IO.Stream object.</returns>
        /// <exception cref="Unity.Services.Multiplay.Authoring.Editor.AdminApis.Ccd.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
        public async Task<Response<System.IO.Stream>> GetContentEnvAsync(Unity.Services.Multiplay.Authoring.Editor.AdminApis.Ccd.Content.GetContentEnvRequest request,
            Configuration operationConfiguration = null)
        {
            var statusCodeToTypeMap = new Dictionary<string, System.Type>() { {"200", typeof(System.IO.Stream)   },{"206", typeof(System.IO.Stream)   },{"307",  null },{"400", typeof(InlineResponse400)   },{"401", typeof(InlineResponse401)   },{"403", typeof(InlineResponse403)   },{"404", typeof(InlineResponse404)   },{"429", typeof(InlineResponse429)   },{"500", typeof(InlineResponse500)   },{"503", typeof(InlineResponse503)   } };

            // Merge the operation/request level configuration with the client level configuration.
            var finalConfiguration = Configuration.MergeConfigurations(operationConfiguration, Configuration);

            var response = await HttpClient.MakeRequestAsync("GET",
                request.ConstructUrl(finalConfiguration.BasePath),
                request.ConstructBody(),
                request.ConstructHeaders(finalConfiguration),
                finalConfiguration.RequestTimeout ?? _baseTimeout);

            var handledResponse = ResponseHandler.HandleAsyncResponse<System.IO.Stream>(response, statusCodeToTypeMap);
            return new Response<System.IO.Stream>(response, handledResponse);
        }


        /// <summary>
        /// Async Operation.
        /// Get content status by entryid.
        /// </summary>
        /// <param name="request">Request object for GetContentStatus.</param>
        /// <param name="operationConfiguration">Configuration for GetContentStatus.</param>
        /// <returns>Task for a Response object containing status code, headers.</returns>
        /// <exception cref="Unity.Services.Multiplay.Authoring.Editor.AdminApis.Ccd.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
        public async Task<Response> GetContentStatusAsync(Unity.Services.Multiplay.Authoring.Editor.AdminApis.Ccd.Content.GetContentStatusRequest request,
            Configuration operationConfiguration = null)
        {
            var statusCodeToTypeMap = new Dictionary<string, System.Type>() { {"200",  null },{"400", typeof(InlineResponse400)   },{"401", typeof(InlineResponse401)   },{"403", typeof(InlineResponse403)   },{"404", typeof(InlineResponse404)   },{"429", typeof(InlineResponse429)   },{"500", typeof(InlineResponse500)   },{"503", typeof(InlineResponse503)   } };

            // Merge the operation/request level configuration with the client level configuration.
            var finalConfiguration = Configuration.MergeConfigurations(operationConfiguration, Configuration);

            var response = await HttpClient.MakeRequestAsync("HEAD",
                request.ConstructUrl(finalConfiguration.BasePath),
                request.ConstructBody(),
                request.ConstructHeaders(finalConfiguration),
                finalConfiguration.RequestTimeout ?? _baseTimeout);

            ResponseHandler.HandleAsyncResponse(response, statusCodeToTypeMap);
            return new Response(response);
        }


        /// <summary>
        /// Async Operation.
        /// Get content status by entryid.
        /// </summary>
        /// <param name="request">Request object for GetContentStatusEnv.</param>
        /// <param name="operationConfiguration">Configuration for GetContentStatusEnv.</param>
        /// <returns>Task for a Response object containing status code, headers.</returns>
        /// <exception cref="Unity.Services.Multiplay.Authoring.Editor.AdminApis.Ccd.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
        public async Task<Response> GetContentStatusEnvAsync(Unity.Services.Multiplay.Authoring.Editor.AdminApis.Ccd.Content.GetContentStatusEnvRequest request,
            Configuration operationConfiguration = null)
        {
            var statusCodeToTypeMap = new Dictionary<string, System.Type>() { {"200",  null },{"400", typeof(InlineResponse400)   },{"401", typeof(InlineResponse401)   },{"403", typeof(InlineResponse403)   },{"404", typeof(InlineResponse404)   },{"429", typeof(InlineResponse429)   },{"500", typeof(InlineResponse500)   },{"503", typeof(InlineResponse503)   } };

            // Merge the operation/request level configuration with the client level configuration.
            var finalConfiguration = Configuration.MergeConfigurations(operationConfiguration, Configuration);

            var response = await HttpClient.MakeRequestAsync("HEAD",
                request.ConstructUrl(finalConfiguration.BasePath),
                request.ConstructBody(),
                request.ConstructHeaders(finalConfiguration),
                finalConfiguration.RequestTimeout ?? _baseTimeout);

            ResponseHandler.HandleAsyncResponse(response, statusCodeToTypeMap);
            return new Response(response);
        }


        /// <summary>
        /// Async Operation.
        /// Get content status for version of entry.
        /// </summary>
        /// <param name="request">Request object for GetContentStatusVersion.</param>
        /// <param name="operationConfiguration">Configuration for GetContentStatusVersion.</param>
        /// <returns>Task for a Response object containing status code, headers.</returns>
        /// <exception cref="Unity.Services.Multiplay.Authoring.Editor.AdminApis.Ccd.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
        public async Task<Response> GetContentStatusVersionAsync(Unity.Services.Multiplay.Authoring.Editor.AdminApis.Ccd.Content.GetContentStatusVersionRequest request,
            Configuration operationConfiguration = null)
        {
            var statusCodeToTypeMap = new Dictionary<string, System.Type>() { {"200",  null },{"400", typeof(InlineResponse400)   },{"401", typeof(InlineResponse401)   },{"403", typeof(InlineResponse403)   },{"404", typeof(InlineResponse404)   },{"429", typeof(InlineResponse429)   },{"500", typeof(InlineResponse500)   },{"503", typeof(InlineResponse503)   } };

            // Merge the operation/request level configuration with the client level configuration.
            var finalConfiguration = Configuration.MergeConfigurations(operationConfiguration, Configuration);

            var response = await HttpClient.MakeRequestAsync("HEAD",
                request.ConstructUrl(finalConfiguration.BasePath),
                request.ConstructBody(),
                request.ConstructHeaders(finalConfiguration),
                finalConfiguration.RequestTimeout ?? _baseTimeout);

            ResponseHandler.HandleAsyncResponse(response, statusCodeToTypeMap);
            return new Response(response);
        }


        /// <summary>
        /// Async Operation.
        /// Get content status for version of entry.
        /// </summary>
        /// <param name="request">Request object for GetContentStatusVersionEnv.</param>
        /// <param name="operationConfiguration">Configuration for GetContentStatusVersionEnv.</param>
        /// <returns>Task for a Response object containing status code, headers.</returns>
        /// <exception cref="Unity.Services.Multiplay.Authoring.Editor.AdminApis.Ccd.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
        public async Task<Response> GetContentStatusVersionEnvAsync(Unity.Services.Multiplay.Authoring.Editor.AdminApis.Ccd.Content.GetContentStatusVersionEnvRequest request,
            Configuration operationConfiguration = null)
        {
            var statusCodeToTypeMap = new Dictionary<string, System.Type>() { {"200",  null },{"400", typeof(InlineResponse400)   },{"401", typeof(InlineResponse401)   },{"403", typeof(InlineResponse403)   },{"404", typeof(InlineResponse404)   },{"429", typeof(InlineResponse429)   },{"500", typeof(InlineResponse500)   },{"503", typeof(InlineResponse503)   } };

            // Merge the operation/request level configuration with the client level configuration.
            var finalConfiguration = Configuration.MergeConfigurations(operationConfiguration, Configuration);

            var response = await HttpClient.MakeRequestAsync("HEAD",
                request.ConstructUrl(finalConfiguration.BasePath),
                request.ConstructBody(),
                request.ConstructHeaders(finalConfiguration),
                finalConfiguration.RequestTimeout ?? _baseTimeout);

            ResponseHandler.HandleAsyncResponse(response, statusCodeToTypeMap);
            return new Response(response);
        }


        /// <summary>
        /// Async Operation.
        /// Get content for version of entry.
        /// </summary>
        /// <param name="request">Request object for GetContentVersion.</param>
        /// <param name="operationConfiguration">Configuration for GetContentVersion.</param>
        /// <returns>Task for a Response object containing status code, headers, and System.IO.Stream object.</returns>
        /// <exception cref="Unity.Services.Multiplay.Authoring.Editor.AdminApis.Ccd.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
        public async Task<Response<System.IO.Stream>> GetContentVersionAsync(Unity.Services.Multiplay.Authoring.Editor.AdminApis.Ccd.Content.GetContentVersionRequest request,
            Configuration operationConfiguration = null)
        {
            var statusCodeToTypeMap = new Dictionary<string, System.Type>() { {"200", typeof(System.IO.Stream)   },{"206", typeof(System.IO.Stream)   },{"307",  null },{"400", typeof(InlineResponse400)   },{"401", typeof(InlineResponse401)   },{"403", typeof(InlineResponse403)   },{"404", typeof(InlineResponse404)   },{"429", typeof(InlineResponse429)   },{"500", typeof(InlineResponse500)   },{"503", typeof(InlineResponse503)   } };

            // Merge the operation/request level configuration with the client level configuration.
            var finalConfiguration = Configuration.MergeConfigurations(operationConfiguration, Configuration);

            var response = await HttpClient.MakeRequestAsync("GET",
                request.ConstructUrl(finalConfiguration.BasePath),
                request.ConstructBody(),
                request.ConstructHeaders(finalConfiguration),
                finalConfiguration.RequestTimeout ?? _baseTimeout);

            var handledResponse = ResponseHandler.HandleAsyncResponse<System.IO.Stream>(response, statusCodeToTypeMap);
            return new Response<System.IO.Stream>(response, handledResponse);
        }


        /// <summary>
        /// Async Operation.
        /// Get content for version of entry.
        /// </summary>
        /// <param name="request">Request object for GetContentVersionEnv.</param>
        /// <param name="operationConfiguration">Configuration for GetContentVersionEnv.</param>
        /// <returns>Task for a Response object containing status code, headers, and System.IO.Stream object.</returns>
        /// <exception cref="Unity.Services.Multiplay.Authoring.Editor.AdminApis.Ccd.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
        public async Task<Response<System.IO.Stream>> GetContentVersionEnvAsync(Unity.Services.Multiplay.Authoring.Editor.AdminApis.Ccd.Content.GetContentVersionEnvRequest request,
            Configuration operationConfiguration = null)
        {
            var statusCodeToTypeMap = new Dictionary<string, System.Type>() { {"200", typeof(System.IO.Stream)   },{"206", typeof(System.IO.Stream)   },{"307",  null },{"400", typeof(InlineResponse400)   },{"401", typeof(InlineResponse401)   },{"403", typeof(InlineResponse403)   },{"404", typeof(InlineResponse404)   },{"429", typeof(InlineResponse429)   },{"500", typeof(InlineResponse500)   },{"503", typeof(InlineResponse503)   } };

            // Merge the operation/request level configuration with the client level configuration.
            var finalConfiguration = Configuration.MergeConfigurations(operationConfiguration, Configuration);

            var response = await HttpClient.MakeRequestAsync("GET",
                request.ConstructUrl(finalConfiguration.BasePath),
                request.ConstructBody(),
                request.ConstructHeaders(finalConfiguration),
                finalConfiguration.RequestTimeout ?? _baseTimeout);

            var handledResponse = ResponseHandler.HandleAsyncResponse<System.IO.Stream>(response, statusCodeToTypeMap);
            return new Response<System.IO.Stream>(response, handledResponse);
        }


        /// <summary>
        /// Async Operation.
        /// Upload content for entry.
        /// </summary>
        /// <param name="request">Request object for UploadContent.</param>
        /// <param name="operationConfiguration">Configuration for UploadContent.</param>
        /// <returns>Task for a Response object containing status code, headers.</returns>
        /// <exception cref="Unity.Services.Multiplay.Authoring.Editor.AdminApis.Ccd.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
        public async Task<Response> UploadContentAsync(Unity.Services.Multiplay.Authoring.Editor.AdminApis.Ccd.Content.UploadContentRequest request,
            Configuration operationConfiguration = null)
        {
            var statusCodeToTypeMap = new Dictionary<string, System.Type>() { {"204",  null },{"400", typeof(InlineResponse400)   },{"401", typeof(InlineResponse401)   },{"403", typeof(InlineResponse403)   },{"404", typeof(InlineResponse404)   },{"429", typeof(InlineResponse429)   },{"500", typeof(InlineResponse500)   },{"503", typeof(InlineResponse503)   } };

            // Merge the operation/request level configuration with the client level configuration.
            var finalConfiguration = Configuration.MergeConfigurations(operationConfiguration, Configuration);

            var response = await HttpClient.MakeRequestAsync("PATCH",
                request.ConstructUrl(finalConfiguration.BasePath),
                request.ConstructBody(),
                request.ConstructHeaders(finalConfiguration),
                finalConfiguration.RequestTimeout ?? _baseTimeout,
                "BoundaryUploadContentBoundary");

            ResponseHandler.HandleAsyncResponse(response, statusCodeToTypeMap);
            return new Response(response);
        }


        /// <summary>
        /// Async Operation.
        /// Upload content for entry.
        /// </summary>
        /// <param name="request">Request object for UploadContentEnv.</param>
        /// <param name="operationConfiguration">Configuration for UploadContentEnv.</param>
        /// <returns>Task for a Response object containing status code, headers.</returns>
        /// <exception cref="Unity.Services.Multiplay.Authoring.Editor.AdminApis.Ccd.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
        public async Task<Response> UploadContentEnvAsync(Unity.Services.Multiplay.Authoring.Editor.AdminApis.Ccd.Content.UploadContentEnvRequest request,
            Configuration operationConfiguration = null)
        {
            var statusCodeToTypeMap = new Dictionary<string, System.Type>() { {"204",  null },{"400", typeof(InlineResponse400)   },{"401", typeof(InlineResponse401)   },{"403", typeof(InlineResponse403)   },{"404", typeof(InlineResponse404)   },{"429", typeof(InlineResponse429)   },{"500", typeof(InlineResponse500)   },{"503", typeof(InlineResponse503)   } };

            // Merge the operation/request level configuration with the client level configuration.
            var finalConfiguration = Configuration.MergeConfigurations(operationConfiguration, Configuration);

            var response = await HttpClient.MakeRequestAsync("PATCH",
                request.ConstructUrl(finalConfiguration.BasePath),
                request.ConstructBody(),
                request.ConstructHeaders(finalConfiguration),
                finalConfiguration.RequestTimeout ?? _baseTimeout,
                "BoundaryUploadContentEnvBoundary");

            ResponseHandler.HandleAsyncResponse(response, statusCodeToTypeMap);
            return new Response(response);
        }

    }
}