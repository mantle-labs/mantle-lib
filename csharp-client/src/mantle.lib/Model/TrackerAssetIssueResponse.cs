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
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = mantle.lib.Client.SwaggerDateConverter;

namespace mantle.lib.Model
{
    /// <summary>
    /// TrackerAssetIssueResponse
    /// </summary>
    [DataContract]
    public partial class TrackerAssetIssueResponse :  IEquatable<TrackerAssetIssueResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrackerAssetIssueResponse" /> class.
        /// </summary>
        /// <param name="issueRequest">issueRequest.</param>
        /// <param name="issueResult">issueResult.</param>
        public TrackerAssetIssueResponse(TrackerAssetIssueBulkRequest issueRequest = default(TrackerAssetIssueBulkRequest), MultiStatusResult issueResult = default(MultiStatusResult))
        {
            this.IssueRequest = issueRequest;
            this.IssueResult = issueResult;
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
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as TrackerAssetIssueResponse);
        }

        /// <summary>
        /// Returns true if TrackerAssetIssueResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of TrackerAssetIssueResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrackerAssetIssueResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IssueRequest == input.IssueRequest ||
                    (this.IssueRequest != null &&
                    this.IssueRequest.Equals(input.IssueRequest))
                ) && 
                (
                    this.IssueResult == input.IssueResult ||
                    (this.IssueResult != null &&
                    this.IssueResult.Equals(input.IssueResult))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.IssueRequest != null)
                    hashCode = hashCode * 59 + this.IssueRequest.GetHashCode();
                if (this.IssueResult != null)
                    hashCode = hashCode * 59 + this.IssueResult.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
