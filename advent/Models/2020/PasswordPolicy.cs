using System.Linq;

namespace advent.Models._2020
{
    public class PasswordPolicy
    {
        public int Min { get; }
        public int Max { get; }
        public char Character { get; }
        public string Test { get; }

        public PasswordPolicy(string input)
        {
            var parts = input.Split(':')
                    .Select(x => x.Trim())
                    .ToArray();

            var rule = parts[0];
            Test = parts[1];

            var ruleParts = rule.Split();
            var minMax = ruleParts[0].Split('-');
            Character = char.Parse(ruleParts[1]);

            Min = int.Parse(minMax[0]);
            Max = int.Parse(minMax[1]);
        }
    }
}
