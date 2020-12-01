using advent.Days._2015;
using Xunit;

namespace advent.tests.Days._2015
{
    public class Day11Tests : DayTests<Day11>
    {
        public Day11Tests()
        {
            Client.Console.Wrote += OnWrote;
        }

        [Fact]
        public void Test01()
        {
            var result = Client.Part1("abcdefgh");
            Assert.Equal(1, result);
            Assert.Equal("abcdffaa", Output);
        }

        [Fact]
        public void Test02()
        {
            var result = Client.Part1("ghijklmn");
            Assert.Equal(1, result);
            Assert.Equal("ghjaabcc", Output);
        }

        [Fact]
        public void Test03()
        {
            var result = Client.IsEightCharacters("abcdefgh");
            Assert.True(result);
        }

        [Fact]
        public void Test04()
        {
            const string input = "hijklmmn";

            var result = Client.HasOneIncreasingStraight(input);
            Assert.True(result);

            result = Client.DoesNotHaveILO(input);
            Assert.False(result);
        }

        [Fact]
        public void Test05()
        {
            const string input = "abbceffg";

            var result = Client.HasTwoNonOverlappingPairsOfLetters(input);
            Assert.True(result);

            result = Client.HasOneIncreasingStraight(input);
            Assert.False(result);
        }

        [Fact]
        public void Test06()
        {
            const string input = "abbcegjk";

            var result = Client.HasTwoNonOverlappingPairsOfLetters(input);
            Assert.False(result);
        }
    }
}
