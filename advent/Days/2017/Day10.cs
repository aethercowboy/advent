using System;
using System.Collections.Generic;
using System.Linq;
using advent.Collections;
using advent.Extensions;

namespace advent.Days._2017
{
    public class Day10 : Day
    {
        public IRing<int> List { get; set; } = Enumerable.Range(0, 256).ToRing();

        public IRing<int> Part0(IRing<int> ring, IEnumerable<int> lengths, int iterations = 1)
        {
            var current = 0;
            var skip = 0;
            var lengthsList = lengths.ToList();

            foreach (var _ in Enumerable.Range(0, iterations))
            {
                foreach (var i in lengthsList)
                {
                    var range = Enumerable.Range(current, i).ToList();
                    var slice = range.Select(j => ring[j]).ToList();
                    slice.Reverse();

                    var sidx = 0;

                    foreach (var j in range)
                    {
                        ring[j] = slice[sidx++];
                    }
                    current += i + skip;
                    ++skip;
                }
            }

            return ring;
        }

        public IList<int> DenseHash(IRing<int> ring)
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

        public override int Part1(string input)
        {
            List = List.OrderBy(x => x).ToRing();

            var lengths = input.Split(",").ToInts();

            var list = Part0(List, lengths);

            return list[0] * list[1];
        }

        public override int Part2(string input)
        {
            List = List.OrderBy(x => x).ToRing();

            var bytes = input.ToBytes().ToList();
            bytes.AddRange(new List<byte> {17, 31, 73, 47, 23});

            var list = Part0(List, bytes.ToInt32(), 64);

            var response = DenseHash(list);

            Console.WriteOutput(response.ToHex());

            return list[0] * list[1];
        }
    }
}
