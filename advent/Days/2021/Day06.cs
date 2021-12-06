using advent.Models._2021;

namespace advent.Days._2021
{
    public class Day06 : Day
    {
        public override string Part1(string input)
        {
            var school = new LanternfishSchool(input);

            return school.PopulateForDays(80).ToString();
        }

        public override string Part2(string input)
        {
            var school = new LanternfishSchool(input);

            return school.PopulateForDays(256).ToString();
        }
    }
}
