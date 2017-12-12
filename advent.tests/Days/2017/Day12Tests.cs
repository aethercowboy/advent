using advent.Days._2017;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace advent.tests.Days._2017
{
    [TestClass]
    public class Day12Tests : DayTests<Day12>
    {
        private const string Input = @"0 <-> 2
1 <-> 1
2 <-> 0, 3, 4
3 <-> 2, 4
4 <-> 2, 3, 6
5 <-> 6
6 <-> 4, 5";

        [TestMethod]
        public void Test01()
        {
            var result = Client.Part1(Input);
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void Test02()
        {
            var result = Client.Part2(Input);
            Assert.AreEqual(2, result);
        }
    }
}
