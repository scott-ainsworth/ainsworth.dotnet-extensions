namespace Ainsworth.Extensions.Tests;

/// <summary>
///   Unit tests for <see cref="Ainsworth.Extensions.StringExtensions"/> 
/// </summary>
[TestClass]
public class StringExtensionsTests 
{
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
}
