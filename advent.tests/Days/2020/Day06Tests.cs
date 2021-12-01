using advent.Data;
using advent.Days;
using advent.Days._2020;
using Xunit;

namespace advent.tests.Days._2020
{
    public class Day06Tests
    {
        private readonly IDay day;
        private readonly string data;

        public Day06Tests()
        {
            day = new Day06();
            data = DayData.LoadFile(2020, "Day06");
        }

        [Fact]
        public void Test01()
        {
            const string input = @"abcx
abcy
abcz";

            var result = day.Part1(input);

            Assert.Equal(6.ToString(), result);
        }

        [Fact]
        public void Test02()
        {
            var result = day.Part1(data);

            Assert.Equal(11.ToString(), result);
        }

        [Fact]
        public void Test03()
        {
            var result = day.Part2(data);

            Assert.Equal(6.ToString(), result);
        }
    }
}
