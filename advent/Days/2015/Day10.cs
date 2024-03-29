﻿using System.Linq;

namespace advent.Days._2015
{
    public class Day10 : Day
    {
        public int Generations { get; internal set; } = 40;

        private static string LookAndSay(string input)
        {
            var skip = 0;

            var inputChars = input.ToCharArray();

            var str = inputChars.Select((c, i) =>
            {
                if (skip > 0)
                {
                    --skip;
                    return string.Empty;
                }

                skip += inputChars.Skip(i + 1).TakeWhile(x => x == c).Count();
                return (skip + 1).ToString() + c;
            });

            return string.Concat(str);
        }

        public override string Part1(string input)
        {
            var response = Enumerable.Range(0, Generations)
                .Aggregate(input, (current, _) => LookAndSay(current));

            return response.Length.ToString();
        }

        public override string Part2(string input)
        {
            Generations = 50;
            return Part1(input);
        }
    }
}
