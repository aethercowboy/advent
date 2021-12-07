using advent.Extensions;
using System;
using System.Linq;

namespace advent.Days._2021
{
    public class Day07 : Day
    {
        public override string Part1(string input)
        {
            var crabs = input.Split(',')
                .ToInts()
                .ToList();

            var min = crabs.Min();
            var max = crabs.Max();

            return Enumerable.Range(min, max - min)
                .Min(i => crabs.Select(x => Math.Abs(x - i)).Sum())
                .ToString();
        }

        public override string Part2(string input)
        {
            var crabs = input.Split(',')
                .ToInts()
                .ToList();

            var min = crabs.Min();
            var max = crabs.Max();

            return Enumerable.Range(min, max - min)
                .Min(i => crabs.Select(x => SumRange(i, x)).Sum())
                .ToString();
        }

        private static int SumRange(int a, int b)
        {
            return Math.Abs(a - b) * (Math.Abs(a - b) + 1) / 2;
        }
    }
}
