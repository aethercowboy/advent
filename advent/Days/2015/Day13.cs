using System.Collections.Generic;
using System.Linq;
using advent.Extensions;

namespace advent.Days._2015
{
    public class Day13 : Day
    {
        private static void PopulateHappiness(IDictionary<string, Dictionary<string, int>> dict, string input, params string[] additionals)
        {
            foreach (var line in input.Lines())
            {
                var words = line.Words().ToList();
                var s = words[0];
                var o = words.Last().Replace(".", "");
                var v = words[3].ToInt();
                var m = words[2] == "lose"
                        ? -1
                        : 1
                    ;

                var key = s;

                if (!dict.ContainsKey(key))
                {
                    dict.Add(key, new Dictionary<string, int>());
                }

                dict[key].Add(o, m * v);
            }

            foreach (var a in additionals)
            {
                foreach (var k in dict.Keys.ToList())
                {
                    if (!dict.ContainsKey(a))
                    {
                        dict.Add(a, new Dictionary<string, int>());
                    }

                    dict[a].Add(k, 0);
                    dict[k].Add(a, 0);
                }
            }
        }

        private static int CalculateHappiness(IDictionary<string, Dictionary<string, int>> dict, IList<string> route)
        {
            var value = 0;

            for (var i = 0; i < route.Count; ++i)
            {
                var next = (i + 1) % route.Count;
                var prev = (route.Count + i - 1) % route.Count;

                var a = route[i];
                var b = route[next];
                var c = route[prev];

                value += dict[a][b] + dict[a][c];
            }

            return value;
        }

        private static int MaximizeHappiness(IDictionary<string, Dictionary<string, int>> dict)
        {
            var people = dict.Select(x => x.Key).ToList();
            var routes = people.GenerateRoutes();

            return routes.Select(route => CalculateHappiness(dict, route))
                .Max();
        }

        public override long Part1(string input)
        {
            var dict = new Dictionary<string, Dictionary<string, int>>();

            PopulateHappiness(dict, input);

            return MaximizeHappiness(dict);
        }

        public override long Part2(string input)
        {
            var dict = new Dictionary<string, Dictionary<string, int>>();

            PopulateHappiness(dict, input, "Me");

            return MaximizeHappiness(dict);
        }
    }
}
