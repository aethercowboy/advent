using advent.Days._2015;
using Xunit;

namespace advent.tests.Days._2015
{
    public class Day02Tests : DayTests<Day02>
    {
        [Fact]
        public void Test01()
        {
            var result = Client.Part1("2x3x4");
            Assert.Equal("58", result);
        }

        [Fact]
        public void Test02()
        {
            var result = Client.Part1("1x1x10");
            Assert.Equal("43", result);
        }

        [Fact]
        public void Test03()
        {
            var result = Client.Part2("2x3x4");
            Assert.Equal("34", result);
        }

        [Fact]
        public void Test04()
        {
            var result = Client.Part2("1x1x10");
            Assert.Equal("14", result);
        }
    }
}