using advent.Models._2020;
using Xunit;

namespace advent.tests.Days._2020.Models
{
    public class TicketReaderTests
    {
        [Fact]
        public void Test01()
        {
            var reader = new TicketReader(@"
class: 0-1 or 4-19
row: 0-5 or 8-19
seat: 0-13 or 16-19

your ticket:
11,12,13

nearby tickets:
3,9,18
15,1,5
5,14,9
");
            var result = reader.CheckValidTickets();

            Assert.NotNull(result);

            Assert.Equal(3, result.Count);

            Assert.Equal("row", result[0]);
            Assert.Equal("class", result[1]);
            Assert.Equal("seat", result[2]);
        }
    }
}
