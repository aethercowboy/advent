using advent.Extensions;
using System;
using System.Linq;

namespace advent.Days._2017
{
    public class Day04 : Day
    {
        private static string Part0(string input, Func<string, string> selectFunc)
        {
            return input.Lines()
                .Count(line => line.Words()
                    .Select(selectFunc)
                    .GroupBy(x => x)
                    .All(x => x.Count() == 1))
                .ToString();
        }

        public override string Part1(string input)
        {
            return Part0(input, x => x);
        }

        public override string Part2(string input)
        {
            return Part0(input, x => new string(x.OrderBy(y => y).ToArray()));
        }
    }
}