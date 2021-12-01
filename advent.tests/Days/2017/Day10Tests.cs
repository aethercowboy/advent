using advent.Days._2017;
using advent.Extensions;
using System.Linq;
using Xunit;

namespace advent.tests.Days._2017
{
    public class Day10Tests : DayTests<Day10>
    {
        [Fact]
        public void Test01()
        {
            const string input = "3, 4, 1, 5";

            Client.List = Enumerable.Range(0, 5).ToRing();

            var result = Client.Part1(input);

            Assert.Equal(12.ToString(), result);
        }

        [Fact]
        public void Test02()
        {
            Client.Part2(string.Empty);
            Assert.Equal("a2582a3a0e66e6e86e3812dcb672a272", Output);
        }

        [Fact]
        public void Test03()
        {
            Client.Part2("AoC 2017");
            Assert.Equal("33efeb34ea91902bb2f59c9920caa6cd", Output);
        }

        [Fact]
        public void Test04()
        {
            Client.Part2("1,2,3");
            Assert.Equal("3efbe78a8d82f29979031a4aa0b16a9d", Output);
        }

        [Fact]
        public void Test05()
        {
            Client.Part2("1,2,4");
            Assert.Equal("63960835bcdc130f0b66d7ff4f6a5a8e", Output);
        }
    }
}
