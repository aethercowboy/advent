using advent.Models._2021;

namespace advent.Days._2021
{
    public class Day03 : Day
    {
        public override string Part1(string input)
        {
            var diagnostic = new SubmarineDiagnostic(input);

            return diagnostic.GetPowerConsumption().ToString();
        }

        public override string Part2(string input)
        {
            var diagnostic = new SubmarineDiagnostic(input);

            return diagnostic.GetLifeSupportRating().ToString();
        }
    }
}
