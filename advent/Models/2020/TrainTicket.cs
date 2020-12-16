using advent.Extensions;
using System.Collections.Generic;
using System.Linq;

namespace advent.Models._2020
{
    public class TrainTicket
    {
        public IList<int> Fields { get; }
        public IDictionary<int, IList<string>> Valids { get; }

        public bool IsValid { get; set; }

        public TrainTicket(string data)
        {
            Fields = data.Split(',').ToInts().ToList();
            Valids = new Dictionary<int, IList<string>>();

            IsValid = true;
        }

        public void AddValid(int i, string name)
        {
            if (Valids.ContainsKey(i))
            {
                Valids[i].Add(name);
            }
            else
            {
                Valids.Add(i, new List<string> { name });
            }
        }
    }
}
