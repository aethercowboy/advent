using advent.Extensions;
using System.Linq;

namespace advent.Days._2020
{
    public class Day01 : Day
    {
        public override int Part1(string input)
        {
            var data = input.Lines()
                .Select(x => int.Parse(x))
                .ToList()
                ;

            for (var i = 0; i < data.Count; ++i)
            {
                var a = data[i];

                for (var j = 0; j < data.Count; ++j)
                {
                    if (i == j) continue;

                    var b = data[j];

                    if (a + b == 2020)
                    {
                        return a * b;
                    }
                }
            }

            return 0;
        }

        public override long Part2(string input)
        {
            var data = input.Lines()
                .Select(x => int.Parse(x))
                .ToList()
                ;

            for (var i = 0; i < data.Count; ++i)
            {
                var a = data[i];

                for (var j = 0; j < data.Count; ++j)
                {
                    if (i == j) continue;

                    var b = data[j];

                    for (var k = 0; k < data.Count; ++k)
                    {
                        if (i == k || j == k) continue;

                        var c = data[k];

                        if (a + b + c == 2020)
                        {
                            return a * b * c;
                        }
                    }
                }
            }

            return 0;
        }
    }
}
