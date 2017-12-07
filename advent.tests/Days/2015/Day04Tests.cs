using advent.Days._2015;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace advent.tests.Days._2015
{
    [TestClass]
    public class Day04Tests : DayTests<Day04>
    {
        [TestMethod]
        public void Test01()
        {
            var result = Client.Part1("abcdef");
            Assert.AreEqual(609043, result);
        }

        [TestMethod]
        public void Test02()
        {
            var result = Client.Part1("pqrstuv");
            Assert.AreEqual(1048970, result);
        }
    }
}