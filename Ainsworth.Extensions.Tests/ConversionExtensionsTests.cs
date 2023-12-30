namespace Ainsworth.Extensions.Tests;

[TestClass]
public class ConversionExtensionsTests
{

    // Prefer the clarity of full names in this code
    #pragma warning disable IDE0049 // Simplify Names

    private static IEnumerable<object[]> IntStrings { get; } = [
        new string[] { "-2147483648" },                 // -(2^31)
        [ "-2147483647" ],                              // -(2^31)+1
        [      "-32769" ], [ "-32768" ], [ "-32767" ],  // -(2^15)±1
        [          "-1" ], [      "0" ], [      "1" ],
        [       "32766" ], [  "32767" ], [  "32768" ],  // (2^15-1)±1
        [  "2147483646" ],                              // (2^31-1)-1
        [  "2147483647" ]                               // (2^31-1)
    ];

    [DataTestMethod]
    [DynamicData(nameof(IntStrings), DynamicDataSourceType.Property)]
    public void ParseInt_string__returns_same_value_as_Int32Parse(string s) =>
        Assert.AreEqual(Int32.Parse(s), s.ParseInt());

    [DataTestMethod]
    [DynamicData(nameof(IntStrings), DynamicDataSourceType.Property)]
    public void ParseInt_object__returns_same_value_as_Int32Parse(object obj) =>
        Assert.AreEqual(Int32.Parse((string)obj), obj.ParseInt());

    public static IEnumerable<object[]> LongStrings { get; }  = [
        new string[] { "-9223372036854775808" },                            // -(2^63)
        [ "-9223372036854775807" ],                                         // -(2^63)+1
        [          "-2147483649" ], [ "-2147483648" ], [ "-2147483647" ],   // -(2^31)±1
        [               "-32769" ], [      "-32768" ], [      "-32767" ],   // -(2^15)±1
        [                   "-1" ], [           "0" ], [           "1" ],
        [                "32766" ], [       "32767" ], [       "32768" ],   // (2^15-1)±1
        [           "2147483646" ], [  "2147483647" ], [  "2147483648" ],   // (2^31-1)±1
        [  "9223372036854775806" ],                                         // (2^63-1)-1
        [  "9223372036854775807" ]                                          // (2^63-1)
    ];

    [DataTestMethod]
    [DynamicData(nameof(LongStrings), DynamicDataSourceType.Property)]
    public void ParseLong_string__returns_same_value_as_Int64Parse(string s) =>
        Assert.AreEqual(Int64.Parse(s), s.ParseLong());

    [DataTestMethod]
    [DynamicData(nameof(LongStrings), DynamicDataSourceType.Property)]
    public void ParseLong_object__returns_same_value_as_Int64Parse(object obj) =>
        Assert.AreEqual(Int64.Parse((string)obj), obj.ParseLong());

}
