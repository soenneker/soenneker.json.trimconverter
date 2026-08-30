using AwesomeAssertions;

namespace Soenneker.Json.TrimConverter.Tests;

public class TrimConverterTests
{
    [Test]
    public void Should_convert_with_systemtextjson()
    {
        var testClass = new TestClass { Test = "  blah  " };

        string result = System.Text.Json.JsonSerializer.Serialize(testClass);
        result.Should().Be("{\"Test\":\"  blah  \"}");
    }

    [Test]
    public void Should_trim_during_deserialization()
    {
        TestClass? result = System.Text.Json.JsonSerializer.Deserialize<TestClass>("{\"Test\":\"  blah  \"}");

        result.Should().NotBeNull();
        result!.Test.Should().Be("blah");
    }
}
