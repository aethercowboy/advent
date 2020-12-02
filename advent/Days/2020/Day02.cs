using advent.Extensions;
using advent.Models._2020;
using System.Linq;

namespace advent.Days._2020
{
    public class Day02 : Day
    {
        public override int Part1(string input)
        {
            var lines = input.Lines();

            var valid = 0;

            foreach (var line in lines)
            {
                var policy = new PasswordPolicy(line);

                var result = policy.Test.Count(x => x == policy.Character);

                if (result >= policy.Min && result <= policy.Max)
                {
                    ++valid;
                }
            }

            return valid;
        }

        public override int Part2(string input)
        {
            var lines = input.Lines();

            var valid = 0;

            foreach (var line in lines)
            {
                var policy = new PasswordPolicy(line);

                var minC = policy.Test[policy.Min - 1];
                var maxC = policy.Test[policy.Max - 1];

                if (minC != maxC
                    && (
                        minC == policy.Character
                        || maxC == policy.Character
                    ))
                {
                    ++valid;
                }
            }

            return valid;
        }
    }
}
