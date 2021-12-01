using advent.Extensions;
using advent.Models._2020;

namespace advent.Days._2020
{
    public class Day14 : Day
    {
        public override string Part1(string input)
        {
            var lines = input.Lines();

            var mask = new Mask("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");

            var memory = new Memory();

            foreach (var line in lines)
            {
                var parts = line.Split();

                if (line.StartsWith("mask"))
                {
                    mask = new Mask(parts[2]);
                }
                else if (line.StartsWith("mem"))
                {
                    var lhs = parts[0].Split('[', ']');
                    var address = int.Parse(lhs[1]);
                    var value = int.Parse(parts[2]);

                    var maskedValue = mask.Apply(value);

                    memory.Add(address, maskedValue);
                }
            }

            return memory.Sum().ToString();
        }

        public override string Part2(string input)
        {
            var lines = input.Lines();

            var mask = new Mask("000000000000000000000000000000000000");

            var memory = new Memory();

            foreach (var line in lines)
            {
                var parts = line.Split();

                if (line.StartsWith("mask"))
                {
                    mask = new Mask(parts[2]);
                }
                else if (line.StartsWith("mem"))
                {
                    var lhs = parts[0].Split('[', ']');
                    var address = int.Parse(lhs[1]);
                    var value = int.Parse(parts[2]);

                    foreach (var a in mask.Apply2(address))
                    {
                        memory.Add(a, value);
                    }
                }
            }

            return memory.Sum().ToString();
        }
    }
}
