using advent.Data;
using advent.Days;
using advent.Days._2020;
using Xunit;

namespace advent.tests.Days._2020
{
    public class Day07Tests
    {
        private readonly IDay day;
        private readonly string data;

        public Day07Tests()
        {
            day = new Day07();
            data = DayData.LoadFile(2020, "Day07");
        }

        [Fact]
        public void Test01()
        {
            var result = day.Part1(data);

            Assert.Equal(4, result);
        }

        [Fact]
        public void Test02()
        {
            var moreData = DayData.LoadFile(2020, "Day07-a");

            var result = day.Part1(moreData);

            Assert.Equal(302, result);
        }

        [Fact]
        public void Test03()
        {
            var result = day.Part2(data);

            Assert.Equal(32, result);
        }

        [Fact]
        public void Test04()
        {
            var moreData = DayData.LoadFile(2020, "Day07-b");

            var result = day.Part2(moreData);

            Assert.Equal(126, result);
        }
    }
}
