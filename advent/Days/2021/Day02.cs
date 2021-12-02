using advent.Extensions;
using advent.Models._2021;

namespace advent.Days._2021
{
    public class Day02 : Day
    {
        public override string Part1(string input)
        {
            var submarine = new SubmarinePosition();

            foreach (var line in input.Lines())
            {
                var direction = new SubmarineDirection(line);
                submarine.Process(direction);
            }

            return submarine.GetHorizontalPositionAndDepth()
                .ToString();
        }

        public override string Part2(string input)
        {
            var submarine = new SubmarinePosition2();

            foreach (var line in input.Lines())
            {
                var direction = new SubmarineDirection(line);
                submarine.Process(direction);
            }

            return submarine.GetHorizontalPositionAndDepth()
                .ToString();
        }
    }
}
