using advent.Days._2017;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace advent.tests.Days._2017
{
    [TestClass]
    public class Day04Tests : DayTests<Day04>
    {
        [TestMethod]
        public void Test01()
        {
            const string input = "aa bb cc dd ee";
            var result = Client.Part1(input);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void Test02()
        {
            const string input = "aa bb cc dd aa";
            var result = Client.Part1(input);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Test03()
        {
            const string input = "aa bb cc dd aaa";
            var result = Client.Part1(input);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void Test04()
        {
            const string input = @"aa bb cc dd ee 
aa bb cc dd aa 
aa bb cc dd aaa";
            var result = Client.Part1(input);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void Test05()
        {
            const string input = "abcde fghij";
            var result = Client.Part2(input);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void Test06()
        {
            const string input = "abcde xyz ecdab";
            var result = Client.Part2(input);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Test07()
        {
            const string input = "a ab abc abd abf abj";
            var result = Client.Part2(input);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void Test08()
        {
            const string input = "iiii oiii ooii oooi oooo";
            var result = Client.Part2(input);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void Test09()
        {
            const string input = "oiii ioii iioi iiio";
            var result = Client.Part2(input);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Test10()
        {
            const string input = @"abcde fghij             
abcde xyz ecdab         
a ab abc abd abf abj    
iiii oiii ooii oooi oooo
oiii ioii iioi iiio";
            var result = Client.Part2(input);
            Assert.AreEqual(3, result);
        }
    }
}
