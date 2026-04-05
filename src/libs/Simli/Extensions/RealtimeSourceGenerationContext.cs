using System.Text.Json.Serialization;

namespace Simli.Realtime;

/// <summary>
/// Extends the generated <see cref="RealtimeSourceGenerationContext"/> with
/// the minimum required JsonSerializable attribute for the source generator.
/// </summary>
[JsonSerializable(typeof(string))]
public sealed partial class RealtimeSourceGenerationContext;
