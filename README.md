# dotnet-extensions

Various/random .NET extension methods

The motivation behind this class library is to expressiveness of functional code styles in C#. For example:

```C#
    // Instead of function calls, inside of function calls, inside of function calls, ...
    var i = int.Parse(some_function_that_returns_a_string());
    var l = (long)some_function_that_returns_an_int();

    // We can use a chain-style that can be read more naturally
    // (at least for those who use languages written left-to-right).
    var i = some_function_that_returns_a_string().ParseInt();
    var l = some_function_that_returns_an_int().ToLong();
```

## Example: ConversionExtensions

| Extension Method | Underlying .NET library Implementation |
|------------------|----------------------------------------|
| `ParseInt(string)`  | [`Int32.Parse(string)`](https://learn.microsoft.com/en-us/dotnet/api/system.int32.parse#system-int32-parse(system-string)) |
| `ParseInt(object)`  | [`Int32.Parse(string)`](https://learn.microsoft.com/en-us/dotnet/api/system.int32.parse#system-int32-parse(system-string)) |
| `ParseLong(string)` | [`Int64.Parse(string)`](https://learn.microsoft.com/en-us/dotnet/api/system.int64.parse#system-int64-parse(system-string)) |
| `ParseLong(object)` | [`Int64.Parse(string)`](https://learn.microsoft.com/en-us/dotnet/api/system.int64.parse#system-int64-parse(system-string)) |

## Notes

1. This is far from a complete library. Basically, I add new features as I need them. Few, if any, of the possibilites in the standard .NET libraries are covered completely. For instance, [`int.Parse()`](https://learn.microsoft.com/en-us/dotnet/api/system.int32.parse) has has eigth overloads. This library currently covers just one.