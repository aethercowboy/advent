using System.Collections.Generic;
using System.Linq;
using advent.Collections;
using advent.Extensions;

namespace advent.Days._2017
{
    public class Day10 : Day
    {
        public IRing<int> List { get; set; } = Globals.Ring;

        public static IRing<int> Part0(IRing<int> ring, IEnumerable<int> lengths, int iterations = 1)
        {
            var r = ring.Select(x => x).ToRing();

            var current = 0;
            var skip = 0;
            var lengthsList = lengths.ToList();

            foreach (var _ in Enumerable.Range(0, iterations))
            {
                foreach (var i in lengthsList)
                {
                    var range = Enumerable.Range(current, i).ToList();
                    var slice = range.Select(j => r[j]).ToList();
                    slice.Reverse();

                    var sidx = 0;

                    foreach (var j in range)
                    {
                        r[j] = slice[sidx++];
                    }
                    current += i + skip;
                    ++skip;
                }
            }

            return r;
        }

        public static IList<int> DenseHash(IRing<int> ring)
        {
            var result = new List<int>();

            for (var i = 0; i < ring.Count; i += 16)
            {
                var range = ring.Skip(i).Take(16).ToList();
                var val = range.Aggregate(0, (current, x) => current ^ x);

                result.Add(val);
            }

            return result;
        }

        public override long Part1(string input)
        {
            var lengths = input.Split(",").ToInts();

            var list = Part0(List, lengths);

            return list[0] * list[1];
        }

        public static string KnotHash(string input, IRing<int> ring)
        {
            var bytes = input.ToBytes().ToList();
            bytes.AddRange(new List<byte> { 17, 31, 73, 47, 23 });

            var list = Part0(ring, bytes.ToInt32(), 64);

            var response = DenseHash(list);

            return response.ToHex();
        }

        public override long Part2(string input)
        {
            var response = KnotHash(input, List);

            Console.WriteOutput(response);

            return 0;
        }
    }
}
