using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace advent2017.Extensions
{
    public static class IEnumerableExtensions
    {
        public static T NthOrDefault<T>(this IEnumerable<T> list, int index)
        {
            return list.Skip(index).FirstOrDefault();
        }
    }
}
