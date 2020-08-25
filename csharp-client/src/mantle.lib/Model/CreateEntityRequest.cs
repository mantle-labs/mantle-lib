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
    /// CreateEntityRequest
    /// </summary>
    [DataContract]
    public partial class CreateEntityRequest :  IEquatable<CreateEntityRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEntityRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateEntityRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEntityRequest" /> class.
        /// </summary>
        /// <param name="OwnedIdentifier">OwnedIdentifier (required).</param>
        public CreateEntityRequest(string OwnedIdentifier = null)
        {
            // to ensure "OwnedIdentifier" is required (not null)
            if (OwnedIdentifier == null)
            {
                throw new InvalidDataException("OwnedIdentifier is a required property for CreateEntityRequest and cannot be null");
            }
            else
            {
                this.OwnedIdentifier = OwnedIdentifier;
            }
        }
        
        /// <summary>
        /// Gets or Sets OwnedIdentifier
        /// </summary>
        [DataMember(Name="ownedIdentifier", EmitDefaultValue=false)]
        public string OwnedIdentifier { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateEntityRequest {\n");
            sb.Append("  OwnedIdentifier: ").Append(OwnedIdentifier).Append("\n");
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
            return this.Equals(obj as CreateEntityRequest);
        }

        /// <summary>
        /// Returns true if CreateEntityRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of CreateEntityRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateEntityRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.OwnedIdentifier == other.OwnedIdentifier ||
                    this.OwnedIdentifier != null &&
                    this.OwnedIdentifier.Equals(other.OwnedIdentifier)
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
                if (this.OwnedIdentifier != null)
                    hash = hash * 59 + this.OwnedIdentifier.GetHashCode();
                return hash;
            }
        }
    }

}
