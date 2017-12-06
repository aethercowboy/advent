using advent2017.Days;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace advent2017.tests.Days
{
    [TestClass]
    public class Day06Tests : DayTests<Day06>
    {
        [TestMethod]
        public void Test01()
        {
            var response = Client.Part1("0 2 7 0");
            Assert.AreEqual(5, response);
        }

        [TestMethod]
        public void Test02()
        {
            var response = Client.Part2("0 2 7 0");
            Assert.AreEqual(4, response);
        }
    }
}
