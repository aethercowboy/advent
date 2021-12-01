using advent.Extensions;
using advent.Models._2020;
using System.Linq;

namespace advent.Days._2020
{
    public class Day07 : Day
    {
        public override string Part1(string input)
        {
            var bags = new BagHandler();

            foreach (var line in input.Lines())
            {
                bags.AddBag(line);
            }

            return bags.BagContains("shiny gold").Count.ToString();
        }

        public override string Part2(string input)
        {
            var bags = new BagHandler();

            foreach (var line in input.Lines())
            {
                bags.AddBag(line);
            }

            return bags.BagInsides("shiny gold").Sum(x => x.Value).ToString();
        }
    }
}
