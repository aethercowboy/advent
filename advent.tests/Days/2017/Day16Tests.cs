using advent.Days._2017;
using Xunit;

namespace advent.tests.Days._2017
{
    public class Day16Tests : DayTests<Day16>
    {
        public string input = "s1,x3/4,pe/b";

        public Day16Tests()
        {
            Client.Dancers = "abcde";
        }

        [Fact]
        public void Test01()
        {
            Client.Part1(input);
            Assert.Equal("baedc", Output);
        }

        [Fact]
        public void Test02()
        {
            var result = Client.Dance(input, 2);
            Assert.Equal("ceadb", result);
        }
    }
}
