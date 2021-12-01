using advent.Days._2017;
using Xunit;

namespace advent.tests.Days._2017
{
    public class Day11Tests : DayTests<Day11>
    {
        [Fact]
        public void Test01()
        {
            var result = Client.Part1("ne,ne,ne");
            Assert.Equal(3.ToString(), result);
        }

        [Fact]
        public void Test02()
        {
            var result = Client.Part1("ne,ne,sw,sw");
            Assert.Equal(0.ToString(), result);
        }

        [Fact]
        public void Test03()
        {
            var result = Client.Part1("ne,ne,s,s");
            Assert.Equal(2.ToString(), result);
        }

        [Fact]
        public void Test04()
        {
            var result = Client.Part1("se,sw,se,sw,sw");
            Assert.Equal(3.ToString(), result);
        }
    }
}
