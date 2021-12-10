using advent.Models._2021;

namespace advent.Days._2021
{
    public class Day10 : Day
    {
        public override string Part1(string input)
        {
            var subsystem = new NavSubsystem(input);

            return subsystem.GetBadScore().ToString();
        }

        public override string Part2(string input)
        {
            var subsystem = new NavSubsystem(input);

            return subsystem.GetAutoCompleteScore().ToString();
        }
    }
}
