using System;
using System.Linq;
using advent2017.Extensions;

namespace advent2017.Days
{
    public class Day04 : IDay
    {
        private static int Part0(string input, Func<string, string> selectFunc)
        {
            return input.Lines()
                .Count(line => line.Words()
                    .Select(selectFunc)
                    .GroupBy(x => x)
                    .All(x => x.Count() == 1));
        }

        public int Part1(string input)
        {
            return Part0(input, x => x);
        }

        public int Part2(string input)
        {
            return Part0(input, x => new string(x.OrderBy(y => y).ToArray()));
        }
    }
}