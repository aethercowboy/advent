using advent.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace advent.Models._2021
{
    internal class NavSubsystem
    {
        private readonly IList<char> _badCharacters;

        private readonly IList<long> _scores;

        public NavSubsystem(string input)
        {
            _badCharacters = new List<char>();
            _scores = new List<long>();

            foreach (var line in input.Lines())
            {
                var openers = new Stack<char>();
                var isGood = true;

                foreach (var c in line)
                {
                    if (IsOpener(c))
                    {
                        openers.Push(c);
                    }
                    else
                    {
                        if (IsMyCloser(openers.Peek(), c))
                        {
                            openers.Pop();
                        }
                        else
                        {
                            _badCharacters.Add(c);
                            isGood = false;
                            break;
                        }
                    }
                }

                if (isGood)
                {
                    var score = CalculateAutoCompleteScore(openers.Select(GetCloser));

                    _scores.Add(score);
                }
            }
        }

        private static char GetCloser(char c)
        {
            return c switch
            {
                '(' => ')',
                '[' => ']',
                '{' => '}',
                '<' => '>',
                _ => throw new IndexOutOfRangeException()
            };
        }

        private static bool IsOpener(char c)
        {
            return c == '('
                || c == '['
                || c == '{'
                || c == '<'
                ;
        }

        private static bool IsMyCloser(char opener, char closer)
        {
            return closer == GetCloser(opener);
        }

        private int ScoreBadChar(char c)
        {
            return c switch
            {
                ')' => 3,
                ']' => 57,
                '}' => 1197,
                '>' => 25137,
                _ => throw new IndexOutOfRangeException()
            };
        }

        private static int ScoreGoodChar(char c)
        {
            return c switch
            {
                ')' => 1,
                ']' => 2,
                '}' => 3,
                '>' => 4,
                _ => throw new IndexOutOfRangeException()
            };
        }

        public int GetBadScore()
        {
            return _badCharacters.Select(ScoreBadChar)
                .Sum();
        }

        private static long CalculateAutoCompleteScore(IEnumerable<char> characters)
        {
            long score = 0;

            foreach (var c in characters)
            {
                score *= 5;
                score += ScoreGoodChar(c);
            }

            return score;
        }

        public long GetAutoCompleteScore()
        {
            var length = _scores.Count / 2;
            return _scores.OrderBy(x => x)
                .Skip(length)
                .First();
        }
    }
}
