using System;
using System.Linq;

namespace advent
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            args = new[] { "2020", "day01" };

            if (!args.Any())
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