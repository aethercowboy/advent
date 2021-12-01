using advent.Data;
using advent.Days;
using advent.Days._2020;
using Xunit;

namespace advent.tests.Days._2020
{
    public class Day17Tests
    {
        private readonly IDay day;
        private readonly string data;

        public Day17Tests()
        {
            day = new Day17();
            data = DayData.LoadFile(2020, "Day17");
        }

        [Fact]
        public void Test01()
        {
            var result = day.Part1(data);

            Assert.Equal(112.ToString(), result);
        }
    }
}
