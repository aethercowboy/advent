using System;
using System.Collections.Generic;
using System.Linq;

namespace advent.Days._2015
{
    public class Day02 : Day
    {
        private static void GetLWH(string input, out int l, out int w, out int h)
        {
            var lwh = input.Split('x');

            l = int.Parse(lwh[0]);
            w = int.Parse(lwh[1]);
            h = int.Parse(lwh[2]);
        }

        private static int Part0(string input, Func<int, int, int, int> sideFunc)
        {
            var output = 0;

            foreach (var line in input.Split('\n'))
            {
                GetLWH(line, out var l, out var w, out var h);

                output += sideFunc(l, w, h);
            }

            return output;
        }

        private static List<int> GetUnits(int l, int w, int h, Func<int, int, int> operatorFunc)
        {
            return new List<int>
            {
                operatorFunc(l, w),
                operatorFunc(w, h),
                operatorFunc(h, l)
            };
        }

        public override int Part1(string input)
        {
            return Part0(input, (l, w, h) =>
            {
                var units = GetUnits(l, w, h, (x, y) => x * y);

                return units.Select(x => 2 * x).Sum()
                       + units.Min();
            });
        }

        public override long Part2(string input)
        {
            return Part0(input, (l, w, h) =>
            {
                var units = GetUnits(l, w, h, (x, y) => x + y);

                return units.Min() * 2
                       + l * w * h;
            });
        }
    }
}