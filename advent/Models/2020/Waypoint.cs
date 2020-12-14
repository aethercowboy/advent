using System.Numerics;

namespace advent.Models._2020
{
    public class Waypoint
    {
        private readonly Ship _ship;

        public Vector2 Position { get; private set; }

        public Waypoint()
        {
            _ship = new Ship();
            Position = new Vector2(10, 1);
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
                    MoveShip(units);
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

        private void MoveVector(Vector2 transform)
        {
            Position += transform;
        }

        private void MoveShip(int units)
        {
            _ship.MoveVector(Position * units);
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
            var normalized = ((steps % 4) + 4) % 4;

            switch (normalized)
            {
                case 0:
                    // do nothing
                    break;
                case 1: // one step right
                    Position = new Vector2(Position.Y, -Position.X);
                    break;
                case 2: // two steps right
                    Position = new Vector2(-Position.X, -Position.Y);
                    break;
                case 3: // three steps right
                    Position = new Vector2(-Position.Y, Position.X);
                    break;
            }
        }

        public int GetManhattanDistance()
        {
            return _ship.GetManhattanDistance();
        }
    }
}
