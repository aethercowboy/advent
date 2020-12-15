using advent.Extensions;
using advent.Models._2020;
using System.Collections.Generic;
using System.Linq;

namespace advent.Days._2020
{
    internal delegate int Process(IList<string> buffer);

    public class Day04 : Day
    {
        public override long Part1(string input)
        {
            return PartX(input, ProcessBuffer);
        }

        private int ProcessBuffer(IList<string> buffer)
        {
            var passport = new Passport(buffer);

            buffer.Clear();

            if (passport.HasRequiredFields())
            {
                return 1;
            }

            return 0;
        }

        private int ProcessBuffer2(IList<string> buffer)
        {
            var passport = new Passport(buffer);

            buffer.Clear();

            if (passport.HasRequiredFields() && passport.AreFieldsValid())
            {
                return 1;
            }

            return 0;
        }

        public override long Part2(string input)
        {
            return PartX(input, ProcessBuffer2);
        }

        private static int PartX(string input, Process process)
        {
            var lines = input.Lines(includeBlankLines: true)
                .ToList();

            var buffer = new List<string>();

            var valid = 0;

            foreach (var line in lines)
            {
                if (string.IsNullOrWhiteSpace(line))
                {
                    valid += process(buffer);
                    continue;
                }

                buffer.Add(line);
            }

            valid += process(buffer);

            return valid;
        }
    }
}
