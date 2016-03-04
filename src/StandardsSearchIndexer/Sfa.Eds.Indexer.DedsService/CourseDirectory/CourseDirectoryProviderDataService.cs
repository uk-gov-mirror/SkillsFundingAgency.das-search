﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Sfa.Infrastructure
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    using Microsoft.Rest;

    using Newtonsoft.Json.Linq;

    using Sfa.Infrastructure.Models;

    public class CourseDirectoryProviderDataService : ServiceClient<CourseDirectoryProviderDataService>, ICourseDirectoryProviderDataService
    {
        public CourseDirectoryProviderDataService()
        {
            
        }

        /// <summary>
        ///     Initializes a new instance of the
        ///     CourseDirectoryProviderDataService class.
        /// </summary>
        /// <param name='handlers'>
        ///     Optional. The set of delegating handlers to insert in the http
        ///     client pipeline.
        /// </param>
        public CourseDirectoryProviderDataService(params DelegatingHandler[] handlers)
            : base(handlers)
        {
        }

        /// <summary>
        ///     Initializes a new instance of the
        ///     CourseDirectoryProviderDataService class.
        /// </summary>
        /// <param name='rootHandler'>
        ///     Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        ///     Optional. The set of delegating handlers to insert in the http
        ///     client pipeline.
        /// </param>
        public CourseDirectoryProviderDataService(HttpClientHandler rootHandler, params DelegatingHandler[] handlers)
            : base(rootHandler, handlers)
        {
        }

        /// <summary>
        ///     Initializes a new instance of the
        ///     CourseDirectoryProviderDataService class.
        /// </summary>
        /// <param name='baseUri'>
        ///     Optional. The base URI of the service.
        /// </param>
        /// <param name='handlers'>
        ///     Optional. The set of delegating handlers to insert in the http
        ///     client pipeline.
        /// </param>
        public CourseDirectoryProviderDataService(Uri baseUri, params DelegatingHandler[] handlers)
            : this(handlers)
        {
            if (baseUri == null)
            {
                throw new ArgumentNullException("baseUri");
            }
            BaseUri = baseUri;
        }

        /// <summary>
        ///     Initializes a new instance of the
        ///     CourseDirectoryProviderDataService class.
        /// </summary>
        /// <param name='credentials'>
        ///     Required. Credentials for authenticating with the service.
        /// </param>
        /// <param name='handlers'>
        ///     Optional. The set of delegating handlers to insert in the http
        ///     client pipeline.
        /// </param>
        public CourseDirectoryProviderDataService(ServiceClientCredentials credentials, params DelegatingHandler[] handlers)
            : this(handlers)
        {
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            Credentials = credentials;

            if (Credentials != null)
            {
                Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        ///     Initializes a new instance of the
        ///     CourseDirectoryProviderDataService class.
        /// </summary>
        /// <param name='baseUri'>
        ///     Optional. The base URI of the service.
        /// </param>
        /// <param name='credentials'>
        ///     Required. Credentials for authenticating with the service.
        /// </param>
        /// <param name='handlers'>
        ///     Optional. The set of delegating handlers to insert in the http
        ///     client pipeline.
        /// </param>
        public CourseDirectoryProviderDataService(Uri baseUri, ServiceClientCredentials credentials, params DelegatingHandler[] handlers)
            : this(handlers)
        {
            if (baseUri == null)
            {
                throw new ArgumentNullException("baseUri");
            }
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            BaseUri = baseUri;
            Credentials = credentials;

            if (Credentials != null)
            {
                Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        ///     The base URI of the service.
        /// </summary>
        public Uri BaseUri { get; set; }

        /// <summary>
        ///     Credentials for authenticating with the service.
        /// </summary>
        public ServiceClientCredentials Credentials { get; set; }

        /// <summary>
        ///     Provides the ability to retreive all providers that provide
        ///     training for standards and frameworks along with the locations and
        ///     areas that they offer to provide it.
        /// </summary>
        /// <param name='version'>
        ///     Optional. version of the api
        /// </param>
        /// <param name='cancellationToken'>
        ///     Cancellation token.
        /// </param>
        public async Task<HttpOperationResponse<IList<Provider>>> BulkprovidersWithOperationResponseAsync(
            int? version = null,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            // Tracing
            var shouldTrace = ServiceClientTracing.IsEnabled;
            string invocationId = null;
            if (shouldTrace)
            {
                invocationId = ServiceClientTracing.NextInvocationId.ToString();
                var tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("version", version);
                ServiceClientTracing.Enter(invocationId, this, "BulkprovidersAsync", tracingParameters);
            }

            // Construct URL
            var url = "";
            url = url + "/bulk/providers/";
            var queryParameters = new List<string>();
            if (version != null)
            {
                queryParameters.Add("version=" + Uri.EscapeDataString(version.Value.ToString()));
            }
            if (queryParameters.Count > 0)
            {
                url = url + "?" + string.Join("&", queryParameters);
            }
            var baseUrl = BaseUri.AbsoluteUri;
            // Trim '/' character from the end of baseUrl and beginning of url.
            if (baseUrl[baseUrl.Length - 1] == '/')
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            if (url[0] == '/')
            {
                url = url.Substring(1);
            }
            url = baseUrl + "/" + url;
            url = url.Replace(" ", "%20");

            // Create HTTP transport objects
            var httpRequest = new HttpRequestMessage();
            httpRequest.Method = HttpMethod.Get;
            httpRequest.RequestUri = new Uri(url);

            // Set Credentials
            if (Credentials != null)
            {
                cancellationToken.ThrowIfCancellationRequested();
                await Credentials.ProcessHttpRequestAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            }

            // Send Request
            if (shouldTrace)
            {
                ServiceClientTracing.SendRequest(invocationId, httpRequest);
            }
            cancellationToken.ThrowIfCancellationRequested();
            var httpResponse = await HttpClient.SendAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            if (shouldTrace)
            {
                ServiceClientTracing.ReceiveResponse(invocationId, httpResponse);
            }
            var statusCode = httpResponse.StatusCode;
            cancellationToken.ThrowIfCancellationRequested();
            var responseContent = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
            if (statusCode != HttpStatusCode.OK)
            {
                var errorModel = new Error();
                JToken responseDoc = null;
                if (string.IsNullOrEmpty(responseContent) == false)
                {
                    responseDoc = JToken.Parse(responseContent);
                }
                if (responseDoc != null)
                {
                    errorModel.DeserializeJson(responseDoc);
                }
                var ex = new HttpOperationException<Error>();
                ex.Request = httpRequest;
                ex.Response = httpResponse;
                ex.Body = errorModel;
                if (shouldTrace)
                {
                    ServiceClientTracing.Error(invocationId, ex);
                }
                throw ex;
            }

            // Create Result
            var result = new HttpOperationResponse<IList<Provider>>();
            result.Request = httpRequest;
            result.Response = httpResponse;

            // Deserialize Response
            if (statusCode == HttpStatusCode.OK)
            {
                IList<Provider> resultModel = new List<Provider>();
                JToken responseDoc = null;
                if (string.IsNullOrEmpty(responseContent) == false)
                {
                    responseDoc = JToken.Parse(responseContent);
                }
                if (responseDoc != null)
                {
                    resultModel = ProviderCollection.DeserializeJson(responseDoc);
                }
                result.Body = resultModel;
            }

            if (shouldTrace)
            {
                ServiceClientTracing.Exit(invocationId, result);
            }
            return result;
        }
    }
}