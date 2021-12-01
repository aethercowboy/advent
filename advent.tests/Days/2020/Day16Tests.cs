using advent.Data;
using advent.Days;
using advent.Days._2020;
using Xunit;

namespace advent.tests.Days._2020
{
    public class Day16Tests
    {
        private readonly IDay day;
        private readonly string data;

        public Day16Tests()
        {
            day = new Day16();
            data = DayData.LoadFile(2020, "Day16");
        }

        [Fact]
        public void Test01()
        {
            var result = day.Part1(data);

            Assert.Equal(71.ToString(), result);
        }
    }
}
