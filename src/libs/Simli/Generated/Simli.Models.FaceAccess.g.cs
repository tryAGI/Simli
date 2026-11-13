
#nullable enable

namespace Simli
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class FaceAccess
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Version of the Simli model used for the face<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("simli_version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SimliVersion { get; set; }

        /// <summary>
        /// Whether the face is public: usable by any account that has its face ID, though not listed or discoverable
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_public")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsPublic { get; set; }

        /// <summary>
        /// Whether the face is your own. When false, you can use it because it is public and you have its ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_owner")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsOwner { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FaceAccess" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="simliVersion">
        /// Version of the Simli model used for the face<br/>
        /// Example: 1
        /// </param>
        /// <param name="isPublic">
        /// Whether the face is public: usable by any account that has its face ID, though not listed or discoverable
        /// </param>
        /// <param name="isOwner">
        /// Whether the face is your own. When false, you can use it because it is public and you have its ID
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FaceAccess(
            global::System.Guid id,
            string name,
            int simliVersion,
            bool isPublic,
            bool isOwner)
        {
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.SimliVersion = simliVersion;
            this.IsPublic = isPublic;
            this.IsOwner = isOwner;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FaceAccess" /> class.
        /// </summary>
        public FaceAccess()
        {
        }

    }
}