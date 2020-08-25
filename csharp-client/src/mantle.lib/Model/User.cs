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
    /// User
    /// </summary>
    [DataContract]
    public partial class User :  IEquatable<User>
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
        /// Gets or Sets Roles
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RolesEnum
        {
            
            /// <summary>
            /// Enum MCKeeperAdmin for "MCKeeperAdmin"
            /// </summary>
            [EnumMember(Value = "MCKeeperAdmin")]
            MCKeeperAdmin,
            
            /// <summary>
            /// Enum MCBilling for "MCBilling"
            /// </summary>
            [EnumMember(Value = "MCBilling")]
            MCBilling,
            
            /// <summary>
            /// Enum MCUserAdmin for "MCUserAdmin"
            /// </summary>
            [EnumMember(Value = "MCUserAdmin")]
            MCUserAdmin,
            
            /// <summary>
            /// Enum MCTrackerAdmin for "MCTrackerAdmin"
            /// </summary>
            [EnumMember(Value = "MCTrackerAdmin")]
            MCTrackerAdmin,
            
            /// <summary>
            /// Enum MCTrackerUser for "MCTrackerUser"
            /// </summary>
            [EnumMember(Value = "MCTrackerUser")]
            MCTrackerUser,
            
            /// <summary>
            /// Enum MCSealerAdmin for "MCSealerAdmin"
            /// </summary>
            [EnumMember(Value = "MCSealerAdmin")]
            MCSealerAdmin,
            
            /// <summary>
            /// Enum MCSealerUser for "MCSealerUser"
            /// </summary>
            [EnumMember(Value = "MCSealerUser")]
            MCSealerUser,
            
            /// <summary>
            /// Enum MCAdmin for "MCAdmin"
            /// </summary>
            [EnumMember(Value = "MCAdmin")]
            MCAdmin,
            
            /// <summary>
            /// Enum MCBunkerUser for "MCBunkerUser"
            /// </summary>
            [EnumMember(Value = "MCBunkerUser")]
            MCBunkerUser,
            
            /// <summary>
            /// Enum MCBunkerAdmin for "MCBunkerAdmin"
            /// </summary>
            [EnumMember(Value = "MCBunkerAdmin")]
            MCBunkerAdmin
        }

        /// <summary>
        /// Gets or Sets BlockchainStatus
        /// </summary>
        [DataMember(Name="blockchainStatus", EmitDefaultValue=false)]
        public BlockchainStatusEnum? BlockchainStatus { get; set; }
        /// <summary>
        /// Gets or Sets Roles
        /// </summary>
        [DataMember(Name="roles", EmitDefaultValue=false)]
        public List<RolesEnum> Roles { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="User" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="ClientId">ClientId.</param>
        /// <param name="Email">Email.</param>
        /// <param name="FirstName">FirstName.</param>
        /// <param name="LastName">LastName.</param>
        /// <param name="IsEnabled">IsEnabled.</param>
        /// <param name="BlockchainStatus">BlockchainStatus.</param>
        /// <param name="Roles">Roles.</param>
        public User(string Id = null, string ClientId = null, string Email = null, string FirstName = null, string LastName = null, bool? IsEnabled = null, BlockchainStatusEnum? BlockchainStatus = null, List<RolesEnum> Roles = null)
        {
            this.Id = Id;
            this.ClientId = ClientId;
            this.Email = Email;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.IsEnabled = IsEnabled;
            this.BlockchainStatus = BlockchainStatus;
            this.Roles = Roles;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        /// <summary>
        /// Gets or Sets ClientId
        /// </summary>
        [DataMember(Name="clientId", EmitDefaultValue=false)]
        public string ClientId { get; set; }
        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
        /// <summary>
        /// Gets or Sets FirstName
        /// </summary>
        [DataMember(Name="firstName", EmitDefaultValue=false)]
        public string FirstName { get; set; }
        /// <summary>
        /// Gets or Sets LastName
        /// </summary>
        [DataMember(Name="lastName", EmitDefaultValue=false)]
        public string LastName { get; set; }
        /// <summary>
        /// Gets or Sets IsEnabled
        /// </summary>
        [DataMember(Name="isEnabled", EmitDefaultValue=false)]
        public bool? IsEnabled { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class User {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ClientId: ").Append(ClientId).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  IsEnabled: ").Append(IsEnabled).Append("\n");
            sb.Append("  BlockchainStatus: ").Append(BlockchainStatus).Append("\n");
            sb.Append("  Roles: ").Append(Roles).Append("\n");
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
            return this.Equals(obj as User);
        }

        /// <summary>
        /// Returns true if User instances are equal
        /// </summary>
        /// <param name="other">Instance of User to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(User other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.ClientId == other.ClientId ||
                    this.ClientId != null &&
                    this.ClientId.Equals(other.ClientId)
                ) && 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) && 
                (
                    this.FirstName == other.FirstName ||
                    this.FirstName != null &&
                    this.FirstName.Equals(other.FirstName)
                ) && 
                (
                    this.LastName == other.LastName ||
                    this.LastName != null &&
                    this.LastName.Equals(other.LastName)
                ) && 
                (
                    this.IsEnabled == other.IsEnabled ||
                    this.IsEnabled != null &&
                    this.IsEnabled.Equals(other.IsEnabled)
                ) && 
                (
                    this.BlockchainStatus == other.BlockchainStatus ||
                    this.BlockchainStatus != null &&
                    this.BlockchainStatus.Equals(other.BlockchainStatus)
                ) && 
                (
                    this.Roles == other.Roles ||
                    this.Roles != null &&
                    this.Roles.SequenceEqual(other.Roles)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.ClientId != null)
                    hash = hash * 59 + this.ClientId.GetHashCode();
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                if (this.FirstName != null)
                    hash = hash * 59 + this.FirstName.GetHashCode();
                if (this.LastName != null)
                    hash = hash * 59 + this.LastName.GetHashCode();
                if (this.IsEnabled != null)
                    hash = hash * 59 + this.IsEnabled.GetHashCode();
                if (this.BlockchainStatus != null)
                    hash = hash * 59 + this.BlockchainStatus.GetHashCode();
                if (this.Roles != null)
                    hash = hash * 59 + this.Roles.GetHashCode();
                return hash;
            }
        }
    }

}
