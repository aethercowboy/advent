using advent.Days;
using advent.Days._2020;
using Xunit;

namespace advent.tests.Days._2020
{
    public class Day15Tests
    {
        private readonly IDay _day;

        public Day15Tests()
        {
            _day = new Day15();
        }

        [Theory]
        [InlineData("0,3,6", 436)]
        [InlineData("1,3,2", 1)]
        [InlineData("2,1,3", 10)]
        [InlineData("1,2,3", 27)]
        [InlineData("2,3,1", 78)]
        [InlineData("3,2,1", 438)]
        [InlineData("3,1,2", 1836)]
        public void Test01(string input, int expected)
        {
            var result = _day.Part1(input);

            Assert.Equal(expected.ToString(), result);
        }

        [Theory]
        [InlineData("0,3,6", 175594)]
        [InlineData("1,3,2", 2578)]
        [InlineData("2,1,3", 3544142)]
        [InlineData("1,2,3", 261214)]
        [InlineData("2,3,1", 6895259)]
        [InlineData("3,2,1", 18)]
        [InlineData("3,1,2", 362)]
        public void Test02(string input, int expected)
        {
            var result = _day.Part2(input);

            Assert.Equal(expected.ToString(), result);
        }
    }
}
