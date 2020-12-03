using System;
using System.Linq;
using advent.Extensions;

namespace advent.Days._2017
{
    public class Day04 : Day
    {
        private static int Part0(string input, Func<string, string> selectFunc)
        {
            return input.Lines()
                .Count(line => line.Words()
                    .Select(selectFunc)
                    .GroupBy(x => x)
                    .All(x => x.Count() == 1));
        }

        public override int Part1(string input)
        {
            return Part0(input, x => x);
        }

        public override long Part2(string input)
        {
            return Part0(input, x => new string(x.OrderBy(y => y).ToArray()));
        }
    }
}