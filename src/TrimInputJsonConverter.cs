using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Soenneker.Json.TrimConverter;

/// <summary>
/// A System.Text.Json converter attribute for automatic string trimming
/// </summary>
public class TrimJsonConverter : JsonConverter<string?>
{
    public override string? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        string? result = reader.GetString()?.Trim();
        return result;
    }

    public override void Write(Utf8JsonWriter writer, string? value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(value);
    }
}