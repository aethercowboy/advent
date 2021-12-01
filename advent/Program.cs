using System;

namespace advent
{
    internal static class Program
    {
#pragma warning disable IDE0060 // Remove unused parameter
        private static void Main(string[] args)
#pragma warning restore IDE0060 // Remove unused parameter
        {
            args = new[] { "2021", "day01" };

            if (args.Length == 0)
            {
                Runner.RunAll();
            }
            else
            {
                Runner.Run(args);
            }

            Console.Write("Press Enter to Quit");
            Console.ReadLine();
        }

    }
}