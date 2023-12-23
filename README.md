# dotnet-extensions

Extension methods to make built-in static methods available as instance
methods.  For example, Char.IsLetter(c) can be written c.IsLetter(). This
package adds no new functionality. It just enables method chaining and makes
interfaces to some System classes a bit more fluent.

The motivation behind this class library is to add expressiveness of chaining to existing .NET System classes.  For example:

```C#
    // Instead of function calls, inside of function calls,
    // inside of function calls, ..., all of which are a bit inside-out,
    var b = char.IsLetter(third(second(first())));
    var i = int.Parse(third(second(first())));
    var l = (long)third(second(first()));

    // Use chaining to show execution order and make it a bit easier for
    // human parsing.
    var b = first().second().third().IsLetter();
    var i = first().second().third().ParseInt();
    var l = first().second().third().ToLong();
```

## Examples

| Extension Method | Underlying .NET library Implementation |
|------------------|----------------------------------------|
| `ParseInt(s)`  | [`Int32.Parse(s)`](https://learn.microsoft.com/en-us/dotnet/api/system.int32.parse#system-int32-parse(system-string)) |
| `IsDigit(c)` | [`Char.IsDigit(c)`](https://learn.microsoft.com/en-us/dotnet/api/system.char.isdigit#system-char-isdigit(system-char)) |
| `IsLetter(c, index)` | [`Char.IsLetter(c, index)`](https://learn.microsoft.com/en-us/dotnet/api/system.char.isletter#system-char-isletter(system-string-system-int32)) |
| `n.ToLong()` | [ `(long)n` ](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/language-specification/conversions#1032-explicit-numeric-conversions) |

## Usage

```C#
using Ainsworth.System.Chaining;

var c = 'x';
var b = c.IsLetter();
```
## Limitations

1. There are no known technical problems or conflicts. Please report problems on GitHub.

2. This is far from a complete library. Basically, new features are added as need arises. Pull requests welcome.
