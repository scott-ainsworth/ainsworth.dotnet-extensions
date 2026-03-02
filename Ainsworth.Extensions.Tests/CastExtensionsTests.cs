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
    public void ByteToByteReturnsSameValueAsCastSyntax(byte value) =>
        Assert.AreEqual((byte)value, value.ToByte());

    [TestMethod]
    [DynamicData(nameof(FloatTestValues))]
    public void FloatToByteReturnsSameValueAsCastSyntax(float value) =>
        Assert.AreEqual((byte)value, value.ToByte());

    [TestMethod]
    [DynamicData(nameof(IntTestValues))]
    public void IntToByteReturnsSameValueAsCastSyntax(int value) =>
        Assert.AreEqual((byte)value, value.ToByte());

    [TestMethod]
    [DynamicData(nameof(SByteTestValues))]
    public void SByteToByteReturnsSameValueAsCastSyntax(sbyte value) =>
        Assert.AreEqual((byte)value, value.ToByte());

    [TestMethod]
    [DynamicData(nameof(ShortTestValues))]
    public void ShortToByteReturnsSameValueAsCastSyntax(short value) =>
        Assert.AreEqual((byte)value, value.ToByte());

    [TestMethod]
    [DynamicData(nameof(UShortTestValues))]
    public void UShortToByteReturnsSameValueAsCastSyntax(ushort value) =>
        Assert.AreEqual((byte)value, value.ToByte());

    [TestMethod]
    [DynamicData(nameof(UIntTestValues))]
    public void UIntToByteReturnsSameValueAsCastSyntax(uint value) =>
        Assert.AreEqual((byte)value, value.ToByte());

    [TestMethod]
    [DynamicData(nameof(LongTestValues))]
    public void LongToByteReturnsSameValueAsCastSyntax(long value) =>
        Assert.AreEqual((byte)value, value.ToByte());

    [TestMethod]
    [DynamicData(nameof(ULongTestValues))]
    public void ULongToByteReturnsSameValueAsCastSyntax(ulong value) =>
        Assert.AreEqual((byte)value, value.ToByte());

    #endregion
    #region ToInt() Unit Tests

    [TestMethod]
    [DynamicData(nameof(SByteTestValues))]
    public void SByteToIntReturnsSameValueAsCastSyntax(sbyte value) =>
        Assert.AreEqual((int)value, value.ToInt());

    [TestMethod]
    [DynamicData(nameof(ByteTestValues))]
    public void ByteToIntReturnsSameValueAsCastSyntax(byte value) =>
        Assert.AreEqual((int)value, value.ToInt());

    [TestMethod]
    [DynamicData(nameof(ShortTestValues))]
    public void ShortToIntReturnsSameValueAsCastSyntax(short value) =>
        Assert.AreEqual((int)value, value.ToInt());

    [TestMethod]
    [DynamicData(nameof(UShortTestValues))]
    public void UShortToIntReturnsSameValueAsCastSyntax(ushort value) =>
        Assert.AreEqual((int)value, value.ToInt());

    [TestMethod]
    [DynamicData(nameof(IntTestValues))]
    public void IntToIntReturnsSameValueAsCastSyntax(int value) =>
        Assert.AreEqual((int)value, value.ToInt());

    [TestMethod]
    [DynamicData(nameof(UIntTestValues))]
    public void UIntToIntReturnsSameValueAsCastSyntax(uint value) =>
        Assert.AreEqual((int)value, value.ToInt());

    [TestMethod]
    [DynamicData(nameof(LongTestValues))]
    public void LongToIntReturnsSameValueAsCastSyntax(long value) =>
        Assert.AreEqual((int)value, value.ToInt());

    [TestMethod]
    [DynamicData(nameof(ULongTestValues))]
    public void ULongToIntReturnsSameValueAsCastSyntax(ulong value) =>
        Assert.AreEqual((int)value, value.ToInt());

    #endregion
    #region ToLong() Unit Tests

    [TestMethod]
    [DynamicData(nameof(SByteTestValues))]
    public void SByteToLongReturnsSameValueAsCastSyntax(sbyte value) =>
        Assert.AreEqual((long)value, value.ToLong());

    [TestMethod]
    [DynamicData(nameof(ByteTestValues))]
    public void ByteToLongReturnsSameValueAsCastSyntax(byte value) =>
        Assert.AreEqual((long)value, value.ToLong());

    [TestMethod]
    [DynamicData(nameof(ShortTestValues))]
    public void ShortToLongReturnsSameValueAsCastSyntax(short value) =>
        Assert.AreEqual((long)value, value.ToLong());

    [TestMethod]
    [DynamicData(nameof(UShortTestValues))]
    public void UShortToLongReturnsSameValueAsCastSyntax(ushort value) =>
        Assert.AreEqual((long)value, value.ToLong());

    [TestMethod]
    [DynamicData(nameof(IntTestValues))]
    public void IntToLongReturnsSameValueAsCastSyntax(int value) =>
        Assert.AreEqual((long)value, value.ToLong());

    [TestMethod]
    [DynamicData(nameof(UIntTestValues))]
    public void UIntToLongReturnsSameValueAsCastSyntax(uint value) =>
        Assert.AreEqual((long)value, value.ToLong());

    [TestMethod]
    [DynamicData(nameof(LongTestValues))]
    public void LongToLongReturnsSameValueAsCastSyntax(long value) =>
        Assert.AreEqual((long)value, value.ToLong());

    [TestMethod]
    [DynamicData(nameof(ULongTestValues))]
    public void ULongToLongReturnsSameValueAsCastSyntax(ulong value) =>
        Assert.AreEqual((long)value, value.ToLong());

    #endregion
    #region ToSByte() Unit Tests

    [TestMethod]
    [DynamicData(nameof(SByteTestValues))]
    public void SByteToSByteReturnsSameValueAsCastSyntax(sbyte value) =>
        Assert.AreEqual((sbyte)value, value.ToSByte());

    [TestMethod]
    [DynamicData(nameof(ByteTestValues))]
    public void ByteToSByteReturnsSameValueAsCastSyntax(byte value) =>
        Assert.AreEqual((sbyte)value, value.ToSByte());

    [TestMethod]
    [DynamicData(nameof(ShortTestValues))]
    public void ShortToSByteReturnsSameValueAsCastSyntax(short value) =>
        Assert.AreEqual((sbyte)value, value.ToSByte());

    [TestMethod]
    [DynamicData(nameof(UShortTestValues))]
    public void UShortToSByteReturnsSameValueAsCastSyntax(ushort value) =>
        Assert.AreEqual((sbyte)value, value.ToSByte());

    [TestMethod]
    [DynamicData(nameof(IntTestValues))]
    public void IntToSByteReturnsSameValueAsCastSyntax(int value) =>
        Assert.AreEqual((sbyte)value, value.ToSByte());

    [TestMethod]
    [DynamicData(nameof(UIntTestValues))]
    public void UIntToSByteReturnsSameValueAsCastSyntax(uint value) =>
        Assert.AreEqual((sbyte)value, value.ToSByte());

    [TestMethod]
    [DynamicData(nameof(LongTestValues))]
    public void LongToSByteReturnsSameValueAsCastSyntax(long value) =>
        Assert.AreEqual((sbyte)value, value.ToSByte());

    [TestMethod]
    [DynamicData(nameof(ULongTestValues))]
    public void ULongToSByteReturnsSameValueAsCastSyntax(ulong value) =>
        Assert.AreEqual((sbyte)value, value.ToSByte());

    #endregion
    #region ToShort() Unit Tests

    [TestMethod]
    [DynamicData(nameof(SByteTestValues))]
    public void SByteToShortReturnsSameValueAsCastSyntax(sbyte value) =>
        Assert.AreEqual((short)value, value.ToShort());

    [TestMethod]
    [DynamicData(nameof(ByteTestValues))]
    public void ByteToShortReturnsSameValueAsCastSyntax(byte value) =>
        Assert.AreEqual((short)value, value.ToShort());

    [TestMethod]
    [DynamicData(nameof(ShortTestValues))]
    public void ShortToShortReturnsSameValueAsCastSyntax(short value) =>
        Assert.AreEqual((short)value, value.ToShort());

    [TestMethod]
    [DynamicData(nameof(UShortTestValues))]
    public void UShortToShortReturnsSameValueAsCastSyntax(ushort value) =>
        Assert.AreEqual((short)value, value.ToShort());

    [TestMethod]
    [DynamicData(nameof(IntTestValues))]
    public void IntToShortReturnsSameValueAsCastSyntax(int value) =>
        Assert.AreEqual((short)value, value.ToShort());

    [TestMethod]
    [DynamicData(nameof(UIntTestValues))]
    public void UIntToShortReturnsSameValueAsCastSyntax(uint value) =>
        Assert.AreEqual((short)value, value.ToShort());

    [TestMethod]
    [DynamicData(nameof(LongTestValues))]
    public void LongToShortReturnsSameValueAsCastSyntax(long value) =>
        Assert.AreEqual((short)value, value.ToShort());

    [TestMethod]
    [DynamicData(nameof(ULongTestValues))]
    public void ULongToShortReturnsSameValueAsCastSyntax(ulong value) =>
        Assert.AreEqual((short)value, value.ToShort());

    #endregion
    #region ToUInt() Unit Tests

    [TestMethod]
    [DynamicData(nameof(SByteTestValues))]
    public void SByteToUIntReturnsSameValueAsCastSyntax(sbyte value) =>
        Assert.AreEqual((uint)value, value.ToUInt());

    [TestMethod]
    [DynamicData(nameof(ByteTestValues))]
    public void ByteToUIntReturnsSameValueAsCastSyntax(byte value) =>
        Assert.AreEqual((uint)value, value.ToUInt());

    [TestMethod]
    [DynamicData(nameof(ShortTestValues))]
    public void ShortToUIntReturnsSameValueAsCastSyntax(short value) =>
        Assert.AreEqual((uint)value, value.ToUInt());

    [TestMethod]
    [DynamicData(nameof(UShortTestValues))]
    public void UShortToUIntReturnsSameValueAsCastSyntax(ushort value) =>
        Assert.AreEqual((uint)value, value.ToUInt());

    [TestMethod]
    [DynamicData(nameof(IntTestValues))]
    public void IntToUIntReturnsSameValueAsCastSyntax(int value) =>
        Assert.AreEqual((uint)value, value.ToUInt());

    [TestMethod]
    [DynamicData(nameof(UIntTestValues))]
    public void UIntToUIntReturnsSameValueAsCastSyntax(uint value) =>
        Assert.AreEqual((uint)value, value.ToUInt());

    [TestMethod]
    [DynamicData(nameof(LongTestValues))]
    public void LongToUIntReturnsSameValueAsCastSyntax(long value) =>
        Assert.AreEqual((uint)value, value.ToUInt());

    [TestMethod]
    [DynamicData(nameof(ULongTestValues))]
    public void ULongToUIntReturnsSameValueAsCastSyntax(ulong value) =>
        Assert.AreEqual((uint)value, value.ToUInt());

    #endregion
    #region ToULong() Unit Tests

    [TestMethod]
    [DynamicData(nameof(SByteTestValues))]
    public void SByteToULongReturnsSameValueAsCastSyntax(sbyte value) =>
        Assert.AreEqual((ulong)value, value.ToULong());

    [TestMethod]
    [DynamicData(nameof(ByteTestValues))]
    public void ByteToULongReturnsSameValueAsCastSyntax(byte value) =>
        Assert.AreEqual((ulong)value, value.ToULong());

    [TestMethod]
    [DynamicData(nameof(ShortTestValues))]
    public void ShortToULongReturnsSameValueAsCastSyntax(short value) =>
        Assert.AreEqual((ulong)value, value.ToULong());

    [TestMethod]
    [DynamicData(nameof(UShortTestValues))]
    public void UShortToULongReturnsSameValueAsCastSyntax(ushort value) =>
        Assert.AreEqual((ulong)value, value.ToULong());

    [TestMethod]
    [DynamicData(nameof(IntTestValues))]
    public void IntToULongReturnsSameValueAsCastSyntax(int value) =>
        Assert.AreEqual((ulong)value, value.ToULong());

    [TestMethod]
    [DynamicData(nameof(UIntTestValues))]
    public void UIntToULongReturnsSameValueAsCastSyntax(uint value) =>
        Assert.AreEqual((ulong)value, value.ToULong());

    [TestMethod]
    [DynamicData(nameof(LongTestValues))]
    public void LongToULongReturnsSameValueAsCastSyntax(long value) =>
        Assert.AreEqual((ulong)value, value.ToULong());

    [TestMethod]
    [DynamicData(nameof(ULongTestValues))]
    public void ULongToULongReturnsSameValueAsCastSyntax(ulong value) =>
        Assert.AreEqual((ulong)value, value.ToULong());

    #endregion
    #region ToUShort() Unit Tests

    [TestMethod]
    [DynamicData(nameof(SByteTestValues))]
    public void SByteToUShortReturnsSameValueAsCastSyntax(sbyte value) =>
        Assert.AreEqual((ushort)value, value.ToUShort());

    [TestMethod]
    [DynamicData(nameof(ByteTestValues))]
    public void ByteToUShortReturnsSameValueAsCastSyntax(byte value) =>
        Assert.AreEqual((ushort)value, value.ToUShort());

    [TestMethod]
    [DynamicData(nameof(ShortTestValues))]
    public void ShortToUShortReturnsSameValueAsCastSyntax(short value) =>
        Assert.AreEqual((ushort)value, value.ToUShort());

    [TestMethod]
    [DynamicData(nameof(UShortTestValues))]
    public void UShortToUShortReturnsSameValueAsCastSyntax(ushort value) =>
        Assert.AreEqual((ushort)value, value.ToUShort());

    [TestMethod]
    [DynamicData(nameof(IntTestValues))]
    public void IntToUShortReturnsSameValueAsCastSyntax(int value) =>
        Assert.AreEqual((ushort)value, value.ToUShort());

    [TestMethod]
    [DynamicData(nameof(UIntTestValues))]
    public void UIntToUShortReturnsSameValueAsCastSyntax(uint value) =>
        Assert.AreEqual((ushort)value, value.ToUShort());

    [TestMethod]
    [DynamicData(nameof(LongTestValues))]
    public void LongToUShortReturnsSameValueAsCastSyntax(long value) =>
        Assert.AreEqual((ushort)value, value.ToUShort());

    [TestMethod]
    [DynamicData(nameof(ULongTestValues))]
    public void ULongToUShortReturnsSameValueAsCastSyntax(ulong value) =>
        Assert.AreEqual((ushort)value, value.ToUShort());

    #endregion
}
