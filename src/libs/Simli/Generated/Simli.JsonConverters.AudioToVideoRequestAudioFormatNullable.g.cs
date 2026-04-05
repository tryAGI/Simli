#nullable enable

namespace Simli.JsonConverters
{
    /// <inheritdoc />
    public sealed class AudioToVideoRequestAudioFormatNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Simli.AudioToVideoRequestAudioFormat?>
    {
        /// <inheritdoc />
        public override global::Simli.AudioToVideoRequestAudioFormat? Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Simli.AudioToVideoRequestAudioFormatExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Simli.AudioToVideoRequestAudioFormat)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Simli.AudioToVideoRequestAudioFormat?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Simli.AudioToVideoRequestAudioFormat? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Simli.AudioToVideoRequestAudioFormatExtensions.ToValueString(value.Value));
            }
        }
    }
}
