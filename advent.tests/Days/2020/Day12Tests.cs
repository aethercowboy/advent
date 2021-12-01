using advent.Data;
using advent.Days;
using advent.Days._2020;
using Xunit;

namespace advent.tests.Days._2020
{
    public class Day12Tests
    {
        private readonly IDay day;
        private readonly string data;

        public Day12Tests()
        {
            day = new Day12();
            data = DayData.LoadFile(2020, "Day12");
        }

        [Fact]
        public void Test01()
        {
            var result = day.Part1(data);

            Assert.Equal(25.ToString(), result);
        }

        [Fact]
        public void Test02()
        {
            var result = day.Part2(data);

            Assert.Equal(286.ToString(), result);
        }
    }
}
