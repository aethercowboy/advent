using advent.Data;
using advent.Days;
using advent.Days._2021;
using Xunit;

namespace advent.tests.Days._2021
{
    public class Day03Tests
    {
        private readonly IDay _day;

        public Day03Tests()
        {
            _day = new Day03();
        }

        [Fact]
        public void Part01Test()
        {
            var input = DayData.LoadFile(2021, "Day03");

            var result = _day.Part1(input);

            Assert.Equal(198.ToString(), result);
        }

        [Fact]
        public void Part02Test()
        {
            var input = DayData.LoadFile(2021, "Day03");

            var result = _day.Part2(input);

            Assert.Equal(230.ToString(), result);
        }
    }
}
