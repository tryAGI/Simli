#!/usr/bin/env bash
set -euo pipefail

# OpenAPI spec: https://docs.simli.com/api-reference/openapi.yaml

dotnet tool install --global autosdk.cli --prerelease

rm -rf Generated
curl --fail --silent --show-error -L -o openapi.yaml https://docs.simli.com/api-reference/openapi.yaml

# Auth: Simli uses x-simli-api-key header -- spec already has proper apiKey securityScheme,
#       but we override with ApiKey:Header to ensure autosdk generates the right constructor.
autosdk generate openapi.yaml \
  --namespace Simli \
  --clientClassName SimliClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --security-scheme ApiKey:Header:x-simli-api-key

# Generate WebSocket clients from AsyncAPI spec (2 channels: P2P and LiveKit).
# The spec defines the WebRTC signaling protocol over WebSocket:
# - P2P: SDP offer/answer exchange + audio chunks + control signals
# - LiveKit: LiveKit room join info + audio chunks + control signals
curl --fail --silent --show-error -L -o asyncapi.yaml https://docs.simli.com/api-reference/asyncapi.yaml

autosdk generate asyncapi.yaml \
  --namespace Simli.Realtime \
  --websocket-class-name SimliRealtimeClient \
  --json-serializer-context RealtimeSourceGenerationContext \
  --targetFramework net10.0 \
  --output Generated
