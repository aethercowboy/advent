using advent.Data;
using advent.Days;
using advent.Days._2020;
using advent.Extensions;
using System;
using System.Linq;
using Xunit;

namespace advent.tests.Days._2020
{
    public class Day03Tests
    {
        private readonly IDay day;
        private readonly string data;

        public Day03Tests()
        {
            day = new Day03();
            data = DayData.LoadFile(2020, "Day03");
        }

        [Fact]
        public void Test01()
        {
            var result = day.Part1(data);

            Assert.Equal(7, result);
        }

        [Fact]
        public void Test02()
        {
            var result = day.Part2(data);

            Assert.Equal(336, result);
        }

        [Theory]
        [InlineData(1, 1, 2)]
        [InlineData(3, 1, 7)]
        [InlineData(5, 1, 3)]
        [InlineData(7, 1, 4)]
        [InlineData(1, 2, 2)]
        public void Test03(int x, int y, int expected)
        {
            var lines = data.Lines().ToList();
            var slope = new Tuple<int, int>(x, y);
            var result = Day03.TreesEncountered(lines, slope);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test04()
        {
            const long result = 82L * 173L * 84L * 80L * 46L;

            Assert.Equal(4385176320, result);
        }
    }
}
