using System;
using System.Linq;

namespace advent2017
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //args = new[] {"day05"};

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