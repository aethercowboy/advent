using advent.Days._2017;
using Xunit;

namespace advent.tests.Days._2017
{
    public class Day09Tests : DayTests<Day09>
    {
        [Fact]
        public void Test01()
        {
            var result = Client.Part1("{}");
            Assert.Equal(1.ToString(), result);
        }

        [Fact]
        public void Test02()
        {
            var result = Client.Part1("{{{}}}");
            Assert.Equal(6.ToString(), result);
        }

        [Fact]
        public void Test03()
        {
            var result = Client.Part1("{{},{}}");
            Assert.Equal(5.ToString(), result);
        }

        [Fact]
        public void Test04()
        {
            var result = Client.Part1("{{{},{},{{}}}}");
            Assert.Equal(16.ToString(), result);
        }

        [Fact]
        public void Test05()
        {
            var result = Client.Part1("{<a>,<a>,<a>,<a>}");
            Assert.Equal(1.ToString(), result);
        }

        [Fact]
        public void Test06()
        {
            var result = Client.Part1("{{<ab>},{<ab>},{<ab>},{<ab>}}");
            Assert.Equal(9.ToString(), result);
        }

        [Fact]
        public void Test07()
        {
            var result = Client.Part1("{{<!!>},{<!!>},{<!!>},{<!!>}}");
            Assert.Equal(9.ToString(), result);
        }

        [Fact]
        public void Test08()
        {
            var result = Client.Part1("{{<a!>},{<a!>},{<a!>},{<ab>}}");
            Assert.Equal(3.ToString(), result);
        }

        [Fact]
        public void Test09()
        {
            var result = Client.Part2("<>");
            Assert.Equal(0.ToString(), result);
        }

        [Fact]
        public void Test10()
        {
            var result = Client.Part2("<random characters>");
            Assert.Equal(17.ToString(), result);
        }

        [Fact]
        public void Test11()
        {
            var result = Client.Part2("<<<<>");
            Assert.Equal(3.ToString(), result);
        }

        [Fact]
        public void Test12()
        {
            var result = Client.Part2("<{!>}>");
            Assert.Equal(2.ToString(), result);
        }

        [Fact]
        public void Test13()
        {
            var result = Client.Part2("<!!>");
            Assert.Equal(0.ToString(), result);
        }

        [Fact]
        public void Test14()
        {
            var result = Client.Part2("<!!!>>");
            Assert.Equal(0.ToString(), result);
        }

        [Fact]
        public void Test15()
        {
            var result = Client.Part2("<{o\"i!a,<{i<a>");
            Assert.Equal(10.ToString(), result);
        }
    }
}
