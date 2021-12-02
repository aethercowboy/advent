using advent.Data;
using advent.Days;
using advent.Days._2021;
using Xunit;

namespace advent.tests.Days._2021
{
    public class Day02Tests
    {
        private readonly IDay _day;

        public Day02Tests()
        {
            _day = new Day02();
        }

        [Fact]
        public void Part01Test()
        {
            var input = DayData.LoadFile(2021, "Day02");

            var result = _day.Part1(input);

            Assert.Equal(150.ToString(), result);
        }

        [Fact]
        public void Part02Test()
        {
            var input = DayData.LoadFile(2021, "Day02");

            var result = _day.Part2(input);

            Assert.Equal(900.ToString(), result);
        }
    }
}
