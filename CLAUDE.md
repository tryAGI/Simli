# CLAUDE.md -- Simli SDK

## Overview

Auto-generated C# SDK for [Simli](https://simli.com/) -- realtime avatar API platform with WebRTC streaming, face management, audio-to-video synthesis, and session management.
OpenAPI spec (REST) + AsyncAPI spec (WebSocket) from the official Simli documentation.

## Build & Test

```bash
dotnet build Simli.slnx
dotnet test src/tests/IntegrationTests/
```

## Auth

API key auth (sent as `x-simli-api-key` header via `--security-scheme`):

```csharp
var client = new SimliClient(apiKey); // SIMLI_API_KEY env var
```

## Key Files

- `src/libs/Simli/openapi.yaml` -- OpenAPI spec (downloaded from docs.simli.com)
- `src/libs/Simli/asyncapi.yaml` -- AsyncAPI spec for WebSocket channels (P2P + LiveKit)
- `src/libs/Simli/generate.sh` -- Downloads specs, runs autosdk for both OpenAPI and AsyncAPI
- `src/libs/Simli/Generated/` -- **Never edit** -- auto-generated code
- `src/libs/Simli/Extensions/SimliClient.Tools.cs` -- MEAI AIFunction tools
- `src/libs/Simli/Extensions/SimliPeerToPeerRealtimeClient.Extensions.cs` -- Typed P2P WebSocket ops
- `src/libs/Simli/Extensions/SimliLivekitRealtimeClient.Extensions.cs` -- Typed LiveKit WebSocket ops
- `src/libs/Simli/Extensions/SimliServerEvent.cs` -- Server event model + enum
- `src/libs/Simli/Extensions/SimliServerEventParser.cs` -- Shared event parsing logic
- `src/tests/IntegrationTests/Tests.cs` -- Test helper with API key auth
- `src/tests/IntegrationTests/Examples/` -- Example tests (also generate docs)

## Multi-Spec Architecture

This SDK uses both OpenAPI and AsyncAPI specs:

| Spec | Namespace | Client(s) | Purpose |
|------|-----------|-----------|---------|
| OpenAPI (`openapi.yaml`) | `Simli` | `SimliClient` | REST API: session tokens, static video, faces, history |
| AsyncAPI (`asyncapi.yaml`) | `Simli.Realtime` | `SimliPeerToPeerRealtimeClient`, `SimliLivekitRealtimeClient` | WebSocket: realtime avatar streaming |

### P2P Client (`SimliPeerToPeerRealtimeClient`)

Direct WebRTC connection with optional Cloudflare SFU routing:
- `ConnectAsync(sessionToken, enableSfu)` -- connect with session token as query param
- `SendOfferAsync(sdp)` -- send SDP offer (must be first message within 30s)
- `SendAudioAsync(pcm16Audio)` -- send binary PCM16 audio chunk
- `SendClearBufferAsync()` -- send "SKIP" to stop avatar immediately
- `SendFinalMessageAsync()` -- send "DONE" when audio is complete
- `ReceiveEventsAsync()` -- `IAsyncEnumerable<SimliServerEvent>` with SDP answer, signals, errors

### LiveKit Client (`SimliLivekitRealtimeClient`)

CloudFlare-backed WebRTC via LiveKit room:
- `ConnectAsync(sessionToken)` -- connect with session token as query param
- `SendAudioAsync(pcm16Audio)` -- send binary PCM16 audio chunk
- `SendClearBufferAsync()` -- send "SKIP" to stop avatar immediately
- `SendFinalMessageAsync()` -- send "DONE" when audio is complete
- `ReceiveEventsAsync()` -- `IAsyncEnumerable<SimliServerEvent>` with LiveKit join info, signals, errors

### Server Events

| Type | Description |
|------|-------------|
| `Answer` | SDP answer (P2P only) -- contains `Sdp` property |
| `LivekitJoinInfo` | LiveKit room URL + token -- contains `LivekitUrl`, `LivekitToken` |
| `Start` / `Ack` / `Stop` | Session lifecycle signals |
| `Speak` / `Silent` | Avatar speaking state signals |
| `Error` / `RateLimit` / `Closing` | Termination messages |

## Spec Notes

- OpenAPI spec: `https://docs.simli.com/api-reference/openapi.yaml` (3.1.0)
- AsyncAPI spec: `https://docs.simli.com/api-reference/asyncapi.yaml` (3.0.0)
- Base URL: `https://api.simli.ai/`
- WebSocket URLs: `wss://api.simli.ai/compose/webrtc/p2p`, `wss://api.simli.ai/compose/webrtc/livekit`
- Auth (REST): `--security-scheme ApiKey:Header:x-simli-api-key` sends the key directly as the native header
- Auth (WebSocket): Session token passed as query parameter (token obtained from REST `/compose/token` endpoint)

## Endpoints

| Endpoint | Method | Description |
|----------|--------|-------------|
| `/compose/token` | POST | Create Compose session token for WebRTC streaming |
| `/compose/ice` | GET | Get ICE server credentials for WebRTC P2P |
| `/static/audio` | POST | Generate static video from audio (returns HLS + MP4 URLs) |
| `/static/hls/{dest}/{file}` | GET | Get HLS stream segment |
| `/static/mp4/{dest}/{file}` | GET | Get MP4 of generated video |
| `/faces` | GET | List all avatar faces |
| `/faces/trinity` | POST | Generate Trinity face from image |
| `/faces/trinity/generation_status` | GET | Check Trinity face generation status |
| `/faces/trinity/{id}` | DELETE | Delete a face |
| `/integrations/livekit/agents` | POST | Start LiveKit agents session |
| `/history/sessions` | GET | Retrieve session history |
| `/ratelimiter/sessions` | GET | Get active session count |

## MEAI AIFunction Tools

| Tool | Method | Description |
|------|--------|-------------|
| `AsCreateSessionTokenTool()` | Session | Creates a Compose session token for a face ID |
| `AsGenerateStaticVideoTool()` | Video | Generates static avatar video from base64 audio |
| `AsListFacesTool()` | Faces | Lists all available avatar faces |
| `AsGetSessionHistoryTool()` | History | Retrieves session history records |
| `AsGetActiveSessionCountTool()` | Status | Gets the current active session count |
