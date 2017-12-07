using System.Collections.Generic;
using System.Linq;
using advent.Extensions;

namespace advent.Days._2017
{
    public class Day07 : Day
    {
        private class Disc
        {
            public Disc Parent { private get; set; }
            public string Name { get; set; }
            public IDictionary<string, Disc> Children { get; set; }
            public int Weight { get; set; }

            public int TotalWeight
            {
                get { return Weight + Children.Values.Sum(x => x.TotalWeight); }
            }


            public int Depth => (Parent?.Depth).GetValueOrDefault() + 1;
        }


        private int Part0(string input)
        {
            var stack = new Dictionary<string, Disc>();

            foreach (var line in input.Lines())
            {
                var words = line.Words().ToList();

                var key = words[0];
                var weight = words[1].Replace("(", string.Empty).Replace(")", string.Empty).ToInt();

                stack.TryGetValue(key, out var disc);

                if (disc == null)
                {
                    disc = new Disc
                    {
                        Name = key,
                        Children = new Dictionary<string, Disc>()
                    };

                    stack.Add(key, disc);
                }

                disc.Weight = weight;

                if (words.Count <= 2) continue;

                var followers = words.Skip(3).Select(x => x.Replace(",", string.Empty));
                foreach (var follower in followers)
                {
                    stack.TryGetValue(follower, out var child);

                    if (child == null)
                    {
                        child = new Disc
                        {
                            Name = follower,
                            Children = new Dictionary<string, Disc>()
                        };

                        stack.Add(follower, child);
                    }

                    child.Parent = disc;
                    disc.Children.Add(child.Name, child);
                }
            }

            foreach (var key in stack.Keys)
            {
                if (stack.Values.Any(x => x.Children.Keys.Contains(key)))
                {
                    continue;
                }

                Console.WriteOutput(key);
            }

            var unbalanced = new List<Disc>();

            foreach (var val in stack.Values)
            {
                if (val.Children.Any(x => x.Value.TotalWeight != val.Children.FirstOrDefault().Value.TotalWeight))
                {
                    unbalanced.AddRange(val.Children.Values);
                }
            }

            var goal = unbalanced
                .GroupBy(x => x.Depth)
                .OrderByDescending(x => x.Key)
                .FirstOrDefault()?
                .GroupBy(x => x.TotalWeight)
                .OrderByDescending(x => x.Count())
                .FirstOrDefault()?
                .FirstOrDefault()?
                .TotalWeight;

            var offset = unbalanced.Where(x => x.TotalWeight != goal)
                .Select(x => x.Weight - x.TotalWeight + goal)
                .FirstOrDefault();

            return offset.GetValueOrDefault();
        }

        public override int Part1(string input)
        {  
            return Part0(input);
        }

        public override int Part2(string input)
        {
            return Part0(input);
        }
    }
}
