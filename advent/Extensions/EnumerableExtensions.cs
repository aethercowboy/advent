using System.Collections.Generic;
using System.Linq;

namespace advent.Extensions
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

        public static string AsString(this IEnumerable<int>list)
        {
            return string.Join(",", list);
        }
    }
}