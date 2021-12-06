using advent.IO;
using advent.Models._2021;

namespace advent.Days._2021
{
    public class Day05 : Day
    {
        private readonly IConsole _console;

        public Day05() { }

        public Day05(IConsole console)
        {
            _console = console;
        }

        public override string Part1(string input)
        {
            var ventField = new ThermalVentField(input);

            _console?.WriteLine(ventField.ToString());

            return ventField.GetMostDangerousPoints().ToString();
        }

        public override string Part2(string input)
        {
            var ventField = new ThermalVentField(input, true);

            _console?.WriteLine(ventField.ToString());

            return ventField.GetMostDangerousPoints().ToString();
        }
    }
}
