using System;
using System.Collections.Generic;
using System.Text;
using advent.Days._2017;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace advent.tests.Days._2017
{
    [TestClass]
    public class Day09Tests : DayTests<Day09>
    {
        [TestMethod]
        public void Test01()
        {
            var result = Client.Part1("{}");
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void Test02()
        {
            var result = Client.Part1("{{{}}}");
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void Test03()
        {
            var result = Client.Part1("{{},{}}");
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void Test04()
        {
            var result = Client.Part1("{{{},{},{{}}}}");
            Assert.AreEqual(16, result);
        }

        [TestMethod]
        public void Test05()
        {
            var result = Client.Part1("{<a>,<a>,<a>,<a>}");
            Assert.AreEqual(1, result);
        }


        [TestMethod]
        public void Test06()
        {
            var result = Client.Part1("{{<ab>},{<ab>},{<ab>},{<ab>}}");
            Assert.AreEqual(9, result);
        }

        [TestMethod]
        public void Test07()
        {
            var result = Client.Part1("{{<!!>},{<!!>},{<!!>},{<!!>}}");
            Assert.AreEqual(9, result);
        }

        [TestMethod]
        public void Test08()
        {
            var result = Client.Part1("{{<a!>},{<a!>},{<a!>},{<ab>}}");
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void Test09()
        {
            var result = Client.Part2("<>");
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Test10()
        {
            var result = Client.Part2("<random characters>");
            Assert.AreEqual(17, result);
        }

        [TestMethod]
        public void Test11()
        {
            var result = Client.Part2("<<<<>");
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void Test12()
        {
            var result = Client.Part2("<{!>}>");
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void Test13()
        {
            var result = Client.Part2("<!!>");
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Test14()
        {
            var result = Client.Part2("<!!!>>");
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Test15()
        {
            var result = Client.Part2("<{o\"i!a,<{i<a>");
            Assert.AreEqual(10, result);
        }
    }
}
