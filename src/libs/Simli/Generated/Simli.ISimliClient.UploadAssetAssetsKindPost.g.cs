#nullable enable

namespace Simli
{
    public partial interface ISimliClient
    {
        /// <summary>
        /// Upload Background or Foreground<br/>
        /// Uploads an image to show behind your avatars (a background) or over them (a foreground). It goes through a content safety check first, which takes a few seconds, and one it flags is refused. Stored as PNG, private to your account: only your own sessions can use it, by its id, as a session token's, a static video's or an Auto session's background_id / foreground_id, or in a streaming session's BG_ / FG_ message.
        /// </summary>
        /// <param name="kind"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Simli.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Simli.Asset> UploadAssetAssetsKindPostAsync(
            global::Simli.AssetKind kind,

            global::Simli.BodyUploadAssetAssetsKindPost request,
            global::Simli.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload Background or Foreground<br/>
        /// Uploads an image to show behind your avatars (a background) or over them (a foreground). It goes through a content safety check first, which takes a few seconds, and one it flags is refused. Stored as PNG, private to your account: only your own sessions can use it, by its id, as a session token's, a static video's or an Auto session's background_id / foreground_id, or in a streaming session's BG_ / FG_ message.
        /// </summary>
        /// <param name="kind"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Simli.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Simli.AutoSDKHttpResponse<global::Simli.Asset>> UploadAssetAssetsKindPostAsResponseAsync(
            global::Simli.AssetKind kind,

            global::Simli.BodyUploadAssetAssetsKindPost request,
            global::Simli.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload Background or Foreground<br/>
        /// Uploads an image to show behind your avatars (a background) or over them (a foreground). It goes through a content safety check first, which takes a few seconds, and one it flags is refused. Stored as PNG, private to your account: only your own sessions can use it, by its id, as a session token's, a static video's or an Auto session's background_id / foreground_id, or in a streaming session's BG_ / FG_ message.
        /// </summary>
        /// <param name="kind"></param>
        /// <param name="image">
        /// JPEG, PNG or WEBP, under 5MB, in one of the streaming canvases' shapes: 16:9, 9:16 or 1:1 and no other, at least 512 pixels on its shorter side and at most 1920x1080, 1080x1920 or 1080x1080. A foreground needs transparency (a PNG or WEBP with an alpha channel). EXIF orientation is applied; metadata is dropped.
        /// </param>
        /// <param name="imagename">
        /// JPEG, PNG or WEBP, under 5MB, in one of the streaming canvases' shapes: 16:9, 9:16 or 1:1 and no other, at least 512 pixels on its shorter side and at most 1920x1080, 1080x1920 or 1080x1080. A foreground needs transparency (a PNG or WEBP with an alpha channel). EXIF orientation is applied; metadata is dropped.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Simli.Asset> UploadAssetAssetsKindPostAsync(
            global::Simli.AssetKind kind,
            byte[] image,
            string imagename,
            global::Simli.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Upload Background or Foreground<br/>
        /// Uploads an image to show behind your avatars (a background) or over them (a foreground). It goes through a content safety check first, which takes a few seconds, and one it flags is refused. Stored as PNG, private to your account: only your own sessions can use it, by its id, as a session token's, a static video's or an Auto session's background_id / foreground_id, or in a streaming session's BG_ / FG_ message.
        /// </summary>
        /// <param name="kind"></param>
        /// <param name="image">
        /// JPEG, PNG or WEBP, under 5MB, in one of the streaming canvases' shapes: 16:9, 9:16 or 1:1 and no other, at least 512 pixels on its shorter side and at most 1920x1080, 1080x1920 or 1080x1080. A foreground needs transparency (a PNG or WEBP with an alpha channel). EXIF orientation is applied; metadata is dropped.
        /// </param>
        /// <param name="imagename">
        /// JPEG, PNG or WEBP, under 5MB, in one of the streaming canvases' shapes: 16:9, 9:16 or 1:1 and no other, at least 512 pixels on its shorter side and at most 1920x1080, 1080x1920 or 1080x1080. A foreground needs transparency (a PNG or WEBP with an alpha channel). EXIF orientation is applied; metadata is dropped.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Simli.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Simli.Asset> UploadAssetAssetsKindPostAsync(
            global::Simli.AssetKind kind,
            global::System.IO.Stream image,
            string imagename,
            global::Simli.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload Background or Foreground<br/>
        /// Uploads an image to show behind your avatars (a background) or over them (a foreground). It goes through a content safety check first, which takes a few seconds, and one it flags is refused. Stored as PNG, private to your account: only your own sessions can use it, by its id, as a session token's, a static video's or an Auto session's background_id / foreground_id, or in a streaming session's BG_ / FG_ message.
        /// </summary>
        /// <param name="kind"></param>
        /// <param name="image">
        /// JPEG, PNG or WEBP, under 5MB, in one of the streaming canvases' shapes: 16:9, 9:16 or 1:1 and no other, at least 512 pixels on its shorter side and at most 1920x1080, 1080x1920 or 1080x1080. A foreground needs transparency (a PNG or WEBP with an alpha channel). EXIF orientation is applied; metadata is dropped.
        /// </param>
        /// <param name="imagename">
        /// JPEG, PNG or WEBP, under 5MB, in one of the streaming canvases' shapes: 16:9, 9:16 or 1:1 and no other, at least 512 pixels on its shorter side and at most 1920x1080, 1080x1920 or 1080x1080. A foreground needs transparency (a PNG or WEBP with an alpha channel). EXIF orientation is applied; metadata is dropped.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Simli.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Simli.AutoSDKHttpResponse<global::Simli.Asset>> UploadAssetAssetsKindPostAsResponseAsync(
            global::Simli.AssetKind kind,
            global::System.IO.Stream image,
            string imagename,
            global::Simli.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}