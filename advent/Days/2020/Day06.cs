using advent.Extensions;
using advent.Models._2020;
using System.Collections.Generic;

namespace advent.Days._2020
{
    public class Day06 : Day
    {
        public override long Part1(string input)
        {
            return PartX(input, ProcessBatch);
        }

        private int PartX(string input, Process process)
        {
            var lines = input.Lines(includeBlankLines: true);

            List<string> batch = new List<string>();

            var value = 0;

            foreach (var line in lines)
            {
                if (string.IsNullOrWhiteSpace(line))
                {
                    value += process(batch);
                }
                else
                {
                    batch.Add(line);
                }
            }

            value += process(batch);

            return value;
        }

        private int ProcessBatch(IList<string> batch)
        {
            var form = new CustomsForm(batch);

            batch.Clear();

            return form.GetValue();
        }

        public override long Part2(string input)
        {
            return PartX(input, ProcessBatch2);
        }

        private int ProcessBatch2(IList<string> batch)
        {
            var form = new CustomsForm(batch);

            batch.Clear();

            return form.GetValue2();
        }
    }
}
