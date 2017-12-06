using System.IO;


namespace advent2017.Data {
	public static partial class DayData
	{
		private static string LoadFile(string day) => File.ReadAllText(Path.Combine("Data", $"{day}.txt"));

		public static string Day01 = LoadFile(nameof(Day01));
		public static string Day02 = LoadFile(nameof(Day02));
		public static string Day03 = LoadFile(nameof(Day03));
		public static string Day04 = LoadFile(nameof(Day04));
		public static string Day05 = LoadFile(nameof(Day05));
		public static string Day06 = LoadFile(nameof(Day06));
	}
}