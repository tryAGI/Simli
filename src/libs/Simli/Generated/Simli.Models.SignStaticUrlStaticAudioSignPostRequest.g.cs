
#nullable enable

namespace Simli
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SignStaticUrlStaticAudioSignPostRequest
    {
        /// <summary>
        /// Either of the video's URLs (hls_url or mp4_url), as returned before. The token on it may have expired, or be left off.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SignStaticUrlStaticAudioSignPostRequest" /> class.
        /// </summary>
        /// <param name="url">
        /// Either of the video's URLs (hls_url or mp4_url), as returned before. The token on it may have expired, or be left off.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SignStaticUrlStaticAudioSignPostRequest(
            string url)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SignStaticUrlStaticAudioSignPostRequest" /> class.
        /// </summary>
        public SignStaticUrlStaticAudioSignPostRequest()
        {
        }

    }
}