using System;
using System.Collections.Generic;

namespace advent.Days._2015
{
    public class Day03 : Day
    {
        private static Tuple<int, int> Navigate(char c, Tuple<int, int> loc)
        {
            return c switch
            {
                '>' => new Tuple<int, int>(loc.Item1 + 1, loc.Item2),
                '<' => new Tuple<int, int>(loc.Item1 - 1, loc.Item2),
                '^' => new Tuple<int, int>(loc.Item1, loc.Item2 + 1),
                'v' => new Tuple<int, int>(loc.Item1, loc.Item2 - 1),
                _ => loc,
            };
        }

        private static void AddPresent(IDictionary<Tuple<int, int>, int> dict, Tuple<int, int> loc)
        {
            if (dict.ContainsKey(loc))
            {
                ++dict[loc];
            }
            else
            {
                dict.Add(loc, 1);
            }
        }

        private static string Part0(string input, params Tuple<int, int>[] santas)
        {
            var i = 0;

            var houses = new Dictionary<Tuple<int, int>, int>();

            foreach (var santa in santas)
            {
                AddPresent(houses, santa);
            }

            foreach (var c in input)
            {
                var santa = santas[i];

                santas[i] = santa = Navigate(c, santa);

                AddPresent(houses, santa);

                i = (i + 1) % santas.Length;
            }

            return houses.Count.ToString();
        }

        public override string Part1(string input)
        {
            var santa = new Tuple<int, int>(0, 0);

            return Part0(input, santa);
        }

        public override string Part2(string input)
        {
            var santa = new Tuple<int, int>(0, 0);
            var robo = new Tuple<int, int>(0, 0);

            return Part0(input, santa, robo);
        }
    }
}