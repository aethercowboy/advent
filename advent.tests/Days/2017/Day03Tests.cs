using advent.Days._2017;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace advent.tests.Days._2017
{
    [TestClass]
    public class Day03Tests : DayTests<Day03>
    {
        [TestMethod]
        public void Test01()
        {
            var result = Client.Part1("1");
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Test02()
        {
            var result = Client.Part1("12");
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void Test03()
        {
            var result = Client.Part1("23");
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void Test04()
        {
            var result = Client.Part1("1024");
            Assert.AreEqual(31, result);
        }

        [TestMethod]
        public void Test05()
        {
            var result = Client.Part2("1");
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void Test06()
        {
            var result = Client.Part2("2");
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void Test07()
        {
            var result = Client.Part2("4");
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void Test08()
        {
            var result = Client.Part2("5");
            Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void Test09()
        {
            var result = Client.Part2("10");
            Assert.AreEqual(11, result);
        }

        [TestMethod]
        public void Test10()
        {
            var result = Client.Part2("11");
            Assert.AreEqual(23, result);
        }
    }
}
