using advent.Days._2015;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace advent.tests.Days._2015
{
    [TestClass]
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

        [TestMethod]
        public void Test01()
        {
            Client.Key = "d";
            var result = Client.Part1(Input);
            Assert.AreEqual(72, result);
        }

        [TestMethod]
        public void Test02()
        {
            Client.Key = "e";
            var result = Client.Part1(Input);
            Assert.AreEqual(507, result);
        }

        [TestMethod]
        public void Test03()
        {
            Client.Key = "f";
            var result = Client.Part1(Input);
            Assert.AreEqual(492, result);
        }

        [TestMethod]
        public void Test04()
        {
            Client.Key = "g";
            var result = Client.Part1(Input);
            Assert.AreEqual(114, result);
        }

        [TestMethod]
        public void Test05()
        {
            Client.Key = "h";
            var result = Client.Part1(Input);
            Assert.AreEqual(65412, result);
        }

        [TestMethod]
        public void Test06()
        {
            Client.Key = "i";  
            var result = Client.Part1(Input);
            Assert.AreEqual(65079, result);
        }

        [TestMethod]
        public void Test07()
        {
            Client.Key = "x";
            var result = Client.Part1(Input);
            Assert.AreEqual(123, result);
        }

        [TestMethod]
        public void Test08()
        {
            Client.Key = "y";
            var result = Client.Part1(Input);
            Assert.AreEqual(456, result);
        }

        [TestMethod]
        public void Test09()
        {
            var result = Client.Part1("NOT 1 -> a");
            Assert.AreEqual(65534, result);
        }
    }
}