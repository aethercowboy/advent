using advent.Data;
using advent.Days;
using advent.Days._2021;
using Xunit;

namespace advent.tests.Days._2021
{
    public class Day09Tests
    {
        private readonly IDay _day;

        public Day09Tests()
        {
            _day = new Day09();
        }

        [Fact]
        public void Part01Test()
        {
            var input = DayData.LoadFile(2021, "Day09");

            var result = _day.Part1(input);

            Assert.Equal(15.ToString(), result);
        }

        [Fact]
        public void Part02Test()
        {
            var input = DayData.LoadFile(2021, "Day09");

            var result = _day.Part2(input);

            Assert.Equal(1134.ToString(), result);
        }
    }
}
