using advent.Days._2017;
using Xunit;

namespace advent.tests.Days._2017
{
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

        [Fact]
        public void Test01()
        {
            Client.Part1(Input);

            Assert.Equal("tknk", Output);
        }

        [Fact]
        public void Test02()
        {
            var result = Client.Part2(Input);

            Assert.Equal(60.ToString(), result);
        }
    }
}
