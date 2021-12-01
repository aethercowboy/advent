using advent.Extensions;
using System.Linq;

namespace advent.Days._2021
{
    public class Day01 : Day
    {
        public override string Part1(string input)
        {
            var lines = input.Lines().ToInts();

            var previous = int.MaxValue;

            var increases = 0;

            foreach (var line in lines)
            {
                if (line > previous)
                {
                    increases++;
                }

                previous = line;
            }

            return increases.ToString();
        }

        public override string Part2(string input)
        {
            var lines = input.Lines().ToInts().ToList();

            var previous = int.MaxValue;

            var increases = 0;

            for (var i = 0; i < lines.Count - 2; i++)
            {
                var a = lines[i];
                var b = lines[i + 1];
                var c = lines[i + 2];

                var d = a + b + c;

                if (d > previous)
                {
                    increases++;
                }

                previous = d;
            }

            return increases.ToString();
        }
    }
}
