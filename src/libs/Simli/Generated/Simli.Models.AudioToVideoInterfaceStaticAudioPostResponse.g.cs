
#nullable enable

namespace Simli
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AudioToVideoInterfaceStaticAudioPostResponse
    {
        /// <summary>
        /// Example: https://api.simli.ai/hls/path-to-file/output.m3u8?token=1794500000.q0J...
        /// </summary>
        /// <example>https://api.simli.ai/hls/path-to-file/output.m3u8?token=1794500000.q0J...</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("hls_url")]
        public string? HlsUrl { get; set; }

        /// <summary>
        /// Example: https://api.simli.ai/mp4/path-to-file/output.mp4?token=1794500000.q0J...
        /// </summary>
        /// <example>https://api.simli.ai/mp4/path-to-file/output.mp4?token=1794500000.q0J...</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("mp4_url")]
        public string? Mp4Url { get; set; }

        /// <summary>
        /// The token both URLs carry as `?token=`. The playlist's segment URLs carry it too.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access_token")]
        public string? AccessToken { get; set; }

        /// <summary>
        /// Unix time (seconds) the signed URLs stop working, 6 hours after the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access_token_expires_at")]
        public int? AccessTokenExpiresAt { get; set; }

        /// <summary>
        /// Camera fields outside their supported range, and background_id / foreground_id dropped as not your account's (the avatar's own is used). The video is made regardless.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("warnings")]
        public global::System.Collections.Generic.IList<string>? Warnings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioToVideoInterfaceStaticAudioPostResponse" /> class.
        /// </summary>
        /// <param name="hlsUrl">
        /// Example: https://api.simli.ai/hls/path-to-file/output.m3u8?token=1794500000.q0J...
        /// </param>
        /// <param name="mp4Url">
        /// Example: https://api.simli.ai/mp4/path-to-file/output.mp4?token=1794500000.q0J...
        /// </param>
        /// <param name="accessToken">
        /// The token both URLs carry as `?token=`. The playlist's segment URLs carry it too.
        /// </param>
        /// <param name="accessTokenExpiresAt">
        /// Unix time (seconds) the signed URLs stop working, 6 hours after the request.
        /// </param>
        /// <param name="warnings">
        /// Camera fields outside their supported range, and background_id / foreground_id dropped as not your account's (the avatar's own is used). The video is made regardless.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AudioToVideoInterfaceStaticAudioPostResponse(
            string? hlsUrl,
            string? mp4Url,
            string? accessToken,
            int? accessTokenExpiresAt,
            global::System.Collections.Generic.IList<string>? warnings)
        {
            this.HlsUrl = hlsUrl;
            this.Mp4Url = mp4Url;
            this.AccessToken = accessToken;
            this.AccessTokenExpiresAt = accessTokenExpiresAt;
            this.Warnings = warnings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioToVideoInterfaceStaticAudioPostResponse" /> class.
        /// </summary>
        public AudioToVideoInterfaceStaticAudioPostResponse()
        {
        }

    }
}