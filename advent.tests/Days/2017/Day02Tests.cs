using advent.Days._2017;
using Xunit;

namespace advent.tests.Days._2017
{
    public class Day02Tests : DayTests<Day02>
    {
        [Fact]
        public void Test01()
        {
            const string input = @"5 1 9 5
7 5 3
2 4 6 8";

            var result = Client.Part1(input);

            Assert.Equal(18.ToString(), result);
        }

        [Fact]
        public void Test02()
        {
            const string input = @"5 9 2 8
9 4 7 3
3 8 6 5";

            var result = Client.Part2(input);

            Assert.Equal(9.ToString(), result);
        }
    }
}
