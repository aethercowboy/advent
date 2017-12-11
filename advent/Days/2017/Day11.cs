using System;

namespace advent.Days._2017
{
    public class Day11 : Day
    {
        public AdventHex Part0(string input)
        {
            var hex = new AdventHex();

            foreach (var move in input.Split(','))
            {
                switch (move)
                {
                    case "n":
                        hex.MoveNorth();
                        break;
                    case "ne":
                        hex.MoveNorthEast();
                        break;
                    case "nw":
                        hex.MoveNorthWest();
                        break;
                    case "s":
                        hex.MoveSouth();
                        break;
                    case "sw":
                        hex.MoveSouthWest();
                        break;
                    case "se":
                        hex.MoveSouthEast();
                        break;
                }
            }

            return hex;
        }

        public override int Part1(string input)
        {
            var hex = Part0(input);

            return hex.DistanceToStart();
        }

        public override int Part2(string input)
        {
            var hex = Part0(input);

            return hex.MaxDistance;
        }
    }

    public class AdventHex
    {
        public int MaxDistance { get; set; }

        public int X { get; set; }
        public int Y { get; set; }

        public void MoveNorth()
        {
            X += 1;
            MaxDistance = Math.Max(MaxDistance, DistanceToStart());
        }

        public void MoveNorthEast()
        {
            X += 1;
            Y += 1;
            MaxDistance = Math.Max(MaxDistance, DistanceToStart());
        }

        public void MoveSouthEast()
        {
            Y += 1;
            MaxDistance = Math.Max(MaxDistance, DistanceToStart());
        }

        public void MoveSouth()
        {
            X -= 1;
            MaxDistance = Math.Max(MaxDistance, DistanceToStart());
        }

        public void MoveSouthWest()
        {
            Y -= 1;
            X -= 1;
            MaxDistance = Math.Max(MaxDistance, DistanceToStart());
        }

        public void MoveNorthWest()
        {
            Y -= 1;
            MaxDistance = Math.Max(MaxDistance, DistanceToStart());
        }

        public int DistanceToStart()
        {
            if (X > 0 && Y < 0
                || X < 0 && Y > 0)
            {
                return Math.Abs(X) + Math.Abs(Y);
            }

            return Math.Max(Math.Abs(X), Math.Abs(Y));
        }
    }
}