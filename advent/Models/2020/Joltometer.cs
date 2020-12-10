using System.Collections.Generic;

namespace advent.Models._2020
{
    public class Joltometer
    {
        private readonly IDictionary<int, int> jolts;

        public Joltometer()
        {
            jolts = new Dictionary<int, int>()
            {
                { 1, 0 },
                { 2, 0 },
                { 3, 0 }
            };
        }

        public void AddJolt(int j)
        {
            jolts[j]++;
        }

        public int GetJoltage()
        {
            return jolts[1] * jolts[3];
        }
    }
}
