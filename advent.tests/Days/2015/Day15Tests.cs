using advent.Days._2015;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace advent.tests.Days._2015
{
    [TestClass]
    public class Day15Tests : DayTests<Day15>
    {
        private const string Input = @"Butterscotch: capacity -1, durability -2, flavor 6, texture 3, calories 8
Cinnamon: capacity 2, durability 3, flavor -2, texture -1, calories 3";

        [TestMethod]
        public void Test01()
        {
            Assert.Inconclusive("Still working on it");
            var result = Client.Part1(Input);
            Assert.AreEqual(62842880, result);
        }
    }
}
