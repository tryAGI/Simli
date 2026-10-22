
#nullable enable

namespace Simli
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BodyUploadAssetAssetsKindPost
    {
        /// <summary>
        /// JPEG, PNG or WEBP, under 5MB, in one of the streaming canvases' shapes: 16:9, 9:16 or 1:1 and no other, at least 512 pixels on its shorter side and at most 1920x1080, 1080x1920 or 1080x1080. A foreground needs transparency (a PNG or WEBP with an alpha channel). EXIF orientation is applied; metadata is dropped.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] Image { get; set; }

        /// <summary>
        /// JPEG, PNG or WEBP, under 5MB, in one of the streaming canvases' shapes: 16:9, 9:16 or 1:1 and no other, at least 512 pixels on its shorter side and at most 1920x1080, 1080x1920 or 1080x1080. A foreground needs transparency (a PNG or WEBP with an alpha channel). EXIF orientation is applied; metadata is dropped.
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
        /// Initializes a new instance of the <see cref="BodyUploadAssetAssetsKindPost" /> class.
        /// </summary>
        /// <param name="image">
        /// JPEG, PNG or WEBP, under 5MB, in one of the streaming canvases' shapes: 16:9, 9:16 or 1:1 and no other, at least 512 pixels on its shorter side and at most 1920x1080, 1080x1920 or 1080x1080. A foreground needs transparency (a PNG or WEBP with an alpha channel). EXIF orientation is applied; metadata is dropped.
        /// </param>
        /// <param name="imagename">
        /// JPEG, PNG or WEBP, under 5MB, in one of the streaming canvases' shapes: 16:9, 9:16 or 1:1 and no other, at least 512 pixels on its shorter side and at most 1920x1080, 1080x1920 or 1080x1080. A foreground needs transparency (a PNG or WEBP with an alpha channel). EXIF orientation is applied; metadata is dropped.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyUploadAssetAssetsKindPost(
            byte[] image,
            string imagename)
        {
            this.Image = image ?? throw new global::System.ArgumentNullException(nameof(image));
            this.Imagename = imagename ?? throw new global::System.ArgumentNullException(nameof(imagename));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyUploadAssetAssetsKindPost" /> class.
        /// </summary>
        public BodyUploadAssetAssetsKindPost()
        {
        }

    }
}