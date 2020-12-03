using advent.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("advent.tests")]

namespace advent.Days._2020
{
    public class Day03 : Day
    {
        public override int Part1(string input)
        {
            var lines = input.Lines()
                .ToList();

            var slope = new Tuple<int, int>(3, 1);

            return TreesEncountered(lines, slope);
        }

        internal int TreesEncountered(List<string> lines, Tuple<int, int> slope)
        {
            var trees = 0;

            var x = 0;

            for (var i = slope.Item2; i < lines.Count; i += slope.Item2)
            {
                var line = lines[i];

                x = (x + slope.Item1) % line.Length;

                if (line[x] == '#')
                {
                    trees++;
                }
            }

            return trees;
        }

        public override long Part2(string input)
        {
            var lines = input.Lines()
                .ToList();

            var slopes = new List<Tuple<int, int>>
            {
                new Tuple<int,int>(1,1),
                new Tuple<int,int>(3,1),
                new Tuple<int,int>(5,1),
                new Tuple<int,int>(7,1),
                new Tuple<int,int>(1,2)
            };

            long product = 1;

            foreach (var slope in slopes)
            {
                var trees = TreesEncountered(lines, slope);

                product *= trees;
            }

            return product;
        }
    }
}
