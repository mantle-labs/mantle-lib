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

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace mantle.lib.Model
{
    /// <summary>
    /// TrackerAssetIssueResponse
    /// </summary>
    [DataContract]
    public partial class TrackerAssetIssueResponse :  IEquatable<TrackerAssetIssueResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrackerAssetIssueResponse" /> class.
        /// </summary>
        /// <param name="IssueRequest">IssueRequest.</param>
        /// <param name="IssueResult">IssueResult.</param>
        public TrackerAssetIssueResponse(TrackerAssetIssueBulkRequest IssueRequest = null, MultiStatusResult IssueResult = null)
        {
            this.IssueRequest = IssueRequest;
            this.IssueResult = IssueResult;
        }
        
        /// <summary>
        /// Gets or Sets IssueRequest
        /// </summary>
        [DataMember(Name="issueRequest", EmitDefaultValue=false)]
        public TrackerAssetIssueBulkRequest IssueRequest { get; set; }
        /// <summary>
        /// Gets or Sets IssueResult
        /// </summary>
        [DataMember(Name="issueResult", EmitDefaultValue=false)]
        public MultiStatusResult IssueResult { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TrackerAssetIssueResponse {\n");
            sb.Append("  IssueRequest: ").Append(IssueRequest).Append("\n");
            sb.Append("  IssueResult: ").Append(IssueResult).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as TrackerAssetIssueResponse);
        }

        /// <summary>
        /// Returns true if TrackerAssetIssueResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of TrackerAssetIssueResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrackerAssetIssueResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IssueRequest == other.IssueRequest ||
                    this.IssueRequest != null &&
                    this.IssueRequest.Equals(other.IssueRequest)
                ) && 
                (
                    this.IssueResult == other.IssueResult ||
                    this.IssueResult != null &&
                    this.IssueResult.Equals(other.IssueResult)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.IssueRequest != null)
                    hash = hash * 59 + this.IssueRequest.GetHashCode();
                if (this.IssueResult != null)
                    hash = hash * 59 + this.IssueResult.GetHashCode();
                return hash;
            }
        }
    }

}
