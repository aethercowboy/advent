using advent.Days._2017;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace advent.tests.Days._2017
{
    [TestClass]
    public class Day15Tests : DayTests<Day15>
    {
        private const string Input = @"Generator A starts with 65
Generator B starts with 8921";

        [TestMethod]
        public void Test01()
        {
            var result = Client.Part1(Input);
            Assert.AreEqual(588, result);
        }

        [TestMethod]
        public void Test02()
        {
            var result = Client.Part2(Input);
            Assert.AreEqual(309, result);
        }
    }
}
