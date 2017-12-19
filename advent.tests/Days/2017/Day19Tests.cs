using System;
using System.Collections.Generic;
using System.Text;
using advent.Days._2017;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace advent.tests.Days._2017
{
    [TestClass]
    public class Day19Tests : DayTests<Day19>
    {
        public string input = @"     |          
     |  +--+    
     A  |  C    
 F---|----E|--+ 
     |  |  |  D 
     +B-+  +--+ ";

        [TestMethod]
        public void Test01()
        {
            Client.Part1(input);
            Assert.AreEqual("ABCDEF", Output);
        }

        [TestMethod]
        public void Test02()
        {
            var result = Client.Part2(input);
            Assert.AreEqual(38, result);
        }
    }
}
