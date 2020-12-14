using advent.Enums._2020;
using System;
using System.Numerics;

namespace advent.Models._2020
{
    public class Ship
    {
        public Vector2 Position { get; private set; }
        public ShipDirection Direction { get; private set; }

        public Ship()
        {
            Position = Vector2.Zero;
            Direction = ShipDirection.East;
        }

        public void Process(string input)
        {
            var instruction = input[0];
            var units = int.Parse(input[1..]);

            switch (instruction)
            {
                case 'N':
                    MoveNorth(units);
                    break;
                case 'S':
                    MoveSouth(units);
                    break;
                case 'E':
                    MoveEast(units);
                    break;
                case 'W':
                    MoveWest(units);
                    break;
                case 'L':
                    TurnLeft(units);
                    break;
                case 'R':
                    TurnRight(units);
                    break;
                case 'F':
                    MoveForward(units);
                    break;
            }
        }

        private void MoveNorth(int units)
        {
            var transform = new Vector2(0, units);

            MoveVector(transform);
        }

        private void MoveSouth(int units)
        {
            var transform = new Vector2(0, -units);

            MoveVector(transform);
        }

        private void MoveEast(int units)
        {
            var transform = new Vector2(units, 0);

            MoveVector(transform);
        }

        private void MoveWest(int units)
        {
            var transform = new Vector2(-units, 0);

            MoveVector(transform);
        }

        private void MoveForward(int units)
        {
            var x = 0;
            var y = 0;

            switch (Direction)
            {
                case ShipDirection.North:
                    y = units;
                    break;
                case ShipDirection.East:
                    x = units;
                    break;
                case ShipDirection.South:
                    y = -units;
                    break;
                case ShipDirection.West:
                    x = -units;
                    break;
            }

            var transform = new Vector2(x, y);

            MoveVector(transform);
        }

        internal void MoveVector(Vector2 transform)
        {
            Position += transform;
        }

        private void TurnLeft(int units)
        {
            var steps = units / 90;

            Rotate(-steps);
        }

        private void TurnRight(int units)
        {
            var steps = units / 90;
            Rotate(steps);
        }

        private void Rotate(int steps)
        {
            var direction = (int)Direction + steps;
            var normalized = ((direction % 4) + 4) % 4;

            Direction = (ShipDirection)normalized;
        }

        public int GetManhattanDistance()
        {
            return (int)Math.Abs(Position.X) + (int)Math.Abs(Position.Y);
        }
    }
}
