using System.Collections.Generic;
using System.Linq;

namespace advent.Models._2020
{
    public class TrainRule
    {
        public string Name { get; }

        private readonly IList<(int Min, int Max)> minMax;

        public TrainRule(string name)
        {
            Name = name;

            minMax = new List<(int, int)>();
        }

        public void Add(int min, int max)
        {
            minMax.Add((min, max));
        }

        public bool Check(int value)
        {
            return minMax.Any(x => x.Min <= value && x.Max >= value);
        }
    }
}
