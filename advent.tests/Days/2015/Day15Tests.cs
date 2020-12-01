using advent.Days._2015;
using Xunit;

namespace advent.tests.Days._2015
{
    public class Day15Tests : DayTests<Day15>
    {
        private const string Input = @"Butterscotch: capacity -1, durability -2, flavor 6, texture 3, calories 8
Cinnamon: capacity 2, durability 3, flavor -2, texture -1, calories 3";

        [Fact]
        public void Test01()
        {
            var result = Client.Part1(Input);
            Assert.Equal(62842880, result);
        }

        [Fact]
        public void Test02()
        {
            var result = Client.Part2(Input);
            Assert.Equal(57600000, result);
        }
    }
}
