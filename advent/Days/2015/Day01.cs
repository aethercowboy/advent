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

        public override string Part1(string input)
        {
            return input.Select(_toInt)
                .Sum()
                .ToString();
        }

        public override string Part2(string input)
        {
            var floor = 0;

            for (var i = 0; i < input.Length; i++)
            {
                var current = input[i];

                var increment = _toInt(current);

                floor += increment;

                if (floor < 0)
                {
                    return (i + 1).ToString();
                }
            }

            return 0.ToString();
        }
    }
}
