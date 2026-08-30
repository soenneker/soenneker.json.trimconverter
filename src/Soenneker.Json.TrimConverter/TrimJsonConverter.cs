using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Soenneker.Json.TrimConverter;

/// <summary>
/// Trims JSON string values when reading and preserves them unchanged when writing.
/// </summary>
public sealed class TrimJsonConverter : JsonConverter<string?>
{
    /// <summary>
    /// Reads a JSON string and removes leading and trailing whitespace.
    /// </summary>
    /// <param name="reader">The reader.</param>
    /// <param name="typeToConvert">The type to convert.</param>
    /// <param name="options">The options.</param>
    /// <returns>The trimmed string, or <see langword="null"/> for JSON null.</returns>
    public override string? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.Null)
            return null;

        if (reader.TokenType != JsonTokenType.String)
            throw new JsonException($"Expected a JSON string but found {reader.TokenType}.");

        return reader.GetString()?.Trim();
    }

    /// <summary>
    /// Writes the string without trimming it.
    /// </summary>
    /// <param name="writer">The writer.</param>
    /// <param name="value">The value.</param>
    /// <param name="options">The options.</param>
    public override void Write(Utf8JsonWriter writer, string? value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(value);
    }
}
