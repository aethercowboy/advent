﻿using advent.Models._2020;
using System.Collections.Generic;

namespace advent.Days._2020
{
    public class Day11 : Day
    {
        public override string Part1(string input)
        {
            var layout = new SeatLayout(input);

            var seen = new HashSet<string>();

            var status = layout.ToString();

            while (seen.Add(status))
            {
                status = layout.Process();
            }

            return layout.OccupiedCount().ToString();
        }

        public override string Part2(string input)
        {
            var layout = new SeatLayout(input);

            var seen = new HashSet<string>();

            var status = layout.ToString();

            while (seen.Add(status))
            {
                status = layout.Process2();
            }

            return layout.OccupiedCount().ToString();
        }
    }
}
