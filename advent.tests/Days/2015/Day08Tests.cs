using advent.Data;
using advent.Days._2015;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace advent.tests.Days
{
    [TestClass]
    public class Day08Tests : DayTests<Day08>
    {
        private string input = DayData.LoadFile(2015, "Day08");

        [TestMethod]
        public void Test01()
        {

            var result = Client.Part1(input);
            Assert.AreEqual(12, result);
        }

        [TestMethod]
        public void Test02()
        {
            var result = Client.Part2(input);
            Assert.AreEqual(19, result);
        }
    }
}