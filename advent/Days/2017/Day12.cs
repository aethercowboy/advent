﻿using advent.Extensions;
using advent.Models._2017;
using System.Collections.Generic;
using System.Linq;

namespace advent.Days._2017
{
    public class Day12 : Day
    {
        private static HashSet<int> GetGroupFor(ProgramPathCollection<int> paths, HashSet<int> seen, int key)
        {
            seen.Add(key);

            foreach (var i in paths.GetValue(key))
            {
                if (seen.Contains(i)) continue;

                foreach (var h in GetGroupFor(paths, seen, i))
                {
                    seen.TryAdd(h);
                }
            }

            return seen;
        }

        private static IList<HashSet<int>> GetGroups(ProgramPathCollection<int> paths)
        {
            var response = new List<HashSet<int>>();

            IList<int> left = new List<int>();
            var seen = new HashSet<int>();

            do
            {
                var hash = GetGroupFor(paths, new HashSet<int>(), left.FirstOrDefault());

                seen.UnionWith(hash);

                response.Add(hash);
                left = paths.Paths.Where(x => !seen.Contains(x)).ToList();
            } while (left.Count > 0);

            return response;
        }

        private static ProgramPathCollection<int> Part0(string input)
        {
            var paths = new ProgramPathCollection<int>();

            foreach (var line in input.Lines())
            {
                var words = line.Words().ToList();

                var key = words[0].ToInt();
                var cdr = words.Skip(2).Select(x => x.Trim(',')).ToInts();

                paths.AddPath(key, cdr);
            }

            return paths;
        }

        public override string Part1(string input)
        {
            var paths = Part0(input);

            var result = GetGroupFor(paths, new HashSet<int>(), 0);

            return result.Count.ToString();
        }

        public override string Part2(string input)
        {
            var paths = Part0(input);

            var result = GetGroups(paths);

            return result.Count.ToString();
        }
    }
}
