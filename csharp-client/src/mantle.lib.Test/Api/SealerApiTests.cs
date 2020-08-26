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
    ///  Class for testing SealerApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class SealerApiTests
    {
        private SealerApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new SealerApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of SealerApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' SealerApi
            //Assert.IsInstanceOfType(typeof(SealerApi), instance, "instance is a SealerApi");
        }

        
        /// <summary>
        /// Test CompareContract
        /// </summary>
        [Test]
        public void CompareContractTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string contractId = null;
            //System.IO.Stream file = null;
            //string productId = null;
            //string xApiKey = null;
            //bool? mustGenerateCompareResult = null;
            //var response = instance.CompareContract(contractId, file, productId, xApiKey, mustGenerateCompareResult);
            //Assert.IsInstanceOf<SealerBreadcrumbingCompareResponse> (response, "response is SealerBreadcrumbingCompareResponse");
        }
        
        /// <summary>
        /// Test CompareContractSignature
        /// </summary>
        [Test]
        public void CompareContractSignatureTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string contractId = null;
            //System.IO.Stream file = null;
            //string productId = null;
            //string xApiKey = null;
            //bool? mustGenerateCompareResult = null;
            //var response = instance.CompareContractSignature(contractId, file, productId, xApiKey, mustGenerateCompareResult);
            //Assert.IsInstanceOf<ContractSignatureDiffResponse> (response, "response is ContractSignatureDiffResponse");
        }
        
        /// <summary>
        /// Test CompareSignature
        /// </summary>
        [Test]
        public void CompareSignatureTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string signatureId = null;
            //System.IO.Stream file = null;
            //string productId = null;
            //string xApiKey = null;
            //bool? mustGenerateCompareResult = null;
            //var response = instance.CompareSignature(signatureId, file, productId, xApiKey, mustGenerateCompareResult);
            //Assert.IsInstanceOf<SealerBreadcrumbingCompareResponse> (response, "response is SealerBreadcrumbingCompareResponse");
        }
        
        /// <summary>
        /// Test CompareTemplate
        /// </summary>
        [Test]
        public void CompareTemplateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string templateId = null;
            //System.IO.Stream file = null;
            //string productId = null;
            //string xApiKey = null;
            //bool? mustGenerateCompareResult = null;
            //var response = instance.CompareTemplate(templateId, file, productId, xApiKey, mustGenerateCompareResult);
            //Assert.IsInstanceOf<SealerBreadcrumbingCompareResponse> (response, "response is SealerBreadcrumbingCompareResponse");
        }
        
        /// <summary>
        /// Test CreateContract
        /// </summary>
        [Test]
        public void CreateContractTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream file = null;
            //string displayName = null;
            //List<string> signerEmails = null;
            //List<string> signatures = null;
            //string productId = null;
            //string xApiKey = null;
            //string signatureRequestMessage = null;
            //string templateId = null;
            //var response = instance.CreateContract(file, displayName, signerEmails, signatures, productId, xApiKey, signatureRequestMessage, templateId);
            //Assert.IsInstanceOf<Contract> (response, "response is Contract");
        }
        
        /// <summary>
        /// Test CreateSignature
        /// </summary>
        [Test]
        public void CreateSignatureTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream file = null;
            //string productId = null;
            //string xApiKey = null;
            //var response = instance.CreateSignature(file, productId, xApiKey);
            //Assert.IsInstanceOf<Signature> (response, "response is Signature");
        }
        
        /// <summary>
        /// Test CreateTemplate
        /// </summary>
        [Test]
        public void CreateTemplateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream file = null;
            //string displayName = null;
            //string productId = null;
            //string xApiKey = null;
            //var response = instance.CreateTemplate(file, displayName, productId, xApiKey);
            //Assert.IsInstanceOf<Template> (response, "response is Template");
        }
        
        /// <summary>
        /// Test DeleteContract
        /// </summary>
        [Test]
        public void DeleteContractTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string contractId = null;
            //string productId = null;
            //string xApiKey = null;
            //instance.DeleteContract(contractId, productId, xApiKey);
            
        }
        
        /// <summary>
        /// Test DeleteTemplate
        /// </summary>
        [Test]
        public void DeleteTemplateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string templateId = null;
            //string productId = null;
            //string xApiKey = null;
            //instance.DeleteTemplate(templateId, productId, xApiKey);
            
        }
        
        /// <summary>
        /// Test GetAllContracts
        /// </summary>
        [Test]
        public void GetAllContractsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string productId = null;
            //string xApiKey = null;
            //int? limit = null;
            //int? offset = null;
            //var response = instance.GetAllContracts(productId, xApiKey, limit, offset);
            //Assert.IsInstanceOf<List<Contract>> (response, "response is List<Contract>");
        }
        
        /// <summary>
        /// Test GetAllSignatures
        /// </summary>
        [Test]
        public void GetAllSignaturesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string productId = null;
            //string xApiKey = null;
            //int? limit = null;
            //int? offset = null;
            //var response = instance.GetAllSignatures(productId, xApiKey, limit, offset);
            //Assert.IsInstanceOf<List<Contract>> (response, "response is List<Contract>");
        }
        
        /// <summary>
        /// Test GetAllTemplates
        /// </summary>
        [Test]
        public void GetAllTemplatesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string productId = null;
            //string xApiKey = null;
            //int? limit = null;
            //int? offset = null;
            //var response = instance.GetAllTemplates(productId, xApiKey, limit, offset);
            //Assert.IsInstanceOf<List<Template>> (response, "response is List<Template>");
        }
        
        /// <summary>
        /// Test GetAuthenticatedUserContracts
        /// </summary>
        [Test]
        public void GetAuthenticatedUserContractsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string productId = null;
            //string xApiKey = null;
            //int? limit = null;
            //int? offset = null;
            //var response = instance.GetAuthenticatedUserContracts(productId, xApiKey, limit, offset);
            //Assert.IsInstanceOf<List<Contract>> (response, "response is List<Contract>");
        }
        
        /// <summary>
        /// Test GetContractsByTemplateId
        /// </summary>
        [Test]
        public void GetContractsByTemplateIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string templateId = null;
            //string productId = null;
            //string xApiKey = null;
            //int? limit = null;
            //int? offset = null;
            //var response = instance.GetContractsByTemplateId(templateId, productId, xApiKey, limit, offset);
            //Assert.IsInstanceOf<List<Contract>> (response, "response is List<Contract>");
        }
        
        /// <summary>
        /// Test GetLinkToDownloadOriginalFile
        /// </summary>
        [Test]
        public void GetLinkToDownloadOriginalFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string fileId = null;
            //string productId = null;
            //string xApiKey = null;
            //var response = instance.GetLinkToDownloadOriginalFile(fileId, productId, xApiKey);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test GetTemplateById
        /// </summary>
        [Test]
        public void GetTemplateByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string templateId = null;
            //string productId = null;
            //string xApiKey = null;
            //var response = instance.GetTemplateById(templateId, productId, xApiKey);
            //Assert.IsInstanceOf<Template> (response, "response is Template");
        }
        
        /// <summary>
        /// Test SignContractWhenAuthenticated
        /// </summary>
        [Test]
        public void SignContractWhenAuthenticatedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string contractId = null;
            //System.IO.Stream signature = null;
            //System.IO.Stream contract = null;
            //bool? reuseLastSignature = null;
            //string productId = null;
            //string xApiKey = null;
            //instance.SignContractWhenAuthenticated(contractId, signature, contract, reuseLastSignature, productId, xApiKey);
            
        }
        
    }

}
