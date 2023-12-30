namespace Ainsworth.Extensions;

/// <summary>
///   Extension methods for casts to integral types.
/// </summary>
public static class CastExtensions {

    public static byte ToByte(this float value) => (byte)value;

    #region ToByte()

    /// <summary>Cast to byte (System.Byte).</summary>
    /// <param name=""value"">The value to cast</param>
    /// <exception cref=""InvalidCastException"">
    ///   <paramref name = ""value""/> is not an integral type
    ///   convertable to <see langword=""byte""/>.
    /// </exception>
    public static byte ToByte(this byte value) => (byte)value;

    /// <summary>Cast to byte (System.Byte).</summary>
    /// <param name=""value"">The value to cast</param>
    /// <exception cref=""InvalidCastException"">
    ///   <paramref name = ""value""/> is not an integral type
    ///   convertable to <see langword=""byte""/>.
    /// </exception>
    public static byte ToByte(this int value) => (byte)value;

    /// <summary>Cast to byte (System.Byte).</summary>
    /// <param name=""value"">The value to cast</param>
    /// <exception cref=""InvalidCastException"">
    ///   <paramref name = ""value""/> is not an integral type
    ///   convertable to <see langword=""byte""/>.
    /// </exception>
    public static byte ToByte(this long value) => (byte)value;

    /// <summary>Cast to byte (System.Byte).</summary>
    /// <param name=""value"">The value to cast</param>
    /// <exception cref=""InvalidCastException"">
    ///   <paramref name = ""value""/> is not an integral type
    ///   convertable to <see langword=""byte""/>.
    /// </exception>
    public static byte ToByte(this sbyte value) => (byte)value;

    /// <summary>Cast to byte (System.Byte).</summary>
    /// <param name=""value"">The value to cast</param>
    /// <exception cref=""InvalidCastException"">
    ///   <paramref name = ""value""/> is not an integral type
    ///   convertable to <see langword=""byte""/>.
    /// </exception>
    public static byte ToByte(this short value) => (byte)value;

    /// <summary>Cast to byte (System.Byte).</summary>
    /// <param name=""value"">The value to cast</param>
    /// <exception cref=""InvalidCastException"">
    ///   <paramref name = ""value""/> is not an integral type
    ///   convertable to <see langword=""byte""/>.
    /// </exception>
    public static byte ToByte(this uint value) => (byte)value;

    /// <summary>Cast to byte (System.Byte).</summary>
    /// <param name=""value"">The value to cast</param>
    /// <exception cref=""InvalidCastException"">
    ///   <paramref name = ""value""/> is not an integral type
    ///   convertable to <see langword=""byte""/>.
    /// </exception>
    public static byte ToByte(this ulong value) => (byte)value;

    /// <summary>Cast to byte (System.Byte).</summary>
    /// <param name=""value"">The value to cast</param>
    /// <exception cref=""InvalidCastException"">
    ///   <paramref name = ""value""/> is not an integral type
    ///   convertable to <see langword=""byte""/>.
    /// </exception>
    public static byte ToByte(this ushort value) => (byte)value;

    #endregion
    #region ToInt()

    /// <summary>Cast to int (System.Int32).</summary>
    /// <param name=""value"">The value to cast</param>
    /// <exception cref=""InvalidCastException"">
    ///   <paramref name = ""value""/> is not an integral type
    ///   convertable to <see langword=""int""/>.
    /// </exception>
    public static int ToInt(this byte value) => (int)value;

    /// <summary>Cast to int (System.Int32).</summary>
    /// <param name=""value"">The value to cast</param>
    /// <exception cref=""InvalidCastException"">
    ///   <paramref name = ""value""/> is not an integral type
    ///   convertable to <see langword=""int""/>.
    /// </exception>
    public static int ToInt(this int value) => (int)value;

    /// <summary>Cast to int (System.Int32).</summary>
    /// <param name=""value"">The value to cast</param>
    /// <exception cref=""InvalidCastException"">
    ///   <paramref name = ""value""/> is not an integral type
    ///   convertable to <see langword=""int""/>.
    /// </exception>
    public static int ToInt(this long value) => (int)value;

    /// <summary>Cast to int (System.Int32).</summary>
    /// <param name=""value"">The value to cast</param>
    /// <exception cref=""InvalidCastException"">
    ///   <paramref name = ""value""/> is not an integral type
    ///   convertable to <see langword=""int""/>.
    /// </exception>
    public static int ToInt(this sbyte value) => (int)value;

    /// <summary>Cast to int (System.Int32).</summary>
    /// <param name=""value"">The value to cast</param>
    /// <exception cref=""InvalidCastException"">
    ///   <paramref name = ""value""/> is not an integral type
    ///   convertable to <see langword=""int""/>.
    /// </exception>
    public static int ToInt(this short value) => (int)value;

    /// <summary>Cast to int (System.Int32).</summary>
    /// <param name=""value"">The value to cast</param>
    /// <exception cref=""InvalidCastException"">
    ///   <paramref name = ""value""/> is not an integral type
    ///   convertable to <see langword=""int""/>.
    /// </exception>
    public static int ToInt(this uint value) => (int)value;

    /// <summary>Cast to int (System.Int32).</summary>
    /// <param name=""value"">The value to cast</param>
    /// <exception cref=""InvalidCastException"">
    ///   <paramref name = ""value""/> is not an integral type
    ///   convertable to <see langword=""int""/>.
    /// </exception>
    public static int ToInt(this ulong value) => (int)value;

    /// <summary>Cast to int (System.Int32).</summary>
    /// <param name=""value"">The value to cast</param>
    /// <exception cref=""InvalidCastException"">
    ///   <paramref name = ""value""/> is not an integral type
    ///   convertable to <see langword=""int""/>.
    /// </exception>
    public static int ToInt(this ushort value) => (int)value;

    #endregion
    #region ToLong()

    /// <summary>Cast to long (System.Int64).</summary>
    /// <param name=""value"">The value to cast</param>
    /// <exception cref=""InvalidCastException"">
    ///   <paramref name = ""value""/> is not an integral type
    ///   convertable to <see langword=""long""/>.
    /// </exception>
    public static long ToLong(this byte value) => (long)value;

    /// <summary>Cast to long (System.Int64).</summary>
    /// <param name=""value"">The value to cast</param>
    /// <exception cref=""InvalidCastException"">
    ///   <paramref name = ""value""/> is not an integral type
    ///   convertable to <see langword=""long""/>.
    /// </exception>
    public static long ToLong(this int value) => (long)value;

    /// <summary>Cast to long (System.Int64).</summary>
    /// <param name=""value"">The value to cast</param>
    /// <exception cref=""InvalidCastException"">
    ///   <paramref name = ""value""/> is not an integral type
    ///   convertable to <see langword=""long""/>.
    /// </exception>
    public static long ToLong(this long value) => (long)value;

    /// <summary>Cast to long (System.Int64).</summary>
    /// <param name=""value"">The value to cast</param>
    /// <exception cref=""InvalidCastException"">
    ///   <paramref name = ""value""/> is not an integral type
    ///   convertable to <see langword=""long""/>.
    /// </exception>
    public static long ToLong(this sbyte value) => (long)value;

    /// <summary>Cast to long (System.Int64).</summary>
    /// <param name=""value"">The value to cast</param>
    /// <exception cref=""InvalidCastException"">
    ///   <paramref name = ""value""/> is not an integral type
    ///   convertable to <see langword=""long""/>.
    /// </exception>
    public static long ToLong(this short value) => (long)value;

    /// <summary>Cast to long (System.Int64).</summary>
    /// <param name=""value"">The value to cast</param>
    /// <exception cref=""InvalidCastException"">
    ///   <paramref name = ""value""/> is not an integral type
    ///   convertable to <see langword=""long""/>.
    /// </exception>
    public static long ToLong(this uint value) => (long)value;

    /// <summary>Cast to long (System.Int64).</summary>
    /// <param name=""value"">The value to cast</param>
    /// <exception cref=""InvalidCastException"">
    ///   <paramref name = ""value""/> is not an integral type
    ///   convertable to <see langword=""long""/>.
    /// </exception>
    public static long ToLong(this ulong value) => (long)value;

    /// <summary>Cast to long (System.Int64).</summary>
    /// <param name=""value"">The value to cast</param>
    /// <exception cref=""InvalidCastException"">
    ///   <paramref name = ""value""/> is not an integral type
    ///   convertable to <see langword=""long""/>.
    /// </exception>
    public static long ToLong(this ushort value) => (long)value;

    #endregion
    #region ToSByte()

    /// <summary>Cast to sbyte (System.SByte).</summary>
    /// <param name=""value"">The value to cast</param>
    /// <exception cref=""InvalidCastException"">
    ///   <paramref name = ""value""/> is not an integral type
    ///   convertable to <see langword=""sbyte""/>.
    /// </exception>
    public static sbyte ToSByte(this byte value) => (sbyte)value;

    /// <summary>Cast to sbyte (System.SByte).</summary>
    /// <param name=""value"">The value to cast</param>
    /// <exception cref=""InvalidCastException"">
    ///   <paramref name = ""value""/> is not an integral type
    ///   convertable to <see langword=""sbyte""/>.
    /// </exception>
    public static sbyte ToSByte(this int value) => (sbyte)value;

    /// <summary>Cast to sbyte (System.SByte).</summary>
    /// <param name=""value"">The value to cast</param>
    /// <exception cref=""InvalidCastException"">
    ///   <paramref name = ""value""/> is not an integral type
    ///   convertable to <see langword=""sbyte""/>.
    /// </exception>
    public static sbyte ToSByte(this long value) => (sbyte)value;

    /// <summary>Cast to sbyte (System.SByte).</summary>
    /// <param name=""value"">The value to cast</param>
    /// <exception cref=""InvalidCastException"">
    ///   <paramref name = ""value""/> is not an integral type
    ///   convertable to <see langword=""sbyte""/>.
    /// </exception>
    public static sbyte ToSByte(this sbyte value) => (sbyte)value;

    /// <summary>Cast to sbyte (System.SByte).</summary>
    /// <param name=""value"">The value to cast</param>
    /// <exception cref=""InvalidCastException"">
    ///   <paramref name = ""value""/> is not an integral type
    ///   convertable to <see langword=""sbyte""/>.
    /// </exception>
    public static sbyte ToSByte(this short value) => (sbyte)value;

    /// <summary>Cast to sbyte (System.SByte).</summary>
    /// <param name=""value"">The value to cast</param>
    /// <exception cref=""InvalidCastException"">
    ///   <paramref name = ""value""/> is not an integral type
    ///   convertable to <see langword=""sbyte""/>.
    /// </exception>
    public static sbyte ToSByte(this uint value) => (sbyte)value;

    /// <summary>Cast to sbyte (System.SByte).</summary>
    /// <param name=""value"">The value to cast</param>
    /// <exception cref=""InvalidCastException"">
    ///   <paramref name = ""value""/> is not an integral type
    ///   convertable to <see langword=""sbyte""/>.
    /// </exception>
    public static sbyte ToSByte(this ulong value) => (sbyte)value;

    /// <summary>Cast to sbyte (System.SByte).</summary>
    /// <param name=""value"">The value to cast</param>
    /// <exception cref=""InvalidCastException"">
    ///   <paramref name = ""value""/> is not an integral type
    ///   convertable to <see langword=""sbyte""/>.
    /// </exception>
    public static sbyte ToSByte(this ushort value) => (sbyte)value;

    #endregion
    #region ToShort()

    /// <summary>Cast to short (System.Int16).</summary>
    /// <param name=""value"">The value to cast</param>
    /// <exception cref=""InvalidCastException"">
    ///   <paramref name = ""value""/> is not an integral type
    ///   convertable to <see langword=""short""/>.
    /// </exception>
    public static short ToShort(this byte value) => (short)value;

    /// <summary>Cast to short (System.Int16).</summary>
    /// <param name=""value"">The value to cast</param>
    /// <exception cref=""InvalidCastException"">
    ///   <paramref name = ""value""/> is not an integral type
    ///   convertable to <see langword=""short""/>.
    /// </exception>
    public static short ToShort(this int value) => (short)value;

    /// <summary>Cast to short (System.Int16).</summary>
    /// <param name=""value"">The value to cast</param>
    /// <exception cref=""InvalidCastException"">
    ///   <paramref name = ""value""/> is not an integral type
    ///   convertable to <see langword=""short""/>.
    /// </exception>
    public static short ToShort(this long value) => (short)value;

    /// <summary>Cast to short (System.Int16).</summary>
    /// <param name=""value"">The value to cast</param>
    /// <exception cref=""InvalidCastException"">
    ///   <paramref name = ""value""/> is not an integral type
    ///   convertable to <see langword=""short""/>.
    /// </exception>
    public static short ToShort(this sbyte value) => (short)value;

    /// <summary>Cast to short (System.Int16).</summary>
    /// <param name=""value"">The value to cast</param>
    /// <exception cref=""InvalidCastException"">
    ///   <paramref name = ""value""/> is not an integral type
    ///   convertable to <see langword=""short""/>.
    /// </exception>
    public static short ToShort(this short value) => (short)value;

    /// <summary>Cast to short (System.Int16).</summary>
    /// <param name=""value"">The value to cast</param>
    /// <exception cref=""InvalidCastException"">
    ///   <paramref name = ""value""/> is not an integral type
    ///   convertable to <see langword=""short""/>.
    /// </exception>
    public static short ToShort(this uint value) => (short)value;

    /// <summary>Cast to short (System.Int16).</summary>
    /// <param name=""value"">The value to cast</param>
    /// <exception cref=""InvalidCastException"">
    ///   <paramref name = ""value""/> is not an integral type
    ///   convertable to <see langword=""short""/>.
    /// </exception>
    public static short ToShort(this ulong value) => (short)value;

    /// <summary>Cast to short (System.Int16).</summary>
    /// <param name=""value"">The value to cast</param>
    /// <exception cref=""InvalidCastException"">
    ///   <paramref name = ""value""/> is not an integral type
    ///   convertable to <see langword=""short""/>.
    /// </exception>
    public static short ToShort(this ushort value) => (short)value;

    #endregion
    #region ToUInt()

    /// <summary>Cast to uint (System.UInt32).</summary>
    /// <param name=""value"">The value to cast</param>
    /// <exception cref=""InvalidCastException"">
    ///   <paramref name = ""value""/> is not an integral type
    ///   convertable to <see langword=""uint""/>.
    /// </exception>
    public static uint ToUInt(this byte value) => (uint)value;

    /// <summary>Cast to uint (System.UInt32).</summary>
    /// <param name=""value"">The value to cast</param>
    /// <exception cref=""InvalidCastException"">
    ///   <paramref name = ""value""/> is not an integral type
    ///   convertable to <see langword=""uint""/>.
    /// </exception>
    public static uint ToUInt(this int value) => (uint)value;

    /// <summary>Cast to uint (System.UInt32).</summary>
    /// <param name=""value"">The value to cast</param>
    /// <exception cref=""InvalidCastException"">
    ///   <paramref name = ""value""/> is not an integral type
    ///   convertable to <see langword=""uint""/>.
    /// </exception>
    public static uint ToUInt(this long value) => (uint)value;

    /// <summary>Cast to uint (System.UInt32).</summary>
    /// <param name=""value"">The value to cast</param>
    /// <exception cref=""InvalidCastException"">
    ///   <paramref name = ""value""/> is not an integral type
    ///   convertable to <see langword=""uint""/>.
    /// </exception>
    public static uint ToUInt(this sbyte value) => (uint)value;

    /// <summary>Cast to uint (System.UInt32).</summary>
    /// <param name=""value"">The value to cast</param>
    /// <exception cref=""InvalidCastException"">
    ///   <paramref name = ""value""/> is not an integral type
    ///   convertable to <see langword=""uint""/>.
    /// </exception>
    public static uint ToUInt(this short value) => (uint)value;

    /// <summary>Cast to uint (System.UInt32).</summary>
    /// <param name=""value"">The value to cast</param>
    /// <exception cref=""InvalidCastException"">
    ///   <paramref name = ""value""/> is not an integral type
    ///   convertable to <see langword=""uint""/>.
    /// </exception>
    public static uint ToUInt(this uint value) => (uint)value;

    /// <summary>Cast to uint (System.UInt32).</summary>
    /// <param name=""value"">The value to cast</param>
    /// <exception cref=""InvalidCastException"">
    ///   <paramref name = ""value""/> is not an integral type
    ///   convertable to <see langword=""uint""/>.
    /// </exception>
    public static uint ToUInt(this ulong value) => (uint)value;

    /// <summary>Cast to uint (System.UInt32).</summary>
    /// <param name=""value"">The value to cast</param>
    /// <exception cref=""InvalidCastException"">
    ///   <paramref name = ""value""/> is not an integral type
    ///   convertable to <see langword=""uint""/>.
    /// </exception>
    public static uint ToUInt(this ushort value) => (uint)value;

    #endregion
    #region ToULong()

    /// <summary>Cast to ulong (System.UInt64).</summary>
    /// <param name=""value"">The value to cast</param>
    /// <exception cref=""InvalidCastException"">
    ///   <paramref name = ""value""/> is not an integral type
    ///   convertable to <see langword=""ulong""/>.
    /// </exception>
    public static ulong ToULong(this byte value) => (ulong)value;

    /// <summary>Cast to ulong (System.UInt64).</summary>
    /// <param name=""value"">The value to cast</param>
    /// <exception cref=""InvalidCastException"">
    ///   <paramref name = ""value""/> is not an integral type
    ///   convertable to <see langword=""ulong""/>.
    /// </exception>
    public static ulong ToULong(this int value) => (ulong)value;

    /// <summary>Cast to ulong (System.UInt64).</summary>
    /// <param name=""value"">The value to cast</param>
    /// <exception cref=""InvalidCastException"">
    ///   <paramref name = ""value""/> is not an integral type
    ///   convertable to <see langword=""ulong""/>.
    /// </exception>
    public static ulong ToULong(this long value) => (ulong)value;

    /// <summary>Cast to ulong (System.UInt64).</summary>
    /// <param name=""value"">The value to cast</param>
    /// <exception cref=""InvalidCastException"">
    ///   <paramref name = ""value""/> is not an integral type
    ///   convertable to <see langword=""ulong""/>.
    /// </exception>
    public static ulong ToULong(this sbyte value) => (ulong)value;

    /// <summary>Cast to ulong (System.UInt64).</summary>
    /// <param name=""value"">The value to cast</param>
    /// <exception cref=""InvalidCastException"">
    ///   <paramref name = ""value""/> is not an integral type
    ///   convertable to <see langword=""ulong""/>.
    /// </exception>
    public static ulong ToULong(this short value) => (ulong)value;

    /// <summary>Cast to ulong (System.UInt64).</summary>
    /// <param name=""value"">The value to cast</param>
    /// <exception cref=""InvalidCastException"">
    ///   <paramref name = ""value""/> is not an integral type
    ///   convertable to <see langword=""ulong""/>.
    /// </exception>
    public static ulong ToULong(this uint value) => (ulong)value;

    /// <summary>Cast to ulong (System.UInt64).</summary>
    /// <param name=""value"">The value to cast</param>
    /// <exception cref=""InvalidCastException"">
    ///   <paramref name = ""value""/> is not an integral type
    ///   convertable to <see langword=""ulong""/>.
    /// </exception>
    public static ulong ToULong(this ulong value) => (ulong)value;

    /// <summary>Cast to ulong (System.UInt64).</summary>
    /// <param name=""value"">The value to cast</param>
    /// <exception cref=""InvalidCastException"">
    ///   <paramref name = ""value""/> is not an integral type
    ///   convertable to <see langword=""ulong""/>.
    /// </exception>
    public static ulong ToULong(this ushort value) => (ulong)value;

    #endregion
    #region ToUShort()

    /// <summary>Cast to ushort (System.UInt16).</summary>
    /// <param name=""value"">The value to cast</param>
    /// <exception cref=""InvalidCastException"">
    ///   <paramref name = ""value""/> is not an integral type
    ///   convertable to <see langword=""ushort""/>.
    /// </exception>
    public static ushort ToUShort(this byte value) => (ushort)value;

    /// <summary>Cast to ushort (System.UInt16).</summary>
    /// <param name=""value"">The value to cast</param>
    /// <exception cref=""InvalidCastException"">
    ///   <paramref name = ""value""/> is not an integral type
    ///   convertable to <see langword=""ushort""/>.
    /// </exception>
    public static ushort ToUShort(this int value) => (ushort)value;

    /// <summary>Cast to ushort (System.UInt16).</summary>
    /// <param name=""value"">The value to cast</param>
    /// <exception cref=""InvalidCastException"">
    ///   <paramref name = ""value""/> is not an integral type
    ///   convertable to <see langword=""ushort""/>.
    /// </exception>
    public static ushort ToUShort(this long value) => (ushort)value;

    /// <summary>Cast to ushort (System.UInt16).</summary>
    /// <param name=""value"">The value to cast</param>
    /// <exception cref=""InvalidCastException"">
    ///   <paramref name = ""value""/> is not an integral type
    ///   convertable to <see langword=""ushort""/>.
    /// </exception>
    public static ushort ToUShort(this sbyte value) => (ushort)value;

    /// <summary>Cast to ushort (System.UInt16).</summary>
    /// <param name=""value"">The value to cast</param>
    /// <exception cref=""InvalidCastException"">
    ///   <paramref name = ""value""/> is not an integral type
    ///   convertable to <see langword=""ushort""/>.
    /// </exception>
    public static ushort ToUShort(this short value) => (ushort)value;

    /// <summary>Cast to ushort (System.UInt16).</summary>
    /// <param name=""value"">The value to cast</param>
    /// <exception cref=""InvalidCastException"">
    ///   <paramref name = ""value""/> is not an integral type
    ///   convertable to <see langword=""ushort""/>.
    /// </exception>
    public static ushort ToUShort(this uint value) => (ushort)value;

    /// <summary>Cast to ushort (System.UInt16).</summary>
    /// <param name=""value"">The value to cast</param>
    /// <exception cref=""InvalidCastException"">
    ///   <paramref name = ""value""/> is not an integral type
    ///   convertable to <see langword=""ushort""/>.
    /// </exception>
    public static ushort ToUShort(this ulong value) => (ushort)value;

    /// <summary>Cast to ushort (System.UInt16).</summary>
    /// <param name=""value"">The value to cast</param>
    /// <exception cref=""InvalidCastException"">
    ///   <paramref name = ""value""/> is not an integral type
    ///   convertable to <see langword=""ushort""/>.
    /// </exception>
    public static ushort ToUShort(this ushort value) => (ushort)value;

    #endregion

}
