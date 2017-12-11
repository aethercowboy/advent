using advent.Days._2017;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace advent.tests.Days._2017
{
    [TestClass]
    public class Day11Tests : DayTests<Day11>
    {
        [TestMethod]
        public void Test01()
        {
            var result = Client.Part1("ne,ne,ne");
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void Test02()
        {
            var result = Client.Part1("ne,ne,sw,sw");
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Test03()
        {
            var result = Client.Part1("ne,ne,s,s");
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void Test04()
        {
            var result = Client.Part1("se,sw,se,sw,sw");
            Assert.AreEqual(3, result);
        }
    }
}
