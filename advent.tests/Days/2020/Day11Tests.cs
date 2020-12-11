using advent.Data;
using advent.Days;
using advent.Days._2020;
using Xunit;

namespace advent.tests.Days._2020
{
    public class Day11Tests
    {
        private readonly IDay day;
        private readonly string data;

        public Day11Tests()
        {
            day = new Day11();
            data = DayData.LoadFile(2020, "Day11");
        }

        [Fact]
        public void Test01()
        {
            var result = day.Part1(data);

            Assert.Equal(37, result);
        }

        [Fact]
        public void Test02()
        {
            var result = day.Part2(data);

            Assert.Equal(26, result);
        }
    }
}
