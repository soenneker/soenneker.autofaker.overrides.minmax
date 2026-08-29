[![](https://img.shields.io/nuget/v/soenneker.autofaker.overrides.minmax.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.autofaker.overrides.minmax/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.autofaker.overrides.minmax/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.autofaker.overrides.minmax/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.autofaker.overrides.minmax.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.autofaker.overrides.minmax/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.autofaker.overrides.minmax/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.autofaker.overrides.minmax/actions/workflows/codeql.yml)

# Soenneker.AutoFaker.Overrides.MinMax

An AutoFaker override that generates ordered decimal bounds for `MinMax` fixtures.

## Installation

```bash
dotnet add package Soenneker.AutoFaker.Overrides.MinMax
```

## Usage

```csharp
using Soenneker.AutoFaker.Overrides.MinMax;
using Soenneker.Dtos.MinMax;
using Soenneker.Utils.AutoBogus;

var autoFaker = new AutoFaker();
autoFaker.Config.Overrides = [new MinMaxOverride()];

MinMax range = autoFaker.Generate<MinMax>();
```

`Min` is generated between `0.20` and `28.50`; `Max` is generated between that minimum and `30.00`. The invariant `Min <= Max` is therefore preserved. Values use Bogus's finance amount generator and its decimal precision.
