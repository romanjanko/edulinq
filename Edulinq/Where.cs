using System;
using System.Collections.Generic;

namespace Edulinq
{
    public static partial class Enumerable
    {
        public static IEnumerable<TSource> Where<TSource>(
            this IEnumerable<TSource> source,
            Func<TSource, bool> predicate)
        {
            foreach(TSource item in source)
            {
                if (predicate(item))
                    yield return item;
            }
        }

        //public static IEnumerable<TSource> Where<TSource>(
        //    this IEnumerable<TSource> source,
        //    Func<TSource, int, bool> predicate)
        //{
        //    return null;
        //}
    }
}
