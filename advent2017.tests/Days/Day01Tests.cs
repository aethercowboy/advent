using advent2017.Days;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace advent2017.tests.Days
{
    [TestClass]
    public class UnitTest1
    {
        private Day01 _client;

        [TestInitialize]
        public void Startup()
        {
            _client = new Day01();
        }

        [TestMethod]
        public void Test01()
        {
            var result = _client.Part1("1122");

            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void Test02()
        {
            var result = _client.Part1("1111");
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void Test03()
        {
            var result = _client.Part1("1234");
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Test04()
        {
            var result = _client.Part1("91212129");
            Assert.AreEqual(9, result);
        }

        [TestMethod]
        public void Test05()
        {
            var result = _client.Part2("1212");
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void Test06()
        {
            var result = _client.Part2("1221");
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Test07()
        {
            var result = _client.Part2("123425");
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void Test08()
        {
            var result = _client.Part2("123123");
            Assert.AreEqual(12, result);
        }

        [TestMethod]
        public void Test09()
        {
            var result = _client.Part2("12131415");
            Assert.AreEqual(4, result);
        }
    }
}