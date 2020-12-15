using System;

namespace advent.Days._2017
{
    public class Day01 : Day
    {
        public static int Part0(string input, Func<int, int, int> nextIdxFunc)
        {
            var output = 0;

            for (var i = 0; i < input.Length; ++i)
            {
                var current = input[i];

                var nextIdx = nextIdxFunc(i, input.Length);

                var next = input[nextIdx];

                if (current != next) continue;

                var currentInt = int.Parse(current.ToString());

                output += currentInt;
            }

            return output;
        }

        /// <summary>
        /// Reviews a sequence of digits and finds the sum of all digits that match the next digit in the list.
        /// The list is circular, so the digit after the last digit is the first digit in the list.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public override long Part1(string input)
        {
            return Part0(input, (i, l) => (i + 1) % l);
        }

        /// <summary>
        /// Now, instead of considering the next digit, it wants you to consider the digit halfway around the circular list.
        /// That is, if your list contains 10 items, only include a digit in your sum if the digit 10/2 = 5 steps forward matches it. Fortunately, your list has an even number of elements.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public override long Part2(string input)
        {
            return Part0(input, (i, l) => (i + (l / 2)) % l);
        }
    }
}
