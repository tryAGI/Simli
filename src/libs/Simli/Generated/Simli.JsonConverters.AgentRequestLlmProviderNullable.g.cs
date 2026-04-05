#nullable enable

namespace Simli.JsonConverters
{
    /// <inheritdoc />
    public sealed class AgentRequestLlmProviderNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Simli.AgentRequestLlmProvider?>
    {
        /// <inheritdoc />
        public override global::Simli.AgentRequestLlmProvider? Read(
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
                        return global::Simli.AgentRequestLlmProviderExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Simli.AgentRequestLlmProvider)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Simli.AgentRequestLlmProvider?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Simli.AgentRequestLlmProvider? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Simli.AgentRequestLlmProviderExtensions.ToValueString(value.Value));
            }
        }
    }
}
