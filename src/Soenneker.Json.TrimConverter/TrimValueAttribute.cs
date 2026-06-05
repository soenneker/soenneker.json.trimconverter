using System;
using System.Text.Json.Serialization;

namespace Soenneker.Json.TrimConverter;

/// <summary>
/// Represents the trim value attribute.
/// </summary>
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
public sealed class TrimValueAttribute : JsonConverterAttribute
{
    public TrimValueAttribute() : base(typeof(TrimJsonConverter))
    {
    }
}