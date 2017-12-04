using System;
using System.Linq;
using advent2017.Extensions;

namespace advent2017.Days
{
    public class Day04 : IDay
    {
        private static int Part0(string input, Func<string, bool> countFunc)
        {
            return input.Lines()
                .Count(countFunc);
        }

        private static Func<string, bool> WordFunc(Func<string, string> selectFunc)
        {
            return line => line.Words()
                .Select(selectFunc)
                .GroupBy(x => x)
                .All(x => x.Count() == 1);
        }

        public int Part1(string input)
        {
            return Part0(input, WordFunc(x => x));
        }

        public int Part2(string input)
        {
            return Part0(input, WordFunc(x => new string(x.OrderBy(y => y).ToArray())));
        }
    }
}
