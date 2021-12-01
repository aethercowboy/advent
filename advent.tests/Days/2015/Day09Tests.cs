using advent.Days._2015;
using Xunit;

namespace advent.tests.Days._2015
{
    public class Day09Tests : DayTests<Day09>
    {
        private readonly string input = @"London to Dublin = 464
London to Belfast = 518
Dublin to Belfast = 141";

        [Fact]
        public void Test01()
        {
            var response = Client.Part1(input);
            Assert.Equal(605.ToString(), response);
        }

        [Fact]
        public void Test02()
        {
            var response = Client.Part2(input);
            Assert.Equal(982.ToString(), response);
        }
    }
}