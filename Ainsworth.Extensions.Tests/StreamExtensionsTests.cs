using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Ainsworth.Extensions.Tests;

[TestClass]
[ExcludeFromCodeCoverage]
public class StreamExtensionsTests {

#pragma warning disable CA1861 // Avoid constant arrays as arguments

    [DataTestMethod]
    [DataRow("", new string[] { })]
    [DataRow("Line 1", new string[] { "Line 1" })]
    [DataRow("Line 1\n", new string[] { "Line 1" })]
    [DataRow("Line 1\nLine 2", new string[] { "Line 1", "Line 2" })]
    [DataRow("Line 1\nLine 2\n", new string[] { "Line 1", "Line 2" })]
    [DataRow("\n", new string[] { "" })]
    [DataRow("Line 1\n", new string[] { "Line 1" })]
    [DataRow("Line 1\n\n", new string[] { "Line 1", "" })]
    [DataRow("Line 1\nLine 2\n", new string[] { "Line 1", "Line 2" })]
    [DataRow("Line 1\nLine 2\n\n", new string[] { "Line 1", "Line 2", "" })]
    public void ReadLines_reads_each_line(string source, string[] expected) {
        using var reader = new MemoryStream(Encoding.UTF8.GetBytes(source));
        var actual = reader.ReadLines().ToArray();
        CollectionAssert.AreEqual(expected, actual);
    }

#pragma warning restore CA1861 // Avoid constant arrays as arguments

}
