using System.Globalization;

namespace Ainsworth.Extensions;

// In this code, the library name (e.g., Char vice char) add clarity.
#pragma warning disable IDE0049 // Simplify Names

/// <summary>
///   Convenience versions of static <see cref="Char"/> methods.
/// </summary>
/// <seealso href="https://github.com/Microsoft/referencesource/blob/master/mscorlib/system/char.cs">
///   System.Char source code.<seealso/>
public static class CharExtensions {

    #region ConvertFromUtf32 and ConvertToUtf32 equivalents

    /// <inheritdoc cref="Char.ConvertFromUtf32(int)"/>
    public static string ToUtf32String(int utf32) => Char.ConvertFromUtf32(utf32);

    /// <inheritdoc cref="Char.ConvertToUtf32(char, char)"/>
    public static int ToUtf32(this string s, int index)
        => Char.ConvertToUtf32(s, index);

    #endregion
    #region Char.Get...()   

    public static double GetNumericValue(this char c) => Char.GetNumericValue(c);

    public static double GetNumericValue(this string s, int index) => Char.GetNumericValue(s, index);

    public static UnicodeCategory GetUnicodeCategory(this char c) => Char.GetUnicodeCategory(c);

    #endregion
    #region Char.Is...()
    #region Char.IsAscii...()

    /// <inheritdoc cref="Char.IsAscii(char)"/>
    public static bool IsAscii(this char c) => Char.IsAscii(c);

    /// <inheritdoc cref="Char.IsAsciiHexDigit(char)"/>
    public static bool IsAsciiHexDigit(this char c) => Char.IsAsciiHexDigit(c);

    /// <inheritdoc cref="Char.IsAsciiHexDigitLower(char)"/>
    public static bool IsAsciiHexDigitLower(this char c) => Char.IsAsciiHexDigitLower(c);

    /// <inheritdoc cref="Char.IsAsciiHexDigitUpper(char)"/>
    public static bool IsAsciiHexDigitUpper(this char c) => Char.IsAsciiHexDigitUpper(c);

    /// <inheritdoc cref="Char.IsAsciiLetter(char)"/>
    public static bool IsAsciiLetter(this char c) => Char.IsAsciiLetter(c);

    /// <inheritdoc cref="Char.IsAsciiLetterLower(char)"/>
    public static bool IsAsciiLetterLower(this char c) => Char.IsAsciiLetterLower(c);

    /// <inheritdoc cref="Char.IsAsciiLetterOrDigit(char)"/>
    public static bool IsAsciiLetterOrDigit(this char c) => Char.IsAsciiLetterOrDigit(c);

    /// <inheritdoc cref="Char.IsAsciiLetterUpper(char)"/>
    public static bool IsAsciiLetterUpper(this char c) => Char.IsAsciiLetterUpper(c);

    #endregion
    #region Char.IsBetween()

    /// <inheritdoc cref="Char.IsBetween(char, char, char)"/>
    public static bool IsBetween(this char c, char minInclusive, char maxInclusive)
        => Char.IsBetween(c, minInclusive, maxInclusive);

    /// <inheritdoc cref="Char.IsControl(char)"/>
    ///
    #endregion
    #region Char.IsControl()

    public static bool IsControl(this char c) => Char.IsControl(c);

    /// <inheritdoc cref="Char.IsControl(string, int)"/>
    public static bool IsControl(this string s, int index) => Char.IsControl(s, index);

    #endregion
    #region Char.IsDigit()

    /// <inheritdoc cref="Char.IsDigit(char)"/>
    public static bool IsDigit(this char c) => Char.IsDigit(c);

    /// <inheritdoc cref="Char.IsDigit(string, int)"/>
    public static bool IsDigit(this string s, int index) => Char.IsDigit(s, index);

    #endregion
    #region Char.IsHighSurrogate()

    /// <inheritdoc cref="Char.IsHighSurrogate(char)"/>
    public static bool IsHighSurrogate(this char c) => Char.IsHighSurrogate(c);

    /// <inheritdoc cref="Char.IsHighSurrogate(string, int)"/>
    public static bool IsHighSurrogate(this string s, int index) => Char.IsHighSurrogate(s, index);

    #endregion
    #region Char.IsLetter()

    /// <inheritdoc cref="Char.IsLetter(char)"/>
    public static bool IsLetter(this char c) => Char.IsLetter(c);

    /// <inheritdoc cref="Char.IsLetter(string, int)"/>
    public static bool IsLetter(this string s, int index) => Char.IsLetter(s, index);

    #endregion
    #region Char.IsLetterOrDigit()

    /// <inheritdoc cref="Char.IsLetterOrDigit(char)"/>
    public static bool IsLetterOrDigit(this char c) => Char.IsLetterOrDigit(c);

    /// <inheritdoc cref="Char.IsLetterOrDigit(string, int)"/>
    public static bool IsLetterOrDigit(this string s, int index) => Char.IsLetterOrDigit(s, index);

    #endregion
    #region Char.IsLower()

    /// <inheritdoc cref="Char.IsLower(char)"/>
    public static bool IsLower(this char c) => Char.IsLower(c);

    /// <inheritdoc cref="Char.IsLower(string, int)"/>
    public static bool IsLower(this string s, int index) => Char.IsLower(s, index);

    #endregion
    #region Char.IsLowSurrogate()

    /// <inheritdoc cref="Char.IsLowSurrogate(char)"/>
    public static bool IsLowSurrogate(this char c) => Char.IsLowSurrogate(c);

    /// <inheritdoc cref="Char.IsLowSurrogate(string, int)"/>
    public static bool IsLowSurrogate(this string s, int index) => Char.IsLowSurrogate(s, index);

    #endregion
    #region Char.IsNumber()

    /// <inheritdoc cref="Char.IsNumber(char)"/>
    public static bool IsNumber(this char c) => Char.IsNumber(c);

    /// <inheritdoc cref="Char.IsNumber(string, int)"/>
    public static bool IsNumber(this string s, int index) => Char.IsNumber(s, index);

    #endregion
    #region Char.IsPunctuation()

    /// <inheritdoc cref="Char.IsPunctuation(char)"/>
    public static bool IsPunctuation(this char c) => Char.IsPunctuation(c);

    /// <inheritdoc cref="Char.IsPunctuation(string, int)"/>
    public static bool IsPunctuation(this string s, int index) => Char.IsPunctuation(s, index);

    #endregion
    #region Char.IsSeparator()

    /// <inheritdoc cref="Char.IsSeparator(char)"/>
    public static bool IsSeparator(this char c) => Char.IsSeparator(c);

    /// <inheritdoc cref="Char.IsSeparator(string, int)"/>
    public static bool IsSeparator(this string s, int index) => Char.IsSeparator(s, index);

    #endregion
    #region Char.IsSurrogate()

    /// <inheritdoc cref="Char.IsSurrogate(char)"/>
    public static bool IsSurrogate(this char c) => Char.IsSurrogate(c);

    /// <inheritdoc cref="Char.IsSurrogate(string, int)"/>
    public static bool IsSurrogate(this string s, int index) => Char.IsSurrogate(s, index);

    #endregion
    #region Char.IsSurrogatePair()

    /// <inheritdoc cref="Char.IsSurrogatePair(string, int)"/>
    public static bool IsSurrogatePair(this string s, int index) => Char.IsSurrogatePair(s, index);

    #endregion
    #region Char.IsSymbol()

    /// <inheritdoc cref="Char.IsSymbol(char)"/>
    public static bool IsSymbol(this char c) => Char.IsSymbol(c);

    /// <inheritdoc cref="Char.IsSymbol(string, int)"/>
    public static bool IsSymbol(this string s, int index) => Char.IsSymbol(s, index);

    #endregion
    #region Char.IsUpper()

    /// <inheritdoc cref="Char.IsUpper(char)"/>
    public static bool IsUpper(this char c) => Char.IsUpper(c);

    /// <inheritdoc cref="Char.IsUpper(string, int)"/>
    public static bool IsUpper(this string s, int index) => Char.IsUpper(s, index);

    #endregion
    #region Char.IsWhiteSpace()

    /// <inheritdoc cref="Char.IsWhiteSpace(char)"/>
    public static bool IsWhiteSpace(this char c) => Char.IsWhiteSpace(c);

    /// <inheritdoc cref="Char.IsWhiteSpace(string, int)"/>
    public static bool IsWhiteSpace(this string s, int index) => Char.IsWhiteSpace(s, index);

    #endregion
    #endregion
    #region Char.Parse() and Char.TryParse()

    public static char Parse(this string s) => Char.Parse(s);

    public static bool TryParse(this string? s, out char result) => Char.TryParse(s, out result);

    #endregion
    #region Char.To...()

    public static char ToLower(this char c, CultureInfo culture) => Char.ToLower(c, culture);

    public static char ToLower(this char c) => Char.ToLower(c);

    public static char ToLowerInvariant(this char c) => Char.ToLowerInvariant(c);

    public static char ToUpper(this char c, CultureInfo culture) => Char.ToUpper(c, culture);

    public static char ToUpper(this char c) => Char.ToUpper(c);

    public static char ToUpperInvariant(this char c) => Char.ToUpperInvariant(c);

    #endregion
}
