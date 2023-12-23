using System.Globalization;

namespace Ainsworth.Extensions;

public static class StringExtensions {

    #region String.Compare()

    // Allow obsolete string comparisons for completeness
    #pragma warning disable CA1304 // Specify CultureInfo
    #pragma warning disable CA1309 // Use ordinal string comparison
    #pragma warning disable CA1310 // Specify StringComparison for correctness

    /// <inheritdoc cref="string.Compare(string?, int, string?, int, int, CultureInfo?, CompareOptions)"/>
    public static int Compare(
            this string? strA, int indexA, string? strB, int indexB, int length,
            CultureInfo? culture, CompareOptions options) =>
        string.Compare(strA, indexA, strB, indexB, length, culture, options);

    /// <inheritdoc cref="string.Compare(string?, int, string?, int, int, bool, CultureInfo?)"/>
    public static int Compare(
            this string? strA, int indexA, string? strB, int indexB, int length,
            bool ignoreCase, CultureInfo? culture) =>
        string.Compare(strA, indexA, strB, indexB, length, ignoreCase, culture);

    /// <inheritdoc cref="string.Compare(string?, int, string?, int, int, StringComparison)"/>
    public static int Compare(
            this string? strA, int indexA, string? strB, int indexB, int length,
            StringComparison comparisonType) =>
        string.Compare(strA, indexA, strB, indexB, length, comparisonType);

    /// <inheritdoc cref="string.Compare(string?, int, string?, int, int, bool)"/>
    public static int Compare(
            this string? strA, int indexA, string? strB, int indexB, int length,
            bool ignoreCase) =>
        string.Compare(strA, indexA, strB, indexB, length, ignoreCase);

    /// <inheritdoc cref="string.Compare(string?, int, string?, int, int)"/>
    public static int Compare(
            this string? strA, int indexA, string? strB, int indexB, int length) =>
        string.Compare(strA, indexA, strB, indexB, length);

    /// <inheritdoc cref="string.Compare(string?, string?)"/>
    public static int Compare( this string? strA, string? strB) =>
        string.Compare(strA, strB);

    /// <inheritdoc cref="string.Compare(string?, string?, bool, CultureInfo?)"/>
    public static int Compare(
            this string? strA, string? strB, bool ignoreCase, CultureInfo? culture) =>
        string.Compare(strA, strB, ignoreCase, culture);

    /// <inheritdoc cref="string.Compare(string?, string?, StringComparison)"/>
    public static int Compare(
            this string? strA, string? strB, StringComparison comparisonType) =>
        string.Compare(strA, strB, comparisonType);

    /// <inheritdoc cref="string.Compare(string?, string?, bool)"/>
    public static int Compare(this string? strA, string? strB, bool ignoreCase) =>
        string.Compare(strA, strB, ignoreCase);

    /// <inheritdoc cref="string.Compare(string?, string?, CultureInfo?, CompareOptions)"/>
    public static int Compare(
            this string? strA, string? strB, CultureInfo? culture, CompareOptions options) =>
        string.Compare(strA, strB, culture, options);

    #pragma warning restore CA1304 // Specify CultureInfo
    #pragma warning restore CA1309 // Use ordinal string comparison
    #pragma warning restore CA1310 // Specify StringComparison for correctness

    #endregion
    #region String.IsNullOrEmpty() & String.IsNullOrWhiteSpace()

    /// <inheritdoc cref="string.IsNullOrEmpty(string?)"/>
    public static bool IsNullOrEmpty(this string? value)
        => string.IsNullOrEmpty(value);

    /// <inheritdoc cref="string.IsNullOrWhiteSpace(string?)"/>
    public static bool IsNullOrWhiteSpace(this string? value)
        => string.IsNullOrWhiteSpace(value);

    #endregion
}
