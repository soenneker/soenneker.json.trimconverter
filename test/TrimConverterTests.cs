﻿using FluentAssertions;
using Xunit;

namespace Soenneker.Json.TrimConverter.Tests;

public class TrimConverterTests
{
    [Fact]
    public void Should_convert_with_systemtextjson()
    {
        var testClass = new TestClass { Test = "  blah  " };

        var result = System.Text.Json.JsonSerializer.Serialize(testClass);
        result.Should().NotBeNull();
    }
}