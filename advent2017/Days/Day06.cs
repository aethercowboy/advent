using System;
using System.Collections.Generic;
using System.Linq;
using advent2017.Extensions;

namespace advent2017.Days
{
    public class Day06 : Day
    {
        private static IList<int> IterateValues(IList<int> values)
        {
            var max = values.Max();
            var idx = values.IndexOf(max);
            values[idx] = 0;

            for (var i = 0; i < max; ++i)
            {
                var jdx = (idx + i + 1) % values.Count;
                values[jdx] += 1;
            }

            return values;
        }

        public int Part0(string input, Func<int,int,int> resultFunc)
        {
            var set = new Dictionary<string, int>();

            IList<int> values = input.Words().ToInts().ToList();

            var steps = 0;

            do
            {
                set.Add(values.AsString(), steps);
                values = IterateValues(values);
                steps++;
            } while (!set.ContainsKey(values.AsString()));

            var loopSize = set.Count - set[values.AsString()];

            return resultFunc(steps, loopSize);
        }

        public override int Part1(string input)
        {
            return Part0(input, (x, y) => x);
        }

        public override int Part2(string input)
        {
            return Part0(input, (x, y) => y);
        }
    }
}
