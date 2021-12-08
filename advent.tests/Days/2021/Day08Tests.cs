using advent.Data;
using advent.Days;
using advent.Days._2021;
using Xunit;

namespace advent.tests.Days._2021
{
    public class Day08Tests
    {
        private readonly IDay _day;

        public Day08Tests()
        {
            _day = new Day08();
        }

        [Fact]
        public void Part01Test()
        {
            var input = DayData.LoadFile(2021, "Day08");

            var result = _day.Part1(input);

            Assert.Equal(0.ToString(), result);
        }

        [Fact]
        public void Part01LargerTest()
        {
            var input = DayData.LoadFile(2021, "Day08a");

            var result = _day.Part1(input);

            Assert.Equal(26.ToString(), result);
        }

        [Fact]
        public void Part02Test()
        {
            var input = DayData.LoadFile(2021, "Day08");

            var result = _day.Part2(input);

            Assert.Equal(5353.ToString(), result);
        }

        [Fact]
        public void Part02LongerTest()
        {
            var input = DayData.LoadFile(2021, "Day08a");

            var result = _day.Part2(input);

            Assert.Equal(61229.ToString(), result);
        }
    }
}
