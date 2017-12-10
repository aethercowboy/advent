using System.Collections.Generic;
using System.Linq;

namespace advent.Extensions
{
    public static class CharacterExtensions
    {
        public static int ToInt(this char c)
        {
            return (int) c;
        }

        public static IEnumerable<int> ToInt(this IEnumerable<char> list)
        {
            return list.Select(ToInt);
        }
    }
}
