using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Soenneker.Extensions.String;

namespace Soenneker.Json.TrimConverter;

/// <summary>
/// A System.Text.Json converter attribute for automatic string trimming
/// </summary>
public class TrimJsonConverter : JsonConverter<string?>
{
    public override string? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        return reader.GetString()?.TrimFast();
    }

    public override void Write(Utf8JsonWriter writer, string? value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(value);
    }
}