using advent.Days._2017;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace advent.tests.Days._2017
{
    [TestClass]
    public class Day07Tests : DayTests<Day07>
    {
        private const string Input = @"pbga (66)
xhth (57)
ebii (61)
havc (66)
ktlj (57)
fwft (72) -> ktlj, cntj, xhth
qoyq (66)
padx (45) -> pbga, havc, qoyq
tknk (41) -> ugml, padx, fwft
jptl (61)
ugml (68) -> gyxo, ebii, jptl
gyxo (61)
cntj (57)";

        [TestMethod]
        public void Test01()
        {
            Client.Part1(Input);

            Assert.AreEqual("tknk", Output);
        }

        [TestMethod]
        public void Test02()
        {
            var result = Client.Part2(Input);

            Assert.AreEqual(60, result);
        }
    }
}
