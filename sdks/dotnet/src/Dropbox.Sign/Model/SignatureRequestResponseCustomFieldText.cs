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
using JsonSubTypes;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Dropbox.Sign.Client.OpenAPIDateConverter;

namespace Dropbox.Sign.Model
{
    /// <summary>
    /// This class extends &#x60;SignatureRequestResponseCustomFieldBase&#x60;.
    /// </summary>
    [DataContract(Name = "SignatureRequestResponseCustomFieldText")]
    [JsonConverter(typeof(JsonSubtypes), "Type")]
    [JsonSubtypes.KnownSubType(typeof(SignatureRequestResponseCustomFieldCheckbox), "checkbox")]
    [JsonSubtypes.KnownSubType(typeof(SignatureRequestResponseCustomFieldText), "text")]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public partial class SignatureRequestResponseCustomFieldText : SignatureRequestResponseCustomFieldBase, IOpenApiTyped, IEquatable<SignatureRequestResponseCustomFieldText>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SignatureRequestResponseCustomFieldText" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SignatureRequestResponseCustomFieldText() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SignatureRequestResponseCustomFieldText" /> class.
        /// </summary>
        /// <param name="type">The type of this Custom Field. Only &#39;text&#39; and &#39;checkbox&#39; are currently supported. (required) (default to &quot;text&quot;).</param>
        /// <param name="value">A text string for text fields.</param>
        /// <param name="name">The name of the Custom Field. (required).</param>
        /// <param name="required">A boolean value denoting if this field is required..</param>
        /// <param name="apiId">The unique ID for this field..</param>
        /// <param name="editor">The name of the Role that is able to edit this field..</param>
        public SignatureRequestResponseCustomFieldText(string type = "text", string value = default(string), string name = default(string), bool required = default(bool), string apiId = default(string), string editor = default(string))
        {
            this.Name = name;
            this.Required = required;
            this.ApiId = apiId;
            this.Editor = editor;
            
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new ArgumentNullException("type is a required property for SignatureRequestResponseCustomFieldText and cannot be null");
            }
            this.Type = type;
            this.Value = value;
        }

        /// <summary>
        /// Attempt to instantiate and hydrate a new instance of this class
        /// </summary>
        /// <param name="jsonData">String of JSON data representing target object</param>
        public static SignatureRequestResponseCustomFieldText Init(string jsonData)
        {
            var obj = JsonConvert.DeserializeObject<SignatureRequestResponseCustomFieldText>(jsonData);

            if (obj == null)
            {
                throw new Exception("Unable to deserialize JSON to instance of SignatureRequestResponseCustomFieldText");
            }

            return obj;
        }

        /// <summary>
        /// The type of this Custom Field. Only &#39;text&#39; and &#39;checkbox&#39; are currently supported.
        /// </summary>
        /// <value>The type of this Custom Field. Only &#39;text&#39; and &#39;checkbox&#39; are currently supported.</value>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public string Type { get; set; }

        /// <summary>
        /// A text string for text fields
        /// </summary>
        /// <value>A text string for text fields</value>
        [DataMember(Name = "value", EmitDefaultValue = true)]
        public string Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SignatureRequestResponseCustomFieldText {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
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
            return this.Equals(input as SignatureRequestResponseCustomFieldText);
        }

        /// <summary>
        /// Returns true if SignatureRequestResponseCustomFieldText instances are equal
        /// </summary>
        /// <param name="input">Instance of SignatureRequestResponseCustomFieldText to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SignatureRequestResponseCustomFieldText input)
        {
            if (input == null)
            {
                return false;
            }
            return base.Equals(input) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && base.Equals(input) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
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
                int hashCode = base.GetHashCode();
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
                }
                if (this.Value != null)
                {
                    hashCode = (hashCode * 59) + this.Value.GetHashCode();
                }
                return hashCode;
            }
        }

        public List<OpenApiType> GetOpenApiTypes()
        {
            var types = new List<OpenApiType>();
            types.Add(new OpenApiType(){
                Name = "type",
                Property = "Type",
                Type = "string",
                Value = Type,
            });
            types.Add(new OpenApiType(){
                Name = "value",
                Property = "Value",
                Type = "string",
                Value = Value,
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
            return this.BaseValidate(validationContext);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        protected IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> BaseValidate(ValidationContext validationContext)
        {
            foreach (var x in BaseValidate(validationContext))
            {
                yield return x;
            }
            yield break;
        }
    }

}
