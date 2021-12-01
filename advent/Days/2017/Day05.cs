using advent.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace advent.Days._2017
{
    public class Day05 : Day
    {
        private static IList<int> BuildList(string input)
        {
            return input.Lines().ToInts().ToList();
        }

        private static string NavigateList(string input, Func<int, int> valFunc)
        {
            var list = BuildList(input);

            var steps = 0;

            var i = 0;

            while (i < list.Count && i > -1)
            {
                ++steps;

                var current = list[i];
                var next = i + current;
                list[i] = valFunc(list[i]);
                i = next;
            }

            return steps.ToString();
        }

        public override string Part1(string input)
        {
            return NavigateList(input, x => x + 1);
        }

        public override string Part2(string input)
        {
            return NavigateList(input, x =>
                x >= 3
                    ? x - 1
                    : x + 1
            );
        }
    }
}
