using advent.Extensions;
using advent.Models._2020;
using System.Linq;

namespace advent.Days._2020
{
    public class Day08 : Day
    {
        public override string Part1(string input)
        {
            var lines = input.Lines()
                .ToArray();

            var bootcode = new Bootcode(lines);

            bootcode.Execute();

            return bootcode.Accumulator.ToString();
        }

        public override string Part2(string input)
        {
            var lines = input.Lines()
                .ToArray();

            var bootcode = new BootcodeFixer(lines);

            return bootcode.Execute().ToString();
        }
    }
}
