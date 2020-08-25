# mantle.lib.Api.BunkerApi

All URIs are relative to *http://localhost:5000/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DownloadFileById**](BunkerApi.md#downloadfilebyid) | **GET** /bunker/{productId}/files/{fileId} | [STORAGE] Download a specific file
[**GetAllFilesIds**](BunkerApi.md#getallfilesids) | **GET** /bunker/{productId}/files | [STORAGE] Get all files
[**GetFileStatus**](BunkerApi.md#getfilestatus) | **GET** /bunker/{productId}/files/status/{fileId} | [STORAGE] Get status for the specific file id
[**PostFile**](BunkerApi.md#postfile) | **POST** /bunker/{productId}/files | [STORAGE] Upload a file


<a name="downloadfilebyid"></a>
# **DownloadFileById**
> System.IO.Stream DownloadFileById (string fileId, string productId, string xApiKey)

[STORAGE] Download a specific file

The file will be recreated from multiple shards than it's fingerprint will be compared with the on-chain reference to ensure integrity.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Api;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class DownloadFileByIdExample
    {
        public void main()
        {
            
            var apiInstance = new BunkerApi();
            var fileId = fileId_example;  // string | 
            var productId = productId_example;  // string | 
            var xApiKey = xApiKey_example;  // string |  (default to )

            try
            {
                // [STORAGE] Download a specific file
                System.IO.Stream result = apiInstance.DownloadFileById(fileId, productId, xApiKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BunkerApi.DownloadFileById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fileId** | **string**|  | 
 **productId** | **string**|  | 
 **xApiKey** | **string**|  | [default to ]

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallfilesids"></a>
# **GetAllFilesIds**
> List<BunkerFileResp> GetAllFilesIds (string productId, string xApiKey)

[STORAGE] Get all files

Get all the files stored in a Bunker.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Api;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class GetAllFilesIdsExample
    {
        public void main()
        {
            
            var apiInstance = new BunkerApi();
            var productId = productId_example;  // string | 
            var xApiKey = xApiKey_example;  // string |  (default to )

            try
            {
                // [STORAGE] Get all files
                List&lt;BunkerFileResp&gt; result = apiInstance.GetAllFilesIds(productId, xApiKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BunkerApi.GetAllFilesIds: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **productId** | **string**|  | 
 **xApiKey** | **string**|  | [default to ]

### Return type

[**List<BunkerFileResp>**](BunkerFileResp.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfilestatus"></a>
# **GetFileStatus**
> List<BunkerFileResp> GetFileStatus (string fileId, string productId, string xApiKey)

[STORAGE] Get status for the specific file id

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Api;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class GetFileStatusExample
    {
        public void main()
        {
            
            var apiInstance = new BunkerApi();
            var fileId = fileId_example;  // string | 
            var productId = productId_example;  // string | 
            var xApiKey = xApiKey_example;  // string |  (default to )

            try
            {
                // [STORAGE] Get status for the specific file id
                List&lt;BunkerFileResp&gt; result = apiInstance.GetFileStatus(fileId, productId, xApiKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BunkerApi.GetFileStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fileId** | **string**|  | 
 **productId** | **string**|  | 
 **xApiKey** | **string**|  | [default to ]

### Return type

[**List<BunkerFileResp>**](BunkerFileResp.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postfile"></a>
# **PostFile**
> BunkerCreateFileResp PostFile (System.IO.Stream file, string productId, string xApiKey, string displayName = null)

[STORAGE] Upload a file

Files are currently limited to 500 Megabytes (500MB) in size.   This will fragment the file and store it onto multiple cloud providers.  A fingerprint of the file will also be create and store on-chain for further integrity reference.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Api;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class PostFileExample
    {
        public void main()
        {
            
            var apiInstance = new BunkerApi();
            var file = new System.IO.Stream(); // System.IO.Stream | The file to upload. How http file upload works: https://goo.gl/UYQ2nX
            var productId = productId_example;  // string | 
            var xApiKey = xApiKey_example;  // string |  (default to )
            var displayName = displayName_example;  // string |  (optional) 

            try
            {
                // [STORAGE] Upload a file
                BunkerCreateFileResp result = apiInstance.PostFile(file, productId, xApiKey, displayName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BunkerApi.PostFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **file** | **System.IO.Stream**| The file to upload. How http file upload works: https://goo.gl/UYQ2nX | 
 **productId** | **string**|  | 
 **xApiKey** | **string**|  | [default to ]
 **displayName** | **string**|  | [optional] 

### Return type

[**BunkerCreateFileResp**](BunkerCreateFileResp.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

