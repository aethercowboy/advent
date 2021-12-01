using advent.Days._2015;
using Xunit;

namespace advent.tests.Days._2015
{
    public class Day14Tests : DayTests<Day14>
    {
        private const string Input = @"Comet can fly 14 km/s for 10 seconds, but then must rest for 127 seconds.
Dancer can fly 16 km/s for 11 seconds, but then must rest for 162 seconds.";

        [Fact]
        public void Test01()
        {
            Client.Runtime = 1000;

            var result = Client.Part1(Input);
            Assert.Equal(1120.ToString(), result);
        }

        [Fact]
        public void Test02()
        {
            Client.Runtime = 1000;
            var result = Client.Part2(Input);
            Assert.Equal(689.ToString(), result);
        }
    }
}
