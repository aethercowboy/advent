using advent.Days._2017;
using Xunit;

namespace advent.tests.Days._2017
{
    public class Day17Tests : DayTests<Day17>
    {
        public string input = "3";

        [Fact]
        public void Test01()
        {
            var result = Client.Part1(input);
            Assert.Equal(638.ToString(), result);
        }
    }
}
