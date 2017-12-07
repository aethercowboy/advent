using advent.Days._2015;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace advent.tests.Days._2015
{
    [TestClass]
    public class Day05Tests : DayTests<Day05>
    {
        [TestMethod]
        public void Test01()
        {
            var result = Client.Part1("ugknbfddgicrmopn");
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void Test02()
        {
            var result = Client.Part1("aaa");
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void Test03()
        {
            var result = Client.Part1("jchzalrnumimnmhp");
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Test04()
        {
            var result = Client.Part1("haegwjzuvuyypxyu");
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Test05()
        {
            var result = Client.Part1("dvszwmarrgswjxmb");
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Test06()
        {
            var result = Client.Part2("qjhvhtzxzqqjkmpb");
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void Test07()
        {
            var result = Client.Part2("xxyxx");
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void Test08()
        {
            var result = Client.Part2("uurcxstgmygtbstg");
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Test09()
        {
            var result = Client.Part2("ieodomkazucvgmuy");
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Test10()
        {
            var result = Client.Part2("xyxy");
            Assert.AreEqual(1, result);
        }
    }
}
