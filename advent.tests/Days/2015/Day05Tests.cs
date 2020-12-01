using advent.Days._2015;
using Xunit;

namespace advent.tests.Days._2015
{
    public class Day05Tests : DayTests<Day05>
    {
        [Fact]
        public void Test01()
        {
            var result = Client.Part1("ugknbfddgicrmopn");
            Assert.Equal(1, result);
        }

        [Fact]
        public void Test02()
        {
            var result = Client.Part1("aaa");
            Assert.Equal(1, result);
        }

        [Fact]
        public void Test03()
        {
            var result = Client.Part1("jchzalrnumimnmhp");
            Assert.Equal(0, result);
        }

        [Fact]
        public void Test04()
        {
            var result = Client.Part1("haegwjzuvuyypxyu");
            Assert.Equal(0, result);
        }

        [Fact]
        public void Test05()
        {
            var result = Client.Part1("dvszwmarrgswjxmb");
            Assert.Equal(0, result);
        }

        [Fact]
        public void Test06()
        {
            var result = Client.Part2("qjhvhtzxzqqjkmpb");
            Assert.Equal(1, result);
        }

        [Fact]
        public void Test07()
        {
            var result = Client.Part2("xxyxx");
            Assert.Equal(1, result);
        }

        [Fact]
        public void Test08()
        {
            var result = Client.Part2("uurcxstgmygtbstg");
            Assert.Equal(0, result);
        }

        [Fact]
        public void Test09()
        {
            var result = Client.Part2("ieodomkazucvgmuy");
            Assert.Equal(0, result);
        }

        [Fact]
        public void Test10()
        {
            var result = Client.Part2("xyxy");
            Assert.Equal(1, result);
        }
    }
}
