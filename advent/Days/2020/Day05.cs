using advent.Extensions;
using advent.Models._2020;
using System.Linq;

namespace advent.Days._2020
{
    public class Day05 : Day
    {
        public override string Part1(string input)
        {
            return input.Lines()
                .Select(x => new BoardingPass(x))
                .Max(x => x.SeatId)
                .ToString()
                ;
        }

        public override string Part2(string input)
        {
            var passes = input.Lines()
                .Select(x => new BoardingPass(x))
                .ToList();

            var min = passes.Min(x => x.SeatId);
            var max = passes.Max(x => x.SeatId);
            var sum = passes.Sum(x => x.SeatId);

            var count = max - min + 1;

            var total = count * (max + min) / 2;

            return (total - sum).ToString();
        }
    }
}
