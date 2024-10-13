namespace Ainsworth.Extensions.Tests;

[TestClass]
[ExcludeFromCodeCoverage]
public class CastExtensionsTests
{
    #region Test Data

    private static IEnumerable<object[]> ByteTestValues { get; } =
        new byte[]{ 0, 1, byte.MaxValue }.Select(v => new object[]{v});

    private static IEnumerable<object[]> FloatTestValues { get; } =
        new float[]{ float.MinValue, -256.1f, -256.0f, 0f, 255.0f, 255.1f, float.MaxValue }
            .Select(v => new object[]{v});

    private static IEnumerable<object[]> IntTestValues { get; } =
        new int[]{ int.MinValue, -1, 0, 1, int.MaxValue }.Select(v => new object[]{v});

    private static IEnumerable<object[]> LongTestValues { get; } =
        new long[]{ long.MinValue, -1, 0, 1, long.MaxValue }.Select(v => new object[]{v});

    private static IEnumerable<object[]> SByteTestValues { get; } =
        new sbyte[]{ sbyte.MinValue, -1, 0, 1, sbyte.MaxValue }.Select(v => new object[]{v});

    private static IEnumerable<object[]> ShortTestValues { get; } =
        new short[]{ short.MinValue, -1, 0, 1, short.MaxValue }.Select(v => new object[]{v});

    private static IEnumerable<object[]> UIntTestValues { get; } =
        new uint[]{ 1, uint.MaxValue }.Select(v => new object[]{v});

    private static IEnumerable<object[]> ULongTestValues { get; } =
        new ulong[]{ 0, 1, ulong.MaxValue }.Select(v => new object[]{v});

    private static IEnumerable<object[]> UShortTestValues { get; } =
        new ushort[]{ 0, 1, ushort.MaxValue }.Select(v => new object[]{v});

    #endregion
    #region ToByte() Unit Tests

    [TestMethod]
    [DynamicData(nameof(ByteTestValues))]
    public void ToByte_byte__returns_same_value_as_cast_syntax(byte value) =>
        Assert.AreEqual((byte)value, value.ToByte());

    [TestMethod]
    [DynamicData(nameof(FloatTestValues))]
    public void ToByte_float__returns_same_value_as_cast_syntax(float value) =>
        Assert.AreEqual((byte)value, value.ToByte());

    [TestMethod]
    [DynamicData(nameof(IntTestValues))]
    public void ToByte_int__returns_same_value_as_cast_syntax(int value) =>
        Assert.AreEqual((byte)value, value.ToByte());

    [TestMethod]
    [DynamicData(nameof(SByteTestValues))]
    public void ToByte_sbyte__returns_same_value_as_cast_syntax(sbyte value) =>
        Assert.AreEqual((byte)value, value.ToByte());

    [TestMethod]
    [DynamicData(nameof(ShortTestValues))]
    public void ToByte_short__returns_same_value_as_cast_syntax(short value) =>
        Assert.AreEqual((byte)value, value.ToByte());

    [TestMethod]
    [DynamicData(nameof(UShortTestValues))]
    public void ToByte_ushort__returns_same_value_as_cast_syntax(ushort value) =>
        Assert.AreEqual((byte)value, value.ToByte());

    [TestMethod]
    [DynamicData(nameof(UIntTestValues))]
    public void ToByte_uint__returns_same_value_as_cast_syntax(uint value) =>
        Assert.AreEqual((byte)value, value.ToByte());

    [TestMethod]
    [DynamicData(nameof(LongTestValues))]
    public void ToByte_long__returns_same_value_as_cast_syntax(long value) =>
        Assert.AreEqual((byte)value, value.ToByte());

    [TestMethod]
    [DynamicData(nameof(ULongTestValues))]
    public void ToByte_ulong__returns_same_value_as_cast_syntax(ulong value) =>
        Assert.AreEqual((byte)value, value.ToByte());

    #endregion
    #region ToInt() Unit Tests

    [TestMethod]
    [DynamicData(nameof(SByteTestValues))]
    public void ToInt_sbyte__returns_same_value_as_cast_syntax(sbyte value) =>
        Assert.AreEqual((int)value, value.ToInt());

    [TestMethod]
    [DynamicData(nameof(ByteTestValues))]
    public void ToInt_byte__returns_same_value_as_cast_syntax(byte value) =>
        Assert.AreEqual((int)value, value.ToInt());

    [TestMethod]
    [DynamicData(nameof(ShortTestValues))]
    public void ToInt_short__returns_same_value_as_cast_syntax(short value) =>
        Assert.AreEqual((int)value, value.ToInt());

    [TestMethod]
    [DynamicData(nameof(UShortTestValues))]
    public void ToInt_ushort__returns_same_value_as_cast_syntax(ushort value) =>
        Assert.AreEqual((int)value, value.ToInt());

    [TestMethod]
    [DynamicData(nameof(IntTestValues))]
    public void ToInt_int__returns_same_value_as_cast_syntax(int value) =>
        Assert.AreEqual((int)value, value.ToInt());

    [TestMethod]
    [DynamicData(nameof(UIntTestValues))]
    public void ToInt_uint__returns_same_value_as_cast_syntax(uint value) =>
        Assert.AreEqual((int)value, value.ToInt());

    [TestMethod]
    [DynamicData(nameof(LongTestValues))]
    public void ToInt_long__returns_same_value_as_cast_syntax(long value) =>
        Assert.AreEqual((int)value, value.ToInt());

    [TestMethod]
    [DynamicData(nameof(ULongTestValues))]
    public void ToInt_ulong__returns_same_value_as_cast_syntax(ulong value) =>
        Assert.AreEqual((int)value, value.ToInt());

    #endregion
    #region ToLong() Unit Tests

    [TestMethod]
    [DynamicData(nameof(SByteTestValues))]
    public void ToLong_sbyte__returns_same_value_as_cast_syntax(sbyte value) =>
        Assert.AreEqual((long)value, value.ToLong());

    [TestMethod]
    [DynamicData(nameof(ByteTestValues))]
    public void ToLong_byte__returns_same_value_as_cast_syntax(byte value) =>
        Assert.AreEqual((long)value, value.ToLong());

    [TestMethod]
    [DynamicData(nameof(ShortTestValues))]
    public void ToLong_short__returns_same_value_as_cast_syntax(short value) =>
        Assert.AreEqual((long)value, value.ToLong());

    [TestMethod]
    [DynamicData(nameof(UShortTestValues))]
    public void ToLong_ushort__returns_same_value_as_cast_syntax(ushort value) =>
        Assert.AreEqual((long)value, value.ToLong());

    [TestMethod]
    [DynamicData(nameof(IntTestValues))]
    public void ToLong_int__returns_same_value_as_cast_syntax(int value) =>
        Assert.AreEqual((long)value, value.ToLong());

    [TestMethod]
    [DynamicData(nameof(UIntTestValues))]
    public void ToLong_uint__returns_same_value_as_cast_syntax(uint value) =>
        Assert.AreEqual((long)value, value.ToLong());

    [TestMethod]
    [DynamicData(nameof(LongTestValues))]
    public void ToLong_long__returns_same_value_as_cast_syntax(long value) =>
        Assert.AreEqual((long)value, value.ToLong());

    [TestMethod]
    [DynamicData(nameof(ULongTestValues))]
    public void ToLong_ulong__returns_same_value_as_cast_syntax(ulong value) =>
        Assert.AreEqual((long)value, value.ToLong());

    #endregion
    #region ToSByte() Unit Tests

    [TestMethod]
    [DynamicData(nameof(SByteTestValues))]
    public void ToSByte_sbyte__returns_same_value_as_cast_syntax(sbyte value) =>
        Assert.AreEqual((sbyte)value, value.ToSByte());

    [TestMethod]
    [DynamicData(nameof(ByteTestValues))]
    public void ToSByte_byte__returns_same_value_as_cast_syntax(byte value) =>
        Assert.AreEqual((sbyte)value, value.ToSByte());

    [TestMethod]
    [DynamicData(nameof(ShortTestValues))]
    public void ToSByte_short__returns_same_value_as_cast_syntax(short value) =>
        Assert.AreEqual((sbyte)value, value.ToSByte());

    [TestMethod]
    [DynamicData(nameof(UShortTestValues))]
    public void ToSByte_ushort__returns_same_value_as_cast_syntax(ushort value) =>
        Assert.AreEqual((sbyte)value, value.ToSByte());

    [TestMethod]
    [DynamicData(nameof(IntTestValues))]
    public void ToSByte_int__returns_same_value_as_cast_syntax(int value) =>
        Assert.AreEqual((sbyte)value, value.ToSByte());

    [TestMethod]
    [DynamicData(nameof(UIntTestValues))]
    public void ToSByte_uint__returns_same_value_as_cast_syntax(uint value) =>
        Assert.AreEqual((sbyte)value, value.ToSByte());

    [TestMethod]
    [DynamicData(nameof(LongTestValues))]
    public void ToSByte_long__returns_same_value_as_cast_syntax(long value) =>
        Assert.AreEqual((sbyte)value, value.ToSByte());

    [TestMethod]
    [DynamicData(nameof(ULongTestValues))]
    public void ToSByte_ulong__returns_same_value_as_cast_syntax(ulong value) =>
        Assert.AreEqual((sbyte)value, value.ToSByte());

    #endregion
    #region ToShort() Unit Tests

    [TestMethod]
    [DynamicData(nameof(SByteTestValues))]
    public void ToShort_sbyte__returns_same_value_as_cast_syntax(sbyte value) =>
        Assert.AreEqual((short)value, value.ToShort());

    [TestMethod]
    [DynamicData(nameof(ByteTestValues))]
    public void ToShort_byte__returns_same_value_as_cast_syntax(byte value) =>
        Assert.AreEqual((short)value, value.ToShort());

    [TestMethod]
    [DynamicData(nameof(ShortTestValues))]
    public void ToShort_short__returns_same_value_as_cast_syntax(short value) =>
        Assert.AreEqual((short)value, value.ToShort());

    [TestMethod]
    [DynamicData(nameof(UShortTestValues))]
    public void ToShort_ushort__returns_same_value_as_cast_syntax(ushort value) =>
        Assert.AreEqual((short)value, value.ToShort());

    [TestMethod]
    [DynamicData(nameof(IntTestValues))]
    public void ToShort_int__returns_same_value_as_cast_syntax(int value) =>
        Assert.AreEqual((short)value, value.ToShort());

    [TestMethod]
    [DynamicData(nameof(UIntTestValues))]
    public void ToShort_uint__returns_same_value_as_cast_syntax(uint value) =>
        Assert.AreEqual((short)value, value.ToShort());

    [TestMethod]
    [DynamicData(nameof(LongTestValues))]
    public void ToShort_long__returns_same_value_as_cast_syntax(long value) =>
        Assert.AreEqual((short)value, value.ToShort());

    [TestMethod]
    [DynamicData(nameof(ULongTestValues))]
    public void ToShort_ulong__returns_same_value_as_cast_syntax(ulong value) =>
        Assert.AreEqual((short)value, value.ToShort());

    #endregion
    #region ToUInt() Unit Tests

    [TestMethod]
    [DynamicData(nameof(SByteTestValues))]
    public void ToUInt_sbyte__returns_same_value_as_cast_syntax(sbyte value) =>
        Assert.AreEqual((uint)value, value.ToUInt());

    [TestMethod]
    [DynamicData(nameof(ByteTestValues))]
    public void ToUInt_byte__returns_same_value_as_cast_syntax(byte value) =>
        Assert.AreEqual((uint)value, value.ToUInt());

    [TestMethod]
    [DynamicData(nameof(ShortTestValues))]
    public void ToUInt_short__returns_same_value_as_cast_syntax(short value) =>
        Assert.AreEqual((uint)value, value.ToUInt());

    [TestMethod]
    [DynamicData(nameof(UShortTestValues))]
    public void ToUInt_ushort__returns_same_value_as_cast_syntax(ushort value) =>
        Assert.AreEqual((uint)value, value.ToUInt());

    [TestMethod]
    [DynamicData(nameof(IntTestValues))]
    public void ToUInt_int__returns_same_value_as_cast_syntax(int value) =>
        Assert.AreEqual((uint)value, value.ToUInt());

    [TestMethod]
    [DynamicData(nameof(UIntTestValues))]
    public void ToUInt_uint__returns_same_value_as_cast_syntax(uint value) =>
        Assert.AreEqual((uint)value, value.ToUInt());

    [TestMethod]
    [DynamicData(nameof(LongTestValues))]
    public void ToUInt_long__returns_same_value_as_cast_syntax(long value) =>
        Assert.AreEqual((uint)value, value.ToUInt());

    [TestMethod]
    [DynamicData(nameof(ULongTestValues))]
    public void ToUInt_ulong__returns_same_value_as_cast_syntax(ulong value) =>
        Assert.AreEqual((uint)value, value.ToUInt());

    #endregion
    #region ToULong() Unit Tests

    [TestMethod]
    [DynamicData(nameof(SByteTestValues))]
    public void ToULong_sbyte__returns_same_value_as_cast_syntax(sbyte value) =>
        Assert.AreEqual((ulong)value, value.ToULong());

    [TestMethod]
    [DynamicData(nameof(ByteTestValues))]
    public void ToULong_byte__returns_same_value_as_cast_syntax(byte value) =>
        Assert.AreEqual((ulong)value, value.ToULong());

    [TestMethod]
    [DynamicData(nameof(ShortTestValues))]
    public void ToULong_short__returns_same_value_as_cast_syntax(short value) =>
        Assert.AreEqual((ulong)value, value.ToULong());

    [TestMethod]
    [DynamicData(nameof(UShortTestValues))]
    public void ToULong_ushort__returns_same_value_as_cast_syntax(ushort value) =>
        Assert.AreEqual((ulong)value, value.ToULong());

    [TestMethod]
    [DynamicData(nameof(IntTestValues))]
    public void ToULong_int__returns_same_value_as_cast_syntax(int value) =>
        Assert.AreEqual((ulong)value, value.ToULong());

    [TestMethod]
    [DynamicData(nameof(UIntTestValues))]
    public void ToULong_uint__returns_same_value_as_cast_syntax(uint value) =>
        Assert.AreEqual((ulong)value, value.ToULong());

    [TestMethod]
    [DynamicData(nameof(LongTestValues))]
    public void ToULong_long__returns_same_value_as_cast_syntax(long value) =>
        Assert.AreEqual((ulong)value, value.ToULong());

    [TestMethod]
    [DynamicData(nameof(ULongTestValues))]
    public void ToULong_ulong__returns_same_value_as_cast_syntax(ulong value) =>
        Assert.AreEqual((ulong)value, value.ToULong());

    #endregion
    #region ToUShort() Unit Tests

    [TestMethod]
    [DynamicData(nameof(SByteTestValues))]
    public void ToUShort_sbyte__returns_same_value_as_cast_syntax(sbyte value) =>
        Assert.AreEqual((ushort)value, value.ToUShort());

    [TestMethod]
    [DynamicData(nameof(ByteTestValues))]
    public void ToUShort_byte__returns_same_value_as_cast_syntax(byte value) =>
        Assert.AreEqual((ushort)value, value.ToUShort());

    [TestMethod]
    [DynamicData(nameof(ShortTestValues))]
    public void ToUShort_short__returns_same_value_as_cast_syntax(short value) =>
        Assert.AreEqual((ushort)value, value.ToUShort());

    [TestMethod]
    [DynamicData(nameof(UShortTestValues))]
    public void ToUShort_ushort__returns_same_value_as_cast_syntax(ushort value) =>
        Assert.AreEqual((ushort)value, value.ToUShort());

    [TestMethod]
    [DynamicData(nameof(IntTestValues))]
    public void ToUShort_int__returns_same_value_as_cast_syntax(int value) =>
        Assert.AreEqual((ushort)value, value.ToUShort());

    [TestMethod]
    [DynamicData(nameof(UIntTestValues))]
    public void ToUShort_uint__returns_same_value_as_cast_syntax(uint value) =>
        Assert.AreEqual((ushort)value, value.ToUShort());

    [TestMethod]
    [DynamicData(nameof(LongTestValues))]
    public void ToUShort_long__returns_same_value_as_cast_syntax(long value) =>
        Assert.AreEqual((ushort)value, value.ToUShort());

    [TestMethod]
    [DynamicData(nameof(ULongTestValues))]
    public void ToUShort_ulong__returns_same_value_as_cast_syntax(ulong value) =>
        Assert.AreEqual((ushort)value, value.ToUShort());

    #endregion
}
