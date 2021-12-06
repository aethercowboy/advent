using advent.Data;
using advent.Days;
using advent.Days._2021;
using Xunit;

namespace advent.tests.Days._2021
{
    public class Day06Tests
    {
        private readonly IDay _day;

        public Day06Tests()
        {
            _day = new Day06();
        }

        [Fact]
        public void Part01Test()
        {
            var input = DayData.LoadFile(2021, "Day06");

            var result = _day.Part1(input);

            Assert.Equal(5934.ToString(), result);
        }

        [Fact]
        public void Part02Test()
        {
            var input = DayData.LoadFile(2021, "Day06");

            var result = _day.Part2(input);

            Assert.Equal(26984457539.ToString(), result);
        }
    }
}
