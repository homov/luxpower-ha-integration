# Python to C# Translation Notes

This document describes the translation of `const.py` from Python to C# (`Constants.cs`).

## Translation Mapping

### Python → C# Type Conversions

| Python Type | C# Type | Example |
|------------|---------|---------|
| `str` | `string` | `"host"` → `"host"` |
| `int` | `int` | `60` → `60` |
| `bool` | `bool` | `False` → `false`, `True` → `true` |
| `Final` (constant) | `const` | `DOMAIN: Final = "lxp_modbus"` → `public const string DOMAIN = "lxp_modbus";` |
| `List[Platform]` | `readonly string[]` | `[Platform.SENSOR, ...]` → `new[] { "sensor", ... }` |

### Key Translation Decisions

1. **Namespace**: Created `LxpModbus` namespace for better organization in C#
2. **Class Structure**: Used `public static class Constants` to hold all constants (similar to Python module-level constants)
3. **Platform Enum**: Converted Home Assistant's `Platform` enum values to their string equivalents since we don't have the Home Assistant library in C#
4. **Constant Modifiers**: 
   - Simple constants use `const` (compile-time constants)
   - Arrays use `static readonly` (runtime constants) since arrays cannot be `const` in C#
5. **Naming Convention**: Kept Python's UPPER_CASE naming for constants to maintain consistency with the original code
6. **Comments**: Preserved all comments from the original Python file

## File Comparison

### Python (const.py)
```python
from typing import Final
from homeassistant.const import Platform

DOMAIN = "lxp_modbus"

PLATFORMS: Final = [
    Platform.SENSOR,
    Platform.NUMBER,
    Platform.TIME,
    Platform.SELECT,
    Platform.BUTTON,
    Platform.SWITCH,
]
```

### C# (Constants.cs)
```csharp
namespace LxpModbus
{
    public static class Constants
    {
        public const string DOMAIN = "lxp_modbus";

        public static readonly string[] PLATFORMS = new[]
        {
            "sensor",
            "number",
            "time",
            "select",
            "button",
            "switch"
        };
```

## Verification

The C# code has been validated by:
1. Creating a .NET 8.0 class library project
2. Compiling the Constants.cs file
3. Confirming zero compilation errors or warnings

## Usage in C#

```csharp
using LxpModbus;

// Access constants
string domain = Constants.DOMAIN;
int defaultPort = Constants.DEFAULT_PORT;
string[] platforms = Constants.PLATFORMS;
```
