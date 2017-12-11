using System.Collections.Generic;
using System.Linq;
using advent.Extensions;

namespace advent.Days._2015
{
    public class Day16 : Day
    {
        private class AdventAunt
        {
            public int Index { get; set; }
            public int? Children { get; private set; }
            public int? Cats { get; private set; }
            public int? Samoyeds { get; private set; }
            public int? Pomeranians { get; private set; }
            public int? Akitas { get; private set; }
            public int? Vizslas { get; private set; }
            public int? Goldfish { get; private set; }
            public int? Trees { get; private set; }
            public int? Cars { get; private set; }
            public int? Perfumes { get; private set; }

            public void AddTrait(string key, int value)
            {
                switch (key)
                {
                    case "children":
                        Children = value;
                        break;
                    case "cats":
                        Cats = value;
                        break;
                    case "samoyeds":
                        Samoyeds = value;
                        break;
                    case "pomeranians":
                        Pomeranians = value;
                        break;
                    case "akitas":
                        Akitas = value;
                        break;
                    case "vizslas":
                        Vizslas = value;
                        break;
                    case "goldfish":
                        Goldfish = value;
                        break;
                    case "trees":
                        Trees = value;
                        break;
                    case "cars":
                        Cars = value;
                        break;
                    case "perfumes":
                        Perfumes = value;
                        break;
                }
            }
        }

        public string Pattern = @"
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

        private static IEnumerable<AdventAunt> Part0(string input)
        {
            var aunts = new List<AdventAunt>();

            var index = 1;

            foreach (var line in input.Lines())
            {
                var aunt = new AdventAunt
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

        public override int Part1(string input)
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
                        aunts = aunts.Where(x => x.Children == null || x.Children == val);
                        break;
                    case "cats":
                        aunts = aunts.Where(x => x.Cats == null || x.Cats == val);
                        break;
                    case "samoyeds":
                        aunts = aunts.Where(x => x.Samoyeds == null || x.Samoyeds == val);
                        break;
                    case "pomeranians":
                        aunts = aunts.Where(x => x.Pomeranians == null || x.Pomeranians == val);
                        break;
                    case "akitas":
                        aunts = aunts.Where(x => x.Akitas == null || x.Akitas == val);
                        break;
                    case "vizslas":
                        aunts = aunts.Where(x => x.Vizslas == null || x.Vizslas == val);
                        break;
                    case "goldfish":
                        aunts = aunts.Where(x => x.Goldfish == null || x.Goldfish == val);
                        break;
                    case "trees":
                        aunts = aunts.Where(x => x.Trees == null || x.Trees == val);
                        break;
                    case "cars":
                        aunts = aunts.Where(x => x.Cars == null || x.Cars == val);
                        break;
                    case "perfumes":
                        aunts = aunts.Where(x => x.Perfumes == null || x.Perfumes == val);
                        break;
                }
            }

            var sue = aunts.Single();

            return sue.Index;
        }

        public override int Part2(string input)
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
                        aunts = aunts.Where(x => x.Children == null || x.Children == val);
                        break;
                    case "cats":
                        aunts = aunts.Where(x => x.Cats == null || x.Cats > val);
                        break;
                    case "samoyeds":
                        aunts = aunts.Where(x => x.Samoyeds == null || x.Samoyeds == val);
                        break;
                    case "pomeranians":
                        aunts = aunts.Where(x => x.Pomeranians == null || x.Pomeranians < val);
                        break;
                    case "akitas":
                        aunts = aunts.Where(x => x.Akitas == null || x.Akitas == val);
                        break;
                    case "vizslas":
                        aunts = aunts.Where(x => x.Vizslas == null || x.Vizslas == val);
                        break;
                    case "goldfish":
                        aunts = aunts.Where(x => x.Goldfish == null || x.Goldfish < val);
                        break;
                    case "trees":
                        aunts = aunts.Where(x => x.Trees == null || x.Trees > val);
                        break;
                    case "cars":
                        aunts = aunts.Where(x => x.Cars == null || x.Cars == val);
                        break;
                    case "perfumes":
                        aunts = aunts.Where(x => x.Perfumes == null || x.Perfumes == val);
                        break;
                }
            }

            var sue = aunts.Single();

            return sue.Index;
        }
    }
}