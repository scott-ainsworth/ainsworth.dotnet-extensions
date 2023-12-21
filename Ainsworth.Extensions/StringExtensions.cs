namespace Ainsworth.Extensions;

public static class StringExtensions {

    #region String.IsNullOrEmpty() & String.IsNullOrWhiteSpace()

    /// <inheritdoc cref="string.IsNullOrEmpty(string?)"/>
    public static bool IsNullOrEmpty(this string? value)
        => string.IsNullOrEmpty(value);

    /// <inheritdoc cref="string.IsNullOrWhiteSpace(string?)"/>
    public static bool IsNullOrWhiteSpace(this string? value)
        => string.IsNullOrWhiteSpace(value);

    #endregion
}
