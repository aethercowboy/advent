using advent.Extensions;
using System.Collections.Generic;
using System.Linq;

namespace advent.Days._2015
{
    public class Day07 : Day
    {
        public string Key { get; set; } = "a";

        private static readonly Dictionary<string, ushort> ValueDict = new Dictionary<string, ushort>();

        private static ushort BitwiseAnd(ushort x, ushort y)
        {
            return (ushort)(x & y);
        }

        private static ushort BitwiseOr(ushort x, ushort y)
        {
            return (ushort)(x | y);
        }

        private static ushort LeftShift(ushort x, ushort y)
        {
            return (ushort)(x << y);
        }

        private static ushort RightShift(ushort x, ushort y)
        {
            return (ushort)(x >> y);
        }

        private static ushort BitwiseNot(ushort x)
        {
            return (ushort)~x;
        }

        private static void ProcessLine(IDictionary<string, string> dict, string line)
        {
            var words = line.Words().ToList();
            var idx = words.IndexOf("->");
            var lhs = string.Join(" ", words.Take(idx).ToList());
            var rhs = words.Skip(idx + 1).Last();

            dict.Add(rhs, lhs);
        }

        private static ushort CalculateValue(IDictionary<string, string> dict, string key)
        {
            if (ValueDict.TryGetValue(key, out var val))
            {
                return val;
            }

            dict.TryGetValue(key, out var formula);

            var lhs = formula.Words().ToList();

            if (ushort.TryParse(key, out val))
            {
                return val;
            }

            if (ushort.TryParse(formula, out val))
            {
                ValueDict.Add(key, val);
                return val;
            }

            if (lhs.Contains("AND"))
            {
                var x = CalculateValue(dict, lhs[0]);
                var y = CalculateValue(dict, lhs[2]);
                val = BitwiseAnd(x, y);
            }
            else if (lhs.Contains("LSHIFT"))
            {
                var x = CalculateValue(dict, lhs[0]);
                var y = CalculateValue(dict, lhs[2]);
                val = LeftShift(x, y);
            }
            else if (lhs.Contains("NOT"))
            {
                var x = CalculateValue(dict, lhs[1]);
                val = BitwiseNot(x);
            }
            else if (lhs.Contains("OR"))
            {
                var x = CalculateValue(dict, lhs[0]);
                var y = CalculateValue(dict, lhs[2]);
                val = BitwiseOr(x, y);
            }
            else if (lhs.Contains("RSHIFT"))
            {
                var x = CalculateValue(dict, lhs[0]);
                var y = CalculateValue(dict, lhs[2]);
                val = RightShift(x, y);
            }
            else
            {
                val = CalculateValue(dict, lhs[0]);
            }

            ValueDict.Add(key, val);
            return val;
        }

        private static Dictionary<string, string> BuildDict(string input)
        {
            var dict = new Dictionary<string, string>();

            foreach (var line in input.Lines())
            {
                ProcessLine(dict, line);
            }

            return dict;
        }

        public override string Part1(string input)
        {
            ValueDict.Clear();

            var dict = BuildDict(input);

            return CalculateValue(dict, Key).ToString();
        }

        public override string Part2(string input)
        {
            ValueDict.Clear();

            var dict = BuildDict(input);

            var val = CalculateValue(dict, Key);

            ValueDict.Clear();

            dict["b"] = val.ToString();

            return CalculateValue(dict, Key).ToString();
        }
    }
}
