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
    /// An object that contains necessary information to set up embedded signing.
    /// </summary>
    [DataContract(Name = "EmbeddedSignUrlResponseEmbedded")]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public partial class EmbeddedSignUrlResponseEmbedded : IOpenApiTyped, IEquatable<EmbeddedSignUrlResponseEmbedded>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddedSignUrlResponseEmbedded" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EmbeddedSignUrlResponseEmbedded() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddedSignUrlResponseEmbedded" /> class.
        /// </summary>
        /// <param name="signUrl">A signature url that can be opened in an iFrame..</param>
        /// <param name="expiresAt">The specific time that the the &#x60;sign_url&#x60; link expires, in epoch..</param>
        public EmbeddedSignUrlResponseEmbedded(string signUrl = default(string), int expiresAt = default(int))
        {
            
            this.SignUrl = signUrl;
            this.ExpiresAt = expiresAt;
        }

        /// <summary>
        /// Attempt to instantiate and hydrate a new instance of this class
        /// </summary>
        /// <param name="jsonData">String of JSON data representing target object</param>
        public static EmbeddedSignUrlResponseEmbedded Init(string jsonData)
        {
            var obj = JsonConvert.DeserializeObject<EmbeddedSignUrlResponseEmbedded>(jsonData);

            if (obj == null)
            {
                throw new Exception("Unable to deserialize JSON to instance of EmbeddedSignUrlResponseEmbedded");
            }

            return obj;
        }

        /// <summary>
        /// A signature url that can be opened in an iFrame.
        /// </summary>
        /// <value>A signature url that can be opened in an iFrame.</value>
        [DataMember(Name = "sign_url", EmitDefaultValue = true)]
        public string SignUrl { get; set; }

        /// <summary>
        /// The specific time that the the &#x60;sign_url&#x60; link expires, in epoch.
        /// </summary>
        /// <value>The specific time that the the &#x60;sign_url&#x60; link expires, in epoch.</value>
        [DataMember(Name = "expires_at", EmitDefaultValue = true)]
        public int ExpiresAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EmbeddedSignUrlResponseEmbedded {\n");
            sb.Append("  SignUrl: ").Append(SignUrl).Append("\n");
            sb.Append("  ExpiresAt: ").Append(ExpiresAt).Append("\n");
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
            return this.Equals(input as EmbeddedSignUrlResponseEmbedded);
        }

        /// <summary>
        /// Returns true if EmbeddedSignUrlResponseEmbedded instances are equal
        /// </summary>
        /// <param name="input">Instance of EmbeddedSignUrlResponseEmbedded to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmbeddedSignUrlResponseEmbedded input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.SignUrl == input.SignUrl ||
                    (this.SignUrl != null &&
                    this.SignUrl.Equals(input.SignUrl))
                ) && 
                (
                    this.ExpiresAt == input.ExpiresAt ||
                    this.ExpiresAt.Equals(input.ExpiresAt)
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
                if (this.SignUrl != null)
                {
                    hashCode = (hashCode * 59) + this.SignUrl.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ExpiresAt.GetHashCode();
                return hashCode;
            }
        }

        public List<OpenApiType> GetOpenApiTypes()
        {
            var types = new List<OpenApiType>();
            types.Add(new OpenApiType(){
                Name = "sign_url",
                Property = "SignUrl",
                Type = "string",
                Value = SignUrl,
            });
            types.Add(new OpenApiType(){
                Name = "expires_at",
                Property = "ExpiresAt",
                Type = "int",
                Value = ExpiresAt,
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
