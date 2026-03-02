using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace Ainsworth.Extensions.Tests;

[TestClass]
[ExcludeFromCodeCoverage]
public class ParseExtensionsTests {

    // Prefer the clarity of full names in this code
    #pragma warning disable IDE0049 // Simplify Names

    #region string.ParseInt32() Tests
    /*******************************************************
    * string.ParseInt32() && string.TryParseInt32() Tests
    *******************************************************/

    private static IEnumerable<object[]> Int32ValidStrings { get; } = [
        new string[] { "-2147483648" },                 // -(2^31)
        [ "-2147483647" ],                              // -(2^31)+1
        [      "-32769" ], [ "-32768" ], [ "-32767" ],  // -(2^15)±1
        [          "-1" ], [      "0" ], [      "1" ],
        [       "32766" ], [  "32767" ], [  "32768" ],  // (2^15-1)±1
        [  "2147483646" ],                              // (2^31-1)-1
        [  "2147483647" ]                               // (2^31-1)
    ];

    [TestMethod]
    [DynamicData(nameof(Int32ValidStrings))]
    public void StringParseInt32ReturnsSameValueAsInt32Parse(string s) {
        var expected = Int32.Parse(s);
        Assert.AreEqual(expected, s.ParseInt32());
        Assert.AreEqual(expected,
                        s.ParseInt32(NumberStyles.Integer, provider: null));
        Assert.AreEqual(expected, s.ParseInt32(provider: null));
        Assert.AreEqual(expected,
                        s.ParseInt32(NumberStyles.Integer));
    }

    /**
    * string.TryParseInt32() Tests
    */

    [TestMethod]
    [DynamicData(nameof(Int32ValidStrings))]
    public void StringTryParseInt32ReturnsSameValueAsInt32TryParse(string s) {
        var expected = Int32.Parse(s);
        Assert.IsTrue(s.TryParseInt32(out var result));
        Assert.AreEqual(expected, result);
        Assert.IsTrue(s.TryParseInt32(NumberStyles.Integer, provider: null, out result));
        Assert.AreEqual(expected, result);
        Assert.IsTrue(s.TryParseInt32(provider: null, out result));
        Assert.AreEqual(expected, result);
        Assert.IsTrue(s.TryParseInt32(CultureInfo.InvariantCulture, out result));
        Assert.AreEqual(expected, result);
        Assert.IsTrue(s.TryParseInt32(NumberStyles.Integer, out result));
        Assert.AreEqual(expected, result);
    }

    #endregion
    #region string.ParseInt64() & string.TryParseInt64() Tests
    /*******************************************************
    * string.ParseInt64() && string.TryParseInt64() Tests
    *******************************************************/

    public static IEnumerable<object[]> Int64ValidStrings { get; }  = [
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

    [TestMethod]
    [DynamicData(nameof(Int64ValidStrings))]
    public void StringParseInt64ReturnsSameValueAsInt64Parse(string s) {
        var expected = Int64.Parse(s);
        Assert.AreEqual(expected, s.ParseInt64());
        Assert.AreEqual(expected, s.ParseInt64(NumberStyles.Integer, provider: null));
        Assert.AreEqual(expected, s.ParseInt64(provider: null));
        Assert.AreEqual(expected, s.ParseInt64(CultureInfo.InvariantCulture));
        Assert.AreEqual(expected, s.ParseInt64(NumberStyles.Integer));
    }

    /**
    * string.TryParseInt64() Tests
    */

    [TestMethod]
    [DynamicData(nameof(Int64ValidStrings))]
    public void StringTryParseInt64ReturnsSameValueAsInt64TryParse(string s) {
        var expected = Int64.Parse(s);
        Assert.IsTrue(s.TryParseInt64(out var result));
        Assert.AreEqual(expected, result);
        Assert.IsTrue(s.TryParseInt64(NumberStyles.Integer, provider: null, out result));
        Assert.AreEqual(expected, result);
        Assert.IsTrue(s.TryParseInt64(provider: null, out result));
        Assert.AreEqual(expected, result);
        Assert.IsTrue(s.TryParseInt64(CultureInfo.InvariantCulture, out result));
        Assert.AreEqual(expected, result);
        Assert.IsTrue(s.TryParseInt64(NumberStyles.Integer, out result));
        Assert.AreEqual(expected, result);
    }

    #endregion
}
