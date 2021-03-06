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
    /// HttpExposedError
    /// </summary>
    [DataContract]
    public partial class HttpExposedError :  IEquatable<HttpExposedError>, IValidatableObject
    {
        /// <summary>
        /// Defines ErrorCode
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ErrorCodeEnum
        {
            
            /// <summary>
            /// Enum CoreUnhandled for value: Core_Unhandled
            /// </summary>
            [EnumMember(Value = "Core_Unhandled")]
            CoreUnhandled = 1,
            
            /// <summary>
            /// Enum CoreWavesSpendingLimitReached for value: Core_WavesSpendingLimitReached
            /// </summary>
            [EnumMember(Value = "Core_WavesSpendingLimitReached")]
            CoreWavesSpendingLimitReached = 2,
            
            /// <summary>
            /// Enum ClientConfigNotFound for value: Client_ConfigNotFound
            /// </summary>
            [EnumMember(Value = "Client_ConfigNotFound")]
            ClientConfigNotFound = 3,
            
            /// <summary>
            /// Enum ClientConfigNotConfirmed for value: Client_ConfigNotConfirmed
            /// </summary>
            [EnumMember(Value = "Client_ConfigNotConfirmed")]
            ClientConfigNotConfirmed = 4,
            
            /// <summary>
            /// Enum ClientConfigAlreadyExists for value: Client_ConfigAlreadyExists
            /// </summary>
            [EnumMember(Value = "Client_ConfigAlreadyExists")]
            ClientConfigAlreadyExists = 5,
            
            /// <summary>
            /// Enum ClientProductAlreadyExists for value: Client_ProductAlreadyExists
            /// </summary>
            [EnumMember(Value = "Client_ProductAlreadyExists")]
            ClientProductAlreadyExists = 6,
            
            /// <summary>
            /// Enum BreadcrumbingInvalidImageSize for value: Breadcrumbing_InvalidImageSize
            /// </summary>
            [EnumMember(Value = "Breadcrumbing_InvalidImageSize")]
            BreadcrumbingInvalidImageSize = 7,
            
            /// <summary>
            /// Enum BreadcrumbingFileTypesDoNotMatch for value: Breadcrumbing_FileTypesDoNotMatch
            /// </summary>
            [EnumMember(Value = "Breadcrumbing_FileTypesDoNotMatch")]
            BreadcrumbingFileTypesDoNotMatch = 8,
            
            /// <summary>
            /// Enum BreadcrumbingFileNotFound for value: Breadcrumbing_FileNotFound
            /// </summary>
            [EnumMember(Value = "Breadcrumbing_FileNotFound")]
            BreadcrumbingFileNotFound = 9,
            
            /// <summary>
            /// Enum BreadcrumbingFileNotConfirmed for value: Breadcrumbing_FileNotConfirmed
            /// </summary>
            [EnumMember(Value = "Breadcrumbing_FileNotConfirmed")]
            BreadcrumbingFileNotConfirmed = 10,
            
            /// <summary>
            /// Enum BreadcrumbingStackedFileNotConfirmed for value: Breadcrumbing_StackedFileNotConfirmed
            /// </summary>
            [EnumMember(Value = "Breadcrumbing_StackedFileNotConfirmed")]
            BreadcrumbingStackedFileNotConfirmed = 11,
            
            /// <summary>
            /// Enum BreadcrumbingFileAlreadyExists for value: Breadcrumbing_FileAlreadyExists
            /// </summary>
            [EnumMember(Value = "Breadcrumbing_FileAlreadyExists")]
            BreadcrumbingFileAlreadyExists = 12,
            
            /// <summary>
            /// Enum BreadcrumbingInvalidFileFormat for value: Breadcrumbing_InvalidFileFormat
            /// </summary>
            [EnumMember(Value = "Breadcrumbing_InvalidFileFormat")]
            BreadcrumbingInvalidFileFormat = 13,
            
            /// <summary>
            /// Enum BreadcrumbingVersionNotFound for value: Breadcrumbing_VersionNotFound
            /// </summary>
            [EnumMember(Value = "Breadcrumbing_VersionNotFound")]
            BreadcrumbingVersionNotFound = 14,
            
            /// <summary>
            /// Enum BreadcrumbingVersionNotConfirmed for value: Breadcrumbing_VersionNotConfirmed
            /// </summary>
            [EnumMember(Value = "Breadcrumbing_VersionNotConfirmed")]
            BreadcrumbingVersionNotConfirmed = 15,
            
            /// <summary>
            /// Enum BreadcrumbingNotSupportedFileFormat for value: Breadcrumbing_NotSupportedFileFormat
            /// </summary>
            [EnumMember(Value = "Breadcrumbing_NotSupportedFileFormat")]
            BreadcrumbingNotSupportedFileFormat = 16,
            
            /// <summary>
            /// Enum FactoryIssueAmountCantBeZero for value: Factory_IssueAmountCantBeZero
            /// </summary>
            [EnumMember(Value = "Factory_IssueAmountCantBeZero")]
            FactoryIssueAmountCantBeZero = 17,
            
            /// <summary>
            /// Enum FactoryIssueAmountTooHigh for value: Factory_IssueAmountTooHigh
            /// </summary>
            [EnumMember(Value = "Factory_IssueAmountTooHigh")]
            FactoryIssueAmountTooHigh = 18,
            
            /// <summary>
            /// Enum FactoryTransferAmountCantBeZero for value: Factory_TransferAmountCantBeZero
            /// </summary>
            [EnumMember(Value = "Factory_TransferAmountCantBeZero")]
            FactoryTransferAmountCantBeZero = 19,
            
            /// <summary>
            /// Enum FactoryTransferAmountTooHigh for value: Factory_TransferAmountTooHigh
            /// </summary>
            [EnumMember(Value = "Factory_TransferAmountTooHigh")]
            FactoryTransferAmountTooHigh = 20,
            
            /// <summary>
            /// Enum FactoryCannotRevertInvalidAttachment for value: Factory_CannotRevertInvalidAttachment
            /// </summary>
            [EnumMember(Value = "Factory_CannotRevertInvalidAttachment")]
            FactoryCannotRevertInvalidAttachment = 21,
            
            /// <summary>
            /// Enum FactoryCannotRevertAssetIssue for value: Factory_CannotRevertAssetIssue
            /// </summary>
            [EnumMember(Value = "Factory_CannotRevertAssetIssue")]
            FactoryCannotRevertAssetIssue = 22,
            
            /// <summary>
            /// Enum FactoryCannotDeleteInheritedFactory for value: Factory_CannotDeleteInheritedFactory
            /// </summary>
            [EnumMember(Value = "Factory_CannotDeleteInheritedFactory")]
            FactoryCannotDeleteInheritedFactory = 23,
            
            /// <summary>
            /// Enum FactoryStackedFactoryDuplicateFactory for value: Factory_StackedFactoryDuplicateFactory
            /// </summary>
            [EnumMember(Value = "Factory_StackedFactoryDuplicateFactory")]
            FactoryStackedFactoryDuplicateFactory = 24,
            
            /// <summary>
            /// Enum FactoryStackedFactoryWithoutFactory for value: Factory_StackedFactoryWithoutFactory
            /// </summary>
            [EnumMember(Value = "Factory_StackedFactoryWithoutFactory")]
            FactoryStackedFactoryWithoutFactory = 25,
            
            /// <summary>
            /// Enum FactoryCannotRevertTransactionAlreadySpent for value: Factory_CannotRevertTransactionAlreadySpent
            /// </summary>
            [EnumMember(Value = "Factory_CannotRevertTransactionAlreadySpent")]
            FactoryCannotRevertTransactionAlreadySpent = 26,
            
            /// <summary>
            /// Enum FactoryFactoryNotFound for value: Factory_FactoryNotFound
            /// </summary>
            [EnumMember(Value = "Factory_FactoryNotFound")]
            FactoryFactoryNotFound = 27,
            
            /// <summary>
            /// Enum FactoryStackedFactoryNotFound for value: Factory_StackedFactoryNotFound
            /// </summary>
            [EnumMember(Value = "Factory_StackedFactoryNotFound")]
            FactoryStackedFactoryNotFound = 28,
            
            /// <summary>
            /// Enum FactoryTransactionNotFound for value: Factory_TransactionNotFound
            /// </summary>
            [EnumMember(Value = "Factory_TransactionNotFound")]
            FactoryTransactionNotFound = 29,
            
            /// <summary>
            /// Enum FactoryFactoryNotConfirmed for value: Factory_FactoryNotConfirmed
            /// </summary>
            [EnumMember(Value = "Factory_FactoryNotConfirmed")]
            FactoryFactoryNotConfirmed = 30,
            
            /// <summary>
            /// Enum FactoryStackedFactoryNotConfirmed for value: Factory_StackedFactoryNotConfirmed
            /// </summary>
            [EnumMember(Value = "Factory_StackedFactoryNotConfirmed")]
            FactoryStackedFactoryNotConfirmed = 31,
            
            /// <summary>
            /// Enum FactoryTransactionNotConfirmed for value: Factory_TransactionNotConfirmed
            /// </summary>
            [EnumMember(Value = "Factory_TransactionNotConfirmed")]
            FactoryTransactionNotConfirmed = 32,
            
            /// <summary>
            /// Enum FactoryReversalNotConfirmed for value: Factory_ReversalNotConfirmed
            /// </summary>
            [EnumMember(Value = "Factory_ReversalNotConfirmed")]
            FactoryReversalNotConfirmed = 33,
            
            /// <summary>
            /// Enum FactoryFactoryAlreadyExists for value: Factory_FactoryAlreadyExists
            /// </summary>
            [EnumMember(Value = "Factory_FactoryAlreadyExists")]
            FactoryFactoryAlreadyExists = 34,
            
            /// <summary>
            /// Enum FactoryStackedFactoryAlreadyExists for value: Factory_StackedFactoryAlreadyExists
            /// </summary>
            [EnumMember(Value = "Factory_StackedFactoryAlreadyExists")]
            FactoryStackedFactoryAlreadyExists = 35,
            
            /// <summary>
            /// Enum FactoryTransactionAlreadyExists for value: Factory_TransactionAlreadyExists
            /// </summary>
            [EnumMember(Value = "Factory_TransactionAlreadyExists")]
            FactoryTransactionAlreadyExists = 36,
            
            /// <summary>
            /// Enum FactoryTransactionWasAlreadyReversed for value: Factory_TransactionWasAlreadyReversed
            /// </summary>
            [EnumMember(Value = "Factory_TransactionWasAlreadyReversed")]
            FactoryTransactionWasAlreadyReversed = 37,
            
            /// <summary>
            /// Enum FactoryFactoryTransferInsufficientFund for value: Factory_FactoryTransferInsufficientFund
            /// </summary>
            [EnumMember(Value = "Factory_FactoryTransferInsufficientFund")]
            FactoryFactoryTransferInsufficientFund = 38,
            
            /// <summary>
            /// Enum UserNotFound for value: User_NotFound
            /// </summary>
            [EnumMember(Value = "User_NotFound")]
            UserNotFound = 39,
            
            /// <summary>
            /// Enum UserNotConfirmed for value: User_NotConfirmed
            /// </summary>
            [EnumMember(Value = "User_NotConfirmed")]
            UserNotConfirmed = 40,
            
            /// <summary>
            /// Enum UserAlreadyExists for value: User_AlreadyExists
            /// </summary>
            [EnumMember(Value = "User_AlreadyExists")]
            UserAlreadyExists = 41,
            
            /// <summary>
            /// Enum IdentityStackedIdentityDuplicateSubIdentity for value: Identity_StackedIdentityDuplicateSubIdentity
            /// </summary>
            [EnumMember(Value = "Identity_StackedIdentityDuplicateSubIdentity")]
            IdentityStackedIdentityDuplicateSubIdentity = 42,
            
            /// <summary>
            /// Enum IdentitySubIdentityNotFound for value: Identity_SubIdentityNotFound
            /// </summary>
            [EnumMember(Value = "Identity_SubIdentityNotFound")]
            IdentitySubIdentityNotFound = 43,
            
            /// <summary>
            /// Enum IdentityStackedIdentityAlreadyExists for value: Identity_StackedIdentityAlreadyExists
            /// </summary>
            [EnumMember(Value = "Identity_StackedIdentityAlreadyExists")]
            IdentityStackedIdentityAlreadyExists = 44,
            
            /// <summary>
            /// Enum IdentityStackedIdentityNotFound for value: Identity_StackedIdentityNotFound
            /// </summary>
            [EnumMember(Value = "Identity_StackedIdentityNotFound")]
            IdentityStackedIdentityNotFound = 45,
            
            /// <summary>
            /// Enum IdentityDeleteNotFound for value: Identity_DeleteNotFound
            /// </summary>
            [EnumMember(Value = "Identity_DeleteNotFound")]
            IdentityDeleteNotFound = 46,
            
            /// <summary>
            /// Enum IdentityUpdateNotFound for value: Identity_UpdateNotFound
            /// </summary>
            [EnumMember(Value = "Identity_UpdateNotFound")]
            IdentityUpdateNotFound = 47,
            
            /// <summary>
            /// Enum IdentityNotFound for value: Identity_NotFound
            /// </summary>
            [EnumMember(Value = "Identity_NotFound")]
            IdentityNotFound = 48,
            
            /// <summary>
            /// Enum IdentityNotConfirmed for value: Identity_NotConfirmed
            /// </summary>
            [EnumMember(Value = "Identity_NotConfirmed")]
            IdentityNotConfirmed = 49,
            
            /// <summary>
            /// Enum IdentityNotTheOwner for value: Identity_NotTheOwner
            /// </summary>
            [EnumMember(Value = "Identity_NotTheOwner")]
            IdentityNotTheOwner = 50,
            
            /// <summary>
            /// Enum RuleAlreadyExists for value: Rule_AlreadyExists
            /// </summary>
            [EnumMember(Value = "Rule_AlreadyExists")]
            RuleAlreadyExists = 51,
            
            /// <summary>
            /// Enum RuleMaximumDailyTransactionCount for value: Rule_MaximumDailyTransactionCount
            /// </summary>
            [EnumMember(Value = "Rule_MaximumDailyTransactionCount")]
            RuleMaximumDailyTransactionCount = 52,
            
            /// <summary>
            /// Enum RuleMaximumAmountPerTransaction for value: Rule_MaximumAmountPerTransaction
            /// </summary>
            [EnumMember(Value = "Rule_MaximumAmountPerTransaction")]
            RuleMaximumAmountPerTransaction = 53,
            
            /// <summary>
            /// Enum RuleMaximumYearlyTotalInput for value: Rule_MaximumYearlyTotalInput
            /// </summary>
            [EnumMember(Value = "Rule_MaximumYearlyTotalInput")]
            RuleMaximumYearlyTotalInput = 54
        }

        /// <summary>
        /// Gets or Sets ErrorCode
        /// </summary>
        [DataMember(Name="errorCode", EmitDefaultValue=false)]
        public ErrorCodeEnum? ErrorCode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="HttpExposedError" /> class.
        /// </summary>
        /// <param name="errorCode">errorCode.</param>
        /// <param name="message">message.</param>
        /// <param name="arguments">arguments.</param>
        public HttpExposedError(ErrorCodeEnum? errorCode = default(ErrorCodeEnum?), string message = default(string), List<Object> arguments = default(List<Object>))
        {
            this.ErrorCode = errorCode;
            this.Message = message;
            this.Arguments = arguments;
        }
        

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }

        /// <summary>
        /// Gets or Sets Arguments
        /// </summary>
        [DataMember(Name="arguments", EmitDefaultValue=false)]
        public List<Object> Arguments { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HttpExposedError {\n");
            sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Arguments: ").Append(Arguments).Append("\n");
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
            return this.Equals(input as HttpExposedError);
        }

        /// <summary>
        /// Returns true if HttpExposedError instances are equal
        /// </summary>
        /// <param name="input">Instance of HttpExposedError to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HttpExposedError input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ErrorCode == input.ErrorCode ||
                    (this.ErrorCode != null &&
                    this.ErrorCode.Equals(input.ErrorCode))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.Arguments == input.Arguments ||
                    this.Arguments != null &&
                    this.Arguments.SequenceEqual(input.Arguments)
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
                if (this.ErrorCode != null)
                    hashCode = hashCode * 59 + this.ErrorCode.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.Arguments != null)
                    hashCode = hashCode * 59 + this.Arguments.GetHashCode();
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
