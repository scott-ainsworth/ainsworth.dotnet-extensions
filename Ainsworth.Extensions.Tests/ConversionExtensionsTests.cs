using Microsoft.VisualBasic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ainsworth.Extensions.Tests;

[TestClass]
public class ConversionExtensionsTests 
{
    #region Test Parse()

    public static IEnumerable<object> IntStrings { get => new[] {
            new string[] { "-2147483648" },         // -(2^31)
            ["-2147483647"],                        // -(2^31)+1
            ["-32769"], ["-32768"], ["-32767"],     // -(2^15)±1
            ["-1"], ["0"], ["1"],
            ["32766"], ["32767"],  ["32768"],       // (2^15-1)±1
            ["2147483646"],                         // (2^31-1)-1
            ["2147483647"]                          // (2^31-1)
        };
    }

    public static IEnumerable<object> LongStrings { get => new[] {
            new string[] { "-9223372036854775808" },            // -(2^63)
            ["-9223372036854775807"],                           // -(2^63)+1
            ["-2147483649"],["-2147483648"],["-2147483647"],    // -(2^31)±1
            ["-32769"], ["-32768"], ["-32767"],                 // -(2^15)±1
            ["-1"], ["0"], ["1"],
            ["32766"], ["32767"],  ["32768"],                   // (2^15-1)±1
            ["2147483646"], ["2147483647"], ["2147483648"],     // (2^31-1)±1
            ["9223372036854775806"],                            // (2^63-1)-1
            ["9223372036854775807"]                             // (2^63-1)
        };
    }

    [DataTestMethod]
    [DynamicData(nameof(IntStrings), DynamicDataSourceType.Property)]
    public void ParseInt_string__returns_same_value_as_Int32Parse(string s) {
        var actual = s.ParseInt();
        var expected = Int32.Parse(s);
        Assert.AreEqual(expected, actual);
    }

    [DataTestMethod]
    [DynamicData(nameof(IntStrings), DynamicDataSourceType.Property)]
    public void ParseInt_object__returns_same_value_as_Int32Parse(object obj) {
        var actual = obj.ParseInt();
        var expected = Int32.Parse((string)obj);
        Assert.AreEqual(expected, actual);
    }

    [DataTestMethod]
    [DynamicData(nameof(LongStrings), DynamicDataSourceType.Property)]
    public void ParseLong_string__returns_same_value_as_Int64Parse(string s) {
        var actual = s.ParseLong();
        var expected = Int64.Parse(s);
        Assert.AreEqual(expected, actual);
    }

    [DataTestMethod]
    [DynamicData(nameof(LongStrings), DynamicDataSourceType.Property)]
    public void ParseLong_string__returns_same_value_as_Int64Parse(object obj) {
        var actual = obj.ParseLong();
        var expected = Int64.Parse((string)obj);
        Assert.AreEqual(expected, actual);
    }

    #endregion
    #region Test Casts

    #region Cast Unit Tests
    [TestMethod]
    [DynamicData(nameof(SByteTestValues))]
    public void ToLong_sbyte__returns_same_value_as_cast_syntax(sbyte value) {
        var expected = (long)value;
        var actual = value.ToLong();
    }

    [TestMethod]
    [DynamicData(nameof(ByteTestValues))]
    public void ToLong_byte__returns_same_value_as_cast_syntax(byte value) {
        var expected = (long)value;
        var actual = value.ToLong();
    }

    [TestMethod]
    [DynamicData(nameof(ShortTestValues))]
    public void ToLong_short__returns_same_value_as_cast_syntax(short value) {
        var expected = (long)value;
        var actual = value.ToLong();
    }

    [TestMethod]
    [DynamicData(nameof(UShortTestValues))]
    public void ToLong_ushort__returns_same_value_as_cast_syntax(ushort value) {
        var expected = (long)value;
        var actual = value.ToLong();
    }

    [TestMethod]
    [DynamicData(nameof(IntTestValues))]
    public void ToLong_int__returns_same_value_as_cast_syntax(int value) {
        var expected = (long)value;
        var actual = value.ToLong();
    }

    [TestMethod]
    [DynamicData(nameof(UIntTestValues))]
    public void ToLong_uint__returns_same_value_as_cast_syntax(uint value) {
        var expected = (long)value;
        var actual = value.ToLong();
    }

    [TestMethod]
    [DynamicData(nameof(LongTestValues))]
    public void ToLong_long__returns_same_value_as_cast_syntax(long value) {
        var expected = (long)value;
        var actual = value.ToLong();
    }

    [TestMethod]
    [DynamicData(nameof(ULongTestValues))]
    public void ToLong_ulong__returns_same_value_as_cast_syntax(ulong value) {
        var expected = (long)value;
        var actual = value.ToLong();
    }

    #endregion
    #region Cast Test Data

    private static IEnumerable<object[]> SByteTestValues =>
        new sbyte[]{ sbyte.MinValue, -1, 0, 1, sbyte.MaxValue }.Select(v => new object[]{v});

    private static IEnumerable<object[]> ByteTestValues =>
        new byte[]{ 0, 1, byte.MaxValue }.Select(v => new object[]{v});
    
    private static IEnumerable<object[]> ShortTestValues =>
        new short[]{ short.MinValue, -1, 0, 1, short.MaxValue }.Select(v => new object[]{v});
    
    private static IEnumerable<object[]> UShortTestValues =>
        new ushort[]{ 0, 1, ushort.MaxValue }.Select(v => new object[]{v});
    
    private static IEnumerable<object[]> IntTestValues =>
        new int[]{ int.MinValue, -1, 0, 1, int.MaxValue }.Select(v => new object[]{v});
    
    private static IEnumerable<object[]> UIntTestValues =>
        new uint[]{ 1, uint.MaxValue }.Select(v => new object[]{v});
    
    private static IEnumerable<object[]> LongTestValues =>
        new long[]{ long.MinValue, -1, 0, 1, long.MaxValue }.Select(v => new object[]{v});
    
    private static IEnumerable<object[]> ULongTestValues =>
        new ulong[]{ 0, 1, ulong.MaxValue }.Select(v => new object[]{v});
    
    #endregion
   
   #endregion
}
