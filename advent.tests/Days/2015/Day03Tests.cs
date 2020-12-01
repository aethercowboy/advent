using advent.Days._2015;
using Xunit;

namespace advent.tests.Days._2015
{
    public class Day03Tests : DayTests<Day03>
    {
        [Fact]
        public void Test01()
        {
            var result = Client.Part1(">");
            Assert.Equal(2, result);
        }

        [Fact]
        public void Test02()
        {
            var result = Client.Part1("^>v<");
            Assert.Equal(4, result);
        }

        [Fact]
        public void Test03()
        {
            var result = Client.Part1("^v^v^v^v^v");
            Assert.Equal(2, result);
        }

        [Fact]
        public void Test04()
        {
            var result = Client.Part2("^v");
            Assert.Equal(3, result);
        }

        [Fact]
        public void Test05()
        {
            var result = Client.Part2("^>v<");
            Assert.Equal(3, result);
        }

        [Fact]
        public void Test06()
        {
            var result = Client.Part2("^v^v^v^v^v");
            Assert.Equal(11, result);
        }
    }
}
