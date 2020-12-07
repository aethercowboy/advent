using System.Collections.Generic;
using System.Linq;

namespace advent.Models._2020
{
    public class Bag
    {
        public string Color { get; }

        public Dictionary<string, int> Contents { get; }

        public Bag(string line)
        {
            var lineParts = line.Split("contain")
                .Select(x => x.Trim())
                .ToList();

            Color = lineParts[0].Replace("bags", string.Empty)
                .Replace("bag", string.Empty)
                .Trim();

            Contents = new Dictionary<string, int>();

            foreach (var cont in lineParts[1].Split(',').Select(x => x.Trim().TrimEnd('.')))
            {
                if (cont == "no other bags") continue;

                var firstSpace = cont.IndexOf(' ');

                var count = int.Parse(cont.Substring(0, firstSpace));

                var color = cont[firstSpace..].Replace("bags", string.Empty)
                    .Replace("bag", string.Empty)
                    .Replace(".", string.Empty)
                    .Trim();

                Contents.Add(color, count);
            }
        }
    }
}
