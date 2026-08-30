using System;
using System.Text.Json.Serialization;

namespace Soenneker.Json.TrimConverter;

/// <summary>
/// Trims a string property or field when it is read from JSON.
/// </summary>
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
public sealed class TrimValueAttribute : JsonConverterAttribute
{
    /// <summary>
    /// Creates the converter attribute.
    /// </summary>
    public TrimValueAttribute() : base(typeof(TrimJsonConverter))
    {
    }
}
