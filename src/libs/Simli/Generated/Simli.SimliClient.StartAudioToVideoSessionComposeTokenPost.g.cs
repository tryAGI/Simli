
#nullable enable

namespace Simli
{
    public partial class SimliClient
    {


        private static readonly global::Simli.EndPointSecurityRequirement s_StartAudioToVideoSessionComposeTokenPostSecurityRequirement0 =
            new global::Simli.EndPointSecurityRequirement
            {
                Authorizations = new global::Simli.EndPointAuthorizationRequirement[]
                {                    new global::Simli.EndPointAuthorizationRequirement
                    {
                        Type = "ApiKey",
                        Location = "Header",
                        Name = "x-simli-api-key",
                        FriendlyName = "ApiKeyInHeader",
                    },
                },
            };
        private static readonly global::Simli.EndPointSecurityRequirement[] s_StartAudioToVideoSessionComposeTokenPostSecurityRequirements =
            new global::Simli.EndPointSecurityRequirement[]
            {                s_StartAudioToVideoSessionComposeTokenPostSecurityRequirement0,
            };
        partial void PrepareStartAudioToVideoSessionComposeTokenPostArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::Simli.StartStreamingSessionRequest request);
        partial void PrepareStartAudioToVideoSessionComposeTokenPostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Simli.StartStreamingSessionRequest request);
        partial void ProcessStartAudioToVideoSessionComposeTokenPostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessStartAudioToVideoSessionComposeTokenPostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Compose Session Token<br/>
        /// Create a temporary Simli Compose Session Token
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Simli.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Simli.StartAudioToVideoSessionComposeTokenPostResponse> StartAudioToVideoSessionComposeTokenPostAsync(

            global::Simli.StartStreamingSessionRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareStartAudioToVideoSessionComposeTokenPostArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::Simli.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_StartAudioToVideoSessionComposeTokenPostSecurityRequirements,
                operationName: "StartAudioToVideoSessionComposeTokenPostAsync");

            var __pathBuilder = new global::Simli.PathBuilder(
                path: "/compose/token",
                baseUri: HttpClient.BaseAddress);
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }
            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareStartAudioToVideoSessionComposeTokenPostRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessStartAudioToVideoSessionComposeTokenPostResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Invalid Data
            if ((int)__response.StatusCode == 400)
            {
                string? __content_400 = null;
                global::System.Exception? __exception_400 = null;
                global::Simli.StartAudioToVideoSessionComposeTokenPostResponse2? __value_400 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_400 = global::Simli.StartAudioToVideoSessionComposeTokenPostResponse2.FromJson(__content_400, JsonSerializerContext);
                    }
                    else
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_400 = global::Simli.StartAudioToVideoSessionComposeTokenPostResponse2.FromJson(__content_400, JsonSerializerContext);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_400 = __ex;
                }

                throw new global::Simli.ApiException<global::Simli.StartAudioToVideoSessionComposeTokenPostResponse2>(
                    message: __content_400 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_400,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_400,
                    ResponseObject = __value_400,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Validation Error
            if ((int)__response.StatusCode == 422)
            {
                string? __content_422 = null;
                global::System.Exception? __exception_422 = null;
                global::Simli.HTTPValidationError? __value_422 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_422 = global::Simli.HTTPValidationError.FromJson(__content_422, JsonSerializerContext);
                    }
                    else
                    {
                        __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_422 = global::Simli.HTTPValidationError.FromJson(__content_422, JsonSerializerContext);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_422 = __ex;
                }

                throw new global::Simli.ApiException<global::Simli.HTTPValidationError>(
                    message: __content_422 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_422,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_422,
                    ResponseObject = __value_422,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessStartAudioToVideoSessionComposeTokenPostResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Simli.StartAudioToVideoSessionComposeTokenPostResponse.FromJson(__content, JsonSerializerContext) ??
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                }
                catch (global::System.Exception __ex)
                {
                    throw new global::Simli.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();
                    using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return
                        await global::Simli.StartAudioToVideoSessionComposeTokenPostResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                }
                catch (global::System.Exception __ex)
                {
                    string? __content = null;
                    try
                    {
                        __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                            cancellationToken
#endif
                        ).ConfigureAwait(false);
                    }
                    catch (global::System.Exception)
                    {
                    }

                    throw new global::Simli.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
        }
        /// <summary>
        /// Compose Session Token<br/>
        /// Create a temporary Simli Compose Session Token
        /// </summary>
        /// <param name="faceId"></param>
        /// <param name="apiVersion"></param>
        /// <param name="sessionAggregator"></param>
        /// <param name="handleSilence">
        /// Default Value: true
        /// </param>
        /// <param name="maxSessionLength">
        /// Default Value: 3600
        /// </param>
        /// <param name="maxIdleTime">
        /// Default Value: 300
        /// </param>
        /// <param name="startFrame">
        /// Default Value: 0
        /// </param>
        /// <param name="audioInputFormat">
        /// Default Value: pcm16
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Simli.StartAudioToVideoSessionComposeTokenPostResponse> StartAudioToVideoSessionComposeTokenPostAsync(
            string faceId,
            string? apiVersion = default,
            string? sessionAggregator = default,
            bool? handleSilence = default,
            int? maxSessionLength = default,
            int? maxIdleTime = default,
            int? startFrame = default,
            string? audioInputFormat = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Simli.StartStreamingSessionRequest
            {
                FaceId = faceId,
                ApiVersion = apiVersion,
                SessionAggregator = sessionAggregator,
                HandleSilence = handleSilence,
                MaxSessionLength = maxSessionLength,
                MaxIdleTime = maxIdleTime,
                StartFrame = startFrame,
                AudioInputFormat = audioInputFormat,
            };

            return await StartAudioToVideoSessionComposeTokenPostAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}