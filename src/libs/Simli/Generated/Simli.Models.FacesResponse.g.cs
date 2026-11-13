
#nullable enable

namespace Simli
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class FacesResponse
    {
        /// <summary>
        /// Always true: a face is answered this way to its owner only
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_owner")]
        public bool? IsOwner { get; set; }

        /// <summary>
        /// Whether the face is public: usable by any account that has its face ID, though not listed or discoverable. A private face is usable only by the account that created it. New faces are private; change it with PATCH /face/{id}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_public")]
        public bool? IsPublic { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_deleted")]
        public bool? IsDeleted { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Unique identifier for the face
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// Version of the Simli model used for the face<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("simli_version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SimliVersion { get; set; }

        /// <summary>
        /// Timestamp when the face was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Timestamp when the face was last updated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FacesResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the face
        /// </param>
        /// <param name="simliVersion">
        /// Version of the Simli model used for the face<br/>
        /// Example: 1
        /// </param>
        /// <param name="createdAt">
        /// Timestamp when the face was created
        /// </param>
        /// <param name="updatedAt">
        /// Timestamp when the face was last updated
        /// </param>
        /// <param name="isOwner">
        /// Always true: a face is answered this way to its owner only
        /// </param>
        /// <param name="isPublic">
        /// Whether the face is public: usable by any account that has its face ID, though not listed or discoverable. A private face is usable only by the account that created it. New faces are private; change it with PATCH /face/{id}
        /// </param>
        /// <param name="isDeleted"></param>
        /// <param name="name"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FacesResponse(
            global::System.Guid id,
            int simliVersion,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            bool? isOwner,
            bool? isPublic,
            bool? isDeleted,
            string? name)
        {
            this.IsOwner = isOwner;
            this.IsPublic = isPublic;
            this.IsDeleted = isDeleted;
            this.Name = name;
            this.Id = id;
            this.SimliVersion = simliVersion;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FacesResponse" /> class.
        /// </summary>
        public FacesResponse()
        {
        }

    }
}