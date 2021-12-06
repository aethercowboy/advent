using advent.Extensions;
using System.Collections.Generic;
using System.Linq;

namespace advent.Models._2021
{
    internal class LanternfishSchool
    {
        private readonly IDictionary<long, long> _population;

        public LanternfishSchool(string input)
        {
            _population = GetNewDict();

            foreach (var fish in input.Split(',').ToInts())
            {
                _population[fish]++;
            }
        }

        public long PopulateForDays(int days)
        {
            for (var i = 0; i < days; i++)
            {
                var nextG = GetNewDict();

                for (var j = 0; j <= 8; j++)
                {
                    if (j == 0)
                    {
                        nextG[6] += _population[j];
                        nextG[8] += _population[j];
                    }
                    else
                    {
                        nextG[j - 1] += _population[j];
                    }
                }

                foreach (var g in nextG)
                {
                    _population[g.Key] = g.Value;
                }
            }

            return _population.Sum(x => x.Value);
        }

        private static IDictionary<long, long> GetNewDict()
        {
            return new Dictionary<long, long>()
            {
                {0, 0},
                {1, 0},
                {2, 0},
                {3, 0},
                {4, 0},
                {5, 0},
                {6, 0},
                {7, 0},
                {8, 0}
            };
        }
    }
}
