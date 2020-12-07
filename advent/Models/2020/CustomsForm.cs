using System.Collections.Generic;
using System.Linq;

namespace advent.Models._2020
{
    public class CustomsForm
    {
        private Dictionary<int, int> hash;
        private int entries;

        public CustomsForm(IEnumerable<string> batch)
        {
            hash = new Dictionary<int, int>();
            entries = batch.Count();

            foreach (var line in batch)
            {
                foreach (var c in line)
                {
                    if (hash.ContainsKey(c))
                    {
                        hash[c]++;
                    }
                    else
                    {
                        hash.Add(c, 1);
                    }
                }
            }
        }

        public int GetValue()
        {
            return hash.Count;
        }

        public int GetValue2()
        {
            return hash.Count(x => x.Value == entries);
        }
    }
}
