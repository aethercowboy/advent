using advent.Days._2017;
using Xunit;

namespace advent.tests.Days._2017
{
    public class Day15Tests : DayTests<Day15>
    {
        private const string Input = @"Generator A starts with 65
Generator B starts with 8921";

        [Fact]
        public void Test01()
        {
            var result = Client.Part1(Input);
            Assert.Equal(588, result);
        }

        [Fact]
        public void Test02()
        {
            var result = Client.Part2(Input);
            Assert.Equal(309, result);
        }
    }
}
