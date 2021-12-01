using advent.Collections;
using advent.Extensions;
using System.Linq;

namespace advent.Days._2017
{
    public class Day17 : Day
    {
        private static Ring<int> Spinlock(string input, int iterations)
        {
            var steps = input.ToInt();
            var ring = new Ring<int> { 0 };

            var i = 0;

            foreach (var x in Enumerable.Range(1, iterations))
            {
                i += steps;
                i = ring.InsertAfter(i, x);
            }

            return ring;
        }

        public override string Part1(string input)
        {
            var ring = Spinlock(input, 2017);

            var i = ring.IndexOf(2017);

            return ring[i + 1].ToString();
        }

        public override string Part2(string input)
        {
            var steps = input.ToInt();

            var i = 0;

            var value = 0;

            for (var x = 1; x < 50_000_000; x++)
            {
                i = ((i + steps) % x) + 1;

                if (i == 1) value = x;
            }

            return value.ToString();
        }
    }
}
