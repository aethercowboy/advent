using advent.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace advent.Models._2021
{
    internal class SevenSegmentDisplay
    {
        private readonly IDictionary<SegmentPosition, IList<char>> _candidates;

        public SevenSegmentDisplay(string input)
        {
            _candidates = new Dictionary<SegmentPosition, IList<char>>() {
                { SegmentPosition.Top, new List<char> { 'a','b','c','d','e','f','g'} },
                { SegmentPosition.TopLeft, new List<char> { 'a','b','c','d','e','f','g'} },
                { SegmentPosition.TopRight, new List<char> { 'a','b','c','d','e','f','g'} },
                { SegmentPosition.Middle, new List<char> { 'a','b','c','d','e','f','g'} },
                { SegmentPosition.BottomLeft, new List<char> { 'a','b','c','d','e','f','g'} },
                { SegmentPosition.BottomRight, new List<char> { 'a','b','c','d','e','f','g'} },
                { SegmentPosition.Bottom, new List<char> { 'a','b','c','d','e','f','g'} }
            };

            var words = input.Words().ToList();

            var one = words.First(IsOne);

            ParseOne(one);

            var seven = words.First(IsSeven);

            ParseSeven(seven);

            var four = words.First(IsFour);

            ParseFour(four);

            var zero = words.First(IsZero);

            ParseZero(zero);

            var five = words.First(IsFive);

            ParseFive(five);
        }

        public int GetDisplay(string input)
        {
            var words = input.Words().ToList();

            var number = new StringBuilder();

            foreach (var word in words)
            {
                number.Append(GetDigit(word));
            }

            return int.Parse(number.ToString());
        }

        private int GetDigit(string word)
        {
            if (word.Length == 2)
            {
                return 1;
            }
            else if (word.Length == 3)
            {
                return 7;
            }
            else if (word.Length == 4)
            {
                return 4;
            }
            else if (word.Length == 7)
            {
                return 8;
            }
            else if (word.Length == 5)
            {
                var candidates = new List<int> { 2, 3, 5 };

                return GetDigit(word, candidates);
            }
            else if (word.Length == 6)
            {
                var candidates = new List<int> { 0, 6, 9 };

                return GetDigit(word, candidates);
            }

            return -1;
        }

        private int GetDigit(string word, IList<int> candidates)
        {
            foreach (var candidate in candidates)
            {
                var segments = GetSegments(candidate)
                    .Select(x => _candidates[x].First());

                if (segments.All(x => word.Contains(x)))
                {
                    return candidate;
                }
            }

            return -1;
        }

        private static SegmentPosition[] GetSegments(int i)
        {
            return i switch
            {
                0 => new SegmentPosition[] { SegmentPosition.Top, SegmentPosition.TopLeft, SegmentPosition.TopRight, SegmentPosition.BottomLeft, SegmentPosition.BottomRight, SegmentPosition.Bottom },
                1 => new SegmentPosition[] { SegmentPosition.TopRight, SegmentPosition.BottomRight },
                2 => new SegmentPosition[] { SegmentPosition.Top, SegmentPosition.TopRight, SegmentPosition.Middle, SegmentPosition.BottomLeft, SegmentPosition.Bottom },
                3 => new SegmentPosition[] { SegmentPosition.Top, SegmentPosition.TopRight, SegmentPosition.Middle, SegmentPosition.BottomRight, SegmentPosition.Bottom },
                4 => new SegmentPosition[] { SegmentPosition.TopLeft, SegmentPosition.TopRight, SegmentPosition.Middle, SegmentPosition.BottomRight },
                5 => new SegmentPosition[] { SegmentPosition.Top, SegmentPosition.TopLeft, SegmentPosition.Middle, SegmentPosition.BottomRight, SegmentPosition.Bottom },
                6 => new SegmentPosition[] { SegmentPosition.Top, SegmentPosition.TopLeft, SegmentPosition.Middle, SegmentPosition.BottomLeft, SegmentPosition.BottomRight, SegmentPosition.Bottom },
                7 => new SegmentPosition[] { SegmentPosition.Top, SegmentPosition.TopRight, SegmentPosition.BottomRight },
                8 => new SegmentPosition[] { SegmentPosition.Top, SegmentPosition.TopLeft, SegmentPosition.TopRight, SegmentPosition.Middle, SegmentPosition.BottomLeft, SegmentPosition.BottomRight, SegmentPosition.Bottom },
                9 => new SegmentPosition[] { SegmentPosition.Top, SegmentPosition.TopLeft, SegmentPosition.TopRight, SegmentPosition.Middle, SegmentPosition.BottomRight, SegmentPosition.Bottom },
                _ => Array.Empty<SegmentPosition>(),
            };
        }

        private void Deactivate(char c, params SegmentPosition[] positions)
        {
            foreach (var position in positions)
            {
                _candidates[position].Remove(c);
            }
        }

        private void Activate(SegmentPosition position, params char[] letters)
        {
            _candidates[position] = letters.ToList();
        }

        private void ParseOne(string word)
        {
            var letters = word.ToCharArray();

            foreach (var c in letters)
            {
                Deactivate(c, SegmentPosition.Top, SegmentPosition.TopLeft, SegmentPosition.Middle, SegmentPosition.BottomLeft, SegmentPosition.Bottom);
            }

            Activate(SegmentPosition.TopRight, letters);
            Activate(SegmentPosition.BottomRight, letters);
        }

        private void ParseSeven(string word)
        {
            var sides = _candidates[SegmentPosition.TopRight];
            var top = word.Replace(sides[0].ToString(), string.Empty)
                .Replace(sides[1].ToString(), string.Empty)
                .ToCharArray();

            Deactivate(top[0], SegmentPosition.TopLeft, SegmentPosition.TopRight, SegmentPosition.Middle, SegmentPosition.BottomLeft, SegmentPosition.BottomRight, SegmentPosition.Bottom);
            Activate(SegmentPosition.Top, top);
        }

        private void ParseFour(string word)
        {
            var sides = _candidates[SegmentPosition.TopRight];

            var ell = word.Replace(sides[0].ToString(), string.Empty)
                .Replace(sides[1].ToString(), string.Empty)
                .ToCharArray();

            foreach (var c in ell)
            {
                Deactivate(c, SegmentPosition.Top, SegmentPosition.TopRight, SegmentPosition.BottomLeft, SegmentPosition.BottomRight, SegmentPosition.Bottom);
            }

            Activate(SegmentPosition.TopLeft, ell);
            Activate(SegmentPosition.Middle, ell);
        }

        private void ParseZero(string word)
        {
            var middles = _candidates[SegmentPosition.Middle];

            var middle = middles.First(x => !word.Contains(x));

            Deactivate(middle, SegmentPosition.Top, SegmentPosition.TopLeft, SegmentPosition.TopRight, SegmentPosition.BottomLeft, SegmentPosition.BottomRight, SegmentPosition.Bottom);
            Activate(SegmentPosition.Middle, middle);
        }

        private void ParseFive(string word)
        {
            var brs = _candidates[SegmentPosition.BottomRight];
            var bots = _candidates[SegmentPosition.Bottom];

            var br = brs.Single(x => word.Contains(x));
            var bot = bots.Single(x => word.Contains(x));

            Deactivate(br, SegmentPosition.Top, SegmentPosition.TopLeft, SegmentPosition.TopRight, SegmentPosition.Middle, SegmentPosition.BottomLeft, SegmentPosition.Bottom);
            Activate(SegmentPosition.BottomRight, br);

            Deactivate(bot, SegmentPosition.Top, SegmentPosition.TopLeft, SegmentPosition.TopRight, SegmentPosition.Middle, SegmentPosition.BottomLeft, SegmentPosition.BottomRight);
            Activate(SegmentPosition.Bottom, bot);
        }

        private static IEnumerable<string> GetUniques(IEnumerable<string> words)
        {
            return words.Where(x => IsOne(x) || IsFour(x) || IsSeven(x) || IsEight(x));
        }

        public static int CountUniques(string output)
        {
            var words = output.Words();

            return GetUniques(words).Count();
        }

        private static bool IsOne(string word)
        {
            return word.Length == 2;
        }

        private static bool IsFour(string word)
        {
            return word.Length == 4;
        }

        private static bool IsSeven(string word)
        {
            return word.Length == 3;
        }

        private static bool IsEight(string word)
        {
            return word.Length == 8;
        }

        private bool IsZero(string word)
        {
            var middles = _candidates[SegmentPosition.Middle];

            return middles.Count != 2
                ? throw new ApplicationException("Not ready to determine zero")
                : word.Length == 6 && (!word.Contains(middles[0]) || !word.Contains(middles[1]));
        }

        private bool IsFive(string word)
        {
            var top = _candidates[SegmentPosition.Top].Single();
            var tl = _candidates[SegmentPosition.TopLeft].Single();
            var mid = _candidates[SegmentPosition.Middle].Single();

            return word.Length == 5 && word.Contains(top) && word.Contains(tl) && word.Contains(mid);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            var t = GetCandidate(SegmentPosition.Top);

            sb.Append(' ').Append(t).Append(t).Append(t).Append(t).AppendLine(" ");

            var tl = GetCandidate(SegmentPosition.TopLeft);
            var tr = GetCandidate(SegmentPosition.TopRight);

            sb.Append(tl).Append("    ").Append(tr).AppendLine();
            sb.Append(tl).Append("    ").Append(tr).AppendLine();

            var m = GetCandidate(SegmentPosition.Middle);

            sb.Append(' ').Append(m).Append(m).Append(m).Append(m).AppendLine(" ");

            var bl = GetCandidate(SegmentPosition.BottomLeft);
            var br = GetCandidate(SegmentPosition.BottomRight);

            sb.Append(bl).Append("    ").Append(br).AppendLine();
            sb.Append(bl).Append("    ").Append(br).AppendLine();

            var b = GetCandidate(SegmentPosition.Bottom);

            sb.Append(' ').Append(b).Append(b).Append(b).Append(b).AppendLine(" ");

            return sb.ToString();
        }

        private char GetCandidate(SegmentPosition position)
        {
            return _candidates[position].Count > 1
                ? _candidates[position].Count.ToCharDigit()
                : _candidates[position][0];
        }
    }

    internal enum SegmentPosition
    {
        Top,
        TopLeft,
        TopRight,
        Middle,
        BottomLeft,
        BottomRight,
        Bottom
    }
}
