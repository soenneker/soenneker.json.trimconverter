using System;
using System.Text.Json.Serialization;

namespace Soenneker.Json.TrimConverter;

[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
public sealed class TrimValueAttribute : JsonConverterAttribute
{
    public TrimValueAttribute() : base(typeof(TrimJsonConverter))
    {
    }
}