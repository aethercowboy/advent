﻿using advent.IO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace advent.Days._2015
{
    public class Day11 : Day
    {
        public static bool IsEightCharacters(string input)
        {
            return input.Length == 8;
        }

        public static char IncrementCharacter(char c, int i)
        {
            return (char)(Convert.ToUInt16(c) + i);
        }

        public static bool HasOneIncreasingStraight(string input)
        {
            var straights = Globals.Alphabet.Select(a =>
            {
                if (a == 'y' || a == 'z')
                {
                    return null;
                }

                var b = IncrementCharacter(a, 1);
                var c = IncrementCharacter(a, 2);
                return new string(new[] { a, b, c });
            }).Where(x => x != null)
            .ToList();

            return straights.Any(input.Contains);
        }

        public static bool DoesNotHaveILO(string input)
        {
            var ilo = new[] { 'i', 'l', 'o' };
            return input.All(x => !ilo.Contains(x));
        }

        public static bool HasTwoNonOverlappingPairsOfLetters(string input)
        {
            var pairs = Globals.Alphabet.Select(x => $"{x}{x}").ToList();

            return pairs.Any(x => input.Contains(x) && pairs.Where(y => y != x).Any(input.Contains));
        }

        private static string IncreaseString(string input)
        {
            var tupni = input.Reverse().ToList();

            var result = new List<char>();

            var carryover = 1;

            foreach (var c in tupni)
            {
                if (c == 'z' && carryover == 1)
                {
                    carryover = 1;
                    result.Add('a');
                }
                else
                {
                    result.Add(IncrementCharacter(c, carryover));
                    carryover = 0;
                }
            }

            result.Reverse();

            return new string(result.ToArray());
        }

        public override string Part1(string input)
        {
            var rules = new List<Func<string, bool>>
            {
                IsEightCharacters,
                HasOneIncreasingStraight,
                DoesNotHaveILO,
                HasTwoNonOverlappingPairsOfLetters
            };

            var str = IncreaseString(input);
            var response = 0;

            while (str.Length <= 8)
            {
                if (rules.All(x => x(str)))
                {
                    Console.WriteOutput(str);
                    response = 1;
                    break;
                }

                str = IncreaseString(str);
            }

            return response.ToString();
        }

        private string Key { get; set; }

        public override string Part2(string input)
        {
            Console.Wrote += OnWrote;

            Part1(input);
            return Part1(Key);
        }

        private void OnWrote(object sender, EventArgs e)
        {
            if (e is ConsoleEventArgs f)
            {
                Key = f.Message;
            }
        }
    }
}
