using System.Globalization;

namespace Ainsworth.Extensions;

// Suppress known issue
#pragma warning disable CA1305 // Specify IFormatProvider

public static partial class ParseExtensions {

    #region string.ParseInt32() Extension Methods
    /*******************************************************
    * string.ParseInt32() && string.TryParseInt32()
    *******************************************************/

    /// <inheritdoc cref="int.Parse(string)"/>
    public static int ParseInt32(this string s) => int.Parse(s);

    /// <inheritdoc cref="int.Parse(string, NumberStyles, IFormatProvider)"/>
    public static int ParseInt32(this string s, NumberStyles style, IFormatProvider? provider) =>
        int.Parse(s, style, provider);

    /// <inheritdoc cref="int.Parse(string, IFormatProvider)"/>
    public static int ParseInt32(this string s, IFormatProvider? provider) => int.Parse(s, provider);

    /// <inheritdoc cref="int.Parse(string, NumberStyles)"/>
    public static int ParseInt32(this string s, NumberStyles style) => int.Parse(s, style);

    /**
    * string.TryParseInt32()
    */

    /// <inheritdoc cref="int.TryParse(string, out int)"/>
    public static bool TryParseInt32(this string s, out int result) => int.TryParse(s, out result);

    /// <inheritdoc cref="int.TryParse(string, NumberStyles, IFormatProvider, out int)"/>
    public static bool TryParseInt32(
        this string s, NumberStyles style, IFormatProvider? provider, out int result)
        => int.TryParse(s, style, provider, out result);


    /// <inheritdoc cref="int.TryParse(string, IFormatProvider, out int)"/>
    public static bool TryParseInt32(this string s, IFormatProvider? provider, out int result) =>
#if NET7_0_OR_GREATER
        int.TryParse(s, provider, out result);
#else
        int.TryParse(s, NumberStyles.Integer, provider, out result);
#endif

    /// <inheritdoc cref="int.TryParse(string, NumberStyles, IFormatProvider, out int)"/>
    public static bool TryParseInt32(this string s, NumberStyles style, out int result)
        => int.TryParse(s, style, provider: null, out result);

    #endregion
    #region string.ParseInt64() Extension Methods
    /*******************************************************
    * string.ParseInt64() && string.TryParseInt64()
    *******************************************************/

    /// <inheritdoc cref="long.Parse(string)"/>
    public static long ParseInt64(this string s) => long.Parse(s);

    /// <inheritdoc cref="long.Parse(string, NumberStyles, IFormatProvider)"/>
    public static long ParseInt64(this string s, NumberStyles style, IFormatProvider? provider)
        => long.Parse(s, style, provider);

    /// <inheritdoc cref="long.Parse(string, IFormatProvider)"/>
    public static long ParseInt64(this string s, IFormatProvider? provider)
        => long.Parse(s, provider);

    /// <inheritdoc cref="long.Parse(string, NumberStyles, IFormatProvider)"/>
    public static long ParseInt64(this string s, NumberStyles style) => long.Parse(s, style);

    /**
    * string.TryParseInt64()
    */

    /// <inheritdoc cref="long.TryParse(string, out long)"/>
    public static bool TryParseInt64(this string s, out long result)
        => long.TryParse(s, out result);

    /// <inheritdoc cref="long.TryParse(string, NumberStyles, IFormatProvider, out long)"/>
    public static bool TryParseInt64(
        this string s, NumberStyles style, IFormatProvider? provider, out long result)
        => long.TryParse(s, style, provider, out result);

    /// <inheritdoc cref="long.TryParse(string, IFormatProvider, out long)"/>
    public static bool TryParseInt64(this string s, IFormatProvider? provider, out long result) =>
#if NET7_0_OR_GREATER
        long.TryParse(s, provider, out result);
#else
        long.TryParse(s, NumberStyles.Integer, provider, out result);
#endif

    /// <inheritdoc cref="long.TryParse(string, NumberStyles, IFormatProvider, out long)"/>
    public static bool TryParseInt64(this string s, NumberStyles style, out long result)
        => long.TryParse(s, style, provider: null, out result);

    #endregion
}

