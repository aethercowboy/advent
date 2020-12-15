using System;
using System.Collections.Generic;
using System.Linq;

namespace advent.Extensions
{
    public static class Int32Extensions
    {
        public static char ToChar(this int i)
        {
            return Convert.ToChar(i);
        }

        public static IEnumerable<char> ToChar(this IEnumerable<int> list)
        {
            return list.Select(ToChar);
        }

        public static string ToHex(this int i)
        {
            return i.ToString("X2").ToLower();
        }

        public static string ToHex(this IEnumerable<int> list)
        {
            return string.Concat(list.Select(ToHex));
        }
    }
}
