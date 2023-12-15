namespace Ainsworth.Extensions;

/// <summary>
///   Extension methods to make <see cref="String.Join"/> More "functional".
/// </summary>
public static class JoinExtensions {

    #region IEnumerables

    /// <summary>
    ///   Concatenates the string representations of an enumerable of objects, using the
    ///   specified separator between each member.
    /// </summary>
    /// <inheritdoc cref="String.Join(char, object?[])"/>
    public static string Join(this IEnumerable<object?> values, char separator)
        => string.Join(separator, values);

    /// <summary>
    ///   Concatenates the string representations of an enumerable of objects, using the
    ///   specified separator between each member.
    /// </summary>
    /// <inheritdoc cref="String.Join(string?, object?[])"/>
    public static string Join(this IEnumerable<object?> strings, string? separator)
        => string.Join(separator, strings);

    /// <summary>
    ///   Concatenates the string representations of an enumerable of strings, using the
    ///   specified separator between each member.
    /// </summary>
    /// <inheritdoc cref="String.Join(char, string?[])"/>
    public static string Join(this IEnumerable<string?> strings, char separator)
        => string.Join(separator, strings);

    /// <summary>
    ///   Concatenates the string representations of an enumerable of strings, using the
    ///   specified separator between each member.
    /// </summary>
    /// <inheritdoc cref="String.Join(string?, IEnumerable{string?})"/>
    public static string Join(this IEnumerable<string?> strings, string separator)
        => string.Join(separator, strings);

    /// <inheritdoc cref="String.Join(char, string?[], int, int)"/>
    public static string Join(
            this string?[] strings, char separator, int startIndex, int count)
        => string.Join(separator, strings, startIndex, count);

    /// <inheritdoc cref="String.Join(string?, string?[], int, int)"/>
    public static string Join(
            this string?[] strings, string separator, int startIndex, int count)
        => string.Join(separator, strings, startIndex, count);

    /// <inheritdoc cref="String.Join{T}(char, IEnumerable{T})"/>
    public static string Join<T>(this IEnumerable<T> values, char separator)
        => string.Join(separator, values);

    /// <inheritdoc cref="String.Join{T}(string, IEnumerable{T})"/>
    public static string Join<T>(this IEnumerable<T> values, string separator)
        => string.Join(separator, values);

    #endregion
}
