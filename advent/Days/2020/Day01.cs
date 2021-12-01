using advent.Extensions;
using System.Linq;

namespace advent.Days._2020
{
    public class Day01 : Day
    {
        public override string Part1(string input)
        {
            var data = input.Lines()
                .Select(x => int.Parse(x))
                .ToList()
                ;

            for (var i = 0; i < data.Count; ++i)
            {
                var a = data[i];

                for (var j = i + 1; j < data.Count; ++j)
                {
                    if (i == j) continue;

                    var b = data[j];

                    if (a + b == 2020)
                    {
                        return (a * b).ToString();
                    }
                }
            }

            return 0.ToString();
        }

        public override string Part2(string input)
        {
            var data = input.Lines()
                .Select(x => int.Parse(x))
                .ToList()
                ;

            for (var i = 0; i < data.Count; ++i)
            {
                var a = data[i];

                for (var j = i + 1; j < data.Count; ++j)
                {
                    if (i == j) continue;

                    var b = data[j];

                    for (var k = j + 1; k < data.Count; ++k)
                    {
                        if (i == k || j == k) continue;

                        var c = data[k];

                        if (a + b + c == 2020)
                        {
                            return (a * b * c).ToString();
                        }
                    }
                }
            }

            return 0.ToString();
        }
    }
}
