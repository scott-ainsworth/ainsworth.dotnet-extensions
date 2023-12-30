using System.Numerics;
using System.Security.Cryptography;

namespace Ainsworth.Extensions;

public static class ConversionExtensions {

// Suppress known issue
#pragma warning disable CA1305 // Specify IFormatProvider

    /// <inheritdoc cref="int.Parse(string)"/>
    public static int ParseInt(this string s) => int.Parse(s);

    /// <inheritdoc cref="int.Parse(string)"/>
    /// <exception cref="InvalidCastException">
    ///   <paramref name="obj"/> is not a <see cref="string"/>
    /// </exception>
    public static int ParseInt(this object? obj) => ((string)obj!).ParseInt();

    /// <inheritdoc cref="long.Parse(string)"/>
    public static long ParseLong(this string s) => long.Parse(s);

    /// <inheritdoc cref="long.Parse(string)"/>
    /// <exception cref="InvalidCastException">
    ///   <paramref name="obj"/> is not a <see cref="string"/>
    /// </exception>
    public static long ParseLong(this object? obj) => ((string)obj!).ParseLong();

}
