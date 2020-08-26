/* 
 * Mantle API
 *
 * Most endpoints require authentication with an <strong>API key</strong><br><br>                                         You must first authenticate with your account by logging in your account on <strong><a target='_blank' href='https://www.mantleblockchain.com'/>mantleblockchain.com</a></strong>.<br>                                         Then, you will need to navigate to the <strong>My API Key</strong> page in the Settings section.<br>                                         You need to have the role administrator of your organization to generate an <strong>API Key</strong>.<br><br>                                         Then use this <strong>API Key</strong> in all your requests with the following header:<br><br>                                         <strong>[ x-api-key: API_KEY ]</strong><br><br>For more information on the different product and more, you can refer to the <a target='_blank' href='https://docs.mantleblockchain.com/v1.0/documentation/home'><strong>knowledge base</strong></a>
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using mantle.lib.Client;
using mantle.lib.Model;

namespace mantle.lib.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IApiKeysApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Create an API key for a specific user
        /// </summary>
        /// <remarks>
        /// Requires the User Admin Role.
        /// </remarks>
        /// <exception cref="mantle.lib.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xApiKey"></param>
        /// <param name="request"> (optional)</param>
        /// <returns></returns>
        void CreateApiKey (string xApiKey, CreateApiKeyRequest request = null);

        /// <summary>
        /// Create an API key for a specific user
        /// </summary>
        /// <remarks>
        /// Requires the User Admin Role.
        /// </remarks>
        /// <exception cref="mantle.lib.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xApiKey"></param>
        /// <param name="request"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> CreateApiKeyWithHttpInfo (string xApiKey, CreateApiKeyRequest request = null);
        /// <summary>
        /// Delete the API key for a specific user
        /// </summary>
        /// <remarks>
        /// Requires the User Admin Role.
        /// </remarks>
        /// <exception cref="mantle.lib.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="xApiKey"></param>
        /// <returns></returns>
        void DeleteApiKey (string userId, string xApiKey);

        /// <summary>
        /// Delete the API key for a specific user
        /// </summary>
        /// <remarks>
        /// Requires the User Admin Role.
        /// </remarks>
        /// <exception cref="mantle.lib.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="xApiKey"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteApiKeyWithHttpInfo (string userId, string xApiKey);
        /// <summary>
        /// Get all generated api keys
        /// </summary>
        /// <remarks>
        /// Requires the User Admin Role.
        /// </remarks>
        /// <exception cref="mantle.lib.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xApiKey"></param>
        /// <returns>List&lt;AnonymousApiKeyResponse&gt;</returns>
        List<AnonymousApiKeyResponse> GetAllApiKeys (string xApiKey);

        /// <summary>
        /// Get all generated api keys
        /// </summary>
        /// <remarks>
        /// Requires the User Admin Role.
        /// </remarks>
        /// <exception cref="mantle.lib.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xApiKey"></param>
        /// <returns>ApiResponse of List&lt;AnonymousApiKeyResponse&gt;</returns>
        ApiResponse<List<AnonymousApiKeyResponse>> GetAllApiKeysWithHttpInfo (string xApiKey);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Create an API key for a specific user
        /// </summary>
        /// <remarks>
        /// Requires the User Admin Role.
        /// </remarks>
        /// <exception cref="mantle.lib.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xApiKey"></param>
        /// <param name="request"> (optional)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task CreateApiKeyAsync (string xApiKey, CreateApiKeyRequest request = null);

        /// <summary>
        /// Create an API key for a specific user
        /// </summary>
        /// <remarks>
        /// Requires the User Admin Role.
        /// </remarks>
        /// <exception cref="mantle.lib.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xApiKey"></param>
        /// <param name="request"> (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> CreateApiKeyAsyncWithHttpInfo (string xApiKey, CreateApiKeyRequest request = null);
        /// <summary>
        /// Delete the API key for a specific user
        /// </summary>
        /// <remarks>
        /// Requires the User Admin Role.
        /// </remarks>
        /// <exception cref="mantle.lib.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="xApiKey"></param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteApiKeyAsync (string userId, string xApiKey);

        /// <summary>
        /// Delete the API key for a specific user
        /// </summary>
        /// <remarks>
        /// Requires the User Admin Role.
        /// </remarks>
        /// <exception cref="mantle.lib.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="xApiKey"></param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteApiKeyAsyncWithHttpInfo (string userId, string xApiKey);
        /// <summary>
        /// Get all generated api keys
        /// </summary>
        /// <remarks>
        /// Requires the User Admin Role.
        /// </remarks>
        /// <exception cref="mantle.lib.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xApiKey"></param>
        /// <returns>Task of List&lt;AnonymousApiKeyResponse&gt;</returns>
        System.Threading.Tasks.Task<List<AnonymousApiKeyResponse>> GetAllApiKeysAsync (string xApiKey);

        /// <summary>
        /// Get all generated api keys
        /// </summary>
        /// <remarks>
        /// Requires the User Admin Role.
        /// </remarks>
        /// <exception cref="mantle.lib.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xApiKey"></param>
        /// <returns>Task of ApiResponse (List&lt;AnonymousApiKeyResponse&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<AnonymousApiKeyResponse>>> GetAllApiKeysAsyncWithHttpInfo (string xApiKey);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ApiKeysApi : IApiKeysApi
    {
        private mantle.lib.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiKeysApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ApiKeysApi(String basePath)
        {
            this.Configuration = new mantle.lib.Client.Configuration { BasePath = basePath };

            ExceptionFactory = mantle.lib.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiKeysApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ApiKeysApi(mantle.lib.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = mantle.lib.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = mantle.lib.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public mantle.lib.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public mantle.lib.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Create an API key for a specific user Requires the User Admin Role.
        /// </summary>
        /// <exception cref="mantle.lib.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xApiKey"></param>
        /// <param name="request"> (optional)</param>
        /// <returns></returns>
        public void CreateApiKey (string xApiKey, CreateApiKeyRequest request = null)
        {
             CreateApiKeyWithHttpInfo(xApiKey, request);
        }

        /// <summary>
        /// Create an API key for a specific user Requires the User Admin Role.
        /// </summary>
        /// <exception cref="mantle.lib.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xApiKey"></param>
        /// <param name="request"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> CreateApiKeyWithHttpInfo (string xApiKey, CreateApiKeyRequest request = null)
        {
            // verify the required parameter 'xApiKey' is set
            if (xApiKey == null)
                throw new ApiException(400, "Missing required parameter 'xApiKey' when calling ApiKeysApi->CreateApiKey");

            var localVarPath = "/apikeys";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (xApiKey != null) localVarHeaderParams.Add("x-api-key", this.Configuration.ApiClient.ParameterToString(xApiKey)); // header parameter
            if (request != null && request.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(request); // http body (model) parameter
            }
            else
            {
                localVarPostBody = request; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CreateApiKey", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Create an API key for a specific user Requires the User Admin Role.
        /// </summary>
        /// <exception cref="mantle.lib.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xApiKey"></param>
        /// <param name="request"> (optional)</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task CreateApiKeyAsync (string xApiKey, CreateApiKeyRequest request = null)
        {
             await CreateApiKeyAsyncWithHttpInfo(xApiKey, request);

        }

        /// <summary>
        /// Create an API key for a specific user Requires the User Admin Role.
        /// </summary>
        /// <exception cref="mantle.lib.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xApiKey"></param>
        /// <param name="request"> (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> CreateApiKeyAsyncWithHttpInfo (string xApiKey, CreateApiKeyRequest request = null)
        {
            // verify the required parameter 'xApiKey' is set
            if (xApiKey == null)
                throw new ApiException(400, "Missing required parameter 'xApiKey' when calling ApiKeysApi->CreateApiKey");

            var localVarPath = "/apikeys";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (xApiKey != null) localVarHeaderParams.Add("x-api-key", this.Configuration.ApiClient.ParameterToString(xApiKey)); // header parameter
            if (request != null && request.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(request); // http body (model) parameter
            }
            else
            {
                localVarPostBody = request; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CreateApiKey", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Delete the API key for a specific user Requires the User Admin Role.
        /// </summary>
        /// <exception cref="mantle.lib.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="xApiKey"></param>
        /// <returns></returns>
        public void DeleteApiKey (string userId, string xApiKey)
        {
             DeleteApiKeyWithHttpInfo(userId, xApiKey);
        }

        /// <summary>
        /// Delete the API key for a specific user Requires the User Admin Role.
        /// </summary>
        /// <exception cref="mantle.lib.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="xApiKey"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteApiKeyWithHttpInfo (string userId, string xApiKey)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling ApiKeysApi->DeleteApiKey");
            // verify the required parameter 'xApiKey' is set
            if (xApiKey == null)
                throw new ApiException(400, "Missing required parameter 'xApiKey' when calling ApiKeysApi->DeleteApiKey");

            var localVarPath = "/apikeys/{userId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (userId != null) localVarPathParams.Add("userId", this.Configuration.ApiClient.ParameterToString(userId)); // path parameter
            if (xApiKey != null) localVarHeaderParams.Add("x-api-key", this.Configuration.ApiClient.ParameterToString(xApiKey)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DeleteApiKey", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Delete the API key for a specific user Requires the User Admin Role.
        /// </summary>
        /// <exception cref="mantle.lib.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="xApiKey"></param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteApiKeyAsync (string userId, string xApiKey)
        {
             await DeleteApiKeyAsyncWithHttpInfo(userId, xApiKey);

        }

        /// <summary>
        /// Delete the API key for a specific user Requires the User Admin Role.
        /// </summary>
        /// <exception cref="mantle.lib.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="xApiKey"></param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteApiKeyAsyncWithHttpInfo (string userId, string xApiKey)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling ApiKeysApi->DeleteApiKey");
            // verify the required parameter 'xApiKey' is set
            if (xApiKey == null)
                throw new ApiException(400, "Missing required parameter 'xApiKey' when calling ApiKeysApi->DeleteApiKey");

            var localVarPath = "/apikeys/{userId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (userId != null) localVarPathParams.Add("userId", this.Configuration.ApiClient.ParameterToString(userId)); // path parameter
            if (xApiKey != null) localVarHeaderParams.Add("x-api-key", this.Configuration.ApiClient.ParameterToString(xApiKey)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DeleteApiKey", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Get all generated api keys Requires the User Admin Role.
        /// </summary>
        /// <exception cref="mantle.lib.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xApiKey"></param>
        /// <returns>List&lt;AnonymousApiKeyResponse&gt;</returns>
        public List<AnonymousApiKeyResponse> GetAllApiKeys (string xApiKey)
        {
             ApiResponse<List<AnonymousApiKeyResponse>> localVarResponse = GetAllApiKeysWithHttpInfo(xApiKey);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get all generated api keys Requires the User Admin Role.
        /// </summary>
        /// <exception cref="mantle.lib.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xApiKey"></param>
        /// <returns>ApiResponse of List&lt;AnonymousApiKeyResponse&gt;</returns>
        public ApiResponse< List<AnonymousApiKeyResponse> > GetAllApiKeysWithHttpInfo (string xApiKey)
        {
            // verify the required parameter 'xApiKey' is set
            if (xApiKey == null)
                throw new ApiException(400, "Missing required parameter 'xApiKey' when calling ApiKeysApi->GetAllApiKeys");

            var localVarPath = "/apikeys";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (xApiKey != null) localVarHeaderParams.Add("x-api-key", this.Configuration.ApiClient.ParameterToString(xApiKey)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetAllApiKeys", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<AnonymousApiKeyResponse>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<AnonymousApiKeyResponse>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<AnonymousApiKeyResponse>)));
        }

        /// <summary>
        /// Get all generated api keys Requires the User Admin Role.
        /// </summary>
        /// <exception cref="mantle.lib.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xApiKey"></param>
        /// <returns>Task of List&lt;AnonymousApiKeyResponse&gt;</returns>
        public async System.Threading.Tasks.Task<List<AnonymousApiKeyResponse>> GetAllApiKeysAsync (string xApiKey)
        {
             ApiResponse<List<AnonymousApiKeyResponse>> localVarResponse = await GetAllApiKeysAsyncWithHttpInfo(xApiKey);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get all generated api keys Requires the User Admin Role.
        /// </summary>
        /// <exception cref="mantle.lib.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xApiKey"></param>
        /// <returns>Task of ApiResponse (List&lt;AnonymousApiKeyResponse&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<AnonymousApiKeyResponse>>> GetAllApiKeysAsyncWithHttpInfo (string xApiKey)
        {
            // verify the required parameter 'xApiKey' is set
            if (xApiKey == null)
                throw new ApiException(400, "Missing required parameter 'xApiKey' when calling ApiKeysApi->GetAllApiKeys");

            var localVarPath = "/apikeys";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (xApiKey != null) localVarHeaderParams.Add("x-api-key", this.Configuration.ApiClient.ParameterToString(xApiKey)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetAllApiKeys", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<AnonymousApiKeyResponse>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<AnonymousApiKeyResponse>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<AnonymousApiKeyResponse>)));
        }

    }
}
