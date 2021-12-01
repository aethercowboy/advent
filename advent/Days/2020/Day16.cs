using advent.Models._2020;
using System.Linq;

namespace advent.Days._2020
{
    public class Day16 : Day
    {
        public override string Part1(string input)
        {
            var ticketReader = new TicketReader(input);

            return ticketReader.CheckTickets().ToString();
        }

        public override string Part2(string input)
        {
            var ticketReader = new TicketReader(input);

            var result = ticketReader.CheckValidTickets();

            long values = 1;

            foreach (var r in result.Where(x => x.Value.StartsWith("departure")))
            {
                values *= ticketReader.MyTicket.Fields[r.Key];
            }

            return values.ToString();
        }
    }
}
