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
    #region String.CompareOrdinal()
    /// <inheritdoc cref="string.CompareOrdinal(string?, string?)"/>
    public static int CompareOrdinal(this string? strA, string? strB) =>
        string.CompareOrdinal(strA, strB);

    /// <inheritdoc cref="string.CompareOrdinal(string?, int, string?, int, int)"/>
    public static int CompareOrdinal(
            this string? strA, int indexA, string? strB, int indexB, int length) =>
        string.CompareOrdinal(strA, indexA, strB, indexB, length);

    #endregion
    #region String.Concat()

#if NETCOREAPP3_0_OR_GREATER

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

#endif

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

#if NET8_0_OR_GREATER

    /// <inheritdoc cref="string.Format(IFormatProvider?, CompositeFormat, ReadOnlySpan{object?})"/>
    public static string Format(
            this CompositeFormat format, IFormatProvider provider,
            ReadOnlySpan<object?> args) =>
        string.Format(provider, format, args);

    /// <inheritdoc cref="string.Format(IFormatProvider?, CompositeFormat, object?[])"/>
    public static string Format(
            this CompositeFormat format, IFormatProvider provider, object?[] args) =>
        string.Format(provider, format, args);

#endif

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

#if NET8_0_OR_GREATER

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

#endif

    #endregion
    #region String.IsNullOrEmpty() & String.IsNullOrWhiteSpace()

    /// <inheritdoc cref="string.IsNullOrEmpty(string?)"/>
    public static bool IsNullOrEmpty(this string? value)
        => string.IsNullOrEmpty(value);

    /// <inheritdoc cref="string.IsNullOrWhiteSpace(string?)"/>
    public static bool IsNullOrWhiteSpace(this string? value)
        => string.IsNullOrWhiteSpace(value);

    #endregion
    #region String.Join()

    #region Variant: String.Join(char separator, object?[] values)

    /// <inheritdoc cref="string.Join(char, object?[])"/>
    public static string Join(this object?[] values, char separator) =>
#if (NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_0_OR_GREATER)
        string.Join(separator, values);
#else
        string.Join(separator.ToString(), values);
#endif

    /// <inheritdoc cref="string.Join(char, object?[])"/>
    public static string Join(this char separator, params object?[] values) =>
#if (NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_0_OR_GREATER)
        string.Join(separator, values);
#else
        string.Join(separator.ToString(), values);
#endif

    #endregion
    #region Variant: String.Join(char separator, string?[] values)

    /// <inheritdoc cref="string.Join(char, string?[])"/>
    public static string Join(this string?[] values, char separator) =>
#if (NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_0_OR_GREATER)
        string.Join(separator, values);
#else
        string.Join(separator.ToString(), values);
#endif

    /// <inheritdoc cref="string.Join(char, string?[])"/>
    public static string Join(this char separator, params string?[] values) =>
#if (NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_0_OR_GREATER)
        string.Join(separator, values);
#else
        string.Join(separator.ToString(), values);
#endif

    #endregion
    #region Variant: String.Join(char separator, string?[] values, int startIndex, int count)

    /// <inheritdoc cref="string.Join(char, string?[], int, int)"/>
    public static string Join(
            this string?[] values, char separator, int startIndex, int count) =>
#if (NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_0_OR_GREATER)
        string.Join(separator, values, startIndex, count);
#else
        string.Join(separator.ToString(), values, startIndex, count);
#endif

    /// <inheritdoc cref="string.Join(char, string?[], int, int)"/>
    public static string Join(
            this char separator, string?[] values, int startIndex, int count) =>
#if (NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_0_OR_GREATER)
        string.Join(separator, values, startIndex, count);
#else
        string.Join(separator.ToString(), values, startIndex, count);
#endif

    #endregion
    #region Variant: String.Join(char separator, IEnumerable<string> values)

    /// <inheritdoc cref="string.Join(string?, IEnumerable{string?})"/>
    public static string Join(this IEnumerable<string?> values, string? separator) =>
        string.Join(separator, values);

    /// <inheritdoc cref="string.Join(string?, IEnumerable{string?})"/>
    public static string Join(this string? separator, IEnumerable<string?> values) =>
        string.Join(separator, values);

    #endregion
    #region Variant: String.Join(string? separator, object?[] values)

    /// <inheritdoc cref="string.Join(string?, object?[])
    public static string Join(this object?[] values, string? separator) =>
        string.Join(separator, values);

    /// <inheritdoc cref="string.Join(char, object?[])"/>
    public static string Join(this string? separator, params object?[] values) =>
        string.Join(separator, values);

    #endregion
    #region Variant: String.Join(string? separator, string?[] values)

    /// <inheritdoc cref="string.Join(string?, string?[])"/>
    public static string Join(this string?[] values, string? separator) =>
        string.Join(separator, values);

    /// <inheritdoc cref="string.Join(string?, string?[])"/>
    public static string Join(this string? separator, params string?[] values) =>
        string.Join(separator, values);


    #endregion
    #region Variant: String.Join(string? separator, string?[] values, int startIndex, int count)

    /// <inheritdoc cref="string.Join(string?, string?[], int, int)
    public static string Join(
            this string?[] values, string? separator, int startIndex, int count) =>
        string.Join(separator, values, startIndex, count);

    /// <inheritdoc cref="string.Join(string?, string?[], int, int)
    public static string Join(
            this string? separator, string?[] values, int startIndex, int count) =>
        string.Join(separator, values, startIndex, count);

    #endregion
    #region Variant: String.Join<T>(char separator, IEnumerable<T> values)

    /// <inheritdoc cref="string.Join{T}(char, IEnumerable{T})"/>
    public static string Join<T>(this IEnumerable<T> values, char separator) =>
#if (NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_0_OR_GREATER)
        string.Join(separator, values);
#else
        string.Join(separator.ToString(), values);
#endif

    /// <inheritdoc cref="string.Join(char, IEnumerable{string?})"/>
    public static string Join<T>(this char separator, IEnumerable<T> values) =>
#if (NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_0_OR_GREATER)
        string.Join(separator, values);
#else
        string.Join(separator.ToString(), values);
#endif

    #endregion
    #region Variant: String.Join<T>(string? separator, IEnumerable<T> values)

    /// <inheritdoc cref="string.Join{T}(string?, IEnumerable{T})"/>
    public static string Join<T>(this IEnumerable<T> values, string? separator) =>
        string.Join(separator, values);

    /// <inheritdoc cref="string.Join{T}(string?, IEnumerable{T})"/>
    public static string Join<T>(this string? separator, IEnumerable<T> values) =>
        string.Join(separator, values);

    #endregion
    #endregion
}
