using advent.Days._2015;
using Xunit;

namespace advent.tests.Days._2015
{
    public class Day04Tests : DayTests<Day04>
    {
        [Fact]
        public void Test01()
        {
            var result = Client.Part1("abcdef");
            Assert.Equal(609043, result);
        }

        [Fact]
        public void Test02()
        {
            var result = Client.Part1("pqrstuv");
            Assert.Equal(1048970, result);
        }
    }
}