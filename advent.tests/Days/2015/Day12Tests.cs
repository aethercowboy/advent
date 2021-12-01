using advent.Days._2015;
using Xunit;

namespace advent.tests.Days._2015
{
    public class Day12Tests : DayTests<Day12>
    {
        [Fact]

        public void Test01()
        {
            var result = Client.Part1("[1,2,3]");
            Assert.Equal(6.ToString(), result);
        }

        [Fact]

        public void Test02()
        {
            var result = Client.Part1("{\"a\":2,\"b\":4}");
            Assert.Equal(6.ToString(), result);
        }

        [Fact]

        public void Test03()
        {
            var result = Client.Part1("[[[3]]]");
            Assert.Equal(3.ToString(), result);
        }

        [Fact]

        public void Test04()
        {
            var result = Client.Part1("{\"a\":{\"b\":4},\"c\":-1}");
            Assert.Equal(3.ToString(), result);
        }

        [Fact]

        public void Test05()
        {
            var result = Client.Part1("{\"a\":[-1,1]}");
            Assert.Equal(0.ToString(), result);
        }

        [Fact]

        public void Test06()
        {
            var result = Client.Part1("[-1,{\"a\":1}]");
            Assert.Equal(0.ToString(), result);
        }

        [Fact]

        public void Test07()
        {
            var result = Client.Part1("[]");
            Assert.Equal(0.ToString(), result);
        }

        [Fact]

        public void Test08()
        {
            var result = Client.Part1("{}");
            Assert.Equal(0.ToString(), result);
        }

        [Fact]

        public void Test09()
        {
            var result = Client.Part2("[1,2,3]");
            Assert.Equal(6.ToString(), result);
        }

        [Fact]

        public void Test10()
        {
            var result = Client.Part2("[1,{\"c\":\"red\",\"b\":2},3]");
            Assert.Equal(4.ToString(), result);
        }

        [Fact]

        public void Test11()
        {
            var result = Client.Part2("{\"d\":\"red\",\"e\":[1,2,3,4],\"f\":5}");
            Assert.Equal(0.ToString(), result);
        }

        [Fact]

        public void Test12()
        {
            var result = Client.Part2("[1,\"red\",5]");
            Assert.Equal(6.ToString(), result);
        }
    }
}
