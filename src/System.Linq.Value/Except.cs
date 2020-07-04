﻿using System.Collections.Generic;

namespace System.Linq.Value
{
    public static partial class EnumerableExtensions
    {
        public static WhereEnumerable<T> ValueExcept<T>(this IEnumerable<T> source, IEnumerable<T> second) =>
            source.ValueExcept(second, EqualityComparer<T>.Default);

        public static WhereEnumerable<T> ValueExcept<T>(this IEnumerable<T> source, IEnumerable<T> second, IEqualityComparer<T> comparer) =>
            source.ValueWhere(p => !second.Contains(p, comparer));
    }
}
