
#nullable enable

namespace Simli
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreatePipecatSessionTokenAutoTokenPostResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_token")]
        public string? SessionToken { get; set; }

        /// <summary>
        /// Starting camera fields outside their supported range, and background_id / foreground_id dropped as not your account's (the avatar's own is used). The token is minted regardless.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("warnings")]
        public global::System.Collections.Generic.IList<string>? Warnings { get; set; }

        /// <summary>
        /// The face's generation, for a token carrying its request: connect the websocket with `?model=` set to it, which routes the start to a node serving the face.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public global::Simli.CreatePipecatSessionTokenAutoTokenPostResponseModel? Model { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePipecatSessionTokenAutoTokenPostResponse" /> class.
        /// </summary>
        /// <param name="sessionToken"></param>
        /// <param name="warnings">
        /// Starting camera fields outside their supported range, and background_id / foreground_id dropped as not your account's (the avatar's own is used). The token is minted regardless.
        /// </param>
        /// <param name="model">
        /// The face's generation, for a token carrying its request: connect the websocket with `?model=` set to it, which routes the start to a node serving the face.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreatePipecatSessionTokenAutoTokenPostResponse(
            string? sessionToken,
            global::System.Collections.Generic.IList<string>? warnings,
            global::Simli.CreatePipecatSessionTokenAutoTokenPostResponseModel? model)
        {
            this.SessionToken = sessionToken;
            this.Warnings = warnings;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePipecatSessionTokenAutoTokenPostResponse" /> class.
        /// </summary>
        public CreatePipecatSessionTokenAutoTokenPostResponse()
        {
        }

    }
}