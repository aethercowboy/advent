using advent.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace advent.Days._2017
{
    public class Day06 : Day
    {
        private static void IterateValues(IList<int> values)
        {
            var max = values.Max();
            var idx = values.IndexOf(max);
            values[idx] = 0;

            for (var i = 0; i < max; ++i)
            {
                var jdx = (idx + i + 1) % values.Count;
                values[jdx]++;
            }
        }

        public static int Part0(string input, Func<int, int, int> resultFunc)
        {
            var set = new Dictionary<string, int>();

            IList<int> values = input.Words().ToInts().ToList();

            var steps = 0;

            do
            {
                set.Add(values.AsString(), steps++);
                IterateValues(values);
            } while (!set.ContainsKey(values.AsString()));

            var loopSize = set.Count - set[values.AsString()];

            return resultFunc(steps, loopSize);
        }

        public override long Part1(string input)
        {
            return Part0(input, (x, _) => x);
        }

        public override long Part2(string input)
        {
            return Part0(input, (_, y) => y);
        }
    }
}
