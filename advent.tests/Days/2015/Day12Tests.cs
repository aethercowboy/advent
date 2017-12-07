using advent.Days._2015;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace advent.tests.Days._2015
{
    [TestClass]
    public class Day12Tests :DayTests<Day12>
    {
        [TestMethod]

        public void Test01()
        {
            var result = Client.Part1("[1,2,3]");
            Assert.AreEqual(6, result);
        }

        [TestMethod]

        public void Test02()
        {
            var result = Client.Part1("{\"a\":2,\"b\":4}");
            Assert.AreEqual(6, result);
        }

        [TestMethod]

        public void Test03()
        {
            var result = Client.Part1("[[[3]]]");
            Assert.AreEqual(3, result);
        }

        [TestMethod]

        public void Test04()
        {
            var result = Client.Part1("{\"a\":{\"b\":4},\"c\":-1}");
            Assert.AreEqual(3, result);
        }

        [TestMethod]

        public void Test05()
        {
            var result = Client.Part1("{\"a\":[-1,1]}");
            Assert.AreEqual(0, result);
        }

        [TestMethod]

        public void Test06()
        {
            var result = Client.Part1("[-1,{\"a\":1}]");
            Assert.AreEqual(0, result);
        }

        [TestMethod]

        public void Test07()
        {
            var result = Client.Part1("[]");
            Assert.AreEqual(0, result);
        }

        [TestMethod]

        public void Test08()
        {
            var result = Client.Part1("{}");
            Assert.AreEqual(0, result);
        }

        [TestMethod]

        public void Test09()
        {
            var result = Client.Part2("[1,2,3]");
            Assert.AreEqual(6, result);
        }

        [TestMethod]

        public void Test10()
        {
            var result = Client.Part2("[1,{\"c\":\"red\",\"b\":2},3]");
            Assert.AreEqual(4, result);
        }

        [TestMethod]

        public void Test11()
        {
            var result = Client.Part2("{\"d\":\"red\",\"e\":[1,2,3,4],\"f\":5}");
            Assert.AreEqual(0, result);
        }

        [TestMethod]

        public void Test12()
        {
            var result = Client.Part2("[1,\"red\",5]");
            Assert.AreEqual(6, result);
        }
    }
}
