/* 
 * Mantle API
 *
 * Most endpoints require authentication with an <strong>API key</strong><br><br>                                         You must first authenticate with your account by logging in your account on <strong><a target='_blank' href='https://www.mantleblockchain.com'/>mantleblockchain.com</a></strong>.<br>                                         Then, you will need to navigate to the <strong>My API Key</strong> page in the Settings section.<br>                                         You need to have the role administrator of your organization to generate an <strong>API Key</strong>.<br><br>                                         Then use this <strong>API Key</strong> in all your requests with the following header:<br><br>                                         <strong>[ x-api-key: API_KEY ]</strong><br><br>For more information on the different product and more, you can refer to the <a target='_blank' href='https://docs.mantleblockchain.com/v1.0/documentation/home'><strong>knowledge base</strong></a>
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using mantle.lib.Api;
using mantle.lib.Model;
using mantle.lib.Client;
using System.Reflection;

namespace mantle.lib.Test
{
    /// <summary>
    ///  Class for testing KeeperFile
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class KeeperFileTests
    {
        // TODO uncomment below to declare an instance variable for KeeperFile
        //private KeeperFile instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of KeeperFile
            //instance = new KeeperFile();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of KeeperFile
        /// </summary>
        [Test]
        public void KeeperFileInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" KeeperFile
            //Assert.IsInstanceOfType<KeeperFile> (instance, "variable 'instance' is a KeeperFile");
        }

        /// <summary>
        /// Test the property 'Tag'
        /// </summary>
        [Test]
        public void TagTest()
        {
            // TODO unit test for the property 'Tag'
        }
        /// <summary>
        /// Test the property 'FileType'
        /// </summary>
        [Test]
        public void FileTypeTest()
        {
            // TODO unit test for the property 'FileType'
        }
        /// <summary>
        /// Test the property 'AccuracyLevel'
        /// </summary>
        [Test]
        public void AccuracyLevelTest()
        {
            // TODO unit test for the property 'AccuracyLevel'
        }
        /// <summary>
        /// Test the property 'Id'
        /// </summary>
        [Test]
        public void IdTest()
        {
            // TODO unit test for the property 'Id'
        }
        /// <summary>
        /// Test the property 'BlockchainStatus'
        /// </summary>
        [Test]
        public void BlockchainStatusTest()
        {
            // TODO unit test for the property 'BlockchainStatus'
        }
        /// <summary>
        /// Test the property 'OwnerEmail'
        /// </summary>
        [Test]
        public void OwnerEmailTest()
        {
            // TODO unit test for the property 'OwnerEmail'
        }
        /// <summary>
        /// Test the property 'DisplayName'
        /// </summary>
        [Test]
        public void DisplayNameTest()
        {
            // TODO unit test for the property 'DisplayName'
        }
        /// <summary>
        /// Test the property 'CreationDate'
        /// </summary>
        [Test]
        public void CreationDateTest()
        {
            // TODO unit test for the property 'CreationDate'
        }
        /// <summary>
        /// Test the property 'IsDeleted'
        /// </summary>
        [Test]
        public void IsDeletedTest()
        {
            // TODO unit test for the property 'IsDeleted'
        }

    }

}
