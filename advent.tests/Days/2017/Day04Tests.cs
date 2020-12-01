using advent.Days._2017;
using Xunit;

namespace advent.tests.Days._2017
{
    public class Day04Tests : DayTests<Day04>
    {
        [Fact]
        public void Test01()
        {
            const string input = "aa bb cc dd ee";
            var result = Client.Part1(input);
            Assert.Equal(1, result);
        }

        [Fact]
        public void Test02()
        {
            const string input = "aa bb cc dd aa";
            var result = Client.Part1(input);
            Assert.Equal(0, result);
        }

        [Fact]
        public void Test03()
        {
            const string input = "aa bb cc dd aaa";
            var result = Client.Part1(input);
            Assert.Equal(1, result);
        }

        [Fact]
        public void Test04()
        {
            const string input = @"aa bb cc dd ee 
aa bb cc dd aa 
aa bb cc dd aaa";
            var result = Client.Part1(input);
            Assert.Equal(2, result);
        }

        [Fact]
        public void Test05()
        {
            const string input = "abcde fghij";
            var result = Client.Part2(input);
            Assert.Equal(1, result);
        }

        [Fact]
        public void Test06()
        {
            const string input = "abcde xyz ecdab";
            var result = Client.Part2(input);
            Assert.Equal(0, result);
        }

        [Fact]
        public void Test07()
        {
            const string input = "a ab abc abd abf abj";
            var result = Client.Part2(input);
            Assert.Equal(1, result);
        }

        [Fact]
        public void Test08()
        {
            const string input = "iiii oiii ooii oooi oooo";
            var result = Client.Part2(input);
            Assert.Equal(1, result);
        }

        [Fact]
        public void Test09()
        {
            const string input = "oiii ioii iioi iiio";
            var result = Client.Part2(input);
            Assert.Equal(0, result);
        }

        [Fact]
        public void Test10()
        {
            const string input = @"abcde fghij             
abcde xyz ecdab         
a ab abc abd abf abj    
iiii oiii ooii oooi oooo
oiii ioii iioi iiio";
            var result = Client.Part2(input);
            Assert.Equal(3, result);
        }
    }
}
