using advent.Data;
using advent.Days;
using advent.Days._2020;
using Xunit;

namespace advent.tests.Days._2020
{
    public class Day02Tests
    {
        private readonly IDay day;
        private readonly string data;

        public Day02Tests()
        {
            day = new Day02();
            data = DayData.LoadFile(2020, "Day02");
        }

        [Fact]
        public void Test01()
        {
            var result = day.Part1(data);

            Assert.Equal(2, result);
        }

        [Fact]
        public void Test02()
        {
            var result = day.Part2(data);

            Assert.Equal(1, result);
        }
    }
}
