using System.Linq;
using advent.Days._2017;
using advent.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace advent.tests.Days._2017
{
    [TestClass]
    public class Day10Tests : DayTests<Day10>
    {
        [TestMethod]
        public void Test01()
        {
            const string input = "3, 4, 1, 5";

            Client.List = Enumerable.Range(0, 5).ToRing();

            var result = Client.Part1(input);

            Assert.AreEqual(12, result);
        }

        [TestMethod]
        public void Test02()
        {
            Client.Part2(string.Empty);
            Assert.AreEqual("a2582a3a0e66e6e86e3812dcb672a272", Output);
        }


        [TestMethod]
        public void Test03()
        {
            Client.Part2("AoC 2017");
            Assert.AreEqual("33efeb34ea91902bb2f59c9920caa6cd", Output);
        }

        [TestMethod]
        public void Test04()
        {
            Client.Part2("1,2,3");
            Assert.AreEqual("3efbe78a8d82f29979031a4aa0b16a9d", Output);
        }

        [TestMethod]
        public void Test05()
        {
            Client.Part2("1,2,4");
            Assert.AreEqual("63960835bcdc130f0b66d7ff4f6a5a8e", Output);
        }
    }
}
