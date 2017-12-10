using System.Collections.Generic;
using System.Linq;

namespace advent.Extensions
{
    public static class ByteExtensions
    {
        public static int ToInt32(this byte b)
        {
            return b;
        }

        public static IEnumerable<int> ToInt32(this IEnumerable<byte> list)
        {
            return list.Select(ToInt32);
        }
    }
}
