using System.Collections.Generic;
using System.Linq;

namespace advent2017.Extensions
{
    public static class EnumerableExtensions
    {
        public static T NthOrDefault<T>(this IEnumerable<T> list, int index)
        {
            return list == null
                    ? default(T)
                    : list.Skip(index).FirstOrDefault()
                ;
        }
    }
}