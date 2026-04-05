# CLAUDE.md -- Simli SDK

## Overview

Auto-generated C# SDK for [Simli](https://simli.com/) -- realtime avatar API platform with WebRTC streaming, face management, audio-to-video synthesis, and session management.
OpenAPI spec from the official Simli documentation.

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
- `src/libs/Simli/generate.sh` -- Downloads spec, runs autosdk with `--security-scheme ApiKey:Header:x-simli-api-key`
- `src/libs/Simli/Generated/` -- **Never edit** -- auto-generated code
- `src/libs/Simli/Extensions/SimliClient.Tools.cs` -- MEAI AIFunction tools
- `src/tests/IntegrationTests/Tests.cs` -- Test helper with API key auth
- `src/tests/IntegrationTests/Examples/` -- Example tests (also generate docs)

## Spec Notes

- OpenAPI spec: `https://docs.simli.com/api-reference/openapi.yaml` (3.1.0)
- Base URL: `https://api.simli.ai/`
- Auth: `--security-scheme ApiKey:Header:x-simli-api-key` sends the key directly as the native header (no spec conversion or PrepareRequest hook needed)

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
