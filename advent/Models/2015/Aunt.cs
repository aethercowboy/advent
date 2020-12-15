using advent.Extensions;
using System.Collections.Generic;

namespace advent.Models._2015
{
    internal class Aunt
    {
        private readonly IDictionary<string, int?> _dictionary = new Dictionary<string, int?>();

        public int Index { get; set; }

        public int? GetTraitValue(string key)
        {
            return _dictionary.GetValueOrDefault(key);
        }

        public void AddTrait(string key, int value)
        {
            _dictionary.TryAdd(key, value);
        }
    }
}
