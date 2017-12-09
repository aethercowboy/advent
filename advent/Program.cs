﻿using System;
using System.Linq;

namespace advent
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            args = new[] {"2017", "day09"};

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