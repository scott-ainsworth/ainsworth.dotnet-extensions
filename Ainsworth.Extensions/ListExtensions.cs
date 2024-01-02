namespace Ainsworth.Extensions;

public static partial class ListExtensions {

// These extension methods must expose generic lists
#pragma warning disable CA1002 // Do not expose generic lists

// `null` validation is redundant and a performance anti-pattern as the reference is
// `null` check by the framework anyway.
#pragma warning disable CA1062 // Validate arguments of public methods

    /// <inheritdoc cref="List{T}.Add"/>
    /// <returns><paramref name="list"/> with <paramref name="item"/> added.</returns>
    public static List<T> Add<T>(this List<T> list, T item) {
        list.Add(item);
        return list;
    }

    /// <inheritdoc cref="List{T}.AddRange"/>
    /// <returns><paramref name="list"/> with the items from <paramref name="collection"/>
    ///   added.</returns>
    public static List<T> AddRange<T>(this List<T> list, IEnumerable<T> collection) {
        list.AddRange(collection);
        return list;
    }

    /// <inheritdoc cref="List{T}.Clear"/>
    /// <returns><paramref name="list"/> cleared.</returns>
    public static List<T> Clear<T>(this List<T> list) {
        list.Clear();
        return list;
    }

    /// <inheritdoc cref="List{T}.Insert"/>
    /// <returns><paramref name="list"/> with <paramref name="item"/> add at
    ///   <paramref name="index"/>.</returns>
    public static List<T> Insert<T>(this List<T> list, int index, T item) {
        list.Insert(index, item);
        return list;
    }

    /// <inheritdoc cref="List{T}.InsertRange"/>
    /// <returns><paramref name="list"/> with the items from <paramref name="collection"/>
    ///   add at <paramref name="index"/>.</returns>
    public static List<T> InsertRange<T>(
        this List<T> list, int index, IEnumerable<T> collection) {
        list.InsertRange(index, collection);
        return list;
    }

    /// <inheritdoc cref="List{T}.RemoveAt"/>
    /// <returns><paramref name="list"/> with the item at <paramref name="index"/>
    ///   removed.</returns>
    public static List<T> RemoveAt<T>(this List<T> list, int index) {
        list.RemoveAt(index);
        return list;
    }

    /// <inheritdoc cref="List{T}.RemoveRange"/>
    /// <returns><paramref name="list"/> with <paramref name="count"/> items at
    ///   <paramref name="index"/> removed.
    public static List<T> RemoveRange<T>(this List<T> list, int index, int count) {
        list.RemoveRange(index, count);
        return list;
    }

    /// <inheritdoc cref="List{T}.Reverse"/>
    /// <returns><paramref name="list"/> with its items reversed.
    public static List<T> Reverse<T>(this List<T> list) {
        list.Reverse();
        return list;
    }

    /// <inheritdoc cref="List{T}.Sort(Comparison{T})"/>
    /// <returns><paramref name="list"/> with its items sorted.
    public static List<T> Sort<T>(this List<T> list, Comparison<T> comparison) {
        list.Sort(comparison);
        return list;
    }

    /// <inheritdoc cref="List{T}.Sort(int, int, IComparer{T}?)"/>
    /// <returns><paramref name="list"/> with <paramref name="count"/> items at
    ///   <paramref name="index"/> sorted.
    public static List<T> Sort<T>(
        this List<T> list, int index, int count, IComparer<T> comparer) {
        list.Sort(index, count, comparer);
        return list;
    }

    /// <inheritdoc cref="List{T}.Sort()"/>
    /// <returns><paramref name="list"/> with its items sorted.
    public static List<T> Sort<T>(this List<T> list) {
        list.Sort();
        return list;
    }

    /// <inheritdoc cref="List{T}.Sort(IComparer{T}?)"/>
    /// <returns><paramref name="list"/> with its items sorted.
    public static List<T> Sort<T>(this List<T> list, IComparer<T>? comparer) {
        list.Sort(comparer);
        return list;
    }

    /// <inheritdoc cref="List{T}.TrimExcess"/>
    /// <returns><paramref name="list"/> with its capacity set to the number of
    ///   items in the list.</returns>
    public static List<T> TrimExcess<T>(this List<T> list) {
        list.TrimExcess();
        return list;
    }

}
