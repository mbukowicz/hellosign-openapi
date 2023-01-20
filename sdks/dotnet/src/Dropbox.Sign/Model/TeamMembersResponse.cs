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
    /// TeamMembersResponse
    /// </summary>
    [DataContract(Name = "TeamMembersResponse")]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public partial class TeamMembersResponse : IOpenApiTyped, IEquatable<TeamMembersResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamMembersResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TeamMembersResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamMembersResponse" /> class.
        /// </summary>
        /// <param name="teamMembers">Contains a list of team members and their roles for a specific team..</param>
        /// <param name="listInfo">listInfo.</param>
        /// <param name="warnings">warnings.</param>
        public TeamMembersResponse(List<TeamMemberResponse> teamMembers = default(List<TeamMemberResponse>), ListInfoResponse listInfo = default(ListInfoResponse), List<WarningResponse> warnings = default(List<WarningResponse>))
        {
            
            this.TeamMembers = teamMembers;
            this.ListInfo = listInfo;
            this.Warnings = warnings;
        }

        /// <summary>
        /// Attempt to instantiate and hydrate a new instance of this class
        /// </summary>
        /// <param name="jsonData">String of JSON data representing target object</param>
        public static TeamMembersResponse Init(string jsonData)
        {
            var obj = JsonConvert.DeserializeObject<TeamMembersResponse>(jsonData);

            if (obj == null)
            {
                throw new Exception("Unable to deserialize JSON to instance of TeamMembersResponse");
            }

            return obj;
        }

        /// <summary>
        /// Contains a list of team members and their roles for a specific team.
        /// </summary>
        /// <value>Contains a list of team members and their roles for a specific team.</value>
        [DataMember(Name = "team_members", EmitDefaultValue = true)]
        public List<TeamMemberResponse> TeamMembers { get; set; }

        /// <summary>
        /// Gets or Sets ListInfo
        /// </summary>
        [DataMember(Name = "list_info", EmitDefaultValue = true)]
        public ListInfoResponse ListInfo { get; set; }

        /// <summary>
        /// Gets or Sets Warnings
        /// </summary>
        [DataMember(Name = "warnings", EmitDefaultValue = true)]
        public List<WarningResponse> Warnings { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TeamMembersResponse {\n");
            sb.Append("  TeamMembers: ").Append(TeamMembers).Append("\n");
            sb.Append("  ListInfo: ").Append(ListInfo).Append("\n");
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
            return this.Equals(input as TeamMembersResponse);
        }

        /// <summary>
        /// Returns true if TeamMembersResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of TeamMembersResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TeamMembersResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.TeamMembers == input.TeamMembers ||
                    this.TeamMembers != null &&
                    input.TeamMembers != null &&
                    this.TeamMembers.SequenceEqual(input.TeamMembers)
                ) && 
                (
                    this.ListInfo == input.ListInfo ||
                    (this.ListInfo != null &&
                    this.ListInfo.Equals(input.ListInfo))
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
                if (this.TeamMembers != null)
                {
                    hashCode = (hashCode * 59) + this.TeamMembers.GetHashCode();
                }
                if (this.ListInfo != null)
                {
                    hashCode = (hashCode * 59) + this.ListInfo.GetHashCode();
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
                Name = "team_members",
                Property = "TeamMembers",
                Type = "List<TeamMemberResponse>",
                Value = TeamMembers,
            });
            types.Add(new OpenApiType(){
                Name = "list_info",
                Property = "ListInfo",
                Type = "ListInfoResponse",
                Value = ListInfo,
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
