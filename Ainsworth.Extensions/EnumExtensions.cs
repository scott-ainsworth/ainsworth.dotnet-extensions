namespace Ainsworth.Extensions;

public static class EnumExtensions {

    /// <inheritdoc cref="Enum.Format(Type, object, string)"/>
    public static string? Format<TEnum>(this TEnum value, string format)
            where TEnum : struct, Enum =>
        Enum.Format(typeof(TEnum), value, format);


#if !NETSTANDARD2_1_OR_GREATER
    /// <inheritdoc cref="Enum.GetName{TEnum}(TEnum)"/>
    [System.Diagnostics.CodeAnalysis.SuppressMessage(
        "Usage", "CA2263:Prefer generic overload when type is known",
        Justification = "Generic overload not available prior to .NET Standard 2.1")]
    public static string? GetName<TEnum>(this TEnum value) where TEnum : struct, Enum =>
        Enum.GetName(typeof(TEnum), value);
#endif

#if !NETSTANDARD2_1_OR_GREATER
    /// <inheritdoc cref="Enum.Parse{TEnum}(string)"/>
    [System.Diagnostics.CodeAnalysis.SuppressMessage(
        "Usage", "CA2263:Prefer generic overload when type is known",
        Justification = "Generic overload not available prior to .NET Standard 2.1")]
    public static TEnum Parse<TEnum>(this string value) where TEnum : struct, Enum =>
        (TEnum)Enum.Parse(typeof(TEnum), value);
#endif

#if !NETSTANDARD2_1_OR_GREATER
    /// <inheritdoc cref="Enum.Parse{TEnum}(string,bool)"/>
    [System.Diagnostics.CodeAnalysis.SuppressMessage(
        "Usage", "CA2263:Prefer generic overload when type is known",
        Justification = "Generic overload not available prior to .NET Standard 2.1")]
    public static TEnum Parse<TEnum>(this string value, bool ignoreCase)
            where TEnum : struct, Enum =>
        (TEnum)Enum.Parse(typeof(TEnum), value, ignoreCase);
#endif

}
