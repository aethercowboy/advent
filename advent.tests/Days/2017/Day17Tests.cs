using System;
using System.Collections.Generic;
using System.Text;
using advent.Days._2017;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace advent.tests.Days._2017
{
    [TestClass]
    public class Day17Tests : DayTests<Day17>
    {
        public string input = "3";

        [TestMethod]
        public void Test01()
        {
            var result = Client.Part1(input);
            Assert.AreEqual(638, result);
        }
    }
}
