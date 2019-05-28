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
    /// ProductMenuOption
    /// </summary>
    [DataContract]
    public partial class ProductMenuOption :  IEquatable<ProductMenuOption>, IValidatableObject
    {
        /// <summary>
        /// Defines Product
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ProductEnum
        {
            
            /// <summary>
            /// Enum Tracker for value: Tracker
            /// </summary>
            [EnumMember(Value = "Tracker")]
            Tracker = 1,
            
            /// <summary>
            /// Enum Keeper for value: Keeper
            /// </summary>
            [EnumMember(Value = "Keeper")]
            Keeper = 2,
            
            /// <summary>
            /// Enum Sealer for value: Sealer
            /// </summary>
            [EnumMember(Value = "Sealer")]
            Sealer = 3
        }

        /// <summary>
        /// Gets or Sets Product
        /// </summary>
        [DataMember(Name="product", EmitDefaultValue=false)]
        public ProductEnum? Product { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductMenuOption" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="product">product.</param>
        /// <param name="available">available.</param>
        public ProductMenuOption(string id = default(string), string name = default(string), ProductEnum? product = default(ProductEnum?), bool? available = default(bool?))
        {
            this.Id = id;
            this.Name = name;
            this.Product = product;
            this.Available = available;
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
            return this.Equals(input as ProductMenuOption);
        }

        /// <summary>
        /// Returns true if ProductMenuOption instances are equal
        /// </summary>
        /// <param name="input">Instance of ProductMenuOption to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProductMenuOption input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Product == input.Product ||
                    (this.Product != null &&
                    this.Product.Equals(input.Product))
                ) && 
                (
                    this.Available == input.Available ||
                    (this.Available != null &&
                    this.Available.Equals(input.Available))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Product != null)
                    hashCode = hashCode * 59 + this.Product.GetHashCode();
                if (this.Available != null)
                    hashCode = hashCode * 59 + this.Available.GetHashCode();
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
