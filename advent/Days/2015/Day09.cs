using advent.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace advent.Days._2015
{
    public class Day09 : Day
    {
        private static int GetDist(IDictionary<Tuple<string, string>, int> dict, string from, string to)
        {
            var fromTo = new List<string>
            {
                from,
                to
            };

            fromTo.Sort();

            var key = new Tuple<string, string>(fromTo[0], fromTo[1]);

            return dict[key];
        }

        private static int CalculateRoute(IDictionary<Tuple<string, string>, int> dict, IList<string> route)
        {
            var response = 0;

            for (int i = 0, j = 1; j < route.Count; ++i, ++j)
            {
                var from = route[i];
                var to = route[j];

                var dist = GetDist(dict, from, to);
                response += dist;
            }

            return response;
        }

        private static string Part0(string input, Func<IEnumerable<int>, int> reduceFunc)
        {
            var dict = new Dictionary<Tuple<string, string>, int>();
            var locs = new HashSet<string>();

            foreach (var line in input.Lines())
            {
                var words = line.Words().ToList();
                var fromTo = new List<string> { words[0], words[2] };
                fromTo.Sort();
                var dist = words.Last().ToInt();

                var key = new Tuple<string, string>(fromTo[0], fromTo.Last());
                dict.Add(key, dist);
                locs.TryAdd(fromTo[0]);
                locs.TryAdd(fromTo[1]);
            }

            var routes = locs.ToList().GenerateRoutes();

            return reduceFunc(routes.Select(route => CalculateRoute(dict, route.ToList())))
                .ToString();
        }

        public override string Part1(string input)
        {
            return Part0(input, x => x.Min());
        }

        public override string Part2(string input)
        {
            return Part0(input, x => x.Max());
        }
    }
}