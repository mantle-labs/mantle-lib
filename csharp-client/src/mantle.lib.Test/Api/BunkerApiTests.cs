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
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using mantle.lib.Client;
using mantle.lib.Api;
using mantle.lib.Model;

namespace mantle.lib.Test
{
    /// <summary>
    ///  Class for testing BunkerApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class BunkerApiTests
    {
        private BunkerApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new BunkerApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of BunkerApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' BunkerApi
            //Assert.IsInstanceOfType(typeof(BunkerApi), instance, "instance is a BunkerApi");
        }

        
        /// <summary>
        /// Test DownloadFileById
        /// </summary>
        [Test]
        public void DownloadFileByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string fileId = null;
            //string productId = null;
            //string xApiKey = null;
            //var response = instance.DownloadFileById(fileId, productId, xApiKey);
            //Assert.IsInstanceOf<System.IO.Stream> (response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test GetAllFilesIds
        /// </summary>
        [Test]
        public void GetAllFilesIdsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string productId = null;
            //string xApiKey = null;
            //var response = instance.GetAllFilesIds(productId, xApiKey);
            //Assert.IsInstanceOf<List<BunkerFileResp>> (response, "response is List<BunkerFileResp>");
        }
        
        /// <summary>
        /// Test GetFileStatus
        /// </summary>
        [Test]
        public void GetFileStatusTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string fileId = null;
            //string productId = null;
            //string xApiKey = null;
            //var response = instance.GetFileStatus(fileId, productId, xApiKey);
            //Assert.IsInstanceOf<List<BunkerFileResp>> (response, "response is List<BunkerFileResp>");
        }
        
        /// <summary>
        /// Test PostFile
        /// </summary>
        [Test]
        public void PostFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream file = null;
            //string productId = null;
            //string xApiKey = null;
            //string displayName = null;
            //var response = instance.PostFile(file, productId, xApiKey, displayName);
            //Assert.IsInstanceOf<BunkerCreateFileResp> (response, "response is BunkerCreateFileResp");
        }
        
    }

}
