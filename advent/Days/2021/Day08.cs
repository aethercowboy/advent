using advent.Extensions;
using advent.Models._2021;
using System.Linq;

namespace advent.Days._2021
{
    public class Day08 : Day
    {
        public override string Part1(string input)
        {
            var lines = input.Lines();

            return lines.Select(x => SevenSegmentDisplay.CountUniques(x.Split(" | ")[1]))
                .Sum().ToString();
        }

        public override string Part2(string input)
        {
            var lines = input.Lines();

            var total = 0;

            foreach (var line in lines)
            {
                var io = line.Split(" | ");

                var display = new SevenSegmentDisplay(io[0]);

                total += display.GetDisplay(io[1]);
            }

            return total.ToString();
        }
    }
}
