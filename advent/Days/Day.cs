using advent.IO;

namespace advent.Days
{
    public abstract class Day : IDay
    {
        public IConsole Console { get; set; } = new AdventConsole();

        public abstract long Part1(string input);
        public abstract long Part2(string input);
    }
}
