using advent.Data;
using advent.Days;
using advent.Days._2020;
using Xunit;

namespace advent.tests.Days._2020
{
    public class Day13Tests
    {
        private readonly IDay day;
        private readonly string data;

        public Day13Tests()
        {
            day = new Day13();
            data = DayData.LoadFile(2020, "Day13");
        }

        [Fact]
        public void Test01()
        {
            var result = day.Part1(data);

            Assert.Equal(295.ToString(), result);
        }

        [Theory]
        [InlineData("7,13,x,x,59,x,31,19", 1068781)]
        [InlineData("17,x,13,19", 3417)]
        [InlineData("67,7,59,61", 754018)]
        [InlineData("67,x,7,59,61", 779210)]
        [InlineData("67,7,x,59,61", 1261476)]
        [InlineData("1789,37,47,1889", 1202161486)]
        public void Test02(string input, long expected)
        {
            input = "0\n" + input; // need to fake a first line
            var result = day.Part2(input);

            Assert.Equal(expected.ToString(), result);
        }
    }
}
