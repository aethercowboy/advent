using advent.Data;
using advent.Days;
using advent.Days._2021;
using Xunit;

namespace advent.tests.Days._2021
{
    public class Day10Tests
    {
        private readonly IDay _day;

        public Day10Tests()
        {
            _day = new Day10();
        }

        [Fact]
        public void Part01Test()
        {
            var input = DayData.LoadFile(2021, "Day10");

            var result = _day.Part1(input);

            Assert.Equal(26397.ToString(), result);
        }

        [Fact]
        public void Part02Test()
        {
            var input = DayData.LoadFile(2021, "Day10");

            var result = _day.Part2(input);

            Assert.Equal(288957.ToString(), result);
        }
    }
}
