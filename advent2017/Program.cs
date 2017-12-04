using System;
using System.Linq;

namespace advent2017
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //args = new[] {"day04"};

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