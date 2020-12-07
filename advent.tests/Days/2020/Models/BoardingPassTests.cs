using advent.Models._2020;
using Xunit;

namespace advent.tests.Days._2020.Models
{
    public class BoardingPassTests
    {
        [Fact]
        public void Test01()
        {
            const string input = "FBFBBFFRLR";

            var result = new BoardingPass(input);

            Assert.Equal(44, result.Row);
            Assert.Equal(5, result.Column);
            Assert.Equal(357, result.SeatId);
        }
    }
}
