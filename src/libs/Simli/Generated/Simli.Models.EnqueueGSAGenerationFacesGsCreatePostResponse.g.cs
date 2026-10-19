
#nullable enable

namespace Simli
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class EnqueueGSAGenerationFacesGsCreatePostResponse
    {
        /// <summary>
        /// The generation's place in the queue, and how long it is held, if it is.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// The new face's ID. Poll GET /faces/trinity/generation_status with it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("face_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FaceId { get; set; }

        /// <summary>
        /// GSA_2.0 only, when the generation is held by the 10 minutes between one account's GSA_2.0 generations: the Unix time (seconds) it may start. Absent otherwise.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dispatch_after")]
        public int? DispatchAfter { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("warnings")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Warnings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EnqueueGSAGenerationFacesGsCreatePostResponse" /> class.
        /// </summary>
        /// <param name="message">
        /// The generation's place in the queue, and how long it is held, if it is.
        /// </param>
        /// <param name="faceId">
        /// The new face's ID. Poll GET /faces/trinity/generation_status with it.
        /// </param>
        /// <param name="warnings"></param>
        /// <param name="dispatchAfter">
        /// GSA_2.0 only, when the generation is held by the 10 minutes between one account's GSA_2.0 generations: the Unix time (seconds) it may start. Absent otherwise.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EnqueueGSAGenerationFacesGsCreatePostResponse(
            string message,
            string faceId,
            global::System.Collections.Generic.IList<string> warnings,
            int? dispatchAfter)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.FaceId = faceId ?? throw new global::System.ArgumentNullException(nameof(faceId));
            this.DispatchAfter = dispatchAfter;
            this.Warnings = warnings ?? throw new global::System.ArgumentNullException(nameof(warnings));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnqueueGSAGenerationFacesGsCreatePostResponse" /> class.
        /// </summary>
        public EnqueueGSAGenerationFacesGsCreatePostResponse()
        {
        }

    }
}