using System;
using System.Collections.Generic;
using System.Text;
using advent.Days._2017;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace advent.tests.Days._2017
{
    [TestClass]
    public class Day16Tests :DayTests<Day16>
    {
        public string input = @"s1,x3/4,pe/b";

        [TestInitialize]
        public void Init()
        {
            Client.Dancers = "abcde";
        }

        [TestMethod]
        public void Test01()
        {
            Client.Part1(input);
            Assert.AreEqual("baedc", Output);
        }
    }
}
