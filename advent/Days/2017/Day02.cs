using advent.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace advent.Days._2017
{
    public class Day02 : Day
    {
        private static int ProcessLine(string input, Func<IList<int>, int> numberFunc)
        {
            return input.Lines().Sum(x => numberFunc(x.Words().ToInts().ToList()));
        }

        /// <summary>
        /// For each row, determine the difference between the largest value and the smallest value;
        /// the checksum is the sum of all of these differences.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public override long Part1(string input)
        {
            return ProcessLine(input, numbers =>
            {
                var max = numbers.Max();
                var min = numbers.Min();

                return max - min;
            });
        }

        /// <summary>
        /// It sounds like the goal is to find the only two numbers in each row where one evenly divides the other -
        /// that is, where the result of the division operation is a whole number. They would like you to find those
        /// numbers on each line, divide them, and add up each line's result.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public override long Part2(string input)
        {
            return ProcessLine(input, numbers =>
            {
                return numbers.SelectMany(_ => numbers, (x, y) => new { x, y })
                    .Where(t => t.x != t.y && t.x % t.y == 0)
                    .Select(t => t.x / t.y)
                    .FirstOrDefault();
            });
        }
    }
}