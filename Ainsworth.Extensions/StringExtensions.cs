using System.Globalization;
using System.Text;

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
    #region String.Concat()

    /// <inheritdoc cref="string.Concat(ReadOnlySpan{char}, ReadOnlySpan{char})"/>
    public static string Concat(this ReadOnlySpan<char> str0, ReadOnlySpan<char> str1) =>
        string.Concat(str0, str1);

    /// <inheritdoc cref="string.Concat(ReadOnlySpan{char}, ReadOnlySpan{char}, ReadOnlySpan{char})"/>
    public static string Concat(
            this ReadOnlySpan<char> str0, ReadOnlySpan<char> str1, ReadOnlySpan<char> str2) =>
        string.Concat(str0, str1, str2);

    /// <inheritdoc cref="string.Concat(ReadOnlySpan{char}, ReadOnlySpan{char}, ReadOnlySpan{char}, ReadOnlySpan{char})"/>
    public static string Concat(
            this ReadOnlySpan<char> str0, ReadOnlySpan<char> str1,
            ReadOnlySpan<char> str2, ReadOnlySpan<char> str3) =>
        string.Concat(str0, str1, str2, str3);

    /// <inheritdoc cref="string.Concat(object?)"/>
    public static string Concat(this object? arg0) => string.Concat(arg0);

    /// <inheritdoc cref="string.Concat(object?, object?)"/>
    public static string Concat(this object? arg0, object? arg1) => string.Concat(arg0, arg1);

    /// <inheritdoc cref="string.Concat(object?, object?, object?)"/>
    public static string Concat(this object? arg0, object? arg1, object? arg2) =>
        string.Concat(arg0, arg1, arg2);

    /// <inheritdoc cref="string.Concat(object?[])"/>
    public static string Concat(this object?[] args) => string.Concat(args);

    /// <inheritdoc cref="string.Concat(string?, string?)"/>
    public static string Concat(this string? str0, string? str1) =>
        string.Concat(str0, str1);

    /// <inheritdoc cref="string.Concat(string?, string?, string?)"/>
    public static string Concat(this string? str0, string? str1, string? str2) =>
        string.Concat(str0, str1, str2);

    /// <inheritdoc cref="string.Concat(string?, string?, string?, string?)"/>
    public static string Concat(this string? str0, string? str1, string? str2, string? str3) =>
        string.Concat(str0, str1, str2, str3);

    /// <inheritdoc cref="string.Concat(string?[])"/>
    public static string Concat(this string?[] values) => string.Concat(values);

    /// <inheritdoc cref="string.Concat{T}(IEnumerable{T})"/>
    public static string Concat<T>(this IEnumerable<T> values) => string.Concat(values);

    #endregion
    #region String.Format()

    /// <inheritdoc cref="string.Format(IFormatProvider?, CompositeFormat, ReadOnlySpan{object?})"/>
    public static string Format(
            this CompositeFormat format, IFormatProvider provider,
            ReadOnlySpan<object?> args) =>
        string.Format(provider, format, args);

    /// <inheritdoc cref="string.Format(IFormatProvider?, CompositeFormat, object?[])"/>
    public static string Format(
            this CompositeFormat format, IFormatProvider provider, object?[] args) =>
        string.Format(provider, format, args);

    /// <inheritdoc cref="string.Format(IFormatProvider?, string, object?)"/>
    public static string Format(
            this string format, IFormatProvider provider, object? arg0) =>
        string.Format(provider, format, arg0);

    /// <inheritdoc cref="string.Format(IFormatProvider?, string, object?, object?)"/>
    public static string Format(
            this string format, IFormatProvider provider, object? arg0, object? arg1) =>
        string.Format(provider, format, arg0, arg1);

    /// <inheritdoc cref="string.Format(IFormatProvider?, string, object?, object?, object?)"/>
    public static string Format(
            this string format, IFormatProvider provider,
            object? arg0, object? arg1, object? arg2) =>
        string.Format(provider, format, arg0, arg1, arg2);

    /// <inheritdoc cref="string.Format(IFormatProvider?, string, object?[])"/>
    public static string Format(this string format, IFormatProvider provider, object?[] args) =>
        string.Format(provider, format, args);

    // Allow obsolete format methods for completeness
    #pragma warning disable CA1305 // Specify IFormatProvider

    /// <inheritdoc cref="string.Format(string, object?)"/>
    public static string Format(this string format, object? arg0) =>
        string.Format(format, arg0);

    /// <inheritdoc cref="string.Format(string, object?, object?)"/>
    public static string Format(this string format, object? arg0, object? arg1) =>
        string.Format(format, arg0, arg1);

    /// <inheritdoc cref="string.Format(string, object?, object?, object?)"/>
    public static string Format(this string format, object? arg0, object? arg1, object? arg2) =>
        string.Format(format, arg0, arg1, arg2);

    /// <inheritdoc cref="string.Format(string, object?[])"/>
    public static string Format(this string format, object?[] args) =>
        string.Format(format, args);

    #pragma warning restore CA1305 // Specify IFormatProvider

    /// <inheritdoc cref="string.Format{TArg0}(IFormatProvider?, CompositeFormat, TArg0)"/>
    public static string Format<TArg0>(
            this CompositeFormat format, IFormatProvider? provider, TArg0 arg0) =>
        string.Format(provider, format, arg0);

    /// <inheritdoc cref="string.Format{TArg0,TArg1}(IFormatProvider?, CompositeFormat, TArg0, TArg1)"/>
    public static string Format<TArg0,TArg1>(
            this CompositeFormat format, IFormatProvider? provider, TArg0 arg0, TArg1 arg1) =>
        string.Format(provider, format, arg0, arg1);

    /// <inheritdoc cref="string.Format{TArg0,TArg1,TArg2}(IFormatProvider?, CompositeFormat, TArg0, TArg1, TArg2)"/>
    public static string Format<TArg0,TArg1,TArg2>(
            this CompositeFormat format, IFormatProvider? provider,
            TArg0 arg0, TArg1 arg1, TArg2 arg2) =>
        string.Format(provider, format, arg0, arg1, arg2);

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
