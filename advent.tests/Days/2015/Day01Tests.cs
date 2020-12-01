using advent.Days._2015;
using Xunit;

namespace advent.tests.Days._2015
{
    public class Day01Tests : DayTests<Day01>
    {
        [Fact]
        public void Test01()
        {
            var result = Client.Part1("(())");

            Assert.Equal(0, result);

            var result2 = Client.Part1("()()");
            Assert.Equal(0, result2);
        }

        [Fact]
        public void Test02()
        {
            var result = Client.Part1("(((");

            Assert.Equal(3, result);

            var result2 = Client.Part1("(()(()(");
            Assert.Equal(3, result2);
        }

        [Fact]
        public void Test03()
        {
            var result = Client.Part1("))(((((");

            Assert.Equal(3, result);
        }

        [Fact]
        public void Test04()
        {
            var result = Client.Part1("())");

            Assert.Equal(-1, result);

            var result2 = Client.Part1("))(");
            Assert.Equal(-1, result2);
        }

        [Fact]
        public void Test05()
        {
            var result = Client.Part1(")))");

            Assert.Equal(-3, result);

            var result2 = Client.Part1(")())())");
            Assert.Equal(-3, result2);
        }

        [Fact]
        public void Test06()
        {
            var result = Client.Part2(")");

            Assert.Equal(1, result);
        }

        [Fact]
        public void Test07()
        {
            var result = Client.Part2("()())");

            Assert.Equal(5, result);
        }
    }
}