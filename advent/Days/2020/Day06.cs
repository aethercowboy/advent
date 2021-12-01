using advent.Extensions;
using advent.Models._2020;
using System.Collections.Generic;

namespace advent.Days._2020
{
    public class Day06 : Day
    {
        public override string Part1(string input)
        {
            return PartX(input, ProcessBatch);
        }

        private static string PartX(string input, Process process)
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

            return value.ToString();
        }

        private int ProcessBatch(IList<string> batch)
        {
            var form = new CustomsForm(batch);

            batch.Clear();

            return form.GetValue();
        }

        public override string Part2(string input)
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
