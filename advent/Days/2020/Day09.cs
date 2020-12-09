using advent.Extensions;
using System.Collections.Generic;
using System.Linq;

namespace advent.Days._2020
{
    public class Day09 : Day
    {
        public int PreambleLength { get; set; } = 25;

        public override int Part1(string input)
        {
            var values = input.Lines()
                .ToInts()
                .ToList();

            for (var i = PreambleLength; i < values.Count; ++i)
            {
                var value = values[i];

                var range = values.GetRange(i - PreambleLength, PreambleLength);

                if (!IsValid(value, range))
                {
                    return value;
                }
            }

            return 0;
        }

        private static bool IsValid(int number, List<int> range)
        {
            return range.SelectMany(_ => range, (x, y) => new { x, y })
                .Where(x => x.x != x.y)
                .Select(x => x.x + x.y)
                .Any(x => x == number);
        }

        public override long Part2(string input)
        {
            var target = Part1(input);

            var values = input.Lines()
                .ToInts()
                .ToList();

            for (var i = 0; i < values.Count; ++i)
            {
                var value = values[i];

                if (value > target) continue;

                var sum = value;

                for (var j = i + 1; j < values.Count; ++j)
                {
                    var nextValue = values[j];

                    sum += nextValue;

                    if (sum > target) break;

                    if (sum == target)
                    {
                        var range = values.GetRange(i, j - i);

                        return range.Min() + range.Max();
                    }
                }
            }

            return 0;
        }
    }
}
