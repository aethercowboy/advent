using advent.Days._2015;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace advent.tests.Days._2015
{
    [TestClass]
    public class Day02Tests : DayTests<Day02>
    {
        [TestMethod]
        public void Test01()
        {
            var result = Client.Part1("2x3x4");
            Assert.AreEqual(58, result);
        }

        [TestMethod]
        public void Test02()
        {
            var result = Client.Part1("1x1x10");
            Assert.AreEqual(43, result);
        }

        [TestMethod]
        public void Test03()
        {
            var result = Client.Part2("2x3x4");
            Assert.AreEqual(34, result);
        }

        [TestMethod]
        public void Test04()
        {
            var result = Client.Part2("1x1x10");
            Assert.AreEqual(14, result);
        }
    }
}