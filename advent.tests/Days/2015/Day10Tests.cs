using advent.Days._2015;
using Xunit;

namespace advent.tests.Days._2015
{
    public class Day10Tests : DayTests<Day10>
    {
        [Fact]
        public void Test01()
        {
            Client.Generations = 1;
            var result = Client.Part1("1");
            Assert.Equal(2.ToString(), result);
        }

        [Fact]
        public void Test02()
        {
            Client.Generations = 1;
            var result = Client.Part1("11");
            Assert.Equal(2.ToString(), result);
        }

        [Fact]
        public void Test03()
        {
            Client.Generations = 1;
            var result = Client.Part1("21");
            Assert.Equal(4.ToString(), result);
        }

        [Fact]
        public void Test04()
        {
            Client.Generations = 1;
            var result = Client.Part1("1211");
            Assert.Equal(6.ToString(), result);
        }

        [Fact]
        public void Test05()
        {
            Client.Generations = 1;
            var result = Client.Part1("111221");
            Assert.Equal(6.ToString(), result);
        }

        [Fact]
        public void Test06()
        {
            Client.Generations = 5;
            var result = Client.Part1("1");
            Assert.Equal(6.ToString(), result);
        }
    }
}
