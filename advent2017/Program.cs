using System;
using System.Linq;
using advent2017.Data;
using advent2017.Days;
using advent2017.Extensions;

namespace advent2017
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //args = new[] {"day03"};

            if (!args.Any())
            {
                RunAll();
            }
            else
            {
                switch (args[0])
                {
                    case "day01":
                        Day01(args.NthOrDefault(1));
                        break;
                    case "day02":
                        Day02(args.NthOrDefault(1));
                        break;
                    case "day03":
                        Day03(args.NthOrDefault(1));
                        break;
                }

            }

            Console.Write("Press Enter to Quit");
            Console.ReadLine();
        }

        private static void Day<TDay>(int day, string input)
            where TDay : IDay, new()
        {
            Console.WriteLine($"Day {day:D2}");

            var client = new TDay();

            Console.Write("Part 1: ");

            try
            {
                var output1 = client.Part1(input);

                Console.WriteLine(output1);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.Write("Part 2: ");

            try
            {
                var output2 = client.Part2(input);

                Console.WriteLine(output2);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static void RunAll()
        {
            Console.WriteLine("Running All");
            Day01();
            Day02();
            Day03();
        }
        private static void Day03(string input = null)
        {
            if (input == null)
            {
                input = DayData.Day03;
            }

            Day<Day03>(3, input);
        }


        private static void Day02(string input = null)
        {
            if (input == null)
            {
                input = DayData.Day02;
            }

            Day<Day02>(2, input);
        }

        private static void Day01(string input = null)
        {
            if (input == null)
            {
                input = DayData.Day01;
            }

            Day<Day01>(1, input);
        }
    }
}