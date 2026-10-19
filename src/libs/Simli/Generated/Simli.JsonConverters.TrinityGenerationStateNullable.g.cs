#nullable enable

namespace Simli.JsonConverters
{
    /// <inheritdoc />
    public sealed class TrinityGenerationStateNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Simli.TrinityGenerationState?>
    {
        /// <inheritdoc />
        public override global::Simli.TrinityGenerationState? Read(
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
                        return global::Simli.TrinityGenerationStateExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Simli.TrinityGenerationState)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Simli.TrinityGenerationState?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Simli.TrinityGenerationState? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Simli.TrinityGenerationStateExtensions.ToValueString(value.Value));
            }
        }
    }
}
