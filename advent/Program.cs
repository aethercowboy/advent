using System;

namespace advent
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            args = new[] { "2020", "day08" };

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