using advent.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace advent.Days._2017
{
    public class Day08 : Day
    {
        private static bool Test(IDictionary<string, int> dict, IList<string> test)
        {
            var key = test[0];
            var operation = test[1];
            var comp = test[2].ToInt();

            if (!dict.ContainsKey(key))
            {
                dict.Add(key, 0);
            }

            var val = dict[key];

            return operation switch
            {
                ">" => val > comp,
                "<" => val < comp,
                ">=" => val >= comp,
                "<=" => val <= comp,
                "==" => val == comp,
                "!=" => val != comp,
                _ => false,
            };
        }

        private static string Part0(string input, Func<int, int, int> resultFunc)
        {
            var dict = new Dictionary<string, int>();

            int localMax = 0;

            foreach (var line in input.Lines())
            {
                var words = line.Words().ToList();
                var key = words[0];
                var operation = words[1];
                var amount = words[2].ToInt();

                if (!dict.ContainsKey(key))
                {
                    dict.Add(key, 0);
                }

                var test = words.Skip(4).ToList();

                if (!Test(dict, test)) continue;

                switch (operation)
                {
                    case "inc":
                        dict[key] += amount;
                        break;
                    case "dec":
                        dict[key] -= amount;
                        break;
                }

                localMax = Math.Max(dict[key], localMax);
            }

            return resultFunc(dict.Values.Max(), localMax).ToString();
        }

        public override string Part1(string input)
        {
            return Part0(input, (x, _) => x);
        }

        public override string Part2(string input)
        {
            return Part0(input, (_, y) => y);
        }
    }
}