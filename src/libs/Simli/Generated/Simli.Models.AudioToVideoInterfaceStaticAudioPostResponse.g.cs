
#nullable enable

namespace Simli
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AudioToVideoInterfaceStaticAudioPostResponse
    {
        /// <summary>
        /// Example: https://api.simli.ai/hls/path-to-file/output.m3u8
        /// </summary>
        /// <example>https://api.simli.ai/hls/path-to-file/output.m3u8</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("hls_url")]
        public string? HlsUrl { get; set; }

        /// <summary>
        /// Example: https://api.simli.ai/mp4/path-to-file/output.mp4
        /// </summary>
        /// <example>https://api.simli.ai/mp4/path-to-file/output.mp4</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("mp4_url")]
        public string? Mp4Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioToVideoInterfaceStaticAudioPostResponse" /> class.
        /// </summary>
        /// <param name="hlsUrl">
        /// Example: https://api.simli.ai/hls/path-to-file/output.m3u8
        /// </param>
        /// <param name="mp4Url">
        /// Example: https://api.simli.ai/mp4/path-to-file/output.mp4
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AudioToVideoInterfaceStaticAudioPostResponse(
            string? hlsUrl,
            string? mp4Url)
        {
            this.HlsUrl = hlsUrl;
            this.Mp4Url = mp4Url;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioToVideoInterfaceStaticAudioPostResponse" /> class.
        /// </summary>
        public AudioToVideoInterfaceStaticAudioPostResponse()
        {
        }
    }
}