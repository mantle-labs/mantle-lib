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
    /// AssetTransaction
    /// </summary>
    [DataContract]
    public partial class AssetTransaction :  IEquatable<AssetTransaction>
    {
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
        /// Gets or Sets BlockchainStatus
        /// </summary>
        [DataMember(Name="blockchainStatus", EmitDefaultValue=false)]
        public BlockchainStatusEnum? BlockchainStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AssetTransaction" /> class.
        /// </summary>
        /// <param name="BlockchainStatus">BlockchainStatus.</param>
        /// <param name="AssetId">AssetId.</param>
        /// <param name="AssetDisplayName">AssetDisplayName.</param>
        /// <param name="MetaData">MetaData.</param>
        /// <param name="Id">Id.</param>
        /// <param name="BatchId">BatchId.</param>
        /// <param name="Amount">Amount.</param>
        /// <param name="SenderDisplayName">SenderDisplayName.</param>
        /// <param name="RecipientDisplayName">RecipientDisplayName.</param>
        /// <param name="Timestamp">Timestamp.</param>
        /// <param name="IsReverted">IsReverted.</param>
        public AssetTransaction(BlockchainStatusEnum? BlockchainStatus = null, string AssetId = null, string AssetDisplayName = null, string MetaData = null, string Id = null, string BatchId = null, double? Amount = null, string SenderDisplayName = null, string RecipientDisplayName = null, long? Timestamp = null, bool? IsReverted = null)
        {
            this.BlockchainStatus = BlockchainStatus;
            this.AssetId = AssetId;
            this.AssetDisplayName = AssetDisplayName;
            this.MetaData = MetaData;
            this.Id = Id;
            this.BatchId = BatchId;
            this.Amount = Amount;
            this.SenderDisplayName = SenderDisplayName;
            this.RecipientDisplayName = RecipientDisplayName;
            this.Timestamp = Timestamp;
            this.IsReverted = IsReverted;
        }
        
        /// <summary>
        /// Gets or Sets AssetId
        /// </summary>
        [DataMember(Name="assetId", EmitDefaultValue=false)]
        public string AssetId { get; set; }
        /// <summary>
        /// Gets or Sets AssetDisplayName
        /// </summary>
        [DataMember(Name="assetDisplayName", EmitDefaultValue=false)]
        public string AssetDisplayName { get; set; }
        /// <summary>
        /// Gets or Sets MetaData
        /// </summary>
        [DataMember(Name="metaData", EmitDefaultValue=false)]
        public string MetaData { get; set; }
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        /// <summary>
        /// Gets or Sets BatchId
        /// </summary>
        [DataMember(Name="batchId", EmitDefaultValue=false)]
        public string BatchId { get; set; }
        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public double? Amount { get; set; }
        /// <summary>
        /// Gets or Sets SenderDisplayName
        /// </summary>
        [DataMember(Name="senderDisplayName", EmitDefaultValue=false)]
        public string SenderDisplayName { get; set; }
        /// <summary>
        /// Gets or Sets RecipientDisplayName
        /// </summary>
        [DataMember(Name="recipientDisplayName", EmitDefaultValue=false)]
        public string RecipientDisplayName { get; set; }
        /// <summary>
        /// Gets or Sets Timestamp
        /// </summary>
        [DataMember(Name="timestamp", EmitDefaultValue=false)]
        public long? Timestamp { get; set; }
        /// <summary>
        /// Gets or Sets IsReverted
        /// </summary>
        [DataMember(Name="isReverted", EmitDefaultValue=false)]
        public bool? IsReverted { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AssetTransaction {\n");
            sb.Append("  BlockchainStatus: ").Append(BlockchainStatus).Append("\n");
            sb.Append("  AssetId: ").Append(AssetId).Append("\n");
            sb.Append("  AssetDisplayName: ").Append(AssetDisplayName).Append("\n");
            sb.Append("  MetaData: ").Append(MetaData).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  BatchId: ").Append(BatchId).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  SenderDisplayName: ").Append(SenderDisplayName).Append("\n");
            sb.Append("  RecipientDisplayName: ").Append(RecipientDisplayName).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  IsReverted: ").Append(IsReverted).Append("\n");
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
            return this.Equals(obj as AssetTransaction);
        }

        /// <summary>
        /// Returns true if AssetTransaction instances are equal
        /// </summary>
        /// <param name="other">Instance of AssetTransaction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AssetTransaction other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.BlockchainStatus == other.BlockchainStatus ||
                    this.BlockchainStatus != null &&
                    this.BlockchainStatus.Equals(other.BlockchainStatus)
                ) && 
                (
                    this.AssetId == other.AssetId ||
                    this.AssetId != null &&
                    this.AssetId.Equals(other.AssetId)
                ) && 
                (
                    this.AssetDisplayName == other.AssetDisplayName ||
                    this.AssetDisplayName != null &&
                    this.AssetDisplayName.Equals(other.AssetDisplayName)
                ) && 
                (
                    this.MetaData == other.MetaData ||
                    this.MetaData != null &&
                    this.MetaData.Equals(other.MetaData)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.BatchId == other.BatchId ||
                    this.BatchId != null &&
                    this.BatchId.Equals(other.BatchId)
                ) && 
                (
                    this.Amount == other.Amount ||
                    this.Amount != null &&
                    this.Amount.Equals(other.Amount)
                ) && 
                (
                    this.SenderDisplayName == other.SenderDisplayName ||
                    this.SenderDisplayName != null &&
                    this.SenderDisplayName.Equals(other.SenderDisplayName)
                ) && 
                (
                    this.RecipientDisplayName == other.RecipientDisplayName ||
                    this.RecipientDisplayName != null &&
                    this.RecipientDisplayName.Equals(other.RecipientDisplayName)
                ) && 
                (
                    this.Timestamp == other.Timestamp ||
                    this.Timestamp != null &&
                    this.Timestamp.Equals(other.Timestamp)
                ) && 
                (
                    this.IsReverted == other.IsReverted ||
                    this.IsReverted != null &&
                    this.IsReverted.Equals(other.IsReverted)
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
                if (this.BlockchainStatus != null)
                    hash = hash * 59 + this.BlockchainStatus.GetHashCode();
                if (this.AssetId != null)
                    hash = hash * 59 + this.AssetId.GetHashCode();
                if (this.AssetDisplayName != null)
                    hash = hash * 59 + this.AssetDisplayName.GetHashCode();
                if (this.MetaData != null)
                    hash = hash * 59 + this.MetaData.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.BatchId != null)
                    hash = hash * 59 + this.BatchId.GetHashCode();
                if (this.Amount != null)
                    hash = hash * 59 + this.Amount.GetHashCode();
                if (this.SenderDisplayName != null)
                    hash = hash * 59 + this.SenderDisplayName.GetHashCode();
                if (this.RecipientDisplayName != null)
                    hash = hash * 59 + this.RecipientDisplayName.GetHashCode();
                if (this.Timestamp != null)
                    hash = hash * 59 + this.Timestamp.GetHashCode();
                if (this.IsReverted != null)
                    hash = hash * 59 + this.IsReverted.GetHashCode();
                return hash;
            }
        }
    }

}
