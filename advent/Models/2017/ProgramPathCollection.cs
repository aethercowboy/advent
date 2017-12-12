using System.Collections.Generic;
using advent.Extensions;

namespace advent.Models._2017
{
    internal class ProgramPathCollection<T>
    {
        private readonly IDictionary<T, HashSet<T>> _dict = new Dictionary<T, HashSet<T>>();

        private void AddKey(T key)
        {
            if (!_dict.ContainsKey(key))
            {
                _dict.Add(key, new HashSet<T>());
            }
        }

        public void AddPath(T key, IEnumerable<T> paths)
        {
            AddKey(key);

            foreach (var p in paths)
            {
                AddKey(p);
                _dict[key].TryAdd(p);
                _dict[p].TryAdd(key);
            }
        }

        public HashSet<T> GetValue(T key)
        {
            return _dict.TryGetValue(key, out var hash)
                ? hash
                : new HashSet<T>();
        }

        public IEnumerable<T> Paths => _dict.Keys;
    }
}