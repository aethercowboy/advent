using advent.Days._2015;
using Xunit;

namespace advent.tests.Days._2015
{
    public class Day07Tests : DayTests<Day07>
    {
        private const string Input = @"123 -> x
456 -> y
x AND y -> d
x OR y -> e
x LSHIFT 2 -> f
y RSHIFT 2 -> g
NOT x -> h
NOT y -> i";

        [Fact]
        public void Test01()
        {
            Client.Key = "d";
            var result = Client.Part1(Input);
            Assert.Equal("72", result);
        }

        [Fact]
        public void Test02()
        {
            Client.Key = "e";
            var result = Client.Part1(Input);
            Assert.Equal("507", result);
        }

        [Fact]
        public void Test03()
        {
            Client.Key = "f";
            var result = Client.Part1(Input);
            Assert.Equal(492.ToString(), result);
        }

        [Fact]
        public void Test04()
        {
            Client.Key = "g";
            var result = Client.Part1(Input);
            Assert.Equal(114.ToString(), result);
        }

        [Fact]
        public void Test05()
        {
            Client.Key = "h";
            var result = Client.Part1(Input);
            Assert.Equal(65412.ToString(), result);
        }

        [Fact]
        public void Test06()
        {
            Client.Key = "i";
            var result = Client.Part1(Input);
            Assert.Equal(65079.ToString(), result);
        }

        [Fact]
        public void Test07()
        {
            Client.Key = "x";
            var result = Client.Part1(Input);
            Assert.Equal(123.ToString(), result);
        }

        [Fact]
        public void Test08()
        {
            Client.Key = "y";
            var result = Client.Part1(Input);
            Assert.Equal(456.ToString(), result);
        }

        [Fact]
        public void Test09()
        {
            var result = Client.Part1("NOT 1 -> a");
            Assert.Equal(65534.ToString(), result);
        }
    }
}