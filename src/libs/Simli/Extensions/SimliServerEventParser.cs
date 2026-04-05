using System.Text.Json;

namespace Simli.Realtime;

/// <summary>
/// Parses raw WebSocket text messages into <see cref="SimliServerEvent"/> instances.
/// </summary>
internal static class SimliServerEventParser
{
    /// <summary>
    /// Parses a raw text message into a <see cref="SimliServerEvent"/>.
    /// Handles SDP answers, LiveKit join info, server signals, and error messages.
    /// </summary>
    public static SimliServerEvent Parse(string text)
    {
        // Try parsing as JSON (SDP answer or LiveKit join info)
        if (text.TrimStart().StartsWith('{'))
        {
            try
            {
                using var doc = JsonDocument.Parse(text);
                var root = doc.RootElement;

                // SDP answer
                if (root.TryGetProperty("type", out var typeEl) &&
                    typeEl.GetString() == "answer" &&
                    root.TryGetProperty("sdp", out var sdpEl))
                {
                    return new SimliServerEvent
                    {
                        Type = SimliServerEventType.Answer,
                        Sdp = sdpEl.GetString(),
                        RawText = text,
                    };
                }

                // LiveKit join info
                if (root.TryGetProperty("livekit_url", out var urlEl) &&
                    root.TryGetProperty("livekit_token", out var tokenEl))
                {
                    var urlString = urlEl.GetString();
                    Uri? livekitUri = null;
                    if (urlString is { Length: > 0 })
                    {
                        _ = Uri.TryCreate(urlString, UriKind.Absolute, out livekitUri);
                    }

                    return new SimliServerEvent
                    {
                        Type = SimliServerEventType.LivekitJoinInfo,
                        LivekitUrl = livekitUri,
                        LivekitToken = tokenEl.GetString(),
                        RawText = text,
                    };
                }
            }
            catch (JsonException)
            {
                // Fall through to string parsing
            }
        }

        // Parse known signal strings
        return text.Trim().ToUpperInvariant() switch
        {
            "START" => new SimliServerEvent { Type = SimliServerEventType.Start, RawText = text },
            "ACK" => new SimliServerEvent { Type = SimliServerEventType.Ack, RawText = text },
            "STOP" => new SimliServerEvent { Type = SimliServerEventType.Stop, RawText = text },
            "SPEAK" => new SimliServerEvent { Type = SimliServerEventType.Speak, RawText = text },
            "SILENT" => new SimliServerEvent { Type = SimliServerEventType.Silent, RawText = text },
            _ when text.StartsWith("ERROR", StringComparison.OrdinalIgnoreCase) =>
                new SimliServerEvent { Type = SimliServerEventType.Error, RawText = text },
            _ when text.StartsWith("RATE", StringComparison.OrdinalIgnoreCase) =>
                new SimliServerEvent { Type = SimliServerEventType.RateLimit, RawText = text },
            _ when text.StartsWith("CLOSING", StringComparison.OrdinalIgnoreCase) =>
                new SimliServerEvent { Type = SimliServerEventType.Closing, RawText = text },
            _ => new SimliServerEvent { Type = SimliServerEventType.Unknown, RawText = text },
        };
    }
}
