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
    /// A list of warnings.
    /// </summary>
    [DataContract(Name = "WarningResponse")]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public partial class WarningResponse : IOpenApiTyped, IEquatable<WarningResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WarningResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WarningResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WarningResponse" /> class.
        /// </summary>
        /// <param name="warningMsg">Warning message (required).</param>
        /// <param name="warningName">Warning name (required).</param>
        public WarningResponse(string warningMsg = default(string), string warningName = default(string))
        {
            
            // to ensure "warningMsg" is required (not null)
            if (warningMsg == null)
            {
                throw new ArgumentNullException("warningMsg is a required property for WarningResponse and cannot be null");
            }
            this.WarningMsg = warningMsg;
            // to ensure "warningName" is required (not null)
            if (warningName == null)
            {
                throw new ArgumentNullException("warningName is a required property for WarningResponse and cannot be null");
            }
            this.WarningName = warningName;
        }

        /// <summary>
        /// Attempt to instantiate and hydrate a new instance of this class
        /// </summary>
        /// <param name="jsonData">String of JSON data representing target object</param>
        public static WarningResponse Init(string jsonData)
        {
            var obj = JsonConvert.DeserializeObject<WarningResponse>(jsonData);

            if (obj == null)
            {
                throw new Exception("Unable to deserialize JSON to instance of WarningResponse");
            }

            return obj;
        }

        /// <summary>
        /// Warning message
        /// </summary>
        /// <value>Warning message</value>
        [DataMember(Name = "warning_msg", IsRequired = true, EmitDefaultValue = true)]
        public string WarningMsg { get; set; }

        /// <summary>
        /// Warning name
        /// </summary>
        /// <value>Warning name</value>
        [DataMember(Name = "warning_name", IsRequired = true, EmitDefaultValue = true)]
        public string WarningName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WarningResponse {\n");
            sb.Append("  WarningMsg: ").Append(WarningMsg).Append("\n");
            sb.Append("  WarningName: ").Append(WarningName).Append("\n");
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
            return this.Equals(input as WarningResponse);
        }

        /// <summary>
        /// Returns true if WarningResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of WarningResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WarningResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.WarningMsg == input.WarningMsg ||
                    (this.WarningMsg != null &&
                    this.WarningMsg.Equals(input.WarningMsg))
                ) && 
                (
                    this.WarningName == input.WarningName ||
                    (this.WarningName != null &&
                    this.WarningName.Equals(input.WarningName))
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
                if (this.WarningMsg != null)
                {
                    hashCode = (hashCode * 59) + this.WarningMsg.GetHashCode();
                }
                if (this.WarningName != null)
                {
                    hashCode = (hashCode * 59) + this.WarningName.GetHashCode();
                }
                return hashCode;
            }
        }

        public List<OpenApiType> GetOpenApiTypes()
        {
            var types = new List<OpenApiType>();
            types.Add(new OpenApiType(){
                Name = "warning_msg",
                Property = "WarningMsg",
                Type = "string",
                Value = WarningMsg,
            });
            types.Add(new OpenApiType(){
                Name = "warning_name",
                Property = "WarningName",
                Type = "string",
                Value = WarningName,
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
