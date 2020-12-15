using System;
using System.Numerics;

namespace advent.Extensions
{
    public static class TupleExtensions
    {
        private enum Direction
        {
            Up,
            Down,
            Left,
            Right
        };

        private static Tuple<int, int> MoveDirection(this Tuple<int, int> tuple, Direction direction)
        {
            if (tuple == null) return null;

            var x = tuple.Item1;
            var y = tuple.Item2;

            switch (direction)
            {
                case Direction.Down:
                    y--;
                    break;
                case Direction.Up:
                    y++;
                    break;
                case Direction.Left:
                    x--;
                    break;
                case Direction.Right:
                    x++;
                    break;
            }

            return MoveXY(x, y);
        }

        private static Tuple<int, int> MoveXY(int x, int y)
        {
            return new Tuple<int, int>(x, y);
        }

        public static Tuple<int, int> MoveRight(this Tuple<int, int> tuple)
        {
            return tuple.MoveDirection(Direction.Right);
        }

        public static Tuple<int, int> MoveLeft(this Tuple<int, int> tuple)
        {
            return tuple.MoveDirection(Direction.Left);
        }

        public static Tuple<int, int> MoveUp(this Tuple<int, int> tuple)
        {
            return tuple.MoveDirection(Direction.Up);
        }

        public static Tuple<int, int> MoveDown(this Tuple<int, int> tuple)
        {
            return tuple.MoveDirection(Direction.Down);
        }
    }

    public static class VectorExtensions
    {
        public static int ManhattanDistance(this Vector3 vect)
        {
            return (int)(Math.Abs(vect.X)
                   + Math.Abs(vect.Y)
                   + Math.Abs(vect.Z))
                ;
        }
    }
}