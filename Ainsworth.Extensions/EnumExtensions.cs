namespace Ainsworth.Extensions;

public static class EnumExtensions {

    /// <inheritdoc cref="Enum.Format(Type, object, string)"/>
    public static string? Format<TEnum>(this TEnum value, string format)
            where TEnum : struct, Enum =>
        Enum.Format(typeof(TEnum), value, format);


    /// <inheritdoc cref="Enum.GetName{TEnum}(TEnum)"/>
    public static string? GetName<TEnum>(this TEnum value) where TEnum : struct, Enum =>
        Enum.GetName(typeof(TEnum), value);

    /// <inheritdoc cref="Enum.Parse{TEnum}(string)"/>
    public static TEnum Parse<TEnum>(this string value) where TEnum : struct, Enum =>
#if NETSTANDARD2_1_OR_GREATER
        Enum.Parse<TEnum>(value);
#else
        (TEnum)Enum.Parse(typeof(TEnum), value);
#endif

    /// <inheritdoc cref="Enum.Parse{TEnum}(string,bool)"/>
    public static TEnum Parse<TEnum>(this string value, bool ignoreCase)
            where TEnum : struct, Enum =>
#if (NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_0_GREATER)
        Enum.Parse<TEnum>(value, ignoreCase);
#else
        (TEnum)Enum.Parse(typeof(TEnum), value, ignoreCase);
#endif

}
