using advent.Days._2017;
using Xunit;

namespace advent.tests.Days._2017
{
    public class Day05Tests : DayTests<Day05>
    {
        private const string Input = @"0
3
0
1
-3";

        [Fact]
        public void Test01()
        {
            var result = Client.Part1(Input);

            Assert.Equal(5.ToString(), result);
        }

        [Fact]
        public void Test02()
        {
            var result = Client.Part2(Input);

            Assert.Equal(10.ToString(), result);
        }
    }
}
