using advent.Days._2017;
using Xunit;

namespace advent.tests.Days._2017
{
    public class Day12Tests : DayTests<Day12>
    {
        private const string Input = @"0 <-> 2
1 <-> 1
2 <-> 0, 3, 4
3 <-> 2, 4
4 <-> 2, 3, 6
5 <-> 6
6 <-> 4, 5";

        [Fact]
        public void Test01()
        {
            var result = Client.Part1(Input);
            Assert.Equal(6, result);
        }

        [Fact]
        public void Test02()
        {
            var result = Client.Part2(Input);
            Assert.Equal(2, result);
        }
    }
}
