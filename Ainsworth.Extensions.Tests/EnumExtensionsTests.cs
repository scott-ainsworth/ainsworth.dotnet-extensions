namespace Ainsworth.Extensions.Tests;

[TestClass]
[ExcludeFromCodeCoverage]
public class EnumExtensionTests {

    #region Test Data

    [SuppressMessage(
        "Naming", "CA1711:Identifiers should not have incorrect suffix",
        Justification = "'TestEnum' makes sense for these unit tests.")]
    public enum TestEnum { Zero = 0, One = 1, Two = 2 }

    public static IEnumerable<object[]> DefinedValuesTestData { get; } = [
        // value         name                   format, formatted
        [ TestEnum.Zero, nameof(TestEnum.Zero), "d",    "0"         ],
        [ TestEnum.One,  nameof(TestEnum.One),  "f",    "One"       ],
        [ TestEnum.Two,  nameof(TestEnum.Two),  "x",    "00000002"  ]
    ];

    public static IEnumerable<object[]> UndefinedValuesTestData { get; } = [
        // value         name  format, formatted
        [ (TestEnum)33, "33",  "d",    "33"         ],
        [ (TestEnum)33, "33",  "f",    "33"         ],
        [ (TestEnum)33, "33",  "x",    "00000021"   ],
    ];

    // These names represent TestEnum values, but are not cased properly.
    public static IEnumerable<object[]> DefinedNamesIncorrectCaseTestData { get; } = [
        [ TestEnum.Zero, "zero" ],
        [ TestEnum.One,  "oNe" ],
        [ TestEnum.Two,  "TWO" ]
    ];

    // These names do not represent TestEnum values.
    public static IEnumerable<object[]> UndefinedNamesTestData { get; } = [
        [ (TestEnum)(-1), "Three" ],
        [ (TestEnum)(-1), "Five" ]
    ];

    #endregion
    #region value.Format<TEnum>()

    [TestMethod]
    [DynamicData(nameof(DefinedValuesTestData))]
    public void EnumFormatFormatsCorrectlyForDefinedValues(
            TestEnum value, string _, string format, string formatted) =>
        Assert.AreEqual(formatted, value.Format(format));

    [TestMethod]
    [DynamicData(nameof(UndefinedValuesTestData))]
    public void EnumFormatFormatsCorrectlyForUndefinedValues(
            TestEnum value, string _, string format, string formatted) =>
        Assert.AreEqual(formatted, value.Format(format));

    #endregion
    #region value.GetName<TEnum>()

    [TestMethod]
    [DynamicData(nameof(DefinedValuesTestData))]
    public void EnumGetNameReturnsCorrectNameForDefinedValues(
            TestEnum value, string name, string _0, string _1) =>
        Assert.AreEqual(name, value.GetName());

    [TestMethod]
    [DynamicData(nameof(UndefinedValuesTestData))]
    public void EnumGetNameReturnsNullForUndefinedValue(
            TestEnum value, string _0, string _1, string _2) =>
        Assert.IsNull(value.GetName());

    #endregion
    #region value.Parse<TEnum>()

    [TestMethod]
    [DynamicData(nameof(DefinedValuesTestData))]
    public void ParseEnumReturnsValueForDefinedNames(
        TestEnum value, string name, string _0, string _1) =>
        Assert.AreEqual(value, name.Parse<TestEnum>());

    [TestMethod]
    [DynamicData(nameof(UndefinedNamesTestData))]
    [DynamicData(nameof(DefinedNamesIncorrectCaseTestData))]
    public void EnumParseThrowsForUndefinedAndIncorrectcaseName(
            TestEnum _, string name) =>
        Assert.Throws<ArgumentException>(() => name.Parse<TestEnum>());

    #endregion
    #region value.Parse<TEnum>(ignoreCase)

    [TestMethod]
    [DynamicData(nameof(DefinedNamesIncorrectCaseTestData))]
    public void EnumParseIgnoreCaseTrueReturnsValueForDefinedName(
            TestEnum value, string name) =>
        Assert.AreEqual(value, name.Parse<TestEnum>(true));

    [TestMethod]
    [DynamicData(nameof(DefinedNamesIncorrectCaseTestData))]
    [DynamicData(nameof(UndefinedNamesTestData))]
    public void EnumParseIgnoreCaseFalseThrowsForUndefinedName(
            TestEnum _, string name) =>
        Assert.Throws<ArgumentException>(() => name.Parse<TestEnum>(false));

    [TestMethod]
    [DynamicData(nameof(UndefinedNamesTestData))]
    public void EnumParseIgnoreCaseTrueThrowsForUndefinedUndefinedName(TestEnum _, string name) =>
        Assert.Throws<ArgumentException>(() => name.Parse<TestEnum>(true));

    [TestMethod]
    public void EnumParseThrowsOnNull() =>
        Assert.Throws<ArgumentNullException>(() => ((string)null!).Parse<TestEnum>());

    #endregion
}
