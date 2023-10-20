using advent.Data;
using advent.Days;
using advent.Days._2021;
using Xunit;

namespace advent.tests.Days._2021
{
    public class Day11Tests
    {
        private readonly IDay _day;

        public Day11Tests()
        {
            _day = new Day11();
        }

        [Fact]
        public void Part01Test()
        {
            var input = DayData.LoadFile(2021, "Day11");

            var result = _day.Part1(input);

            Assert.Equal(1656.ToString(), result);
        }

        //[Fact]
        //public void Part02Test()
        //{
        //    var input = DayData.LoadFile(2021, "Day11");

        //    var result = _day.Part2(input);

        //    Assert.Equal(288957.ToString(), result);
        //}
    }
}
