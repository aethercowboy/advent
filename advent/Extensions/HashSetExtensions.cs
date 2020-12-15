using System.Collections.Generic;

namespace advent.Extensions
{
    public static class HashSetExtensions
    {
        public static void TryAdd<T>(this HashSet<T> hashSet, T item)
        {
            if (!hashSet.Contains(item))
            {
                hashSet.Add(item);
            }
        }
    }
}
