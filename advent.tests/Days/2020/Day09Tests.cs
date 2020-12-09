using advent.Data;
using advent.Days._2020;
using Xunit;

namespace advent.tests.Days._2020
{
    public class Day09Tests
    {
        private readonly Day09 day;
        private readonly string data;

        public Day09Tests()
        {
            day = new Day09();

            day.PreambleLength = 5;

            data = DayData.LoadFile(2020, "Day09");
        }

        [Fact]
        public void Test01()
        {
            var result = day.Part1(data);

            Assert.Equal(127, result);
        }

        [Fact]
        public void Test02()
        {
            var result = day.Part2(data);

            Assert.Equal(62, result);
        }
    }
}
