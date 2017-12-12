using System.Collections.Generic;

namespace advent.Extensions
{
    public static class DictionaryExtensions
    {
        public static TVal GetValueOrDefault<TKey, TVal>(this IDictionary<TKey, TVal> dict, TKey key)
        {
            return dict.ContainsKey(key)
                ? dict[key]
                : default(TVal);
        }
    }
}