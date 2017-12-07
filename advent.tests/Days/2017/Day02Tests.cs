using advent.Days._2017;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace advent.tests.Days._2017
{
    [TestClass]
    public class Day02Tests :DayTests<Day02>
    {
        [TestMethod]
        public void Test01()
        {
            const string input = @"5 1 9 5
7 5 3
2 4 6 8";

            var result = Client.Part1(input);

            Assert.AreEqual(18, result);
        }

        [TestMethod]
        public void Test02()
        {
            const string input = @"5 9 2 8
9 4 7 3
3 8 6 5";

            var result = Client.Part2(input);

            Assert.AreEqual(9, result);
        }
    }
}
