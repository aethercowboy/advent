using System;
using System.Collections.Generic;
using System.Text;
using advent.Days._2017;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace advent.tests.Days._2017
{
    [TestClass]
    public class Day14Tests : DayTests<Day14>
    {
        private string input = "flqrgnkx";

        [TestMethod]
        public void Test01()
        {
            var result = Client.Part1(input);
            Assert.AreEqual(8108, result);
        }

        [TestMethod]
        public void Test02()
        {
            var result = Client.Part2(input);
            Assert.AreEqual(1242, result);
        }
    }
}
