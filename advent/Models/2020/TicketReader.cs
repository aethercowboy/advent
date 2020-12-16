using advent.Enums._2020;
using advent.Extensions;
using System.Collections.Generic;
using System.Linq;

namespace advent.Models._2020
{
    public class TicketReader
    {
        public TrainRuleset Ruleset { get; }
        public IList<TrainTicket> Tickets { get; }
        public TrainTicket MyTicket { get; }

        private bool areTicketsChecked = false;

        public TicketReader(string input)
        {
            Ruleset = new TrainRuleset();
            Tickets = new List<TrainTicket>();

            var lines = input.Lines();

            var phase = TicketPhase.Rules;

            foreach (var line in lines)
            {
                switch (line)
                {
                    case "your ticket:":
                        phase = TicketPhase.YourTicket;
                        continue;
                    case "nearby tickets:":
                        phase = TicketPhase.NearbyTickets;
                        continue;
                }

                switch (phase)
                {
                    case TicketPhase.Rules:
                        Ruleset.Add(line);
                        break;
                    case TicketPhase.YourTicket:
                        MyTicket = new TrainTicket(line);
                        break;
                    case TicketPhase.NearbyTickets:
                        Tickets.Add(new TrainTicket(line));
                        break;
                }
            }
        }

        public int CheckTickets()
        {
            var values = new List<int>();

            foreach (var ticket in Tickets)
            {
                var check = Ruleset.CheckTicket(ticket);

                if (check > 0)
                {
                    values.Add(check);
                }
            }

            areTicketsChecked = true;

            return values.Sum();
        }

        public IDictionary<int, string> CheckValidTickets()
        {
            if (!areTicketsChecked) CheckTickets();

            var validTickets = Tickets.Where(x => x.IsValid).ToList();

            var result = new Dictionary<int, string>();

            var toProcess = validTickets[0].Valids.Keys.ToList();

            do
            {
                var nextToProcess = new List<int>();

                foreach (var i in toProcess)
                {
                    var fields = validTickets.Select(x => x.Valids[i]);

                    var intersection = fields.Intersect()
                        .Where(x => !result.ContainsValue(x))
                        .ToList();

                    if (intersection.Count == 1)
                    {
                        result.Add(i, intersection[0]);
                    }
                    else
                    {
                        nextToProcess.Add(i);
                    }
                }

                toProcess = nextToProcess;
            } while (toProcess.Count > 0);

            return result;
        }
    }
}
