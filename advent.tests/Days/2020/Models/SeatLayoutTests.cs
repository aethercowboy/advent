using advent.Models._2020;
using System.Collections.Generic;
using Xunit;

namespace advent.tests.Days._2020.Models
{
    public class SeatLayoutTests
    {
        public static IEnumerable<object[]> Data =>
            new List<object[]>
            {
                new object[] { Generations.Gen0, Generations.Gen1 },
                new object[] { Generations.Gen1, Generations.Gen2 },
                new object[] { Generations.Gen2, Generations.Gen3 },
                new object[] { Generations.Gen3, Generations.Gen4 },
                new object[] { Generations.Gen4, Generations.Gen5 },
                new object[] { Generations.Gen5, Generations.Gen5 }, // where it loops
            };

        [Theory]
        [MemberData(nameof(Data))]
        public void GenTest(string input, string expected)
        {
            var layout = new SeatLayout(input);

            var result = layout.Process();

            Assert.Equal(expected, result);
        }

        [Theory]
        [MemberData(nameof(Data))]
        public void ToStringTest(string input, string _)
        {
            var layout = new SeatLayout(input);

            var result = layout.ToString();

            Assert.Equal(input, result);
        }

        public static IEnumerable<object[]> Data2 =>
            new List<object[]>
            {
                new object[] { Layouts.L1, 4, 3, 8, 0 },
                new object[] { Layouts.L2, 1, 1, 0, 1 },
                new object[] { Layouts.L3, 3, 3, 0, 0 },
            };

        [Theory]
        [MemberData(nameof(Data2))]
        public void SeenTest(string input, int x, int y, int eX, int eY)
        {
            var layout = new SeatLayout(input);

            var result = layout.SeenFrom(x, y);

            Assert.Equal(eX, result.X);
            Assert.Equal(eY, result.Y);
        }

        public static IEnumerable<object[]> Data3 =>
            new List<object[]>
            {
                new object[] { Generations2.Gen0, Generations2.Gen1 },
                new object[] { Generations2.Gen1, Generations2.Gen2 },
                new object[] { Generations2.Gen2, Generations2.Gen3 },
                new object[] { Generations2.Gen3, Generations2.Gen4 },
                new object[] { Generations2.Gen4, Generations2.Gen5 },
                new object[] { Generations2.Gen5, Generations2.Gen6 },
                new object[] { Generations2.Gen6, Generations2.Gen6 }, // where it loops
            };

        [Theory]
        [MemberData(nameof(Data3))]
        public void GenTest2(string input, string expected)
        {
            var layout = new SeatLayout(input);

            var result = layout.Process2();

            Assert.Equal(expected, result);
        }
    }

    internal static class Generations
    {
        public static string Gen0 => @"L.LL.LL.LL
LLLLLLL.LL
L.L.L..L..
LLLL.LL.LL
L.LL.LL.LL
L.LLLLL.LL
..L.L.....
LLLLLLLLLL
L.LLLLLL.L
L.LLLLL.LL";

        public static string Gen1 => @"#.##.##.##
#######.##
#.#.#..#..
####.##.##
#.##.##.##
#.#####.##
..#.#.....
##########
#.######.#
#.#####.##";

        public static string Gen2 => @"#.LL.L#.##
#LLLLLL.L#
L.L.L..L..
#LLL.LL.L#
#.LL.LL.LL
#.LLLL#.##
..L.L.....
#LLLLLLLL#
#.LLLLLL.L
#.#LLLL.##";

        public static string Gen3 => @"#.##.L#.##
#L###LL.L#
L.#.#..#..
#L##.##.L#
#.##.LL.LL
#.###L#.##
..#.#.....
#L######L#
#.LL###L.L
#.#L###.##";

        public static string Gen4 = @"#.#L.L#.##
#LLL#LL.L#
L.L.L..#..
#LLL.##.L#
#.LL.LL.LL
#.LL#L#.##
..L.L.....
#L#LLLL#L#
#.LLLLLL.L
#.#L#L#.##";

        public static string Gen5 = @"#.#L.L#.##
#LLL#LL.L#
L.#.L..#..
#L##.##.L#
#.#L.LL.LL
#.#L#L#.##
..L.L.....
#L#L##L#L#
#.LLLLLL.L
#.#L#L#.##";
    }

    internal static class Layouts
    {
        public static string L1 => @".......#.
...#.....
.#.......
.........
..#L....#
....#....
.........
#........
...#.....";

        public static string L2 => @".............
.L.L.#.#.#.#.
.............";

        public static string L3 => @".##.##.
#.#.#.#
##...##
...L...
##...##
#.#.#.#
.##.##.";
    }

    internal static class Generations2
    {
        public static string Gen0 = @"L.LL.LL.LL
LLLLLLL.LL
L.L.L..L..
LLLL.LL.LL
L.LL.LL.LL
L.LLLLL.LL
..L.L.....
LLLLLLLLLL
L.LLLLLL.L
L.LLLLL.LL";

        public static string Gen1 = @"#.##.##.##
#######.##
#.#.#..#..
####.##.##
#.##.##.##
#.#####.##
..#.#.....
##########
#.######.#
#.#####.##";

        public static string Gen2 = @"#.LL.LL.L#
#LLLLLL.LL
L.L.L..L..
LLLL.LL.LL
L.LL.LL.LL
L.LLLLL.LL
..L.L.....
LLLLLLLLL#
#.LLLLLL.L
#.LLLLL.L#";

        public static string Gen3 = @"#.L#.##.L#
#L#####.LL
L.#.#..#..
##L#.##.##
#.##.#L.##
#.#####.#L
..#.#.....
LLL####LL#
#.L#####.L
#.L####.L#";

        public static string Gen4 = @"#.L#.L#.L#
#LLLLLL.LL
L.L.L..#..
##LL.LL.L#
L.LL.LL.L#
#.LLLLL.LL
..L.L.....
LLLLLLLLL#
#.LLLLL#.L
#.L#LL#.L#";

        public static string Gen5 = @"#.L#.L#.L#
#LLLLLL.LL
L.L.L..#..
##L#.#L.L#
L.L#.#L.L#
#.L####.LL
..#.#.....
LLL###LLL#
#.LLLLL#.L
#.L#LL#.L#";

        public static string Gen6 = @"#.L#.L#.L#
#LLLLLL.LL
L.L.L..#..
##L#.#L.L#
L.L#.LL.L#
#.LLLL#.LL
..#.L.....
LLL###LLL#
#.LLLLL#.L
#.L#LL#.L#";
    }
}
