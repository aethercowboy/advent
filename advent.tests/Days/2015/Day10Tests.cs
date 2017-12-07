using advent.Days._2015;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace advent.tests.Days._2015
{
    [TestClass]
    public class Day10Tests : DayTests<Day10>
    {
        [TestMethod]
        public void Test01()
        {
            Client.Generations = 1;
            var result = Client.Part1("1");
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void Test02()
        {
            Client.Generations = 1;
            var result = Client.Part1("11");
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void Test03()
        {
            Client.Generations = 1;
            var result = Client.Part1("21");
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void Test04()
        {
            Client.Generations = 1;
            var result = Client.Part1("1211");
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void Test05()
        {
            Client.Generations = 1;
            var result = Client.Part1("111221");
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void Test06()
        {
            Client.Generations = 5;
            var result = Client.Part1("1");
            Assert.AreEqual(6, result);
        }
    }
}
