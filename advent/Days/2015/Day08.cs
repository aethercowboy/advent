using advent.Extensions;
using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace advent.Days._2015
{
    public class Day08 : Day
    {
        private static readonly Regex Backslash = new Regex(@"\\\\", RegexOptions.Compiled);
        private static readonly Regex Quote = new Regex(@"\\\""", RegexOptions.Compiled);
        private static readonly Regex Hex = new Regex(@"\\x[0-9a-f]{2}", RegexOptions.Compiled);

        private static int CalculateMemoryLength(string input)
        {
            var str = input[1..^1];

            var output = str.Length;

            output -= Backslash.Matches(str).Count;
            str = Backslash.Replace(str, "?");

            output -= Quote.Matches(str).Count;
            str = Quote.Replace(str, "?");

            output -= Hex.Matches(str).Count * 3;

            return output;
        }

        private static int CalculateEncodedLength(string input)
        {
            var output = 2;

            foreach (var c in input)
            {
                output += c switch
                {
                    '"' or '\\' => 2,
                    _ => 1,
                };
            }
            return output;
        }

        private static int Part0(string input, Func<string, int> calculateFunc)
        {
            return input.Lines()
                .Aggregate(0, (current, line) =>
                    current + line.Length - calculateFunc(line)
                );
        }

        public override string Part1(string input)
        {
            return Part0(input, CalculateMemoryLength).ToString();
        }

        public override string Part2(string input)
        {
            return (-Part0(input, CalculateEncodedLength)).ToString();
        }
    }
}
