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
    /// ProductMenuOption
    /// </summary>
    [DataContract]
    public partial class ProductMenuOption :  IEquatable<ProductMenuOption>
    {
        /// <summary>
        /// Gets or Sets Product
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ProductEnum
        {
            
            /// <summary>
            /// Enum Tracker for "Tracker"
            /// </summary>
            [EnumMember(Value = "Tracker")]
            Tracker,
            
            /// <summary>
            /// Enum Keeper for "Keeper"
            /// </summary>
            [EnumMember(Value = "Keeper")]
            Keeper,
            
            /// <summary>
            /// Enum Sealer for "Sealer"
            /// </summary>
            [EnumMember(Value = "Sealer")]
            Sealer,
            
            /// <summary>
            /// Enum Bunker for "Bunker"
            /// </summary>
            [EnumMember(Value = "Bunker")]
            Bunker
        }

        /// <summary>
        /// Gets or Sets Product
        /// </summary>
        [DataMember(Name="product", EmitDefaultValue=false)]
        public ProductEnum? Product { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductMenuOption" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Name">Name.</param>
        /// <param name="Product">Product.</param>
        /// <param name="Available">Available.</param>
        public ProductMenuOption(string Id = null, string Name = null, ProductEnum? Product = null, bool? Available = null)
        {
            this.Id = Id;
            this.Name = Name;
            this.Product = Product;
            this.Available = Available;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Gets or Sets Available
        /// </summary>
        [DataMember(Name="available", EmitDefaultValue=false)]
        public bool? Available { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProductMenuOption {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Product: ").Append(Product).Append("\n");
            sb.Append("  Available: ").Append(Available).Append("\n");
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
            return this.Equals(obj as ProductMenuOption);
        }

        /// <summary>
        /// Returns true if ProductMenuOption instances are equal
        /// </summary>
        /// <param name="other">Instance of ProductMenuOption to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProductMenuOption other)
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
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Product == other.Product ||
                    this.Product != null &&
                    this.Product.Equals(other.Product)
                ) && 
                (
                    this.Available == other.Available ||
                    this.Available != null &&
                    this.Available.Equals(other.Available)
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
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Product != null)
                    hash = hash * 59 + this.Product.GetHashCode();
                if (this.Available != null)
                    hash = hash * 59 + this.Available.GetHashCode();
                return hash;
            }
        }
    }

}
