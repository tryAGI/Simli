
#nullable enable

namespace Simli
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BodyPreprocessImageFacesTrinityPreprocessPost
    {
        /// <summary>
        /// JPEG, PNG or WEBP, under 5MB, at least 512x512. It must contain a person facing the camera whose head is at least 15% of the image height - a head smaller than that carries too few pixels to keep the likeness, and is rejected. Where several people are present, the largest camera-facing head is treated as the subject.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] Image { get; set; }

        /// <summary>
        /// JPEG, PNG or WEBP, under 5MB, at least 512x512. It must contain a person facing the camera whose head is at least 15% of the image height - a head smaller than that carries too few pixels to keep the likeness, and is rejected. Where several people are present, the largest camera-facing head is treated as the subject.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imagename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Imagename { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyPreprocessImageFacesTrinityPreprocessPost" /> class.
        /// </summary>
        /// <param name="image">
        /// JPEG, PNG or WEBP, under 5MB, at least 512x512. It must contain a person facing the camera whose head is at least 15% of the image height - a head smaller than that carries too few pixels to keep the likeness, and is rejected. Where several people are present, the largest camera-facing head is treated as the subject.
        /// </param>
        /// <param name="imagename">
        /// JPEG, PNG or WEBP, under 5MB, at least 512x512. It must contain a person facing the camera whose head is at least 15% of the image height - a head smaller than that carries too few pixels to keep the likeness, and is rejected. Where several people are present, the largest camera-facing head is treated as the subject.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyPreprocessImageFacesTrinityPreprocessPost(
            byte[] image,
            string imagename)
        {
            this.Image = image ?? throw new global::System.ArgumentNullException(nameof(image));
            this.Imagename = imagename ?? throw new global::System.ArgumentNullException(nameof(imagename));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyPreprocessImageFacesTrinityPreprocessPost" /> class.
        /// </summary>
        public BodyPreprocessImageFacesTrinityPreprocessPost()
        {
        }

    }
}