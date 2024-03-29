﻿using advent.Extensions;
using advent.Models._2020;

namespace advent.Days._2020
{
    public class Day12 : Day
    {
        public override string Part1(string input)
        {
            var data = input.Lines()
                ;

            var ship = new Ship();

            foreach (var line in data)
            {
                ship.Process(line);
            }

            return ship.GetManhattanDistance().ToString();
        }

        public override string Part2(string input)
        {
            var data = input.Lines();

            var waypoint = new Waypoint();

            foreach (var line in data)
            {
                waypoint.Process(line);
            }

            return waypoint.GetManhattanDistance().ToString();
        }
    }
}
