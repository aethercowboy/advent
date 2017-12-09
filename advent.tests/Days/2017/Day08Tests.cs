using advent.Days._2017;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace advent.tests.Days._2017
{
    [TestClass]
    public class Day08Tests : DayTests<Day08>
    {
        private const string Input = @"b inc 5 if a > 1
a inc 1 if b < 5
c dec -10 if a >= 1
c inc -20 if c == 10";

        [TestMethod]
        public void Test01()
        {
            var result = Client.Part1(Input);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void Test02()
        {
            var result = Client.Part2(Input);
            Assert.AreEqual(10, result);
        }
    }
}
