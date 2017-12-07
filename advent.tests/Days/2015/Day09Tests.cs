using advent.Days._2015;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace advent.tests.Days._2015
{
    [TestClass]
    public class Day09Tests : DayTests<Day09>
    {
        private string input = @"London to Dublin = 464
London to Belfast = 518
Dublin to Belfast = 141";

        [TestMethod]
        public void Test01()
        {
            var response = Client.Part1(input);
            Assert.AreEqual(605, response);
        }

        [TestMethod]
        public void Test02()
        {
            var response = Client.Part2(input);
            Assert.AreEqual(982, response);
        }
    }
}