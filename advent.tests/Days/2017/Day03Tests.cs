using advent.Days._2017;
using Xunit;

namespace advent.tests.Days._2017
{
    public class Day03Tests : DayTests<Day03>
    {
        [Fact]
        public void Test01()
        {
            var result = Client.Part1("1");
            Assert.Equal(0, result);
        }

        [Fact]
        public void Test02()
        {
            var result = Client.Part1("12");
            Assert.Equal(3, result);
        }

        [Fact]
        public void Test03()
        {
            var result = Client.Part1("23");
            Assert.Equal(2, result);
        }

        [Fact]
        public void Test04()
        {
            var result = Client.Part1("1024");
            Assert.Equal(31, result);
        }

        [Fact]
        public void Test05()
        {
            var result = Client.Part2("1");
            Assert.Equal(2, result);
        }

        [Fact]
        public void Test06()
        {
            var result = Client.Part2("2");
            Assert.Equal(4, result);
        }

        [Fact]
        public void Test07()
        {
            var result = Client.Part2("4");
            Assert.Equal(5, result);
        }

        [Fact]
        public void Test08()
        {
            var result = Client.Part2("5");
            Assert.Equal(10, result);
        }

        [Fact]
        public void Test09()
        {
            var result = Client.Part2("10");
            Assert.Equal(11, result);
        }

        [Fact]
        public void Test10()
        {
            var result = Client.Part2("11");
            Assert.Equal(23, result);
        }
    }
}
