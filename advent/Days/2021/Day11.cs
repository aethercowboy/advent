using advent.Models._2021;
using System;

namespace advent.Days._2021
{
    public class Day11 : Day
    {
        public override string Part1(string input)
        {
            var garden = new OctopusGarden(input);

            return garden.GetFlashes(100)
                .ToString();
        }

        public override string Part2(string input)
        {
            throw new NotImplementedException();
        }
    }
}
