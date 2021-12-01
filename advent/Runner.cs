
using advent.Data;
using advent.Days;
using advent.Extensions;
using System;
using System.Linq;

namespace advent {
	public static class Runner {
		public static void Run(string[] args) {
			switch (args[0]) {
				case "2015":
					Runner2015.Run(args.Skip(1).ToArray());
					break;

				case "2017":
					Runner2017.Run(args.Skip(1).ToArray());
					break;

				case "2020":
					Runner2020.Run(args.Skip(1).ToArray());
					break;

				case "2021":
					Runner2021.Run(args.Skip(1).ToArray());
					break;

				default:
					Console.WriteLine($"Unable to find year {args[0]}.");
					break;
			}
		}

		public static void RunAll(string year = null) {
			switch (year) {
				case "2015":
					Runner2015.RunAll();
					break;

				case "2017":
					Runner2017.RunAll();
					break;

				case "2020":
					Runner2020.RunAll();
					break;

				case "2021":
					Runner2021.RunAll();
					break;

				default:

					Runner2015.RunAll();

					Runner2017.RunAll();

					Runner2020.RunAll();

					Runner2021.RunAll();

					break;
			}
		}

		public static void Day<TDay>(int day, string input)
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
	}

	public static class Runner2015 {
		public static void Run(string[] args) {
			switch (args[0]) {
				case "day01":
					Day01(args.NthOrDefault(1));
					break;

 

				case "day02":
					Day02(args.NthOrDefault(1));
					break;

 

				case "day03":
					Day03(args.NthOrDefault(1));
					break;

 

				case "day04":
					Day04(args.NthOrDefault(1));
					break;

 

				case "day05":
					Day05(args.NthOrDefault(1));
					break;

 

				case "day06":
					Day06(args.NthOrDefault(1));
					break;

 

				case "day07":
					Day07(args.NthOrDefault(1));
					break;

 

				case "day08":
					Day08(args.NthOrDefault(1));
					break;

 

				case "day09":
					Day09(args.NthOrDefault(1));
					break;

 

				case "day10":
					Day10(args.NthOrDefault(1));
					break;

 

				case "day11":
					Day11(args.NthOrDefault(1));
					break;

 

				case "day12":
					Day12(args.NthOrDefault(1));
					break;

 

				case "day13":
					Day13(args.NthOrDefault(1));
					break;

 

				case "day14":
					Day14(args.NthOrDefault(1));
					break;

 

				case "day15":
					Day15(args.NthOrDefault(1));
					break;

 

				case "day16":
					Day16(args.NthOrDefault(1));
					break;

 

				case "day17":
					Day17(args.NthOrDefault(1));
					break;

 

				case "day18":
					Day18(args.NthOrDefault(1));
					break;

 

				case "day19":
					Day19(args.NthOrDefault(1));
					break;

 

				case "day20":
					Day20(args.NthOrDefault(1));
					break;

 

				case "day21":
					Day21(args.NthOrDefault(1));
					break;

 

				case "day22":
					Day22(args.NthOrDefault(1));
					break;

 

				case "day23":
					Day23(args.NthOrDefault(1));
					break;

 

				case "day24":
					Day24(args.NthOrDefault(1));
					break;

 

				case "day25":
					Day25(args.NthOrDefault(1));
					break;

			}
		}

		public static void RunAll() {
		Console.WriteLine("Running All");

			Day01();

			Day02();

			Day03();

			Day04();

			Day05();

			Day06();

			Day07();

			Day08();

			Day09();

			Day10();

			Day11();

			Day12();

			Day13();

			Day14();

			Day15();

			Day16();

			Day17();

			Day18();

			Day19();

			Day20();

			Day21();

			Day22();

			Day23();

			Day24();

			Day25();
		}

		private static void Day01(string input = null) {
			if (input == null) {
				input = DayData2015.Day01;
			}

			Runner.Day<Days._2015.Day01>(1, input);
		}

		private static void Day02(string input = null) {
			if (input == null) {
				input = DayData2015.Day02;
			}

			Runner.Day<Days._2015.Day02>(2, input);
		}

		private static void Day03(string input = null) {
			if (input == null) {
				input = DayData2015.Day03;
			}

			Runner.Day<Days._2015.Day03>(3, input);
		}

		private static void Day04(string input = null) {
			if (input == null) {
				input = DayData2015.Day04;
			}

			Runner.Day<Days._2015.Day04>(4, input);
		}

		private static void Day05(string input = null) {
			if (input == null) {
				input = DayData2015.Day05;
			}

			Runner.Day<Days._2015.Day05>(5, input);
		}

		private static void Day06(string input = null) {
			if (input == null) {
				input = DayData2015.Day06;
			}

			Runner.Day<Days._2015.Day06>(6, input);
		}

		private static void Day07(string input = null) {
			if (input == null) {
				input = DayData2015.Day07;
			}

			Runner.Day<Days._2015.Day07>(7, input);
		}

		private static void Day08(string input = null) {
			if (input == null) {
				input = DayData2015.Day08;
			}

			Runner.Day<Days._2015.Day08>(8, input);
		}

		private static void Day09(string input = null) {
			if (input == null) {
				input = DayData2015.Day09;
			}

			Runner.Day<Days._2015.Day09>(9, input);
		}

		private static void Day10(string input = null) {
			if (input == null) {
				input = DayData2015.Day10;
			}

			Runner.Day<Days._2015.Day10>(10, input);
		}

		private static void Day11(string input = null) {
			if (input == null) {
				input = DayData2015.Day11;
			}

			Runner.Day<Days._2015.Day11>(11, input);
		}

		private static void Day12(string input = null) {
			if (input == null) {
				input = DayData2015.Day12;
			}

			Runner.Day<Days._2015.Day12>(12, input);
		}

		private static void Day13(string input = null) {
			if (input == null) {
				input = DayData2015.Day13;
			}

			Runner.Day<Days._2015.Day13>(13, input);
		}

		private static void Day14(string input = null) {
			if (input == null) {
				input = DayData2015.Day14;
			}

			Runner.Day<Days._2015.Day14>(14, input);
		}

		private static void Day15(string input = null) {
			if (input == null) {
				input = DayData2015.Day15;
			}

			Runner.Day<Days._2015.Day15>(15, input);
		}

		private static void Day16(string input = null) {
			if (input == null) {
				input = DayData2015.Day16;
			}

			Runner.Day<Days._2015.Day16>(16, input);
		}

		private static void Day17(string input = null) {
			if (input == null) {
				input = DayData2015.Day17;
			}

			Runner.Day<Days._2015.Day17>(17, input);
		}

		private static void Day18(string input = null) {
			if (input == null) {
				input = DayData2015.Day18;
			}

			Runner.Day<Days._2015.Day18>(18, input);
		}

		private static void Day19(string input = null) {
			if (input == null) {
				input = DayData2015.Day19;
			}

			Runner.Day<Days._2015.Day19>(19, input);
		}

		private static void Day20(string input = null) {
			if (input == null) {
				input = DayData2015.Day20;
			}

			Runner.Day<Days._2015.Day20>(20, input);
		}

		private static void Day21(string input = null) {
			if (input == null) {
				input = DayData2015.Day21;
			}

			Runner.Day<Days._2015.Day21>(21, input);
		}

		private static void Day22(string input = null) {
			if (input == null) {
				input = DayData2015.Day22;
			}

			Runner.Day<Days._2015.Day22>(22, input);
		}

		private static void Day23(string input = null) {
			if (input == null) {
				input = DayData2015.Day23;
			}

			Runner.Day<Days._2015.Day23>(23, input);
		}

		private static void Day24(string input = null) {
			if (input == null) {
				input = DayData2015.Day24;
			}

			Runner.Day<Days._2015.Day24>(24, input);
		}

		private static void Day25(string input = null) {
			if (input == null) {
				input = DayData2015.Day25;
			}

			Runner.Day<Days._2015.Day25>(25, input);
		}
	}

	public static class Runner2017 {
		public static void Run(string[] args) {
			switch (args[0]) {
				case "day01":
					Day01(args.NthOrDefault(1));
					break;

 

				case "day02":
					Day02(args.NthOrDefault(1));
					break;

 

				case "day03":
					Day03(args.NthOrDefault(1));
					break;

 

				case "day04":
					Day04(args.NthOrDefault(1));
					break;

 

				case "day05":
					Day05(args.NthOrDefault(1));
					break;

 

				case "day06":
					Day06(args.NthOrDefault(1));
					break;

 

				case "day07":
					Day07(args.NthOrDefault(1));
					break;

 

				case "day08":
					Day08(args.NthOrDefault(1));
					break;

 

				case "day09":
					Day09(args.NthOrDefault(1));
					break;

 

				case "day10":
					Day10(args.NthOrDefault(1));
					break;

 

				case "day11":
					Day11(args.NthOrDefault(1));
					break;

 

				case "day12":
					Day12(args.NthOrDefault(1));
					break;

 

				case "day13":
					Day13(args.NthOrDefault(1));
					break;

 

				case "day14":
					Day14(args.NthOrDefault(1));
					break;

 

				case "day15":
					Day15(args.NthOrDefault(1));
					break;

 

				case "day16":
					Day16(args.NthOrDefault(1));
					break;

 

				case "day17":
					Day17(args.NthOrDefault(1));
					break;

 

				case "day18":
					Day18(args.NthOrDefault(1));
					break;

 

				case "day19":
					Day19(args.NthOrDefault(1));
					break;

 

				case "day20":
					Day20(args.NthOrDefault(1));
					break;

 

				case "day21":
					Day21(args.NthOrDefault(1));
					break;

 

				case "day22":
					Day22(args.NthOrDefault(1));
					break;

 

				case "day23":
					Day23(args.NthOrDefault(1));
					break;

 

				case "day24":
					Day24(args.NthOrDefault(1));
					break;

 

				case "day25":
					Day25(args.NthOrDefault(1));
					break;

			}
		}

		public static void RunAll() {
		Console.WriteLine("Running All");

			Day01();

			Day02();

			Day03();

			Day04();

			Day05();

			Day06();

			Day07();

			Day08();

			Day09();

			Day10();

			Day11();

			Day12();

			Day13();

			Day14();

			Day15();

			Day16();

			Day17();

			Day18();

			Day19();

			Day20();

			Day21();

			Day22();

			Day23();

			Day24();

			Day25();

			Day01();

			Day02();

			Day03();

			Day04();

			Day05();

			Day06();

			Day07();

			Day08();

			Day09();

			Day10();

			Day11();

			Day12();

			Day13();

			Day14();

			Day15();

			Day16();

			Day17();

			Day18();

			Day19();

			Day20();

			Day21();

			Day22();

			Day23();

			Day24();

			Day25();
		}

		private static void Day01(string input = null) {
			if (input == null) {
				input = DayData2017.Day01;
			}

			Runner.Day<Days._2017.Day01>(1, input);
		}

		private static void Day02(string input = null) {
			if (input == null) {
				input = DayData2017.Day02;
			}

			Runner.Day<Days._2017.Day02>(2, input);
		}

		private static void Day03(string input = null) {
			if (input == null) {
				input = DayData2017.Day03;
			}

			Runner.Day<Days._2017.Day03>(3, input);
		}

		private static void Day04(string input = null) {
			if (input == null) {
				input = DayData2017.Day04;
			}

			Runner.Day<Days._2017.Day04>(4, input);
		}

		private static void Day05(string input = null) {
			if (input == null) {
				input = DayData2017.Day05;
			}

			Runner.Day<Days._2017.Day05>(5, input);
		}

		private static void Day06(string input = null) {
			if (input == null) {
				input = DayData2017.Day06;
			}

			Runner.Day<Days._2017.Day06>(6, input);
		}

		private static void Day07(string input = null) {
			if (input == null) {
				input = DayData2017.Day07;
			}

			Runner.Day<Days._2017.Day07>(7, input);
		}

		private static void Day08(string input = null) {
			if (input == null) {
				input = DayData2017.Day08;
			}

			Runner.Day<Days._2017.Day08>(8, input);
		}

		private static void Day09(string input = null) {
			if (input == null) {
				input = DayData2017.Day09;
			}

			Runner.Day<Days._2017.Day09>(9, input);
		}

		private static void Day10(string input = null) {
			if (input == null) {
				input = DayData2017.Day10;
			}

			Runner.Day<Days._2017.Day10>(10, input);
		}

		private static void Day11(string input = null) {
			if (input == null) {
				input = DayData2017.Day11;
			}

			Runner.Day<Days._2017.Day11>(11, input);
		}

		private static void Day12(string input = null) {
			if (input == null) {
				input = DayData2017.Day12;
			}

			Runner.Day<Days._2017.Day12>(12, input);
		}

		private static void Day13(string input = null) {
			if (input == null) {
				input = DayData2017.Day13;
			}

			Runner.Day<Days._2017.Day13>(13, input);
		}

		private static void Day14(string input = null) {
			if (input == null) {
				input = DayData2017.Day14;
			}

			Runner.Day<Days._2017.Day14>(14, input);
		}

		private static void Day15(string input = null) {
			if (input == null) {
				input = DayData2017.Day15;
			}

			Runner.Day<Days._2017.Day15>(15, input);
		}

		private static void Day16(string input = null) {
			if (input == null) {
				input = DayData2017.Day16;
			}

			Runner.Day<Days._2017.Day16>(16, input);
		}

		private static void Day17(string input = null) {
			if (input == null) {
				input = DayData2017.Day17;
			}

			Runner.Day<Days._2017.Day17>(17, input);
		}

		private static void Day18(string input = null) {
			if (input == null) {
				input = DayData2017.Day18;
			}

			Runner.Day<Days._2017.Day18>(18, input);
		}

		private static void Day19(string input = null) {
			if (input == null) {
				input = DayData2017.Day19;
			}

			Runner.Day<Days._2017.Day19>(19, input);
		}

		private static void Day20(string input = null) {
			if (input == null) {
				input = DayData2017.Day20;
			}

			Runner.Day<Days._2017.Day20>(20, input);
		}

		private static void Day21(string input = null) {
			if (input == null) {
				input = DayData2017.Day21;
			}

			Runner.Day<Days._2017.Day21>(21, input);
		}

		private static void Day22(string input = null) {
			if (input == null) {
				input = DayData2017.Day22;
			}

			Runner.Day<Days._2017.Day22>(22, input);
		}

		private static void Day23(string input = null) {
			if (input == null) {
				input = DayData2017.Day23;
			}

			Runner.Day<Days._2017.Day23>(23, input);
		}

		private static void Day24(string input = null) {
			if (input == null) {
				input = DayData2017.Day24;
			}

			Runner.Day<Days._2017.Day24>(24, input);
		}

		private static void Day25(string input = null) {
			if (input == null) {
				input = DayData2017.Day25;
			}

			Runner.Day<Days._2017.Day25>(25, input);
		}
	}

	public static class Runner2020 {
		public static void Run(string[] args) {
			switch (args[0]) {
				case "day01":
					Day01(args.NthOrDefault(1));
					break;

 

				case "day02":
					Day02(args.NthOrDefault(1));
					break;

 

				case "day03":
					Day03(args.NthOrDefault(1));
					break;

 

				case "day04":
					Day04(args.NthOrDefault(1));
					break;

 

				case "day05":
					Day05(args.NthOrDefault(1));
					break;

 

				case "day06":
					Day06(args.NthOrDefault(1));
					break;

 

				case "day07":
					Day07(args.NthOrDefault(1));
					break;

 

				case "day08":
					Day08(args.NthOrDefault(1));
					break;

 

				case "day09":
					Day09(args.NthOrDefault(1));
					break;

 

				case "day10":
					Day10(args.NthOrDefault(1));
					break;

 

				case "day11":
					Day11(args.NthOrDefault(1));
					break;

 

				case "day12":
					Day12(args.NthOrDefault(1));
					break;

 

				case "day13":
					Day13(args.NthOrDefault(1));
					break;

 

				case "day14":
					Day14(args.NthOrDefault(1));
					break;

 

				case "day15":
					Day15(args.NthOrDefault(1));
					break;

 

				case "day16":
					Day16(args.NthOrDefault(1));
					break;

 

				case "day17":
					Day17(args.NthOrDefault(1));
					break;

 

				case "day18":
					Day18(args.NthOrDefault(1));
					break;

 

				case "day19":
					Day19(args.NthOrDefault(1));
					break;

 

				case "day20":
					Day20(args.NthOrDefault(1));
					break;

 

				case "day21":
					Day21(args.NthOrDefault(1));
					break;

 

				case "day22":
					Day22(args.NthOrDefault(1));
					break;

 

				case "day23":
					Day23(args.NthOrDefault(1));
					break;

 

				case "day24":
					Day24(args.NthOrDefault(1));
					break;

 

				case "day25":
					Day25(args.NthOrDefault(1));
					break;

			}
		}

		public static void RunAll() {
		Console.WriteLine("Running All");

			Day01();

			Day02();

			Day03();

			Day04();

			Day05();

			Day06();

			Day07();

			Day08();

			Day09();

			Day10();

			Day11();

			Day12();

			Day13();

			Day14();

			Day15();

			Day16();

			Day17();

			Day18();

			Day19();

			Day20();

			Day21();

			Day22();

			Day23();

			Day24();

			Day25();

			Day01();

			Day02();

			Day03();

			Day04();

			Day05();

			Day06();

			Day07();

			Day08();

			Day09();

			Day10();

			Day11();

			Day12();

			Day13();

			Day14();

			Day15();

			Day16();

			Day17();

			Day18();

			Day19();

			Day20();

			Day21();

			Day22();

			Day23();

			Day24();

			Day25();

			Day01();

			Day02();

			Day03();

			Day04();

			Day05();

			Day06();

			Day07();

			Day08();

			Day09();

			Day10();

			Day11();

			Day12();

			Day13();

			Day14();

			Day15();

			Day16();

			Day17();

			Day18();

			Day19();

			Day20();

			Day21();

			Day22();

			Day23();

			Day24();

			Day25();
		}

		private static void Day01(string input = null) {
			if (input == null) {
				input = DayData2020.Day01;
			}

			Runner.Day<Days._2020.Day01>(1, input);
		}

		private static void Day02(string input = null) {
			if (input == null) {
				input = DayData2020.Day02;
			}

			Runner.Day<Days._2020.Day02>(2, input);
		}

		private static void Day03(string input = null) {
			if (input == null) {
				input = DayData2020.Day03;
			}

			Runner.Day<Days._2020.Day03>(3, input);
		}

		private static void Day04(string input = null) {
			if (input == null) {
				input = DayData2020.Day04;
			}

			Runner.Day<Days._2020.Day04>(4, input);
		}

		private static void Day05(string input = null) {
			if (input == null) {
				input = DayData2020.Day05;
			}

			Runner.Day<Days._2020.Day05>(5, input);
		}

		private static void Day06(string input = null) {
			if (input == null) {
				input = DayData2020.Day06;
			}

			Runner.Day<Days._2020.Day06>(6, input);
		}

		private static void Day07(string input = null) {
			if (input == null) {
				input = DayData2020.Day07;
			}

			Runner.Day<Days._2020.Day07>(7, input);
		}

		private static void Day08(string input = null) {
			if (input == null) {
				input = DayData2020.Day08;
			}

			Runner.Day<Days._2020.Day08>(8, input);
		}

		private static void Day09(string input = null) {
			if (input == null) {
				input = DayData2020.Day09;
			}

			Runner.Day<Days._2020.Day09>(9, input);
		}

		private static void Day10(string input = null) {
			if (input == null) {
				input = DayData2020.Day10;
			}

			Runner.Day<Days._2020.Day10>(10, input);
		}

		private static void Day11(string input = null) {
			if (input == null) {
				input = DayData2020.Day11;
			}

			Runner.Day<Days._2020.Day11>(11, input);
		}

		private static void Day12(string input = null) {
			if (input == null) {
				input = DayData2020.Day12;
			}

			Runner.Day<Days._2020.Day12>(12, input);
		}

		private static void Day13(string input = null) {
			if (input == null) {
				input = DayData2020.Day13;
			}

			Runner.Day<Days._2020.Day13>(13, input);
		}

		private static void Day14(string input = null) {
			if (input == null) {
				input = DayData2020.Day14;
			}

			Runner.Day<Days._2020.Day14>(14, input);
		}

		private static void Day15(string input = null) {
			if (input == null) {
				input = DayData2020.Day15;
			}

			Runner.Day<Days._2020.Day15>(15, input);
		}

		private static void Day16(string input = null) {
			if (input == null) {
				input = DayData2020.Day16;
			}

			Runner.Day<Days._2020.Day16>(16, input);
		}

		private static void Day17(string input = null) {
			if (input == null) {
				input = DayData2020.Day17;
			}

			Runner.Day<Days._2020.Day17>(17, input);
		}

		private static void Day18(string input = null) {
			if (input == null) {
				input = DayData2020.Day18;
			}

			Runner.Day<Days._2020.Day18>(18, input);
		}

		private static void Day19(string input = null) {
			if (input == null) {
				input = DayData2020.Day19;
			}

			Runner.Day<Days._2020.Day19>(19, input);
		}

		private static void Day20(string input = null) {
			if (input == null) {
				input = DayData2020.Day20;
			}

			Runner.Day<Days._2020.Day20>(20, input);
		}

		private static void Day21(string input = null) {
			if (input == null) {
				input = DayData2020.Day21;
			}

			Runner.Day<Days._2020.Day21>(21, input);
		}

		private static void Day22(string input = null) {
			if (input == null) {
				input = DayData2020.Day22;
			}

			Runner.Day<Days._2020.Day22>(22, input);
		}

		private static void Day23(string input = null) {
			if (input == null) {
				input = DayData2020.Day23;
			}

			Runner.Day<Days._2020.Day23>(23, input);
		}

		private static void Day24(string input = null) {
			if (input == null) {
				input = DayData2020.Day24;
			}

			Runner.Day<Days._2020.Day24>(24, input);
		}

		private static void Day25(string input = null) {
			if (input == null) {
				input = DayData2020.Day25;
			}

			Runner.Day<Days._2020.Day25>(25, input);
		}
	}

	public static class Runner2021 {
		public static void Run(string[] args) {
			switch (args[0]) {
				case "day01":
					Day01(args.NthOrDefault(1));
					break;

 

				case "day02":
					Day02(args.NthOrDefault(1));
					break;

 

				case "day03":
					Day03(args.NthOrDefault(1));
					break;

 

				case "day04":
					Day04(args.NthOrDefault(1));
					break;

 

				case "day05":
					Day05(args.NthOrDefault(1));
					break;

 

				case "day06":
					Day06(args.NthOrDefault(1));
					break;

 

				case "day07":
					Day07(args.NthOrDefault(1));
					break;

 

				case "day08":
					Day08(args.NthOrDefault(1));
					break;

 

				case "day09":
					Day09(args.NthOrDefault(1));
					break;

 

				case "day10":
					Day10(args.NthOrDefault(1));
					break;

 

				case "day11":
					Day11(args.NthOrDefault(1));
					break;

 

				case "day12":
					Day12(args.NthOrDefault(1));
					break;

 

				case "day13":
					Day13(args.NthOrDefault(1));
					break;

 

				case "day14":
					Day14(args.NthOrDefault(1));
					break;

 

				case "day15":
					Day15(args.NthOrDefault(1));
					break;

 

				case "day16":
					Day16(args.NthOrDefault(1));
					break;

 

				case "day17":
					Day17(args.NthOrDefault(1));
					break;

 

				case "day18":
					Day18(args.NthOrDefault(1));
					break;

 

				case "day19":
					Day19(args.NthOrDefault(1));
					break;

 

				case "day20":
					Day20(args.NthOrDefault(1));
					break;

 

				case "day21":
					Day21(args.NthOrDefault(1));
					break;

 

				case "day22":
					Day22(args.NthOrDefault(1));
					break;

 

				case "day23":
					Day23(args.NthOrDefault(1));
					break;

 

				case "day24":
					Day24(args.NthOrDefault(1));
					break;

 

				case "day25":
					Day25(args.NthOrDefault(1));
					break;

			}
		}

		public static void RunAll() {
		Console.WriteLine("Running All");

			Day01();

			Day02();

			Day03();

			Day04();

			Day05();

			Day06();

			Day07();

			Day08();

			Day09();

			Day10();

			Day11();

			Day12();

			Day13();

			Day14();

			Day15();

			Day16();

			Day17();

			Day18();

			Day19();

			Day20();

			Day21();

			Day22();

			Day23();

			Day24();

			Day25();

			Day01();

			Day02();

			Day03();

			Day04();

			Day05();

			Day06();

			Day07();

			Day08();

			Day09();

			Day10();

			Day11();

			Day12();

			Day13();

			Day14();

			Day15();

			Day16();

			Day17();

			Day18();

			Day19();

			Day20();

			Day21();

			Day22();

			Day23();

			Day24();

			Day25();

			Day01();

			Day02();

			Day03();

			Day04();

			Day05();

			Day06();

			Day07();

			Day08();

			Day09();

			Day10();

			Day11();

			Day12();

			Day13();

			Day14();

			Day15();

			Day16();

			Day17();

			Day18();

			Day19();

			Day20();

			Day21();

			Day22();

			Day23();

			Day24();

			Day25();

			Day01();

			Day02();

			Day03();

			Day04();

			Day05();

			Day06();

			Day07();

			Day08();

			Day09();

			Day10();

			Day11();

			Day12();

			Day13();

			Day14();

			Day15();

			Day16();

			Day17();

			Day18();

			Day19();

			Day20();

			Day21();

			Day22();

			Day23();

			Day24();

			Day25();
		}

		private static void Day01(string input = null) {
			if (input == null) {
				input = DayData2021.Day01;
			}

			Runner.Day<Days._2021.Day01>(1, input);
		}

		private static void Day02(string input = null) {
			if (input == null) {
				input = DayData2021.Day02;
			}

			Runner.Day<Days._2021.Day02>(2, input);
		}

		private static void Day03(string input = null) {
			if (input == null) {
				input = DayData2021.Day03;
			}

			Runner.Day<Days._2021.Day03>(3, input);
		}

		private static void Day04(string input = null) {
			if (input == null) {
				input = DayData2021.Day04;
			}

			Runner.Day<Days._2021.Day04>(4, input);
		}

		private static void Day05(string input = null) {
			if (input == null) {
				input = DayData2021.Day05;
			}

			Runner.Day<Days._2021.Day05>(5, input);
		}

		private static void Day06(string input = null) {
			if (input == null) {
				input = DayData2021.Day06;
			}

			Runner.Day<Days._2021.Day06>(6, input);
		}

		private static void Day07(string input = null) {
			if (input == null) {
				input = DayData2021.Day07;
			}

			Runner.Day<Days._2021.Day07>(7, input);
		}

		private static void Day08(string input = null) {
			if (input == null) {
				input = DayData2021.Day08;
			}

			Runner.Day<Days._2021.Day08>(8, input);
		}

		private static void Day09(string input = null) {
			if (input == null) {
				input = DayData2021.Day09;
			}

			Runner.Day<Days._2021.Day09>(9, input);
		}

		private static void Day10(string input = null) {
			if (input == null) {
				input = DayData2021.Day10;
			}

			Runner.Day<Days._2021.Day10>(10, input);
		}

		private static void Day11(string input = null) {
			if (input == null) {
				input = DayData2021.Day11;
			}

			Runner.Day<Days._2021.Day11>(11, input);
		}

		private static void Day12(string input = null) {
			if (input == null) {
				input = DayData2021.Day12;
			}

			Runner.Day<Days._2021.Day12>(12, input);
		}

		private static void Day13(string input = null) {
			if (input == null) {
				input = DayData2021.Day13;
			}

			Runner.Day<Days._2021.Day13>(13, input);
		}

		private static void Day14(string input = null) {
			if (input == null) {
				input = DayData2021.Day14;
			}

			Runner.Day<Days._2021.Day14>(14, input);
		}

		private static void Day15(string input = null) {
			if (input == null) {
				input = DayData2021.Day15;
			}

			Runner.Day<Days._2021.Day15>(15, input);
		}

		private static void Day16(string input = null) {
			if (input == null) {
				input = DayData2021.Day16;
			}

			Runner.Day<Days._2021.Day16>(16, input);
		}

		private static void Day17(string input = null) {
			if (input == null) {
				input = DayData2021.Day17;
			}

			Runner.Day<Days._2021.Day17>(17, input);
		}

		private static void Day18(string input = null) {
			if (input == null) {
				input = DayData2021.Day18;
			}

			Runner.Day<Days._2021.Day18>(18, input);
		}

		private static void Day19(string input = null) {
			if (input == null) {
				input = DayData2021.Day19;
			}

			Runner.Day<Days._2021.Day19>(19, input);
		}

		private static void Day20(string input = null) {
			if (input == null) {
				input = DayData2021.Day20;
			}

			Runner.Day<Days._2021.Day20>(20, input);
		}

		private static void Day21(string input = null) {
			if (input == null) {
				input = DayData2021.Day21;
			}

			Runner.Day<Days._2021.Day21>(21, input);
		}

		private static void Day22(string input = null) {
			if (input == null) {
				input = DayData2021.Day22;
			}

			Runner.Day<Days._2021.Day22>(22, input);
		}

		private static void Day23(string input = null) {
			if (input == null) {
				input = DayData2021.Day23;
			}

			Runner.Day<Days._2021.Day23>(23, input);
		}

		private static void Day24(string input = null) {
			if (input == null) {
				input = DayData2021.Day24;
			}

			Runner.Day<Days._2021.Day24>(24, input);
		}

		private static void Day25(string input = null) {
			if (input == null) {
				input = DayData2021.Day25;
			}

			Runner.Day<Days._2021.Day25>(25, input);
		}
	}

namespace Data {
		public static class DayData2015
		{

			public readonly static string Day01 = DayData.LoadFile(2015, nameof(Day01));

			public readonly static string Day02 = DayData.LoadFile(2015, nameof(Day02));

			public readonly static string Day03 = DayData.LoadFile(2015, nameof(Day03));

			public readonly static string Day04 = DayData.LoadFile(2015, nameof(Day04));

			public readonly static string Day05 = DayData.LoadFile(2015, nameof(Day05));

			public readonly static string Day06 = DayData.LoadFile(2015, nameof(Day06));

			public readonly static string Day07 = DayData.LoadFile(2015, nameof(Day07));

			public readonly static string Day08 = DayData.LoadFile(2015, nameof(Day08));

			public readonly static string Day09 = DayData.LoadFile(2015, nameof(Day09));

			public readonly static string Day10 = DayData.LoadFile(2015, nameof(Day10));

			public readonly static string Day11 = DayData.LoadFile(2015, nameof(Day11));

			public readonly static string Day12 = DayData.LoadFile(2015, nameof(Day12));

			public readonly static string Day13 = DayData.LoadFile(2015, nameof(Day13));

			public readonly static string Day14 = DayData.LoadFile(2015, nameof(Day14));

			public readonly static string Day15 = DayData.LoadFile(2015, nameof(Day15));

			public readonly static string Day16 = DayData.LoadFile(2015, nameof(Day16));

			public readonly static string Day17 = DayData.LoadFile(2015, nameof(Day17));

			public readonly static string Day18 = DayData.LoadFile(2015, nameof(Day18));

			public readonly static string Day19 = DayData.LoadFile(2015, nameof(Day19));

			public readonly static string Day20 = DayData.LoadFile(2015, nameof(Day20));

			public readonly static string Day21 = DayData.LoadFile(2015, nameof(Day21));

			public readonly static string Day22 = DayData.LoadFile(2015, nameof(Day22));

			public readonly static string Day23 = DayData.LoadFile(2015, nameof(Day23));

			public readonly static string Day24 = DayData.LoadFile(2015, nameof(Day24));

			public readonly static string Day25 = DayData.LoadFile(2015, nameof(Day25));
		}

		public static class DayData2017
		{

			public readonly static string Day01 = DayData.LoadFile(2017, nameof(Day01));

			public readonly static string Day02 = DayData.LoadFile(2017, nameof(Day02));

			public readonly static string Day03 = DayData.LoadFile(2017, nameof(Day03));

			public readonly static string Day04 = DayData.LoadFile(2017, nameof(Day04));

			public readonly static string Day05 = DayData.LoadFile(2017, nameof(Day05));

			public readonly static string Day06 = DayData.LoadFile(2017, nameof(Day06));

			public readonly static string Day07 = DayData.LoadFile(2017, nameof(Day07));

			public readonly static string Day08 = DayData.LoadFile(2017, nameof(Day08));

			public readonly static string Day09 = DayData.LoadFile(2017, nameof(Day09));

			public readonly static string Day10 = DayData.LoadFile(2017, nameof(Day10));

			public readonly static string Day11 = DayData.LoadFile(2017, nameof(Day11));

			public readonly static string Day12 = DayData.LoadFile(2017, nameof(Day12));

			public readonly static string Day13 = DayData.LoadFile(2017, nameof(Day13));

			public readonly static string Day14 = DayData.LoadFile(2017, nameof(Day14));

			public readonly static string Day15 = DayData.LoadFile(2017, nameof(Day15));

			public readonly static string Day16 = DayData.LoadFile(2017, nameof(Day16));

			public readonly static string Day17 = DayData.LoadFile(2017, nameof(Day17));

			public readonly static string Day18 = DayData.LoadFile(2017, nameof(Day18));

			public readonly static string Day19 = DayData.LoadFile(2017, nameof(Day19));

			public readonly static string Day20 = DayData.LoadFile(2017, nameof(Day20));

			public readonly static string Day21 = DayData.LoadFile(2017, nameof(Day21));

			public readonly static string Day22 = DayData.LoadFile(2017, nameof(Day22));

			public readonly static string Day23 = DayData.LoadFile(2017, nameof(Day23));

			public readonly static string Day24 = DayData.LoadFile(2017, nameof(Day24));

			public readonly static string Day25 = DayData.LoadFile(2017, nameof(Day25));
		}

		public static class DayData2020
		{

			public readonly static string Day01 = DayData.LoadFile(2020, nameof(Day01));

			public readonly static string Day02 = DayData.LoadFile(2020, nameof(Day02));

			public readonly static string Day03 = DayData.LoadFile(2020, nameof(Day03));

			public readonly static string Day04 = DayData.LoadFile(2020, nameof(Day04));

			public readonly static string Day05 = DayData.LoadFile(2020, nameof(Day05));

			public readonly static string Day06 = DayData.LoadFile(2020, nameof(Day06));

			public readonly static string Day07 = DayData.LoadFile(2020, nameof(Day07));

			public readonly static string Day08 = DayData.LoadFile(2020, nameof(Day08));

			public readonly static string Day09 = DayData.LoadFile(2020, nameof(Day09));

			public readonly static string Day10 = DayData.LoadFile(2020, nameof(Day10));

			public readonly static string Day11 = DayData.LoadFile(2020, nameof(Day11));

			public readonly static string Day12 = DayData.LoadFile(2020, nameof(Day12));

			public readonly static string Day13 = DayData.LoadFile(2020, nameof(Day13));

			public readonly static string Day14 = DayData.LoadFile(2020, nameof(Day14));

			public readonly static string Day15 = DayData.LoadFile(2020, nameof(Day15));

			public readonly static string Day16 = DayData.LoadFile(2020, nameof(Day16));

			public readonly static string Day17 = DayData.LoadFile(2020, nameof(Day17));

			public readonly static string Day18 = DayData.LoadFile(2020, nameof(Day18));

			public readonly static string Day19 = DayData.LoadFile(2020, nameof(Day19));

			public readonly static string Day20 = DayData.LoadFile(2020, nameof(Day20));

			public readonly static string Day21 = DayData.LoadFile(2020, nameof(Day21));

			public readonly static string Day22 = DayData.LoadFile(2020, nameof(Day22));

			public readonly static string Day23 = DayData.LoadFile(2020, nameof(Day23));

			public readonly static string Day24 = DayData.LoadFile(2020, nameof(Day24));

			public readonly static string Day25 = DayData.LoadFile(2020, nameof(Day25));
		}

		public static class DayData2021
		{

			public readonly static string Day01 = DayData.LoadFile(2021, nameof(Day01));

			public readonly static string Day02 = DayData.LoadFile(2021, nameof(Day02));

			public readonly static string Day03 = DayData.LoadFile(2021, nameof(Day03));

			public readonly static string Day04 = DayData.LoadFile(2021, nameof(Day04));

			public readonly static string Day05 = DayData.LoadFile(2021, nameof(Day05));

			public readonly static string Day06 = DayData.LoadFile(2021, nameof(Day06));

			public readonly static string Day07 = DayData.LoadFile(2021, nameof(Day07));

			public readonly static string Day08 = DayData.LoadFile(2021, nameof(Day08));

			public readonly static string Day09 = DayData.LoadFile(2021, nameof(Day09));

			public readonly static string Day10 = DayData.LoadFile(2021, nameof(Day10));

			public readonly static string Day11 = DayData.LoadFile(2021, nameof(Day11));

			public readonly static string Day12 = DayData.LoadFile(2021, nameof(Day12));

			public readonly static string Day13 = DayData.LoadFile(2021, nameof(Day13));

			public readonly static string Day14 = DayData.LoadFile(2021, nameof(Day14));

			public readonly static string Day15 = DayData.LoadFile(2021, nameof(Day15));

			public readonly static string Day16 = DayData.LoadFile(2021, nameof(Day16));

			public readonly static string Day17 = DayData.LoadFile(2021, nameof(Day17));

			public readonly static string Day18 = DayData.LoadFile(2021, nameof(Day18));

			public readonly static string Day19 = DayData.LoadFile(2021, nameof(Day19));

			public readonly static string Day20 = DayData.LoadFile(2021, nameof(Day20));

			public readonly static string Day21 = DayData.LoadFile(2021, nameof(Day21));

			public readonly static string Day22 = DayData.LoadFile(2021, nameof(Day22));

			public readonly static string Day23 = DayData.LoadFile(2021, nameof(Day23));

			public readonly static string Day24 = DayData.LoadFile(2021, nameof(Day24));

			public readonly static string Day25 = DayData.LoadFile(2021, nameof(Day25));
		}
	}
}


