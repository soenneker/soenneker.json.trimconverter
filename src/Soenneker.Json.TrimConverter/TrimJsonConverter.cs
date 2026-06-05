using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Soenneker.Json.TrimConverter;

/// <summary>
/// A System.Text.Json converter attribute for automatic string trimming
/// </summary>
public sealed class TrimJsonConverter : JsonConverter<string?>
{
    /// <summary>
    /// Executes the read operation.
    /// </summary>
    /// <param name="reader">The reader.</param>
    /// <param name="typeToConvert">The type to convert.</param>
    /// <param name="options">The options.</param>
    /// <returns>The result of the operation.</returns>
    public override string? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        return reader.GetString()?.Trim();
    }

    /// <summary>
    /// Executes the write operation.
    /// </summary>
    /// <param name="writer">The writer.</param>
    /// <param name="value">The value.</param>
    /// <param name="options">The options.</param>
    public override void Write(Utf8JsonWriter writer, string? value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(value);
    }
}