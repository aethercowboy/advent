﻿using advent.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace advent.Days._2017
{
    public class Day03 : Day
    {
        private static Tuple<int, int> GetPosition(int n)
        {
            var str = BuildString(n);

            var pos = new Tuple<int, int>(0, 0);

            return str.Aggregate(pos, GetNextPos);
        }

        private static IEnumerable<char> BuildString(int n)
        {
            const string input = "RULD";
            var size = 1;
            var run = 1;
            var next = 0;

            for (var i = 1; i < n; i++)
            {
                var c = input[next];

                yield return c;

                run--;

                if (run != 0) continue;

                if (c == 'U' || c == 'D')
                {
                    size++;
                }

                next = (next + 1) % input.Length;
                run = size;
            }
        }

        private static Tuple<int, int> GetNextPos(Tuple<int, int> pos, char c)
        {
            return c switch
            {
                'R' => pos.MoveRight(),
                'U' => pos.MoveUp(),
                'L' => pos.MoveLeft(),
                'D' => pos.MoveDown(),
                _ => pos,
            };
        }

        private static int GetLowestGt(int num)
        {
            IDictionary<Tuple<int, int>, int> dict = new Dictionary<Tuple<int, int>, int>();

            var str = BuildString(Math.Max(num, 6));

            var pos = new Tuple<int, int>(0, 0);

            dict.Add(pos, 1);

            foreach (var c in str)
            {
                pos = GetNextPos(pos, c);

                var keys = new[]
                {
                    pos.MoveUp(),
                    pos.MoveUp().MoveRight(),
                    pos.MoveRight(),
                    pos.MoveDown().MoveRight(),
                    pos.MoveDown(),
                    pos.MoveDown().MoveLeft(),
                    pos.MoveLeft(),
                    pos.MoveUp().MoveLeft()
                };

                var val = dict.Where(x => keys.Contains(x.Key)).Sum(x => x.Value);
                dict.Add(pos, val);

                if (val > num)
                {
                    return val;
                }
            }

            return 0;
        }

        public override string Part1(string input)
        {
            var num = input.ToInt();

            var pos = GetPosition(num);

            return (Math.Abs(pos.Item1) + Math.Abs(pos.Item2)).ToString();
        }

        public override string Part2(string input)
        {
            var num = input.ToInt();

            return GetLowestGt(num).ToString();
        }
    }
}
