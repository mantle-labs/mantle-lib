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
    /// Contract
    /// </summary>
    [DataContract]
    public partial class Contract :  IEquatable<Contract>
    {
        /// <summary>
        /// Gets or Sets ContractStatus
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ContractStatusEnum
        {
            
            /// <summary>
            /// Enum Unsigned for "Unsigned"
            /// </summary>
            [EnumMember(Value = "Unsigned")]
            Unsigned,
            
            /// <summary>
            /// Enum PartiallySigned for "PartiallySigned"
            /// </summary>
            [EnumMember(Value = "PartiallySigned")]
            PartiallySigned,
            
            /// <summary>
            /// Enum CurrentlySigning for "CurrentlySigning"
            /// </summary>
            [EnumMember(Value = "CurrentlySigning")]
            CurrentlySigning,
            
            /// <summary>
            /// Enum Signed for "Signed"
            /// </summary>
            [EnumMember(Value = "Signed")]
            Signed
        }

        /// <summary>
        /// Gets or Sets BlockchainStatus
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum BlockchainStatusEnum
        {
            
            /// <summary>
            /// Enum Unconfirmed for "Unconfirmed"
            /// </summary>
            [EnumMember(Value = "Unconfirmed")]
            Unconfirmed,
            
            /// <summary>
            /// Enum Confirmed for "Confirmed"
            /// </summary>
            [EnumMember(Value = "Confirmed")]
            Confirmed,
            
            /// <summary>
            /// Enum Corrupted for "Corrupted"
            /// </summary>
            [EnumMember(Value = "Corrupted")]
            Corrupted
        }

        /// <summary>
        /// Gets or Sets ContractStatus
        /// </summary>
        [DataMember(Name="contractStatus", EmitDefaultValue=false)]
        public ContractStatusEnum? ContractStatus { get; set; }
        /// <summary>
        /// Gets or Sets BlockchainStatus
        /// </summary>
        [DataMember(Name="blockchainStatus", EmitDefaultValue=false)]
        public BlockchainStatusEnum? BlockchainStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Contract" /> class.
        /// </summary>
        /// <param name="ContractStatus">ContractStatus.</param>
        /// <param name="SignerIdentifiers">SignerIdentifiers.</param>
        /// <param name="Id">Id.</param>
        /// <param name="BlockchainStatus">BlockchainStatus.</param>
        /// <param name="OwnerEmail">OwnerEmail.</param>
        /// <param name="DisplayName">DisplayName.</param>
        /// <param name="CreationDate">CreationDate.</param>
        /// <param name="IsDeleted">IsDeleted.</param>
        public Contract(ContractStatusEnum? ContractStatus = null, List<string> SignerIdentifiers = null, string Id = null, BlockchainStatusEnum? BlockchainStatus = null, string OwnerEmail = null, string DisplayName = null, DateTime? CreationDate = null, bool? IsDeleted = null)
        {
            this.ContractStatus = ContractStatus;
            this.SignerIdentifiers = SignerIdentifiers;
            this.Id = Id;
            this.BlockchainStatus = BlockchainStatus;
            this.OwnerEmail = OwnerEmail;
            this.DisplayName = DisplayName;
            this.CreationDate = CreationDate;
            this.IsDeleted = IsDeleted;
        }
        
        /// <summary>
        /// Gets or Sets SignerIdentifiers
        /// </summary>
        [DataMember(Name="signerIdentifiers", EmitDefaultValue=false)]
        public List<string> SignerIdentifiers { get; set; }
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        /// <summary>
        /// Gets or Sets OwnerEmail
        /// </summary>
        [DataMember(Name="ownerEmail", EmitDefaultValue=false)]
        public string OwnerEmail { get; set; }
        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name="displayName", EmitDefaultValue=false)]
        public string DisplayName { get; set; }
        /// <summary>
        /// Gets or Sets CreationDate
        /// </summary>
        [DataMember(Name="creationDate", EmitDefaultValue=false)]
        public DateTime? CreationDate { get; set; }
        /// <summary>
        /// Gets or Sets IsDeleted
        /// </summary>
        [DataMember(Name="isDeleted", EmitDefaultValue=false)]
        public bool? IsDeleted { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Contract {\n");
            sb.Append("  ContractStatus: ").Append(ContractStatus).Append("\n");
            sb.Append("  SignerIdentifiers: ").Append(SignerIdentifiers).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  BlockchainStatus: ").Append(BlockchainStatus).Append("\n");
            sb.Append("  OwnerEmail: ").Append(OwnerEmail).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  CreationDate: ").Append(CreationDate).Append("\n");
            sb.Append("  IsDeleted: ").Append(IsDeleted).Append("\n");
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
            return this.Equals(obj as Contract);
        }

        /// <summary>
        /// Returns true if Contract instances are equal
        /// </summary>
        /// <param name="other">Instance of Contract to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Contract other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ContractStatus == other.ContractStatus ||
                    this.ContractStatus != null &&
                    this.ContractStatus.Equals(other.ContractStatus)
                ) && 
                (
                    this.SignerIdentifiers == other.SignerIdentifiers ||
                    this.SignerIdentifiers != null &&
                    this.SignerIdentifiers.SequenceEqual(other.SignerIdentifiers)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.BlockchainStatus == other.BlockchainStatus ||
                    this.BlockchainStatus != null &&
                    this.BlockchainStatus.Equals(other.BlockchainStatus)
                ) && 
                (
                    this.OwnerEmail == other.OwnerEmail ||
                    this.OwnerEmail != null &&
                    this.OwnerEmail.Equals(other.OwnerEmail)
                ) && 
                (
                    this.DisplayName == other.DisplayName ||
                    this.DisplayName != null &&
                    this.DisplayName.Equals(other.DisplayName)
                ) && 
                (
                    this.CreationDate == other.CreationDate ||
                    this.CreationDate != null &&
                    this.CreationDate.Equals(other.CreationDate)
                ) && 
                (
                    this.IsDeleted == other.IsDeleted ||
                    this.IsDeleted != null &&
                    this.IsDeleted.Equals(other.IsDeleted)
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
                if (this.ContractStatus != null)
                    hash = hash * 59 + this.ContractStatus.GetHashCode();
                if (this.SignerIdentifiers != null)
                    hash = hash * 59 + this.SignerIdentifiers.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.BlockchainStatus != null)
                    hash = hash * 59 + this.BlockchainStatus.GetHashCode();
                if (this.OwnerEmail != null)
                    hash = hash * 59 + this.OwnerEmail.GetHashCode();
                if (this.DisplayName != null)
                    hash = hash * 59 + this.DisplayName.GetHashCode();
                if (this.CreationDate != null)
                    hash = hash * 59 + this.CreationDate.GetHashCode();
                if (this.IsDeleted != null)
                    hash = hash * 59 + this.IsDeleted.GetHashCode();
                return hash;
            }
        }
    }

}
