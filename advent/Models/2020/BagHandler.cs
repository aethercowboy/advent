using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace advent.Models._2020
{
    public class BagHandler
    {
        private readonly IList<Bag> _bags;

        public BagHandler()
        {
            _bags = new List<Bag>();
        }

        public void AddBag(string line)
        {
            var bag = new Bag(line);

            _bags.Add(bag);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            foreach (var bag in _bags)
            {
                sb.AppendLine(bag.Color);
            }

            return sb.ToString();
        }

        public HashSet<Bag> BagContains(string color)
        {
            var bags = new HashSet<Bag>();

            for (var i = 0; i < _bags.Count; ++i)
            {
                var bag = _bags[i];

                if (bag.Color == color) continue;
                if (bag.Contents.Count == 0) continue;

                if (bag.Contents.ContainsKey(color))
                {
                    bags.Add(bag);

                    foreach (var b in BagContains(bag.Color))
                    {
                        bags.Add(b);
                    }
                }
            }

            return bags;
        }

        public Dictionary<string, int> BagInsides(string color)
        {
            var bags = new Dictionary<string, int>();

            var topBag = _bags.First(x => x.Color == color);

            foreach (var cont in topBag.Contents)
            {
                if (bags.ContainsKey(cont.Key))
                {
                    bags[cont.Key] += cont.Value;
                }
                else
                {
                    bags.Add(cont.Key, cont.Value);
                }

                foreach (var kvp in BagInsides(cont.Key))
                {
                    if (bags.ContainsKey(kvp.Key))
                    {
                        bags[kvp.Key] += (kvp.Value * cont.Value);
                    }
                    else
                    {
                        bags.Add(kvp.Key, kvp.Value * cont.Value);
                    }
                }
            }

            return bags;
        }
    }
}
