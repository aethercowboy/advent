using advent.Days._2017;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace advent.tests.Days._2017
{
    [TestClass]
    public class Day13Tests : DayTests<Day13>
    {
        private const string Input = @"0: 3
1: 2
4: 4
6: 4";

        [TestMethod]
        public void Test01()
        {
            var result = Client.Part1(Input);
            Assert.AreEqual(24, result);
        }

        [TestMethod]
        public void Test02()
        {
            var result = Client.Part2(Input);
            Assert.AreEqual(10, result);
        }
    }
}
