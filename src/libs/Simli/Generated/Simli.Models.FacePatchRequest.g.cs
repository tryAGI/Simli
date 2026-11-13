
#nullable enable

namespace Simli
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class FacePatchRequest
    {
        /// <summary>
        /// true makes the face public (usable by any account that has its face ID; not listed or discoverable), false makes it private (usable only by the account that created it)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_public")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsPublic { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FacePatchRequest" /> class.
        /// </summary>
        /// <param name="isPublic">
        /// true makes the face public (usable by any account that has its face ID; not listed or discoverable), false makes it private (usable only by the account that created it)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FacePatchRequest(
            bool isPublic)
        {
            this.IsPublic = isPublic;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FacePatchRequest" /> class.
        /// </summary>
        public FacePatchRequest()
        {
        }

    }
}