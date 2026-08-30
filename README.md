[![](https://img.shields.io/nuget/v/Soenneker.Json.TrimConverter.svg?style=for-the-badge)](https://www.nuget.org/packages/Soenneker.Json.TrimConverter/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.json.trimconverter/build-and-test.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.json.trimconverter/actions/workflows/build-and-test.yml)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.json.trimconverter/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.json.trimconverter/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/Soenneker.Json.TrimConverter.svg?style=for-the-badge)](https://www.nuget.org/packages/Soenneker.Json.TrimConverter/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.json.trimconverter/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.json.trimconverter/actions/workflows/codeql.yml)

# Soenneker.Json.TrimConverter

Trims selected string values as they are deserialized by `System.Text.Json`.

## Install

```bash
dotnet add package Soenneker.Json.TrimConverter
```

## Usage

```csharp
using Soenneker.Json.TrimConverter;

public sealed class CreateCustomerRequest
{
    [TrimValue]
    public string? DisplayName { get; init; }
}
```

```csharp
CreateCustomerRequest? request =
    JsonSerializer.Deserialize<CreateCustomerRequest>(
        """{"DisplayName":"  Ada Lovelace  "}""");

// request.DisplayName == "Ada Lovelace"
```

`TrimValue` calls `string.Trim()` on inbound string values, removing leading and trailing Unicode whitespace. Whitespace-only input becomes an empty string; JSON `null` remains null. A non-string token for an attributed member throws `JsonException`.

Serialization does not trim:

```csharp
var request = new CreateCustomerRequest
{
    DisplayName = "  Ada Lovelace  "
};

string json = JsonSerializer.Serialize(request);
// {"DisplayName":"  Ada Lovelace  "}
```

The attribute can be placed on string properties and fields. Applying it to another type is unsupported. You can register `TrimJsonConverter` globally, but doing so trims every string read through those serializer options; prefer the attribute for targeted input normalization.
