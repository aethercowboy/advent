using advent.Extensions;
using advent.Models._2020;
using System.Linq;

namespace advent.Days._2020
{
    public class Day15 : Day
    {
        public override long Part1(string input)
        {
            return PartX(input, 2020);
        }

        public override long Part2(string input)
        {
            return PartX(input, 30000000);
        }

        private long PartX(string input, int iterations)
        {
            var digits = input.Split(',').ToInts()
                .ToList();

            var data = new MemoryGame();

            var nextNumber = -1;

            for (var i = 0; i < iterations; i++)
            {
                if (i < digits.Count)
                {
                    nextNumber = data.Say(digits[i], i);
                }
                else
                {
                    nextNumber = data.Say(nextNumber, i);
                }
            }

            return data.LastNumber;
        }
    }
}
