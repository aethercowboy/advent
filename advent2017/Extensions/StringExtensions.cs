using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace advent2017.Extensions
{
    public static class StringExtensions
    {
        public static IEnumerable<string> Lines(this string str)
        {
            return str.Split('\n');
        }

        public static IEnumerable<string> Words(this string str)
        {
            return str.Split().Where(x => !string.IsNullOrWhiteSpace(x));
        }

        public static int ToInt(this string str)
        {
            return int.TryParse(str, out var i) ? i : 0;
        }

        public static IEnumerable<int> ToInts(this IEnumerable<string> strs)
        {
            return strs.Select(ToInt);
        }
    }
}
