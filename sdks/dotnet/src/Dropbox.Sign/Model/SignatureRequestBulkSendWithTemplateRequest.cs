/*
 * Dropbox Sign API
 *
 * Dropbox Sign v3 API
 *
 * The version of the OpenAPI document: 3.0.0
 * Contact: apisupport@hellosign.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Dropbox.Sign.Client.OpenAPIDateConverter;

namespace Dropbox.Sign.Model
{
    /// <summary>
    /// SignatureRequestBulkSendWithTemplateRequest
    /// </summary>
    [DataContract(Name = "SignatureRequestBulkSendWithTemplateRequest")]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public partial class SignatureRequestBulkSendWithTemplateRequest : IOpenApiTyped, IEquatable<SignatureRequestBulkSendWithTemplateRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SignatureRequestBulkSendWithTemplateRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SignatureRequestBulkSendWithTemplateRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SignatureRequestBulkSendWithTemplateRequest" /> class.
        /// </summary>
        /// <param name="templateIds">Use &#x60;template_ids&#x60; to create a SignatureRequest from one or more templates, in the order in which the template will be used. (required).</param>
        /// <param name="signerFile">&#x60;signer_file&#x60; is a CSV file defining values and options for signer fields. Required unless a &#x60;signer_list&#x60; is used, you may not use both. The CSV can have the following columns:  - &#x60;name&#x60;: the name of the signer filling the role of RoleName - &#x60;email_address&#x60;: email address of the signer filling the role of RoleName - &#x60;pin&#x60;: the 4- to 12-character access code that will secure this signer&#39;s signature page (optional) - &#x60;sms_phone_number&#x60;: An E.164 formatted phone number that will receive a code via SMS to access this signer&#39;s signature page. (optional)      **Note**: Not available in test mode and requires a Standard plan or higher. - &#x60;*_field&#x60;: any column with a _field\&quot; suffix will be treated as a custom field (optional)      You may only specify field values here, any other options should be set in the custom_fields request parameter.  Example CSV:  &#x60;&#x60;&#x60; name, email_address, pin, company_field George, george@example.com, d79a3td, ABC Corp Mary, mary@example.com, gd9as5b, 123 LLC &#x60;&#x60;&#x60;.</param>
        /// <param name="signerList">&#x60;signer_list&#x60; is an array defining values and options for signer fields. Required unless a &#x60;signer_file&#x60; is used, you may not use both..</param>
        /// <param name="allowDecline">Allows signers to decline to sign a document if &#x60;true&#x60;. Defaults to &#x60;false&#x60;. (default to false).</param>
        /// <param name="ccs">Add CC email recipients. Required when a CC role exists for the Template..</param>
        /// <param name="clientId">The client id of the API App you want to associate with this request. Used to apply the branding and callback url defined for the app..</param>
        /// <param name="customFields">When used together with merge fields, &#x60;custom_fields&#x60; allows users to add pre-filled data to their signature requests.  Pre-filled data can be used with \&quot;send-once\&quot; signature requests by adding merge fields with &#x60;form_fields_per_document&#x60; or [Text Tags](https://app.hellosign.com/api/textTagsWalkthrough#TextTagIntro) while passing values back with &#x60;custom_fields&#x60; together in one API call.  For using pre-filled on repeatable signature requests, merge fields are added to templates in the Dropbox Sign UI or by calling [/template/create_embedded_draft](/api/reference/operation/templateCreateEmbeddedDraft) and then passing &#x60;custom_fields&#x60; on subsequent signature requests referencing that template..</param>
        /// <param name="message">The custom message in the email that will be sent to the signers..</param>
        /// <param name="metadata">Key-value data that should be attached to the signature request. This metadata is included in all API responses and events involving the signature request. For example, use the metadata field to store a signer&#39;s order number for look up when receiving events for the signature request.  Each request can include up to 10 metadata keys (or 50 nested metadata keys), with key names up to 40 characters long and values up to 1000 characters long..</param>
        /// <param name="signingRedirectUrl">The URL you want signers redirected to after they successfully sign..</param>
        /// <param name="subject">The subject in the email that will be sent to the signers..</param>
        /// <param name="testMode">Whether this is a test, the signature request will not be legally binding if set to &#x60;true&#x60;. Defaults to &#x60;false&#x60;. (default to false).</param>
        /// <param name="title">The title you want to assign to the SignatureRequest..</param>
        public SignatureRequestBulkSendWithTemplateRequest(List<string> templateIds = default(List<string>), System.IO.Stream signerFile = default(System.IO.Stream), List<SubBulkSignerList> signerList = default(List<SubBulkSignerList>), bool allowDecline = false, List<SubCC> ccs = default(List<SubCC>), string clientId = default(string), List<SubCustomField> customFields = default(List<SubCustomField>), string message = default(string), Dictionary<string, Object> metadata = default(Dictionary<string, Object>), string signingRedirectUrl = default(string), string subject = default(string), bool testMode = false, string title = default(string))
        {
            
            // to ensure "templateIds" is required (not null)
            if (templateIds == null)
            {
                throw new ArgumentNullException("templateIds is a required property for SignatureRequestBulkSendWithTemplateRequest and cannot be null");
            }
            this.TemplateIds = templateIds;
            this.SignerFile = signerFile;
            this.SignerList = signerList;
            this.AllowDecline = allowDecline;
            this.Ccs = ccs;
            this.ClientId = clientId;
            this.CustomFields = customFields;
            this.Message = message;
            this.Metadata = metadata;
            this.SigningRedirectUrl = signingRedirectUrl;
            this.Subject = subject;
            this.TestMode = testMode;
            this.Title = title;
        }

        /// <summary>
        /// Attempt to instantiate and hydrate a new instance of this class
        /// </summary>
        /// <param name="jsonData">String of JSON data representing target object</param>
        public static SignatureRequestBulkSendWithTemplateRequest Init(string jsonData)
        {
            var obj = JsonConvert.DeserializeObject<SignatureRequestBulkSendWithTemplateRequest>(jsonData);

            if (obj == null)
            {
                throw new Exception("Unable to deserialize JSON to instance of SignatureRequestBulkSendWithTemplateRequest");
            }

            return obj;
        }

        /// <summary>
        /// Use &#x60;template_ids&#x60; to create a SignatureRequest from one or more templates, in the order in which the template will be used.
        /// </summary>
        /// <value>Use &#x60;template_ids&#x60; to create a SignatureRequest from one or more templates, in the order in which the template will be used.</value>
        [DataMember(Name = "template_ids", IsRequired = true, EmitDefaultValue = true)]
        public List<string> TemplateIds { get; set; }

        /// <summary>
        /// &#x60;signer_file&#x60; is a CSV file defining values and options for signer fields. Required unless a &#x60;signer_list&#x60; is used, you may not use both. The CSV can have the following columns:  - &#x60;name&#x60;: the name of the signer filling the role of RoleName - &#x60;email_address&#x60;: email address of the signer filling the role of RoleName - &#x60;pin&#x60;: the 4- to 12-character access code that will secure this signer&#39;s signature page (optional) - &#x60;sms_phone_number&#x60;: An E.164 formatted phone number that will receive a code via SMS to access this signer&#39;s signature page. (optional)      **Note**: Not available in test mode and requires a Standard plan or higher. - &#x60;*_field&#x60;: any column with a _field\&quot; suffix will be treated as a custom field (optional)      You may only specify field values here, any other options should be set in the custom_fields request parameter.  Example CSV:  &#x60;&#x60;&#x60; name, email_address, pin, company_field George, george@example.com, d79a3td, ABC Corp Mary, mary@example.com, gd9as5b, 123 LLC &#x60;&#x60;&#x60;
        /// </summary>
        /// <value>&#x60;signer_file&#x60; is a CSV file defining values and options for signer fields. Required unless a &#x60;signer_list&#x60; is used, you may not use both. The CSV can have the following columns:  - &#x60;name&#x60;: the name of the signer filling the role of RoleName - &#x60;email_address&#x60;: email address of the signer filling the role of RoleName - &#x60;pin&#x60;: the 4- to 12-character access code that will secure this signer&#39;s signature page (optional) - &#x60;sms_phone_number&#x60;: An E.164 formatted phone number that will receive a code via SMS to access this signer&#39;s signature page. (optional)      **Note**: Not available in test mode and requires a Standard plan or higher. - &#x60;*_field&#x60;: any column with a _field\&quot; suffix will be treated as a custom field (optional)      You may only specify field values here, any other options should be set in the custom_fields request parameter.  Example CSV:  &#x60;&#x60;&#x60; name, email_address, pin, company_field George, george@example.com, d79a3td, ABC Corp Mary, mary@example.com, gd9as5b, 123 LLC &#x60;&#x60;&#x60;</value>
        [DataMember(Name = "signer_file", EmitDefaultValue = true)]
        public System.IO.Stream SignerFile { get; set; }

        /// <summary>
        /// &#x60;signer_list&#x60; is an array defining values and options for signer fields. Required unless a &#x60;signer_file&#x60; is used, you may not use both.
        /// </summary>
        /// <value>&#x60;signer_list&#x60; is an array defining values and options for signer fields. Required unless a &#x60;signer_file&#x60; is used, you may not use both.</value>
        [DataMember(Name = "signer_list", EmitDefaultValue = true)]
        public List<SubBulkSignerList> SignerList { get; set; }

        /// <summary>
        /// Allows signers to decline to sign a document if &#x60;true&#x60;. Defaults to &#x60;false&#x60;.
        /// </summary>
        /// <value>Allows signers to decline to sign a document if &#x60;true&#x60;. Defaults to &#x60;false&#x60;.</value>
        [DataMember(Name = "allow_decline", EmitDefaultValue = true)]
        public bool AllowDecline { get; set; }

        /// <summary>
        /// Add CC email recipients. Required when a CC role exists for the Template.
        /// </summary>
        /// <value>Add CC email recipients. Required when a CC role exists for the Template.</value>
        [DataMember(Name = "ccs", EmitDefaultValue = true)]
        public List<SubCC> Ccs { get; set; }

        /// <summary>
        /// The client id of the API App you want to associate with this request. Used to apply the branding and callback url defined for the app.
        /// </summary>
        /// <value>The client id of the API App you want to associate with this request. Used to apply the branding and callback url defined for the app.</value>
        [DataMember(Name = "client_id", EmitDefaultValue = true)]
        public string ClientId { get; set; }

        /// <summary>
        /// When used together with merge fields, &#x60;custom_fields&#x60; allows users to add pre-filled data to their signature requests.  Pre-filled data can be used with \&quot;send-once\&quot; signature requests by adding merge fields with &#x60;form_fields_per_document&#x60; or [Text Tags](https://app.hellosign.com/api/textTagsWalkthrough#TextTagIntro) while passing values back with &#x60;custom_fields&#x60; together in one API call.  For using pre-filled on repeatable signature requests, merge fields are added to templates in the Dropbox Sign UI or by calling [/template/create_embedded_draft](/api/reference/operation/templateCreateEmbeddedDraft) and then passing &#x60;custom_fields&#x60; on subsequent signature requests referencing that template.
        /// </summary>
        /// <value>When used together with merge fields, &#x60;custom_fields&#x60; allows users to add pre-filled data to their signature requests.  Pre-filled data can be used with \&quot;send-once\&quot; signature requests by adding merge fields with &#x60;form_fields_per_document&#x60; or [Text Tags](https://app.hellosign.com/api/textTagsWalkthrough#TextTagIntro) while passing values back with &#x60;custom_fields&#x60; together in one API call.  For using pre-filled on repeatable signature requests, merge fields are added to templates in the Dropbox Sign UI or by calling [/template/create_embedded_draft](/api/reference/operation/templateCreateEmbeddedDraft) and then passing &#x60;custom_fields&#x60; on subsequent signature requests referencing that template.</value>
        [DataMember(Name = "custom_fields", EmitDefaultValue = true)]
        public List<SubCustomField> CustomFields { get; set; }

        /// <summary>
        /// The custom message in the email that will be sent to the signers.
        /// </summary>
        /// <value>The custom message in the email that will be sent to the signers.</value>
        [DataMember(Name = "message", EmitDefaultValue = true)]
        public string Message { get; set; }

        /// <summary>
        /// Key-value data that should be attached to the signature request. This metadata is included in all API responses and events involving the signature request. For example, use the metadata field to store a signer&#39;s order number for look up when receiving events for the signature request.  Each request can include up to 10 metadata keys (or 50 nested metadata keys), with key names up to 40 characters long and values up to 1000 characters long.
        /// </summary>
        /// <value>Key-value data that should be attached to the signature request. This metadata is included in all API responses and events involving the signature request. For example, use the metadata field to store a signer&#39;s order number for look up when receiving events for the signature request.  Each request can include up to 10 metadata keys (or 50 nested metadata keys), with key names up to 40 characters long and values up to 1000 characters long.</value>
        [DataMember(Name = "metadata", EmitDefaultValue = true)]
        public Dictionary<string, Object> Metadata { get; set; }

        /// <summary>
        /// The URL you want signers redirected to after they successfully sign.
        /// </summary>
        /// <value>The URL you want signers redirected to after they successfully sign.</value>
        [DataMember(Name = "signing_redirect_url", EmitDefaultValue = true)]
        public string SigningRedirectUrl { get; set; }

        /// <summary>
        /// The subject in the email that will be sent to the signers.
        /// </summary>
        /// <value>The subject in the email that will be sent to the signers.</value>
        [DataMember(Name = "subject", EmitDefaultValue = true)]
        public string Subject { get; set; }

        /// <summary>
        /// Whether this is a test, the signature request will not be legally binding if set to &#x60;true&#x60;. Defaults to &#x60;false&#x60;.
        /// </summary>
        /// <value>Whether this is a test, the signature request will not be legally binding if set to &#x60;true&#x60;. Defaults to &#x60;false&#x60;.</value>
        [DataMember(Name = "test_mode", EmitDefaultValue = true)]
        public bool TestMode { get; set; }

        /// <summary>
        /// The title you want to assign to the SignatureRequest.
        /// </summary>
        /// <value>The title you want to assign to the SignatureRequest.</value>
        [DataMember(Name = "title", EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SignatureRequestBulkSendWithTemplateRequest {\n");
            sb.Append("  TemplateIds: ").Append(TemplateIds).Append("\n");
            sb.Append("  SignerFile: ").Append(SignerFile).Append("\n");
            sb.Append("  SignerList: ").Append(SignerList).Append("\n");
            sb.Append("  AllowDecline: ").Append(AllowDecline).Append("\n");
            sb.Append("  Ccs: ").Append(Ccs).Append("\n");
            sb.Append("  ClientId: ").Append(ClientId).Append("\n");
            sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  SigningRedirectUrl: ").Append(SigningRedirectUrl).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  TestMode: ").Append(TestMode).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as SignatureRequestBulkSendWithTemplateRequest);
        }

        /// <summary>
        /// Returns true if SignatureRequestBulkSendWithTemplateRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SignatureRequestBulkSendWithTemplateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SignatureRequestBulkSendWithTemplateRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.TemplateIds == input.TemplateIds ||
                    this.TemplateIds != null &&
                    input.TemplateIds != null &&
                    this.TemplateIds.SequenceEqual(input.TemplateIds)
                ) && 
                (
                    this.SignerFile == input.SignerFile ||
                    (this.SignerFile != null &&
                    this.SignerFile.Equals(input.SignerFile))
                ) && 
                (
                    this.SignerList == input.SignerList ||
                    this.SignerList != null &&
                    input.SignerList != null &&
                    this.SignerList.SequenceEqual(input.SignerList)
                ) && 
                (
                    this.AllowDecline == input.AllowDecline ||
                    this.AllowDecline.Equals(input.AllowDecline)
                ) && 
                (
                    this.Ccs == input.Ccs ||
                    this.Ccs != null &&
                    input.Ccs != null &&
                    this.Ccs.SequenceEqual(input.Ccs)
                ) && 
                (
                    this.ClientId == input.ClientId ||
                    (this.ClientId != null &&
                    this.ClientId.Equals(input.ClientId))
                ) && 
                (
                    this.CustomFields == input.CustomFields ||
                    this.CustomFields != null &&
                    input.CustomFields != null &&
                    this.CustomFields.SequenceEqual(input.CustomFields)
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    this.Metadata != null &&
                    input.Metadata != null &&
                    this.Metadata.SequenceEqual(input.Metadata)
                ) && 
                (
                    this.SigningRedirectUrl == input.SigningRedirectUrl ||
                    (this.SigningRedirectUrl != null &&
                    this.SigningRedirectUrl.Equals(input.SigningRedirectUrl))
                ) && 
                (
                    this.Subject == input.Subject ||
                    (this.Subject != null &&
                    this.Subject.Equals(input.Subject))
                ) && 
                (
                    this.TestMode == input.TestMode ||
                    this.TestMode.Equals(input.TestMode)
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
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
                if (this.TemplateIds != null)
                {
                    hashCode = (hashCode * 59) + this.TemplateIds.GetHashCode();
                }
                if (this.SignerFile != null)
                {
                    hashCode = (hashCode * 59) + this.SignerFile.GetHashCode();
                }
                if (this.SignerList != null)
                {
                    hashCode = (hashCode * 59) + this.SignerList.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.AllowDecline.GetHashCode();
                if (this.Ccs != null)
                {
                    hashCode = (hashCode * 59) + this.Ccs.GetHashCode();
                }
                if (this.ClientId != null)
                {
                    hashCode = (hashCode * 59) + this.ClientId.GetHashCode();
                }
                if (this.CustomFields != null)
                {
                    hashCode = (hashCode * 59) + this.CustomFields.GetHashCode();
                }
                if (this.Message != null)
                {
                    hashCode = (hashCode * 59) + this.Message.GetHashCode();
                }
                if (this.Metadata != null)
                {
                    hashCode = (hashCode * 59) + this.Metadata.GetHashCode();
                }
                if (this.SigningRedirectUrl != null)
                {
                    hashCode = (hashCode * 59) + this.SigningRedirectUrl.GetHashCode();
                }
                if (this.Subject != null)
                {
                    hashCode = (hashCode * 59) + this.Subject.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TestMode.GetHashCode();
                if (this.Title != null)
                {
                    hashCode = (hashCode * 59) + this.Title.GetHashCode();
                }
                return hashCode;
            }
        }

        public List<OpenApiType> GetOpenApiTypes()
        {
            var types = new List<OpenApiType>();
            types.Add(new OpenApiType(){
                Name = "template_ids",
                Property = "TemplateIds",
                Type = "List<string>",
                Value = TemplateIds,
            });
            types.Add(new OpenApiType(){
                Name = "signer_file",
                Property = "SignerFile",
                Type = "System.IO.Stream",
                Value = SignerFile,
            });
            types.Add(new OpenApiType(){
                Name = "signer_list",
                Property = "SignerList",
                Type = "List<SubBulkSignerList>",
                Value = SignerList,
            });
            types.Add(new OpenApiType(){
                Name = "allow_decline",
                Property = "AllowDecline",
                Type = "bool",
                Value = AllowDecline,
            });
            types.Add(new OpenApiType(){
                Name = "ccs",
                Property = "Ccs",
                Type = "List<SubCC>",
                Value = Ccs,
            });
            types.Add(new OpenApiType(){
                Name = "client_id",
                Property = "ClientId",
                Type = "string",
                Value = ClientId,
            });
            types.Add(new OpenApiType(){
                Name = "custom_fields",
                Property = "CustomFields",
                Type = "List<SubCustomField>",
                Value = CustomFields,
            });
            types.Add(new OpenApiType(){
                Name = "message",
                Property = "Message",
                Type = "string",
                Value = Message,
            });
            types.Add(new OpenApiType(){
                Name = "metadata",
                Property = "Metadata",
                Type = "Dictionary<string, Object>",
                Value = Metadata,
            });
            types.Add(new OpenApiType(){
                Name = "signing_redirect_url",
                Property = "SigningRedirectUrl",
                Type = "string",
                Value = SigningRedirectUrl,
            });
            types.Add(new OpenApiType(){
                Name = "subject",
                Property = "Subject",
                Type = "string",
                Value = Subject,
            });
            types.Add(new OpenApiType(){
                Name = "test_mode",
                Property = "TestMode",
                Type = "bool",
                Value = TestMode,
            });
            types.Add(new OpenApiType(){
                Name = "title",
                Property = "Title",
                Type = "string",
                Value = Title,
            });

            return types;
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            // Message (string) maxLength
            if (this.Message != null && this.Message.Length > 5000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Message, length must be less than 5000.", new [] { "Message" });
            }

            // Subject (string) maxLength
            if (this.Subject != null && this.Subject.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Subject, length must be less than 255.", new [] { "Subject" });
            }

            // Title (string) maxLength
            if (this.Title != null && this.Title.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Title, length must be less than 255.", new [] { "Title" });
            }

            yield break;
        }
    }

}
