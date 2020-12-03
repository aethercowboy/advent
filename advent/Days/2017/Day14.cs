﻿using System;
using System.Collections.Generic;
using System.Linq;
using advent.Extensions;

namespace advent.Days._2017
{
    public class Day14 : Day
    {
        private IEnumerable<string> Part0(string input)
        {
            var blocks = Enumerable.Range(0, 128)
                .Select(i => Day10.KnotHash($"{input}-{i}", Globals.Ring))
                .Select(k => string.Join("", k.Chunk(1)
                        .Select(x => Convert.ToInt32(x, 16))
                        .Select(x => Convert.ToString(x, 2)
                            .PadLeft(4, '0')
                        )
                    )
                );

            return blocks;
        }

        public override int Part1(string input)
        {
            var blocks = Part0(input);


            return blocks.Sum(x => x.Count(y => y == '1'));
        }

        public override long Part2(string input)
        {
            var blocks = Part0(input).ToList();

            var regions = new List<List<Tuple<int, int>>>();

            for (var i = 0; i < blocks.Count; ++i)
            {
                var line = blocks[i];
                for (var j = 0; j < line.Length; ++j)
                {

                    var c = line[j];

                    if (c == '1')
                    {
                        var l = i - 1;

                        var current = new Tuple<int, int>(i, j);
                        var currentRegion = new List<Tuple<int, int>> {current};

                        var left = new Tuple<int, int>(l, j);

                        var leftRegion = regions.FirstOrDefault(x => x.Any(y => Equals(y, left)));

                        if (leftRegion != null)
                        {
                            currentRegion.AddRange(leftRegion);
                            regions.Remove(leftRegion);
                        }

                        var u = j - 1;

                        var up = new Tuple<int, int>(i, u);

                        var upRegion = regions.FirstOrDefault(x => x.Any(y => Equals(y, up)));

                        if (upRegion != null)
                        {
                            currentRegion.AddRange(upRegion);
                            regions.Remove(upRegion);
                        }

                        regions.Add(currentRegion);
                    }
                }
            }

            return regions.Count;
        }
    }
}
