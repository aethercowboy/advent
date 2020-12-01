using advent.Data;
using advent.Days._2015;
using Xunit;

namespace advent.tests.Days._2015
{
    public class Day08Tests : DayTests<Day08>
    {
        private string input = DayData.LoadFile(2015, "Day08");

        [Fact]
        public void Test01()
        {

            var result = Client.Part1(input);
            Assert.Equal(12, result);
        }

        [Fact]
        public void Test02()
        {
            var result = Client.Part2(input);
            Assert.Equal(19, result);
        }
    }
}