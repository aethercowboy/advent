﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using advent2017.Extensions;

namespace advent2017.Days
{
    public class Day03 : IDay
    {
        private static Tuple<int, int> GetPosition(int n)
        {
            var str = BuildString(n);

            var pos = new Tuple<int, int>(0, 0);

            return str.Aggregate(pos, GetNextPos);
        }

        private static string BuildString(int n)
        {
            var str = "";
            const string input = "RULD";
            var size = 1;
            var run = 1;
            var next = 0;

            for (var i = 1; i < n; i++)
            {
                var c = input[next];
                str += c;

                run--;

                if (run != 0) continue;

                if (c == 'U' || c == 'D')
                {
                    size += 1;
                }

                next = (next + 1) % input.Length;
                run = size;
            }

            return str;
        }

        private static Tuple<int, int> GetNextPos(Tuple<int, int> pos, char c)
        {
            switch (c)
            {
                case 'R':
                    pos = pos.MoveRight();
                    break;
                case 'U':
                    pos = pos.MoveUp();
                    break;
                case 'L':
                    pos = pos.MoveLeft();
                    break;
                case 'D':
                    pos = pos.MoveDown();
                    break;
            }

            return pos;
        }

        private static int GetLowestGt(int num)
        {
            IDictionary<Tuple<int,int>, int> dict = new Dictionary<Tuple<int, int>, int>();

            var str = BuildString(Math.Max(num, 6));

            var pos = new Tuple<int, int>(0, 0);

            dict.Add(pos, 1);

            foreach (var c in str)
            {
                pos = GetNextPos(pos, c);

                var keys = new []
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
                dict.Add(pos,val);

                if (val > num)
                {
                    return val;
                }
            }

            return 0;
        }

        public int Part1(string input)
        {
            var num = input.ToInt();

            var pos = GetPosition(num);

            return Math.Abs(pos.Item1) + Math.Abs(pos.Item2);
        }

        public int Part2(string input)
        {
            var num = input.ToInt();

            return GetLowestGt(num);
        }
    }
}
