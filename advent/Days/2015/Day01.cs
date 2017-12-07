using System;
using System.Linq;

namespace advent.Days._2015
{
    public class Day01 : Day
    {
        private readonly Func<char, int> _toInt = x =>
                x == '('
                    ? 1
                    : x == ')'
                        ? -1
                        : 0
            ;

        public override int Part1(string input)
        {
            var output = input.Select(_toInt)
                .Sum();

            return output;
        }

        public override int Part2(string input)
        {
            var floor = 0;

            for (var i = 0; i < input.Length; i++)
            {
                var current = input[i];

                var increment = _toInt(current);

                floor += increment;

                if (floor < 0)
                {
                    return i + 1;
                }
            }

            return 0;
        }
    }
}
