using advent.IO;

namespace advent.Days
{
    public abstract class Day : IDay
    {
        public IConsole Console { get; set; } = new AdventConsole();

        public abstract string Part1(string input);
        public abstract string Part2(string input);
    }
}
