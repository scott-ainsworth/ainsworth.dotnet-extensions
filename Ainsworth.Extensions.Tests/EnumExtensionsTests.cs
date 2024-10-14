namespace Ainsworth.Extensions.Tests;

[TestClass]
[ExcludeFromCodeCoverage]
public class EnumExtensionTests {

    #region Test Data

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

    [DataTestMethod]
    [DynamicData(nameof(DefinedValuesTestData), DynamicDataSourceType.Property)]
    public void EnumFormat_formats_correctely_for_defined_values(
            TestEnum value, string _, string format, string formatted) =>
        Assert.AreEqual(formatted, value.Format(format));

    [DataTestMethod]
    [DynamicData(nameof(UndefinedValuesTestData), DynamicDataSourceType.Property)]
    public void EnumFormat_formats_correctely_for_undefined_values(
            TestEnum value, string _, string format, string formatted) =>
        Assert.AreEqual(formatted, value.Format(format));

    #endregion
    #region value.GetName<TEnum>()

    [DataTestMethod]
    [DynamicData(nameof(DefinedValuesTestData), DynamicDataSourceType.Property)]
    public void EnumGetName_returns_correct_name_for_defined_values(
            TestEnum value, string name, string _0, string _1) =>
        Assert.AreEqual(name, value.GetName());

    [DataTestMethod]
    [DynamicData(nameof(UndefinedValuesTestData), DynamicDataSourceType.Property)]
    public void EnumGetName_returns_null_for_undefined_value(
            TestEnum value, string _0, string _1, string _2) =>
        Assert.IsNull(value.GetName());

    #endregion
    #region value.Parse<TEnum>()

    [DataTestMethod]
    [DynamicData(nameof(DefinedValuesTestData), DynamicDataSourceType.Property)]
    public void EnumParse_Value_returns_value_for_defined_names(
        TestEnum value, string name, string _0, string _1) =>
        Assert.AreEqual(value, name.Parse<TestEnum>());

    [DataTestMethod]
    [DynamicData(nameof(UndefinedNamesTestData), DynamicDataSourceType.Property)]
    [DynamicData(nameof(DefinedNamesIncorrectCaseTestData), DynamicDataSourceType.Property)]
    public void EnumParse_Value_throws_for_undefined_and_incorrectcase_name(
            TestEnum _, string name) =>
        Assert.ThrowsException<ArgumentException>(() => name.Parse<TestEnum>());

    #endregion
    #region value.Parse<TEnum>(ignoreCase)

    [DataTestMethod]
    [DynamicData(nameof(DefinedNamesIncorrectCaseTestData), DynamicDataSourceType.Property)]
    public void EnumParse_ValueIgnoreCaseTrue_returns_value_for_defined_names(
            TestEnum value, string name) =>
        Assert.AreEqual(value, name.Parse<TestEnum>(true));

    [DataTestMethod]
    [DynamicData(nameof(DefinedNamesIncorrectCaseTestData), DynamicDataSourceType.Property)]
    [DynamicData(nameof(UndefinedNamesTestData), DynamicDataSourceType.Property)]
    public void EnumParse_ValueIgnoreCaseFalse_throws_for_undefined_value(
            TestEnum _, string name) =>
        Assert.ThrowsException<ArgumentException>(() => name.Parse<TestEnum>(false));

    [DataTestMethod]
    [DynamicData(nameof(UndefinedNamesTestData), DynamicDataSourceType.Property)]
    public void EnumParse_ValueIgnoreCaseTrue(TestEnum _, string name) =>
        Assert.ThrowsException<ArgumentException>(() => name.Parse<TestEnum>(true));

    [TestMethod]
    public void EnumParse_throws_on_null() =>
        Assert.ThrowsException<ArgumentNullException>(() => ((string)null!).Parse<TestEnum>());

    #endregion
}
