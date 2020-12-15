using advent.Data;
using advent.Days;
using advent.Days._2020;
using Xunit;

namespace advent.tests.Days._2020
{
    public class Day14Tests
    {
        private readonly IDay _day;
        private readonly string _data;
        private readonly string _data2;

        public Day14Tests()
        {
            _day = new Day14();
            _data = DayData.LoadFile(2020, "Day14");
            _data2 = DayData.LoadFile(2020, "Day14-a");
        }

        [Fact]
        public void Test01()
        {
            var result = _day.Part1(_data);

            Assert.Equal(165, result);
        }

        [Fact]
        public void Test02()
        {
            var result = _day.Part2(_data2);

            Assert.Equal(208, result);
        }
    }
}
