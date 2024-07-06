namespace Soenneker.Json.TrimConverter.Tests;

public class TestClass
{
    [System.Text.Json.Serialization.JsonConverter(typeof(TrimJsonConverter))]
    public string Test { get; set; }
}