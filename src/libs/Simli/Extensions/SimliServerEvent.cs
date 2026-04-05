namespace Simli.Realtime;

/// <summary>
/// Represents an event received from the Simli WebSocket server.
/// </summary>
public sealed class SimliServerEvent
{
    /// <summary>
    /// The type of server event.
    /// </summary>
    public required SimliServerEventType Type { get; init; }

    /// <summary>
    /// For <see cref="SimliServerEventType.Answer"/> events, contains the SDP answer string.
    /// </summary>
    public string? Sdp { get; init; }

    /// <summary>
    /// For <see cref="SimliServerEventType.LivekitJoinInfo"/> events, contains the LiveKit room URL.
    /// </summary>
    public Uri? LivekitUrl { get; init; }

    /// <summary>
    /// For <see cref="SimliServerEventType.LivekitJoinInfo"/> events, contains the LiveKit join token.
    /// </summary>
    public string? LivekitToken { get; init; }

    /// <summary>
    /// The raw text of the server message, preserved for debugging or custom parsing.
    /// </summary>
    public string? RawText { get; init; }

    /// <summary>
    /// Returns true if this is an SDP answer event.
    /// </summary>
    public bool IsAnswer => Type == SimliServerEventType.Answer;

    /// <summary>
    /// Returns true if this is a LiveKit join info event.
    /// </summary>
    public bool IsLivekitJoinInfo => Type == SimliServerEventType.LivekitJoinInfo;

    /// <summary>
    /// Returns true if this is an error, rate limit, or closing event.
    /// </summary>
    public bool IsError => Type is SimliServerEventType.Error
        or SimliServerEventType.RateLimit
        or SimliServerEventType.Closing;

    /// <summary>
    /// Returns true if this is a signal event (START, ACK, STOP, SPEAK, SILENT).
    /// </summary>
    public bool IsSignal => Type is SimliServerEventType.Start
        or SimliServerEventType.Ack
        or SimliServerEventType.Stop
        or SimliServerEventType.Speak
        or SimliServerEventType.Silent;
}

/// <summary>
/// The type of event received from the Simli WebSocket server.
/// </summary>
public enum SimliServerEventType
{
    /// <summary>
    /// Unknown or unrecognized event.
    /// </summary>
    Unknown,

    /// <summary>
    /// SDP answer from the server (P2P channel only).
    /// Contains the SDP string in <see cref="SimliServerEvent.Sdp"/>.
    /// </summary>
    Answer,

    /// <summary>
    /// Server signal: session has started.
    /// </summary>
    Start,

    /// <summary>
    /// Server signal: acknowledgment.
    /// </summary>
    Ack,

    /// <summary>
    /// Server signal: session has stopped.
    /// </summary>
    Stop,

    /// <summary>
    /// Server signal: avatar is speaking.
    /// </summary>
    Speak,

    /// <summary>
    /// Server signal: avatar is silent.
    /// </summary>
    Silent,

    /// <summary>
    /// Error termination message (e.g., "ERROR: INVALID_API_KEY").
    /// </summary>
    Error,

    /// <summary>
    /// Rate limit termination message.
    /// </summary>
    RateLimit,

    /// <summary>
    /// Closing termination message.
    /// </summary>
    Closing,

    /// <summary>
    /// LiveKit room join info (LiveKit channel only).
    /// Contains URL and token in <see cref="SimliServerEvent.LivekitUrl"/>
    /// and <see cref="SimliServerEvent.LivekitToken"/>.
    /// </summary>
    LivekitJoinInfo,
}
