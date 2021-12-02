using advent.Extensions;
using System;
using System.Linq;

namespace advent.Models._2021
{
    internal class SubmarinePosition
    {
        public int Horizontal { get; protected set; }
        public int Depth { get; protected set; }

        public virtual void Forward(int x)
        {
            Horizontal += x;
        }

        public virtual void Down(int x)
        {
            Depth += x;
        }

        public virtual void Up(int x)
        {
            Depth -= x;
        }

        public void Process(SubmarineDirection direction)
        {
            switch (direction.Direction)
            {
                case Direction.Forward:
                    Forward(direction.Quantity);
                    break;
                case Direction.Down:
                    Down(direction.Quantity);
                    break;
                case Direction.Up:
                    Up(direction.Quantity);
                    break;
                default:
                    throw new ArgumentException("Problem with Submarine Direction", nameof(direction));
            }
        }

        public int GetHorizontalPositionAndDepth()
        {
            return Horizontal * Depth;
        }
    }

    internal enum Direction
    {
        Forward,
        Down,
        Up
    }

    internal class SubmarineDirection
    {
        public Direction Direction { get; }
        public int Quantity { get; }

        public SubmarineDirection(Direction direction, int quantity)
        {
            Direction = direction;
            Quantity = quantity;
        }

        public SubmarineDirection(string direction, string quantity) : this(direction.ToDirection(), quantity.ToInt())
        {
        }

        public SubmarineDirection(params string[] parts) : this(parts[0], parts[1])
        {
        }

        public SubmarineDirection(string data) : this(data.Split().ToArray())
        {
        }
    }

    internal static class StringExtensions
    {
        public static Direction ToDirection(this string direction)
        {
            return direction.ToLower() switch
            {
                "forward" => Direction.Forward,
                "down" => Direction.Down,
                "up" => Direction.Up,
                _ => throw new IndexOutOfRangeException("Unrecognized direction"),
            };
        }
    }

    internal class SubmarinePosition2 : SubmarinePosition
    {
        public int Aim { get; private set; }

        public override void Down(int x)
        {
            Aim += x;
        }

        public override void Up(int x)
        {
            Aim -= x;
        }

        public override void Forward(int x)
        {
            Horizontal += x;
            Depth += Aim * x;
        }
    }
}
