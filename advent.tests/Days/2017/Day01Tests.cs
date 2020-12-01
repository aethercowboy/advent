using advent.Days._2017;
using Xunit;

namespace advent.tests.Days._2017
{
    public class Day01Tests : DayTests<Day01>
    {
        [Fact]
        public void Test01()
        {
            var result = Client.Part1("1122");

            Assert.Equal(3, result);
        }

        [Fact]
        public void Test02()
        {
            var result = Client.Part1("1111");
            Assert.Equal(4, result);
        }

        [Fact]
        public void Test03()
        {
            var result = Client.Part1("1234");
            Assert.Equal(0, result);
        }

        [Fact]
        public void Test04()
        {
            var result = Client.Part1("91212129");
            Assert.Equal(9, result);
        }

        [Fact]
        public void Test05()
        {
            var result = Client.Part2("1212");
            Assert.Equal(6, result);
        }

        [Fact]
        public void Test06()
        {
            var result = Client.Part2("1221");
            Assert.Equal(0, result);
        }

        [Fact]
        public void Test07()
        {
            var result = Client.Part2("123425");
            Assert.Equal(4, result);
        }

        [Fact]
        public void Test08()
        {
            var result = Client.Part2("123123");
            Assert.Equal(12, result);
        }

        [Fact]
        public void Test09()
        {
            var result = Client.Part2("12131415");
            Assert.Equal(4, result);
        }
    }
}