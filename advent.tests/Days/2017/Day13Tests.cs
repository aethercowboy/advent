using advent.Days._2017;
using Xunit;

namespace advent.tests.Days._2017
{
    public class Day13Tests : DayTests<Day13>
    {
        private const string Input = @"0: 3
1: 2
4: 4
6: 4";

        [Fact]
        public void Test01()
        {
            var result = Client.Part1(Input);
            Assert.Equal(24, result);
        }

        [Fact]
        public void Test02()
        {
            var result = Client.Part2(Input);
            Assert.Equal(10, result);
        }
    }
}
