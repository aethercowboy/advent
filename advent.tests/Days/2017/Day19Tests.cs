using advent.Days._2017;
using Xunit;

namespace advent.tests.Days._2017
{
    public class Day19Tests : DayTests<Day19>
    {
        public string input = @"     |          
     |  +--+    
     A  |  C    
 F---|----E|--+ 
     |  |  |  D 
     +B-+  +--+ ";

        [Fact]
        public void Test01()
        {
            Client.Part1(input);
            Assert.Equal("ABCDEF", Output);
        }

        [Fact]
        public void Test02()
        {
            var result = Client.Part2(input);
            Assert.Equal(38, result);
        }
    }
}
