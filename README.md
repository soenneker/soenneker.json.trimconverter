[![](https://img.shields.io/nuget/v/Soenneker.Json.TrimConverter.svg?style=for-the-badge)](https://www.nuget.org/packages/Soenneker.Json.TrimConverter/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.json.trimconverter/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.json.trimconverter/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/Soenneker.Json.TrimConverter.svg?style=for-the-badge)](https://www.nuget.org/packages/Soenneker.Json.TrimConverter/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.json.trimconverter/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.json.trimconverter/actions/workflows/codeql.yml)

# Soenneker.Json.TrimConverter

A System.Text.Json converter attribute for automatic string trimming.

## Install

```bash
dotnet add package Soenneker.Json.TrimConverter
```

## What you get

- `TrimJsonConverter` — A System.Text.Json converter attribute for automatic string trimming.
- `TrimValueAttribute` — Represents the trim value attribute.

## API at a glance

| API | What it does | Result / important behavior |
| --- | --- | --- |
| `TrimJsonConverter.Read(reader, typeToConvert, options)` | Executes the read operation. | The result of the operation. |
