using advent.Days._2017;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace advent.tests.Days._2017
{
    [TestClass]
    public class Day20Tests : DayTests<Day20>
    {
        [TestMethod]
        public void Test01()
        {
            const string input = @"p=< 3,0,0>, v=< 2,0,0>, a=<-1,0,0>
p=< 4,0,0>, v=< 0,0,0>, a=<-2,0,0>";
            var result = Client.Part1(input);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Test02()
        {
            const string input = @"p=<-6,0,0>, v=< 3,0,0>, a=< 0,0,0>    
p=<-4,0,0>, v=< 2,0,0>, a=< 0,0,0>
p=<-2,0,0>, v=< 1,0,0>, a=< 0,0,0>
p=< 3,0,0>, v=<-1,0,0>, a=< 0,0,0>";
            var result = Client.Part2(input);
            Assert.AreEqual(1, result);
        }
    }
}
