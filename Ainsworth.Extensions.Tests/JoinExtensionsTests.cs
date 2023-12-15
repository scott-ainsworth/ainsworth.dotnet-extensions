using Microsoft.VisualBasic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ainsworth.Extensions.Tests;

[TestClass]
public class JoinExtensionsTests
{

    [DataTestMethod]
    [DataRow('|', "1", 2, "3")]
    [DataRow('|', "1", 2)]
    [DataRow('|', "1")]
    [DataRow('|', "")]
    [DataRow('|')]
    public void Join_objects_char_produces_same_result_as_builtin_function(
            char separator, params object[] values) {
        var expected = string.Join(separator, values);
        var actual = values.AsEnumerable().Join(separator);
        Assert.AreEqual(expected, actual);
    }

    [DataTestMethod]
    [DataRow(", ", "1", 2, "3")]
    [DataRow("1, 2", ", ", "1", 2)]
    [DataRow("1", ", ", "1")]
    [DataRow("", ", ", "")]
    [DataRow("", ", ")]
    public void Join_objects_string_produces_same_result_as_builtin_function(
            string separator, params object[] values) {
        var expected = string.Join(separator, values);
        var actual = values.AsEnumerable().Join(separator);
        Assert.AreEqual(expected, actual);
    }

    [DataTestMethod]
    [DataRow('|', "1", "2", "3")]
    [DataRow('|', "1", "2")]
    [DataRow('|', "1")]
    [DataRow('|', "")]
    [DataRow('|')]
    public void Join_strings_char_produces_same_result_as_builtin_function(
            char separator, params string[] strings) {
        var expected = string.Join(separator, strings);
        var actual = strings.AsEnumerable().Join(separator);
        Assert.AreEqual(expected, actual);
    }

    [DataTestMethod]
    [DataRow(", ", "1", "2", "3")]
    [DataRow(", ", "1", "2")]
    [DataRow(", ", "1")]
    [DataRow(", ", "")]
    [DataRow(", ")]
    public void Join_strings_string_produces_same_result_as_builtin_function(
            string separator, params string[] strings) {
        var expected = string.Join(separator, strings);
        var actual = strings.AsEnumerable().Join(separator);
        Assert.AreEqual(expected, actual);
    }

    [DataTestMethod]
    [DataRow('|', 0, 3, "1", "2", "3")]
    [DataRow('|', 0, 2, "1", "2", "3")]
    [DataRow('|', 1, 2, "1", "2", "3")]
    [DataRow('|', 1, 1, "1", "2", "3")]
    [DataRow('|', 2, 1, "1", "2", "3")]
    [DataRow('|', 2, 0, "1", "2", "3")]
    public void Join_strings_char_index_count_produces_same_result_as_builtin_function(
            char separator, int startIndex, int count, params string[] strings) {
        var expected = string.Join(separator, strings, startIndex, count);
        var actual = strings.Join(separator, startIndex, count);
        Assert.AreEqual(expected, actual);
    }

    [DataTestMethod]
    [DataRow("|", 0, 3, "1", "2", "3")]
    [DataRow("|", 0, 2, "1", "2", "3")]
    [DataRow("|", 1, 2, "1", "2", "3")]
    [DataRow("|", 1, 1, "1", "2", "3")]
    [DataRow("|", 2, 1, "1", "2", "3")]
    [DataRow("|", 2, 0, "1", "2", "3")]
    public void Join_strings_string_index_count_produces_same_result_as_builtin_function(
            string separator, int startIndex, int count, params string[] strings) {
        var expected = string.Join(separator, strings, startIndex, count);
        var actual = strings.Join(separator, startIndex, count);
        Assert.AreEqual(expected, actual);
    }

    [DataTestMethod]
    [DataRow('|', 1, 2, 3)]
    [DataRow('|', 1, 2)]
    [DataRow('|', 1)]
    [DataRow('|')]
    public void Join_T_int_char_index_count_produces_same_result_as_builtin_function(
            char separator, params int[] values) {
        var expected = string.Join(separator, values);
        var actual = values.Join(separator);
        Assert.AreEqual(expected, actual);
    }

    [DataTestMethod]
    [DataRow('|', true, false, true)]
    [DataRow('|', true, false)]
    [DataRow('|', true)]
    [DataRow('|')]
    public void Join_T_bool_char_index_count_produces_same_result_as_builtin_function(
            char separator, params bool[] values) {
        var expected = string.Join(separator, values);
        var actual = values.Join(separator);
        Assert.AreEqual(expected, actual);
    }

    [DataTestMethod]
    [DataRow(", ", 1, 2, 3)]
    [DataRow(", ", 1, 2)]
    [DataRow(", ", 1)]
    [DataRow(", ")]
    public void Join_T_int_string_index_count_produces_same_result_as_builtin_function(
            string separator, params int[] values) {
        var expected = string.Join(separator, values);
        var actual = values.Join(separator);
        Assert.AreEqual(expected, actual);
    }

    [DataTestMethod]
    [DataRow(", ", true, false, true)]
    [DataRow(", ", true, false)]
    [DataRow(", ", true)]
    [DataRow(", ")]
    public void Join_T_bool_string_index_count_produces_same_result_as_builtin_function(
            string separator, params bool[] values) {
        var expected = string.Join(separator, values);
        var actual = values.Join(separator);
        Assert.AreEqual(expected, actual);
    }

}
