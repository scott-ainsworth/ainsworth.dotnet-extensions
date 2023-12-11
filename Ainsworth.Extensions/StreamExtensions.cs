namespace Ainsworth.Extensions;

/// <summary>
///   Extension methods to make using Streams simpler.
/// </summary>
public static class StreamExtensions {

    /// <summary>
    ///   An implementation of File.ReadLines() for Stream.
    /// </summary>
    /// <param name="stream"></param>
    /// <returns></returns>
    /// <remarks>
    ///   The motivation behind this extension method is reading lines from an embedded
    ///   file resource. The out-of-the box methods for accessing embedded files returns
    ///   a <see cref="Stream"/>, which has quite rudimentary capabilities. 
    /// </remarks>
    public static IEnumerable<string> ReadLines(this Stream stream) {
        using var reader = new StreamReader(stream);
        while (! reader.EndOfStream)
            yield return reader.ReadLine()!;
        yield break;
    }
}