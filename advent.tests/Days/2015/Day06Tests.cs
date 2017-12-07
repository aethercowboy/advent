using System.IO;
using advent.Data;
using advent.Days._2015;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace advent.tests.Days
{
    [TestClass]
    public class Day06Tests : DayTests<Day06>
    {
        [TestMethod]
        public void Test01()
        {
            var result = Client.Part1("turn on 0,0 through 999,999");
            Assert.AreEqual(1000000, result);
        }

        [TestMethod]
        public void Test02()
        {
            var result = Client.Part1("toggle 0,0 through 999,0");
            Assert.AreEqual(1000, result);
        }

        [TestMethod]
        public void Test03()
        {
            var result = Client.Part1("turn off 499,499 through 500,500");
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Test04()
        {
            var result = Client.Part1(@"turn on 0,0 through 999,999
toggle 0,0 through 999,0
turn off 499,499 through 500,500
");
            Assert.AreEqual(1000000 - 1000 - 4, result);
        }

        [TestMethod]
        public void Test05()
        {
            var result = Client.Part2("turn on 0,0 through 0,0");
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void Test06()
        {
            var result = Client.Part2("toggle 0,0 through 999,999");
            Assert.AreEqual(2000000, result);
        }

        [TestMethod]
        public void Test07()
        {
            var result = Client.Part2(@"turn on 0,0 through 0,0
toggle 0,0 through 999,999
turn off 0,0 through 999,999");
            Assert.AreEqual(1000001, result);
        }

        [TestMethod]
        public void Test08()
        {
            var result = Client.Part2("turn off 0,0 through 999,999");

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Test09()
        {
            var input = DayData.LoadFile(2015, "Day06");
            var result = Client.Part2(input);

            Assert.AreEqual(14687245, result);
        }
    }
}
