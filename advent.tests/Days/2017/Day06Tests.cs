using advent.Days._2017;
using Xunit;

namespace advent.tests.Days._2017
{
    public class Day06Tests : DayTests<Day06>
    {
        [Fact]
        public void Test01()
        {
            var response = Client.Part1("0 2 7 0");
            Assert.Equal(5, response);
        }

        [Fact]
        public void Test02()
        {
            var response = Client.Part2("0 2 7 0");
            Assert.Equal(4, response);
        }
    }
}
