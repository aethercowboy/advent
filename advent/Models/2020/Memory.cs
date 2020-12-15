using System.Collections.Generic;
using System.Linq;

namespace advent.Models._2020
{
    public class Memory
    {
        private readonly Dictionary<long, long> _memory;

        public Memory()
        {
            _memory = new Dictionary<long, long>();
        }

        public void Add(long index, long value)
        {
            _memory[index] = value;
        }

        public long Sum()
        {
            return _memory.Sum(x => x.Value);
        }
    }
}
