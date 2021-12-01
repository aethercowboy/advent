using advent.Data;
using advent.Days;
using advent.Days._2020;
using Xunit;

namespace advent.tests.Days._2020
{
    public class Day04Tests
    {
        private readonly IDay day;
        private readonly string data;

        public Day04Tests()
        {
            day = new Day04();
            data = DayData.LoadFile(2020, "Day04");
        }

        [Fact]
        public void Test01()
        {
            var result = day.Part1(data);

            Assert.Equal(2.ToString(), result);
        }
    }
}
