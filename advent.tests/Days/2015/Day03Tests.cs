using advent.Days._2015;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace advent.tests.Days._2015
{
    [TestClass]
    public class Day03Tests : DayTests<Day03>
    {
        [TestMethod]
        public void Test01()
        {
            var result = Client.Part1(">");
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void Test02()
        {
            var result = Client.Part1("^>v<");
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void Test03()
        {
            var result = Client.Part1("^v^v^v^v^v");
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void Test04()
        {
            var result = Client.Part2("^v");
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void Test05()
        {
            var result = Client.Part2("^>v<");
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void Test06()
        {
            var result = Client.Part2("^v^v^v^v^v");
            Assert.AreEqual(11, result);
        }
    }
}
