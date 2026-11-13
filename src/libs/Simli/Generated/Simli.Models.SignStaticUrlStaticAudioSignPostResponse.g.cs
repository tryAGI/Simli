
#nullable enable

namespace Simli
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SignStaticUrlStaticAudioSignPostResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hls_url")]
        public string? HlsUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mp4_url")]
        public string? Mp4Url { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access_token")]
        public string? AccessToken { get; set; }

        /// <summary>
        /// Unix time (seconds) the new URLs stop working, 6 hours after the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access_token_expires_at")]
        public int? AccessTokenExpiresAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SignStaticUrlStaticAudioSignPostResponse" /> class.
        /// </summary>
        /// <param name="hlsUrl"></param>
        /// <param name="mp4Url"></param>
        /// <param name="accessToken"></param>
        /// <param name="accessTokenExpiresAt">
        /// Unix time (seconds) the new URLs stop working, 6 hours after the request.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SignStaticUrlStaticAudioSignPostResponse(
            string? hlsUrl,
            string? mp4Url,
            string? accessToken,
            int? accessTokenExpiresAt)
        {
            this.HlsUrl = hlsUrl;
            this.Mp4Url = mp4Url;
            this.AccessToken = accessToken;
            this.AccessTokenExpiresAt = accessTokenExpiresAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SignStaticUrlStaticAudioSignPostResponse" /> class.
        /// </summary>
        public SignStaticUrlStaticAudioSignPostResponse()
        {
        }

    }
}