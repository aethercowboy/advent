using advent.Data;
using advent.Days;
using advent.Days._2020;
using Xunit;

namespace advent.tests.Days._2020
{
    public class Day01Tests
    {
        private readonly IDay day;
        private readonly string data;

        public Day01Tests()
        {
            day = new Day01();
            data = DayData.LoadFile(2020, "Day01");
        }

        [Fact]
        public void Test01()
        {
            var result = day.Part1(data);

            Assert.Equal(514579.ToString(), result);
        }

        [Fact]
        public void Test02()
        {
            var result = day.Part2(data);

            Assert.Equal(241861950.ToString(), result);
        }
    }
}
