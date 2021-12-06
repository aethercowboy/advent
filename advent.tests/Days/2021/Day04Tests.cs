using advent.Data;
using advent.Days;
using advent.Days._2021;
using advent.tests.Consoles;
using Xunit;
using Xunit.Abstractions;

namespace advent.tests.Days._2021
{
    public class Day04Tests
    {
        private readonly IDay _day;

        public Day04Tests(ITestOutputHelper output)
        {
            _day = new Day04(new TestConsole(output));
        }

        [Fact]
        public void Part01Test()
        {
            var input = DayData.LoadFile(2021, "Day04");

            var result = _day.Part1(input);

            Assert.Equal(4512.ToString(), result);
        }

        [Fact]
        public void Part02Test()
        {
            var input = DayData.LoadFile(2021, "Day04");

            var result = _day.Part2(input);

            Assert.Equal(1924.ToString(), result);
        }
    }
}
