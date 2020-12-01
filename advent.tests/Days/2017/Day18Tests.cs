using advent.Days._2017;
using Xunit;

namespace advent.tests.Days._2017
{
    public class Day18Tests : DayTests<Day18>
    {
        [Fact]
        public void Test01()
        {
            const string input = @"set a 1
add a 2
mul a a
mod a 5
snd a
set a 0
rcv a
jgz a -1
set a 1
jgz a -2";
            var result = Client.Part1(input);
            Assert.Equal(4, result);
        }

        [Fact]
        public void Test02()
        {
            const string input = @"snd 1
snd 2
snd p
rcv a
rcv b
rcv c
rcv d
rcv e
rcv f";
            var result = Client.Part2(input);
            Assert.Equal(3, result);
        }
    }
}
