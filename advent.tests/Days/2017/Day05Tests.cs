using advent.Days._2017;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace advent.tests.Days._2017
{
    [TestClass]
    public class Day05Tests : DayTests<Day05>
    {
        private const string Input = @"0
3
0
1
-3";

        [TestMethod]
        public void Test01()
        {
            var result = Client.Part1(Input);

            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void Test02()
        {
            var result = Client.Part2(Input);

            Assert.AreEqual(10, result);
        }
    }
}
