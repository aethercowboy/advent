using advent.Data;
using advent.Days;
using advent.Days._2020;
using Xunit;

namespace advent.tests.Days._2020
{
    public class Day01Tests
    {
        private readonly IDay day;

        public Day01Tests()
        {
            day = new Day01();
        }

        [Fact]
        public void Test01()
        {
            var data = DayData.LoadFile(2020, "Day01");

            var result = day.Part1(data);

            Assert.Equal(514579, result);
        }
    }
}
