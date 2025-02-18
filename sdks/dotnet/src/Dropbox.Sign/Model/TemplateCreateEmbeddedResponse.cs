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
    /// TemplateCreateEmbeddedResponse
    /// </summary>
    [DataContract(Name = "TemplateCreateEmbeddedResponse")]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public partial class TemplateCreateEmbeddedResponse : IOpenApiTyped, IEquatable<TemplateCreateEmbeddedResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateCreateEmbeddedResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TemplateCreateEmbeddedResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateCreateEmbeddedResponse" /> class.
        /// </summary>
        /// <param name="template">template.</param>
        /// <param name="warnings">A list of warnings..</param>
        public TemplateCreateEmbeddedResponse(TemplateCreateEmbeddedResponse template = default(TemplateCreateEmbeddedResponse), List<WarningResponse> warnings = default(List<WarningResponse>))
        {
            
            this.Template = template;
            this.Warnings = warnings;
        }

        /// <summary>
        /// Attempt to instantiate and hydrate a new instance of this class
        /// </summary>
        /// <param name="jsonData">String of JSON data representing target object</param>
        public static TemplateCreateEmbeddedResponse Init(string jsonData)
        {
            var obj = JsonConvert.DeserializeObject<TemplateCreateEmbeddedResponse>(jsonData);

            if (obj == null)
            {
                throw new Exception("Unable to deserialize JSON to instance of TemplateCreateEmbeddedResponse");
            }

            return obj;
        }

        /// <summary>
        /// Gets or Sets Template
        /// </summary>
        [DataMember(Name = "template", EmitDefaultValue = true)]
        public TemplateCreateEmbeddedResponse Template { get; set; }

        /// <summary>
        /// A list of warnings.
        /// </summary>
        /// <value>A list of warnings.</value>
        [DataMember(Name = "warnings", EmitDefaultValue = true)]
        public List<WarningResponse> Warnings { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TemplateCreateEmbeddedResponse {\n");
            sb.Append("  Template: ").Append(Template).Append("\n");
            sb.Append("  Warnings: ").Append(Warnings).Append("\n");
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
            return this.Equals(input as TemplateCreateEmbeddedResponse);
        }

        /// <summary>
        /// Returns true if TemplateCreateEmbeddedResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of TemplateCreateEmbeddedResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TemplateCreateEmbeddedResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Template == input.Template ||
                    (this.Template != null &&
                    this.Template.Equals(input.Template))
                ) && 
                (
                    this.Warnings == input.Warnings ||
                    this.Warnings != null &&
                    input.Warnings != null &&
                    this.Warnings.SequenceEqual(input.Warnings)
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
                if (this.Template != null)
                {
                    hashCode = (hashCode * 59) + this.Template.GetHashCode();
                }
                if (this.Warnings != null)
                {
                    hashCode = (hashCode * 59) + this.Warnings.GetHashCode();
                }
                return hashCode;
            }
        }

        public List<OpenApiType> GetOpenApiTypes()
        {
            var types = new List<OpenApiType>();
            types.Add(new OpenApiType(){
                Name = "template",
                Property = "Template",
                Type = "TemplateCreateEmbeddedResponse",
                Value = Template,
            });
            types.Add(new OpenApiType(){
                Name = "warnings",
                Property = "Warnings",
                Type = "List<WarningResponse>",
                Value = Warnings,
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
            yield break;
        }
    }

}
