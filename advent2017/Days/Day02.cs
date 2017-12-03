using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using advent2017.Extensions;

namespace advent2017.Days
{
    public class Day02 : IDay
    {
        private static int ProcessLine1(string input)
        {
            var numbers = input.Words().ToInts().ToList();

            var max = numbers.Max();
            var min = numbers.Min();

            return max - min;
        }

        private static int ProcessLine2(string input)
        {
            var numbers = input.Words().ToInts().ToList();

            return numbers.SelectMany(x => numbers, (x, y) => new {x, y})
                .Where(t => t.x != t.y)
                .Where(t => t.x % t.y == 0)
                .Select(t => t.x / t.y)
                .FirstOrDefault();
        }

        /// <summary>
        /// For each row, determine the difference between the largest value and the smallest value; 
        /// the checksum is the sum of all of these differences.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public int Part1(string input)
        {
            return input.Lines().Sum(ProcessLine1);
        }

        /// <summary>
        /// It sounds like the goal is to find the only two numbers in each row where one evenly divides the other - 
        /// that is, where the result of the division operation is a whole number. They would like you to find those 
        /// numbers on each line, divide them, and add up each line's result.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public int Part2(string input)
        {
            return input.Lines().Sum(ProcessLine2);
        }
    }
}
