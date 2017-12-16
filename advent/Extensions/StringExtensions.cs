using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace advent.Extensions
{
    public static class StringExtensions
    {
        public static IEnumerable<string> Lines(this string str)
        {
            return str?.Split(
                       new[] {"\r\n", "\r", "\n", Environment.NewLine},
                       StringSplitOptions.None).Where(x => !x.IsNullOrWhitespace())
                   ?? Enumerable.Empty<string>();
        }

        public static bool IsNullOrEmpty(this string str)
        {
            return string.IsNullOrEmpty(str);
        }

        public static bool IsNullOrWhitespace(this string str)
        {
            return string.IsNullOrWhiteSpace(str);
        }

        public static IEnumerable<string> Words(this string str)
        {
            return str?.Split().Where(x => !x.IsNullOrWhitespace())
                   ?? Enumerable.Empty<string>()
                ;
        }

        public static int ToInt(this string str)
        {
            return int.TryParse(str, out var i) ? i : 0;
        }

        public static IEnumerable<int> ToInts(this IEnumerable<string> strs)
        {
            return strs?.Select(ToInt)
                   ?? Enumerable.Empty<int>()
                ;
        }

        public static IEnumerable<byte> ToBytes(this string str)
        {
            return Encoding.ASCII.GetBytes(str);
        }

        public static IEnumerable<string> Chunk(this string str, int length)
        {
            return Enumerable.Range(0, str.Length / length)
                .Select(i => str.Substring(i * length, length));
        }
    }
}
