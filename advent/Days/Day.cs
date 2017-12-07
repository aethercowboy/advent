using advent.IO;

namespace advent.Days
{
    public abstract class Day : IDay
    {
        public IConsole Console { get; set; } = new AdventConsole();

        public abstract int Part1(string input);
        public abstract int Part2(string input);
    }
}
