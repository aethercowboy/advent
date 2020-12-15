using advent.Extensions;
using advent.Models._2015;
using System.Collections.Generic;
using System.Linq;

namespace advent.Days._2015
{
    public class Day16 : Day
    {
        public static string Pattern => @"
children: 3
cats: 7
samoyeds: 2
pomeranians: 3
akitas: 0
vizslas: 0
goldfish: 5
trees: 3
cars: 2
perfumes: 1
";

        private static IEnumerable<Aunt> Part0(string input)
        {
            var aunts = new List<Aunt>();

            var index = 1;

            foreach (var line in input.Lines())
            {
                var aunt = new Aunt
                {
                    Index = index++
                };

                aunts.Add(aunt);

                var words = line.Words().ToList();

                for (var i = 2; i < words.Count; i += 2)
                {
                    var key = words[i].Trim(':');
                    var val = words[i + 1].Trim(',').ToInt();

                    aunt.AddTrait(key, val);
                }
            }

            return aunts;
        }

        public override long Part1(string input)
        {
            var aunts = Part0(input);

            foreach (var pattern in Pattern.Lines())
            {
                var words = pattern.Split(':');
                var key = words[0];
                var val = words[1].ToInt();

                aunts = aunts.Where(x => x.GetTraitValue(key) == null || x.GetTraitValue(key) == val);
            }

            var sue = aunts.Single();

            return sue.Index;
        }

        public override long Part2(string input)
        {
            var aunts = Part0(input);

            foreach (var pattern in Pattern.Lines())
            {
                var words = pattern.Split(':');
                var key = words[0];
                var val = words[1].ToInt();

                switch (key)
                {
                    case "children":
                    case "samoyeds":
                    case "akitas":
                    case "vizslas":
                    case "cars":
                    case "perfumes":
                        aunts = aunts.Where(x => x.GetTraitValue(key) == null || x.GetTraitValue(key) == val);
                        break;
                    case "cats":
                    case "trees":
                        aunts = aunts.Where(x => x.GetTraitValue(key) == null || x.GetTraitValue(key) > val);
                        break;
                    case "pomeranians":
                    case "goldfish":
                        aunts = aunts.Where(x => x.GetTraitValue(key) == null || x.GetTraitValue(key) < val);
                        break;
                }
            }

            var sue = aunts.Single();

            return sue.Index;
        }
    }
}