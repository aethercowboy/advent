using advent.Extensions;
using System.Collections.Generic;
using System.Linq;

namespace advent.Models._2020
{
    public partial class TrainRuleset
    {
        private readonly IDictionary<string, TrainRule> rules;

        public TrainRuleset()
        {
            rules = new Dictionary<string, TrainRule>();
        }

        public void Add(string rule)
        {
            var parts = rule.Split(':').Select(x => x.Trim()).ToList();

            var name = parts[0];

            var trainRule = GetRule(name);

            foreach (var range in parts[1].Split("or").Select(x => x.Trim()).ToList())
            {
                var rParts = range.Split('-').ToInts().ToList();

                trainRule.Add(rParts[0], rParts[1]);
            }
        }

        private void Add(TrainRule rule)
        {
            if (rules.ContainsKey(rule.Name))
            {
                rules[rule.Name] = rule;
            }
            else
            {
                rules.Add(rule.Name, rule);
            }
        }

        private TrainRule GetRule(string name)
        {
            TrainRule rule;
            if (rules.ContainsKey(name))
            {
                rule = rules[name];
            }
            else
            {
                rule = new TrainRule(name);
                Add(rule);
            }

            return rule;
        }

        public int CheckTicket(TrainTicket ticket)
        {
            for (var i = 0; i < ticket.Fields.Count; i++)
            {
                var isValid = false;

                foreach (var rule in rules.Values)
                {
                    if (rule.Check(ticket.Fields[i]))
                    {
                        ticket.AddValid(i, rule.Name);

                        isValid = true;
                    }
                }

                if (!isValid)
                {
                    ticket.IsValid = false;

                    return ticket.Fields[i];
                }
            }

            return 0;
        }
    }
}
