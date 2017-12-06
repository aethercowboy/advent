using advent2017.Data;
using advent2017.Days;
using advent2017.Extensions;
using System;


namespace advent2017 {
	public static class Runner {
		public static void Run(string[] args) {
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
				case "day04":
					Day04(args.NthOrDefault(1));
					break;
				case "day05":
					Day05(args.NthOrDefault(1));
					break;
				case "day06":
					Day06(args.NthOrDefault(1));
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

		private static void Day01(string input = null) {
			if (input == null) {
				input = DayData.Day01;
			}

			Day<Day01>(1, input);
		}

		private static void Day02(string input = null) {
			if (input == null) {
				input = DayData.Day02;
			}

			Day<Day02>(2, input);
		}

		private static void Day03(string input = null) {
			if (input == null) {
				input = DayData.Day03;
			}

			Day<Day03>(3, input);
		}

		private static void Day04(string input = null) {
			if (input == null) {
				input = DayData.Day04;
			}

			Day<Day04>(4, input);
		}

		private static void Day05(string input = null) {
			if (input == null) {
				input = DayData.Day05;
			}

			Day<Day05>(5, input);
		}

		private static void Day06(string input = null) {
			if (input == null) {
				input = DayData.Day06;
			}

			Day<Day06>(6, input);
		}

	}
}

