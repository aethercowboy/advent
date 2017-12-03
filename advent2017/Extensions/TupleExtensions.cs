using System;
using System.Collections.Generic;
using System.Text;

namespace advent2017.Extensions
{
    public static class TupleExtensions
    {
        public static Tuple<int, int> MoveRight(this Tuple<int, int> tuple)
        {
            return new Tuple<int, int>(tuple.Item1 + 1, tuple.Item2);
        }

        public static Tuple<int, int> MoveLeft(this Tuple<int, int> tuple)
        {
            return new Tuple<int, int>(tuple.Item1 - 1, tuple.Item2);
        }

        public static Tuple<int, int> MoveUp(this Tuple<int, int> tuple)
        {
            return new Tuple<int, int>(tuple.Item1, tuple.Item2 + 1);
        }

        public static Tuple<int, int> MoveDown(this Tuple<int, int> tuple)
        {
            return new Tuple<int, int>(tuple.Item1, tuple.Item2 - 1);
        }
    }
}