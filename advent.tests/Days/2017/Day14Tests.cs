using advent.Days._2017;
using Xunit;

namespace advent.tests.Days._2017
{
    public class Day14Tests : DayTests<Day14>
    {
        private readonly string input = "flqrgnkx";

        [Fact]
        public void Test01()
        {
            var result = Client.Part1(input);
            Assert.Equal(8108.ToString(), result);
        }

        [Fact]
        public void Test02()
        {
            var result = Client.Part2(input);
            Assert.Equal(1242.ToString(), result);
        }
    }
}
