using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace advent.Days._2015
{
    public class Day05 : Day
    {
        private static int Part0(string input, params Func<string, bool>[] testFuncs)
        {
            return input.Split('\n').Count(line => testFuncs.All(x => x(line)));
        }

        private static bool HasAtLeastThreeVowels(string input)
        {
            var vowels = "aeiou".ToCharArray();

            return input.Count(x => vowels.Contains(x)) >= 3;
        }

        private readonly List<string> _letterPairs = Globals.Alphabet.Select(y => $"{y}{y}").ToList();

        private bool HasAtLeastOneDoubleLetter(string input)
        {
            var pairs = _letterPairs;

            return pairs.Any(input.Contains);
        }

        private static bool DoesNotContainStrings(string input, params string[] badStrings)
        {
            return !badStrings.Any(input.Contains);
        }

        private static bool DoesNotContainsPart1Strings(string input)
        {
            return DoesNotContainStrings(input, "ab", "cd", "pq", "xy");
        }


        public override int Part1(string input)
        {
            return Part0(input,
                HasAtLeastThreeVowels,
                HasAtLeastOneDoubleLetter,
                DoesNotContainsPart1Strings
            );
        }

        private static bool HasPairOfTwoLettersTwice(string input)
        {
            var pairs = Globals.Alphabet.SelectMany(x => Globals.Alphabet.Select(y => $"{x}{y}")).ToList();

            return pairs.Select(x => new Regex($"{x}.*{x}")).Any(x => x.IsMatch(input));
        }

        private static bool HasAtLeatOneSplitLetter(string input)
        {
            var letters = Globals.Alphabet.ToCharArray();

            return letters.Select(x => new Regex($"{x}.{x}")).Any(x => x.IsMatch(input));
        }

        public override long Part2(string input)
        {
            return Part0(input,
                HasPairOfTwoLettersTwice,
                HasAtLeatOneSplitLetter
                );
        }
    }
}
