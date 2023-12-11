using System.Numerics;
using System.Security.Cryptography;

namespace Ainsworth.Extensions;

public static class ConversionExtensions {

    #region Parse()

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

    #endregion
    #region Casts

    /// <summary>Cast to a long.</summary>
    /// <param name="value">The value to cast</param>
    /// <exception cref="InvalidCastException">
    ///   <paramref name="value"/> and integral type
    ///   which can be converted to <see langword="long"/> without data loss.
    /// </exception>
    public static long ToLong(this sbyte value) => (long)value;

    /// <summary>Cast to a long.</summary>
    /// <param name="value">The value to cast</param>
    /// <exception cref="InvalidCastException">
    ///   <paramref name="value"/> and integral type
    ///   which can be converted to <see langword="long"/> without data loss.
    /// </exception>
    public static long ToLong(this byte value) => (long)value;

     /// <summary>Cast to a long.</summary>
    /// <param name="value">The value to cast</param>
    /// <exception cref="InvalidCastException">
    ///   <paramref name="value"/> and integral type
    ///   which can be converted to <see langword="long"/> without data loss.
    /// </exception>
   public static long ToLong(this short value) => (long)value;

    /// <summary>Cast to a long.</summary>
    /// <param name="value">The value to cast</param>
    /// <exception cref="InvalidCastException">
    ///   <paramref name="value"/> and integral type
    ///   which can be converted to <see langword="long"/> without data loss.
    /// </exception>
    public static long ToLong(this ushort value) => (long)value;

    /// <summary>Cast to a long.</summary>
    /// <param name="value">The value to cast</param>
    /// <exception cref="InvalidCastException">
    ///   <paramref name="value"/> and integral type
    ///   which can be converted to <see langword="long"/> without data loss.
    /// </exception>
    public static long ToLong(this int value) => (long)value;

     /// <summary>Cast to a long.</summary>
    /// <param name="value">The value to cast</param>
    /// <exception cref="InvalidCastException">
    ///   <paramref name="value"/> and integral type
    ///   which can be converted to <see langword="long"/> without data loss.
    /// </exception>
   public static long ToLong(this uint value) => (long)value;

    /// <summary>Cast to a long.</summary>
    /// <param name="value">The value to cast</param>
    /// <exception cref="InvalidCastException">
    ///   <paramref name="value"/> and integral type
    ///   which can be converted to <see langword="long"/> without data loss.
    /// </exception>
    public static long ToLong(this long value) => (long)value;

    /// <summary>Cast to a long.</summary>
    /// <param name="value">The value to cast</param>
    /// <exception cref="InvalidCastException">
    ///   <paramref name="value"/> and integral type
    ///   which can be converted to <see langword="long"/> without data loss.
    /// </exception>
    public static long ToLong(this ulong value) => (long)value;

    #endregion

}
