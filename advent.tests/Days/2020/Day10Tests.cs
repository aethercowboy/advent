using advent.Data;
using advent.Days;
using advent.Days._2020;
using Xunit;

namespace advent.tests.Days._2020
{
    public class Day10Tests
    {
        private readonly IDay day;
        private readonly string data;
        private readonly string data2;

        public Day10Tests()
        {
            day = new Day10();
            data = DayData.LoadFile(2020, "Day10");
            data2 = DayData.LoadFile(2020, "Day10-a");
        }

        [Fact]
        public void Test01()
        {
            var result = day.Part1(data);

            Assert.Equal(35.ToString(), result);
        }

        [Fact]
        public void Test02()
        {
            var result = day.Part1(data2);

            Assert.Equal(220.ToString(), result);
        }

        [Fact]
        public void Test03()
        {
            var result = day.Part2(data);

            Assert.Equal(8.ToString(), result);
        }

        [Fact]
        public void Test04()
        {
            var result = day.Part2(data2);

            Assert.Equal(19208.ToString(), result);
        }
    }
}
