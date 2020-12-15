using advent.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace advent.Days._2017
{
    public class Day15 : Day
    {
        private static IEnumerable<Generator> GetGenerators(string input)
        {
            var factors = new Dictionary<string, int[]>
            {
                {"A", new []{16807, 4}},
                {"B", new []{48271, 8}}
            };

            return input.Lines()
                .Select(line => line.Words().ToList())
                .Select(words => new
                {
                    key = words[1],
                    val = words[4].ToInt(),
                    fac = factors[words[1]]
                })
                .Select(t => new Generator(t.key, t.val, t.fac[0], t.fac[1]))
                .ToList();
        }
        public override long Part1(string input)
        {
            var judge = new Judge(40_000_000);

            var generators = GetGenerators(input);

            return judge.Competition(generators, g => g.NextValue());
        }

        public override long Part2(string input)
        {
            var judge = new Judge(5_000_000);
            var generators = GetGenerators(input);
            return judge.Competition(generators, g => g.NextSpecialValue());
        }
    }

    public class Judge
    {
        public Judge(int rounds)
        {
            Rounds = rounds;
        }

        public int Rounds { get; set; }

        public int Competition(IEnumerable<Generator> generators, Func<Generator, int> nextFunc)
        {
            return Enumerable
                .Range(0, Rounds)
                .Select(_ => generators.Select(nextFunc)
                    .Select(v => Convert.ToString(v, 2).PadLeft(32, '0')[16..]).ToList())
                .Count(values =>
                {
                    var first = values[0];
                    return values.Skip(1).All(x => x == first);
                });
        }
    }

    public class Generator
    {
        private const int MagicNumber = 2147483647;

        public Generator(string name, int startingValue, int factor, int denominator)
        {
            Name = name;
            CurrentValue = startingValue;
            Factor = factor;
            Denominator = denominator;
        }

        public string Name { get; set; }

        public int CurrentValue { get; set; }
        public BigInteger Factor { get; set; }
        public int Denominator { get; set; }

        public int NextValue()
        {
            var current = new BigInteger(CurrentValue);

            var calc = current * Factor;
            var mod = calc % MagicNumber;
            CurrentValue = (int)mod;
            return CurrentValue;
        }

        public int NextSpecialValue()
        {
            do
            {
                NextValue();
            } while (CurrentValue % Denominator != 0);

            return CurrentValue;
        }
    }
}
