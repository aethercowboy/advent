using advent.Extensions;
using advent.Models._2020;
using System.Linq;

namespace advent.Days._2020
{
    public class Day10 : Day
    {
        public override int Part1(string input)
        {
            var jolts = input.Lines()
                .ToInts()
                .OrderBy(x => x)
                .ToList();

            var joltometer = new Joltometer();

            for (var i = -1; i < jolts.Count; ++i)
            {
                var j = i + 1;

                var a = i < 0
                    ? 0
                    : jolts[i];

                var b = j < jolts.Count
                    ? jolts[j]
                    : a + 3;

                var diff = b - a;

                joltometer.AddJolt(diff);
            }

            return joltometer.GetJoltage();
        }

        public override long Part2(string input)
        {
            var jolts = input.Lines()
                .ToInts()
                .OrderBy(x => x)
                .ToList();

            jolts.Insert(0, 0);
            jolts.Add(jolts[^1] + 3);

            var tally = new long[jolts.Count];

            for (var i = 0; i < jolts.Count; ++i)
            {
                if (i == 0)
                {
                    tally[i] = 1;
                }
                else
                {
                    tally[i] = 0;

                    for (var j = i - 1; j >= 0; --j)
                    {
                        if (jolts[i] - jolts[j] <= 3)
                        {
                            tally[i] += tally[j];
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }

            return tally[^1];
        }
    }
}