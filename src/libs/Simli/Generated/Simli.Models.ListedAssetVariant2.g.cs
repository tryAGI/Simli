
#nullable enable

namespace Simli
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ListedAssetVariant2
    {
        /// <summary>
        /// A signed URL that GETs the image until url_expires_at; usable as an &lt;img&gt; src. Null if one couldn't be made just then.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Unix time, in seconds, when url stops working.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url_expires_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int UrlExpiresAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListedAssetVariant2" /> class.
        /// </summary>
        /// <param name="urlExpiresAt">
        /// Unix time, in seconds, when url stops working.
        /// </param>
        /// <param name="url">
        /// A signed URL that GETs the image until url_expires_at; usable as an &lt;img&gt; src. Null if one couldn't be made just then.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListedAssetVariant2(
            int urlExpiresAt,
            string? url)
        {
            this.Url = url;
            this.UrlExpiresAt = urlExpiresAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListedAssetVariant2" /> class.
        /// </summary>
        public ListedAssetVariant2()
        {
        }

    }
}