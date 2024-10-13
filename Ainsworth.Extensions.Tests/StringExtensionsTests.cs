using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Text;

namespace Ainsworth.Extensions.Tests;

[ExcludeFromCodeCoverage]
internal record TestStringPair(string? StrA, string? StrB);

[ExcludeFromCodeCoverage]
internal record TestRange(int IndexA, int IndexB, int Length);

/// <summary>
///   Unit tests for <see cref="StringExtensions"/>
/// </summary>
[TestClass]
[ExcludeFromCodeCoverage]
public class StringExtensionsTests {

    #region Test Data

    private static readonly CultureInfo[] TestCultures = [
        CultureInfo.CurrentCulture,
        CultureInfo.InvariantCulture,
        new CultureInfo("en-US"),
        new CultureInfo("fr-FR"),
        new CultureInfo("de-DE")
    ];

    #endregion
    #region String.Compare()

    #region String.Compare() Data

    private static readonly CompareOptions[] TestCompareOptions = [
        CompareOptions.None,
        CompareOptions.IgnoreCase,
        CompareOptions.IgnoreKanaType,
        CompareOptions.IgnoreNonSpace,
        CompareOptions.IgnoreSymbols,
        CompareOptions.IgnoreWidth,
        CompareOptions.Ordinal,
        CompareOptions.OrdinalIgnoreCase,
        CompareOptions.StringSort,
    ];

    private static readonly StringComparison[] TestComparisons = [
        StringComparison.CurrentCulture,
        StringComparison.CurrentCultureIgnoreCase,
        StringComparison.InvariantCulture,
        StringComparison.InvariantCultureIgnoreCase,
        StringComparison.Ordinal,
        StringComparison.Ordinal,
    ];

    private static readonly TestRange[] TestRanges = [
        new(0, 0, 3), // equals
        new(1, 1, 3)  // not equals
    ];

    private static readonly TestStringPair[] TestStrings = [
        new("abcde", "abcde"), // equals
        new("abcde", "abcd" ), // not equals, different lengths
        new("abcde", "abcDe"), // ignore case equals
        new("abcde", ""     ), // not equals, empty string
        new("",      "abcde"), // not equals, empty string
        new("",      ""     ), // equals
        new("abcde", null   ), // not equals, null
        new(null,    "abcde"), // not equals, null
        new(null,    null   ), // equals
    ];

    private static readonly (TestStringPair pair, TestRange range)[] RangeTestStrings =
        TestStrings
            .SelectMany(pair => TestRanges.Select(range => (pair, range)))
            .Where(p => p.pair.IsLongEnough(p.range))
            .ToArray();

    #endregion

    [DataTestMethod]
    [DynamicData(nameof(Substrings_culture_options_data), DynamicDataSourceType.Property)]
    public void String_Compare_substrings_culture_options_returns_same_results(
            string? strA, int indexA, string? strB, int indexB, int length,
            CultureInfo culture, CompareOptions options) =>
        Assert.AreEqual(
            string.Compare(strA, indexA, strB, indexB, length, CultureInfo.CurrentCulture, options),
            strA.Compare(indexA, strB, indexB, length, culture, options));
    private static IEnumerable<object?[]> Substrings_culture_options_data { get {
            foreach (var (pair, range) in RangeTestStrings)
                foreach (var culture in TestCultures)
                    foreach (var options in TestCompareOptions)
                        yield return new object?[] {
                        pair.StrA, range.IndexA,
                        pair.StrB, range.IndexB, range.Length, culture, options };
        } }

    [DataTestMethod]
    [DynamicData(nameof(Substrings_ignorecase_culture_data), DynamicDataSourceType.Property)]
    public void String_Compare_substrings_ignorecase_culture_returns_same_results(
            string? strA, int indexA, string? strB, int indexB, int length,
            bool ignoreCase, CultureInfo culture) =>
        Assert.AreEqual(
            string.Compare(strA, indexA, strB, indexB, length, ignoreCase, culture),
            strA.Compare(indexA, strB, indexB, length, ignoreCase, culture));
    private static IEnumerable<object?[]> Substrings_ignorecase_culture_data { get {
            foreach (var (pair, range) in RangeTestStrings)
                foreach (var culture in TestCultures) {
                    yield return new object?[] {
                    pair.StrA, range.IndexA,
                    pair.StrB, range.IndexB, range.Length, false, culture };
                    yield return new object?[] {
                    pair.StrA, range.IndexA,
                    pair.StrB, range.IndexB, range.Length, true,  culture };
                }
        } }

    [DataTestMethod]
    [DynamicData(nameof(Substrings_comparisontype_data), DynamicDataSourceType.Property)]
    public void String_Compare_substrings_comparisontype_returns_same_results(
            string? strA, int indexA, string? strB, int indexB, int length,
            StringComparison comparisonType) =>
        Assert.AreEqual(
            string.Compare(strA, indexA, strB, indexB, length, comparisonType),
            strA.Compare(indexA, strB, indexB, length, comparisonType));
    private static IEnumerable<object?[]> Substrings_comparisontype_data { get {
            foreach (var (pair, range) in RangeTestStrings)
                foreach (var comparisonType in TestComparisons)
                    yield return new object?[] {
                    pair.StrA, range.IndexA,
                    pair.StrB, range.IndexB, range.Length, comparisonType };
        } }

    [DataTestMethod]
    [DynamicData(nameof(Substrings_ignorecase_data), DynamicDataSourceType.Property)]
    public void String_Compare_substrings_ignorecase_returns_same_results(
            string? strA, int indexA, string? strB, int indexB, int length, bool ignoreCase) =>
        Assert.AreEqual(
            string.Compare(strA, indexA, strB, indexB, length, ignoreCase),
            strA.Compare(indexA, strB, indexB, length, ignoreCase));
    private static IEnumerable<object?[]> Substrings_ignorecase_data { get {
            foreach (var (pair, range) in RangeTestStrings) {
                yield return new object?[] {
                pair.StrA, range.IndexA, pair.StrB, range.IndexB, range.Length, false };
                yield return new object?[] {
                pair.StrA, range.IndexA, pair.StrB, range.IndexB, range.Length, true  };
            }
        } }

    [DataTestMethod]
    [DynamicData(nameof(Substrings_data), DynamicDataSourceType.Property)]
    public void String_Compare_substrings_returns_same_results(
            string? strA, int indexA, string? strB, int indexB, int length) =>
        Assert.AreEqual(
            string.Compare(strA, indexA, strB, indexB, length),
            strA.Compare(indexA, strB, indexB, length));
    private static IEnumerable<object?[]> Substrings_data { get {
            foreach (var (pair, range) in RangeTestStrings)
                yield return new object?[] {
                pair.StrA, range.IndexA, pair.StrB, range.IndexB, range.Length };
        } }

    [DataTestMethod]
    [DynamicData(nameof(Strings_ignorecase_culture_data), DynamicDataSourceType.Property)]
    public void String_Compare_strings_ignorecase_culture_returns_same_results(
            string? strA, string? strB, bool ignoreCase, CultureInfo culture) =>
        Assert.AreEqual(
            string.Compare(strA, strB, ignoreCase, culture),
            strA.Compare(strB, ignoreCase, culture));
    private static IEnumerable<object?[]> Strings_ignorecase_culture_data { get {
            foreach (var pair in TestStrings)
                foreach (var culture in TestCultures) {
                    yield return new object?[] { pair.StrA, pair.StrB, false, culture };
                    yield return new object?[] { pair.StrA, pair.StrB, true, culture };
                }
        } }

    [DataTestMethod]
    [DynamicData(nameof(Strings_data), DynamicDataSourceType.Method)]
    public void String_Compare_strings_returns_same_results(string? strA, string? strB) =>
        Assert.AreEqual(string.Compare(strA, strB), strA.Compare(strB));
    private static IEnumerable<object?[]> Strings_data() {
        foreach (var pair in TestStrings)
            yield return new object?[] { pair.StrA, pair.StrB };
    }

    [DataTestMethod]
    [DynamicData(nameof(Strings_comparisontype_data), DynamicDataSourceType.Method)]
    public void String_Compare_strings_comparisontype_returns_same_results(
            string? strA, string? strB, StringComparison comparisonType) =>
        Assert.AreEqual(
            string.Compare(strA, strB, comparisonType),
            strA.Compare(strB, comparisonType));
    private static IEnumerable<object?[]> Strings_comparisontype_data() {
        foreach (var pair in TestStrings)
            foreach (var comparisonType in TestComparisons)
                yield return new object?[] { pair.StrA, pair.StrB, comparisonType };
    }

    [DataTestMethod]
    [DynamicData(nameof(Strings_ignorecase_data), DynamicDataSourceType.Method)]
    public void String_Compare_strings_ignorecase_returns_same_results(
            string? strA, string? strB, bool ignoreCase) =>
        Assert.AreEqual(
            string.Compare(strA, strB, ignoreCase),
            strA.Compare(strB, ignoreCase));
    private static IEnumerable<object?[]> Strings_ignorecase_data() {
        foreach (var pair in TestStrings) {
            yield return new object?[] { pair.StrA, pair.StrB, false };
            yield return new object?[] { pair.StrA, pair.StrB, true };
        }
    }

    [DataTestMethod]
    [DynamicData(nameof(Strings_culture_compareoptions_data), DynamicDataSourceType.Method)]
    public void String_Compare_strings_culture_options_returns_same_results(
            string? strA, string? strB, CultureInfo culture, CompareOptions options) =>
        Assert.AreEqual(
            string.Compare(strA, strB, CultureInfo.CurrentCulture, options),
            strA.Compare(strB, CultureInfo.CurrentCulture, options));
    private static IEnumerable<object?[]> Strings_culture_compareoptions_data() {
        foreach (var pair in TestStrings)
            foreach (var culture in TestCultures)
                foreach (var comparisonType in TestComparisons)
                    yield return new object?[] {
                        pair.StrA, pair.StrB, culture, comparisonType };
    }

    #endregion
    #region String_CompareOrdinal()

    // Note: String.CompareOrdinal() tests uses String.Compare() data

    [DataTestMethod]
    [DynamicData(nameof(Strings_data), DynamicDataSourceType.Method)]
    public void String_CompareOrdinal_strings_returns_same_results(string? strA, string? strB) =>
        Assert.AreEqual(string.CompareOrdinal(strA, strB), strA.CompareOrdinal(strB));

    [DataTestMethod]
    [DynamicData(nameof(Substrings_data), DynamicDataSourceType.Property)]
    public void String_CompareOrdinal_substrings_returns_same_results(
            string? strA, int indexA, string? strB, int indexB, int length) =>
        Assert.AreEqual(
            string.CompareOrdinal(strA, indexA, strB, indexB, length),
            strA.CompareOrdinal(indexA, strB, indexB, length));

    #endregion
    #region String.Concat()

    private static IEnumerable<object?[]> String_Concat_string_data => new[] {
        new string?[] {
          "a",  "b",  "c",  "d",  "e",  "f" },
        [ "a",  "b",  "c",  "d",  "e"  ],
        [ "a",  "b",  "c",  "d",  null ],
        [ "a",  "b",  "c",  null, null ],
        [ "a",  "b",  null, null, null ],
        [ "a",  null, null, null, null ],
        [ null, null, null, null, null ],
        [ null, null, "c",  null, null ],
        [ "a",  null, "c",  null       ]
    };

    [DataTestMethod]
    [DynamicData(nameof(String_Concat_string_data), DynamicDataSourceType.Property)]
    public void String_Concat_spans_returns_same_value(params string?[] strs) {
        Assert.AreEqual(
            string.Concat(strs[0].AsSpan(), strs[1].AsSpan()),
            strs[0].AsSpan().Concat(strs[1].AsSpan()));
        Assert.AreEqual(
            string.Concat(strs[0].AsSpan(), strs[1].AsSpan(), strs[2]),
            strs[0].AsSpan().Concat(strs[1].AsSpan(), strs[2].AsSpan()));
        Assert.AreEqual(
            string.Concat(strs[0].AsSpan(), strs[1].AsSpan(), strs[2].AsSpan(), strs[3].AsSpan()),
            strs[0].AsSpan().Concat(strs[1].AsSpan(), strs[2].AsSpan(), strs[3].AsSpan()));
    }

    [DataTestMethod]
    [DynamicData(nameof(String_Concat_string_data), DynamicDataSourceType.Property)]
    public void String_Concat_objects_returns_same_value(object?[] args) {
        Assert.AreEqual(string.Concat(args[0]), args[0].Concat());
        Assert.AreEqual(string.Concat(args[0], args[1]), args[0].Concat(args[1]));
        Assert.AreEqual(
            string.Concat(args[0], args[1], args[2]),
            args[0].Concat(args[1], args[2]));
        Assert.AreEqual(string.Concat(args), args.Concat());
    }

    [DataTestMethod]
    [DynamicData(nameof(String_Concat_string_data), DynamicDataSourceType.Property)]
    public void String_Concat_strings_returns_same_value(params string?[] strs) {
        Assert.AreEqual(string.Concat(strs[0], strs[1]), strs[0].Concat(strs[1]));
        Assert.AreEqual(
            string.Concat(strs[0], strs[1], strs[2]),
            strs[0].Concat(strs[1], strs[2]));
        Assert.AreEqual(
            string.Concat(strs[0], strs[1], strs[2], strs[3]),
            strs[0].Concat(strs[1], strs[2], strs[3]));
        Assert.AreEqual(string.Concat(strs), strs.Concat());
    }

    [DataTestMethod]
    [DataRow(0, 1, 2, 3, 4)]
    [DataRow(0, 1, 2, 3)]
    [DataRow(0, 1, 2)]
    [DataRow(0, 1)]
    [DataRow(0)]
    [DataRow()]
    public void String_Concat_T_int_returns_same_value(params int[] ints) =>
        Assert.AreEqual(string.Concat(ints), ints.Concat());

    #endregion
    #region String.Format()

    private static IEnumerable<object?[]> Format_test_data { get; } = new[] { new object?[]
        { "{0:s}",                       "a"                   },
        [ "{0:s} {1:d}",                 "a", 1                ],
        [ "{0:s} {1:d} {2}",             "a", 1, true          ],
        [ "{0:s} {1:d} {2} {3:g}",       "a", 1, true, -0.1    ],
        [ "{0:s} {1:d} {2} {3:g} {4:d}", "a", 1, true, -0.1, 0 ]
    };

    private static IEnumerable<object?[]> Format_test_culture_data =>
        Format_test_data.SelectMany(data0 => TestCultures.Select(culture => {
            var o = new List<object?>() { culture };
            o.AddRange(data0);
            return o.ToArray();
        }));

    [DataTestMethod]
    [DynamicData(nameof(Format_test_culture_data), DynamicDataSourceType.Property)]
    public void String_Format_culture_objects_returns_same_value(
            CultureInfo culture, string format, params object?[] args) {
        switch (args.Length) {
            case 1:
                Assert.AreEqual(string.Format(culture, format, args[0]),
                                format.Format(culture, args[0]));
                break;
            case 2:
            Assert.AreEqual(string.Format(culture, format, args[0], args[1]),
                            format.Format(culture, args[0], args[1]));
                break;
            case 3:
                Assert.AreEqual(string.Format(culture, format, args[0], args[1], args[2]),
                                format.Format(culture, args[0], args[1], args[2]));
                break;
            default:
                Assert.AreEqual(string.Format(culture, format, args), format.Format(culture, args));
                break;
        }
    }

    [DataTestMethod]
    [DynamicData(nameof(Format_test_data), DynamicDataSourceType.Property)]
    public void String_Format_objects_returns_same_value(string format, params object?[] args) {
        switch (args.Length) {
            case 1:
                Assert.AreEqual(string.Format(format, args[0]), format.Format(args[0]));
                break;
            case 2:
                Assert.AreEqual(string.Format(format, args[0], args[1]),
                                format.Format(args[0], args[1]));
                break;
            case 3:
                Assert.AreEqual(string.Format(format, args[0], args[1], args[2]),
                                format.Format(args[0], args[1], args[2]));
                break;
            default:
                Assert.AreEqual(string.Format(format, args), format.Format(args));
                break;
        }
    }

    [DataTestMethod]
    [DynamicData(nameof(Format_test_culture_data), DynamicDataSourceType.Property)]
    public void String_Format_compositeformat_objects_returns_same_value(
            CultureInfo culture, string format, params object?[] args) {
        var compositeFormat = CompositeFormat.Parse(format);
        switch (args.Length) {
            case 1:
                Assert.AreEqual(string.Format(culture, format, args[0]),
                                compositeFormat.Format(culture, args[0]));
                break;
            case 2:
                Assert.AreEqual(string.Format(culture, format, args[0], args[1]),
                                compositeFormat.Format(culture, args[0], args[1]));
                break;
            case 3:
                Assert.AreEqual(string.Format(culture, format, args[0], args[1], args[2]),
                                compositeFormat.Format(culture, args[0], args[1], args[2]));
                break;
            default:
                Assert.AreEqual(string.Format(culture, format, args),
                                compositeFormat.Format(culture, args));
                Assert.AreEqual(string.Format(culture, format, args),
                                compositeFormat.Format(culture, args.AsSpan()));
                break;
        }
    }

    #endregion
    #region String.IsNullOrEmpty() & String.IsNullOrWhiteSpace()

    public static IEnumerable<object?> IsNullOrXxxxxTestStrings => new[] {
        new string?[] { "" }, [null], [" "], ["  "],
        ["X"], ["XX"], [" X"], [" XX"],
        ["X "], ["XX "], [" X "], [" XX "], [" X X "],
    };

    [DataTestMethod]
    [DynamicData(nameof(IsNullOrXxxxxTestStrings), DynamicDataSourceType.Property)]
    public void IsNullOrEmpty_string__returns_same_value_as_dotNet_builtin(string value) {
        var expected = string.IsNullOrEmpty(value);
        var actual = value.IsNullOrEmpty();
        Assert.AreEqual(expected, actual);
    }

    [DataTestMethod]
    [DynamicData(nameof(IsNullOrXxxxxTestStrings), DynamicDataSourceType.Property)]
    public void IsNullOrWhiteSpace_string__returns_same_value_as_dotNet_builtin(string value) {
        var expected = string.IsNullOrWhiteSpace(value);
        var actual = value.IsNullOrWhiteSpace();
        Assert.AreEqual(expected, actual);
    }

    #endregion
    #region String.Join...()

    [DataTestMethod]
    [DataRow('|', "1", 2, "3")]
    [DataRow('|', "1", 2)]
    [DataRow('|', "1")]
    [DataRow('|', "")]
    [DataRow('|')]
    [DataRow('|', "1", null, 2)]
    [DataRow('|', "1", null)]
    [DataRow('|', null)]
    public void Join_objects_produces_same_result_as_builtin_function(
            char charSeparator, params object?[] values) {
        var expected = string.Join(charSeparator, values);
        var strSeparator = charSeparator.ToString();
        Assert.AreEqual(expected, values.Join(charSeparator));
        Assert.AreEqual(expected, charSeparator.Join(values));
        Assert.AreEqual(expected, values.Join(strSeparator));
        Assert.AreEqual(expected, strSeparator.Join(values));
    }

    [DataTestMethod]
    [DataRow('|', "1", "2", "3")]
    [DataRow('|', "1", "2")]
    [DataRow('|', "1")]
    [DataRow('|', "")]
    [DataRow('|')]
    [DataRow('|', "1", null, "2")]
    [DataRow('|', "1", null)]
    [DataRow('|', null)]
    public void Join_strings_produces_same_result_as_builtin_function(
            char charSeparator, params string?[] strings) {
        var expected = string.Join(charSeparator, strings);
        var strSeparator = charSeparator.ToString();
        Assert.AreEqual(expected, strings.Join(charSeparator));
        Assert.AreEqual(expected, charSeparator.Join(strings));
        Assert.AreEqual(expected, strings.Join(strSeparator));
        Assert.AreEqual(expected, strSeparator.Join(strings));
        Assert.AreEqual(expected, strings.AsEnumerable().Join(charSeparator));
        Assert.AreEqual(expected, charSeparator.Join(strings.AsEnumerable()));
        Assert.AreEqual(expected, strings.AsEnumerable().Join(strSeparator));
        Assert.AreEqual(expected, strSeparator.Join(strings.AsEnumerable()));
    }

    [DataTestMethod]
    [DataRow('|', 1, 2, 3)]
    [DataRow('|', 1, 2)]
    [DataRow('|', 1)]
    [DataRow('|')]
    public void Join_ints_produces_same_result_as_builtin_function(
            char charSeparator, params int[] ints) {
        var expected = string.Join(charSeparator, ints);
        var strSeparator = charSeparator.ToString();
        Assert.AreEqual(expected, ints.Join(charSeparator));
        Assert.AreEqual(expected, charSeparator.Join(ints));
        Assert.AreEqual(expected, ints.Join(strSeparator));
        Assert.AreEqual(expected, strSeparator.Join(ints));
        Assert.AreEqual(expected, ints.AsEnumerable().Join(charSeparator));
        Assert.AreEqual(expected, charSeparator.Join(ints.AsEnumerable()));
        Assert.AreEqual(expected, ints.AsEnumerable().Join(strSeparator));
        Assert.AreEqual(expected, strSeparator.Join(ints.AsEnumerable()));
    }


    [DataTestMethod]
    [DataRow('|', 0, 3, "1", "2", "3")]
    [DataRow('|', 0, 2, "1", "2", "3")]
    [DataRow('|', 1, 2, "1", "2", "3")]
    [DataRow('|', 1, 1, "1", "2", "3")]
    [DataRow('|', 2, 1, "1", "2", "3")]
    [DataRow('|', 2, 0, "1", "2", "3")]
    public void Join_strings_index_count_produces_same_result_as_builtin_function(
            char charSeparator, int startIndex, int count, params string?[] strings) {
        var expected = string.Join(charSeparator, strings, startIndex, count);
        var strSeparator = charSeparator.ToString();
        Assert.AreEqual(expected, strings.Join(charSeparator, startIndex, count));
        Assert.AreEqual(expected, charSeparator.Join(strings, startIndex, count));
        Assert.AreEqual(expected, strings.Join(strSeparator, startIndex, count));
        Assert.AreEqual(expected, strSeparator.Join(strings, startIndex, count));
    }

    #endregion
}

[ExcludeFromCodeCoverage]
internal static class StringCompareExtensions {

    public static bool IsLongEnough(this string? s, int index, int length) =>
        s is not null && s.Length >= index + length;

    // public static bool IsLongEnough(
    //         this TestStringPair pair, int indexA, int indexB, int length) =>
    //     pair.StrA.IsLongEnough(indexA, length) && pair.StrB.IsLongEnough(indexB, length);

    public static bool IsLongEnough(this TestStringPair pair, TestRange range) =>
        pair.StrA.IsLongEnough(range.IndexA, range.Length) &&
        pair.StrB.IsLongEnough(range.IndexB, range.Length);
}
