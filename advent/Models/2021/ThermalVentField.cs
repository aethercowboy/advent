using advent.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace advent.Models._2021
{
    internal class ThermalVentField
    {
        private readonly IList<ThermalVent> _vents;
        private readonly IDictionary<(int, int), int> _data;
        private readonly int _rows, _columns;

        public ThermalVentField(string input, bool includeDiagonals = false)
        {
            _vents = new List<ThermalVent>();
            _data = new Dictionary<(int, int), int>();

            foreach (var line in input.Lines())
            {
                var vent = new ThermalVent(line);

                if (includeDiagonals || vent.IsVertical() || vent.IsHorizontal())
                {
                    _vents.Add(vent);

                    foreach (var point in vent.GetPoints())
                    {
                        var key = (point.X, point.Y);

                        if (_data.ContainsKey(key))
                        {
                            _data[key]++;
                        }
                        else
                        {
                            _data.Add(key, 1);
                        }
                    }
                }
            }

            _columns = _data.Keys.Max(x => x.Item1);
            _rows = _data.Keys.Max(x => x.Item2);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            for (var i = 0; i <= _rows; i++)
            {
                for (var j = 0; j <= _columns; j++)
                {
                    if (_data.ContainsKey((j, i)))
                    {
                        sb.Append(_data[(j, i)]);
                    }
                    else
                    {
                        sb.Append('.');
                    }
                }

                sb.AppendLine();
            }

            return sb.ToString();
        }

        public int GetMostDangerousPoints()
        {
            return _data.Values.Count(x => x >= 2)
                ;
        }
    }

    internal class ThermalVent
    {
        public ThermalPoint Start { get; }
        public ThermalPoint End { get; }

        public ThermalVent(string input)
        {
            var parts = input.Split(" -> ")
                .Select(x => new ThermalPoint(x))
                .ToList();

            Start = parts[0];
            End = parts[1];
        }

        public bool IsVertical()
        {
            return Start.Y == End.Y;
        }

        public bool IsHorizontal()
        {
            return Start.X == End.X;
        }

        public IEnumerable<ThermalPoint> GetPoints()
        {
            var minX = Math.Min(Start.X, End.X);
            var minY = Math.Min(Start.Y, End.Y);
            var maxX = Math.Max(Start.X, End.X);
            var maxY = Math.Max(Start.Y, End.Y);

            if (minX == maxX || minY == maxY)
            {
                for (var i = minX; i <= maxX; i++)
                {
                    for (var j = minY; j <= maxY; j++)
                    {
                        yield return new ThermalPoint(i, j);
                    }
                }
            }
            else
            {
                Func<int, int> iIncrementFunc;
                Func<int, int> jIncrementFunc;
                Func<int, bool> iCheckFunc;
                Func<int, bool> jCheckFunc;

                if (Start.X < End.X)
                {
                    iIncrementFunc = (x) => x + 1;
                    iCheckFunc = (x) => x <= End.X;
                }
                else
                {
                    iIncrementFunc = (x) => x - 1;
                    iCheckFunc = (x) => x >= End.X;
                }

                if (Start.Y < End.Y)
                {
                    jIncrementFunc = (x) => x + 1;
                    jCheckFunc = (x) => x <= End.Y;
                }
                else
                {
                    jIncrementFunc = (x) => x - 1;
                    jCheckFunc = (x) => x >= End.Y;
                }

                for (int i = Start.X, j = Start.Y; iCheckFunc(i) && jCheckFunc(j); i = iIncrementFunc(i), j = jIncrementFunc(j))
                {
                    yield return new ThermalPoint(i, j);
                }
            }
        }
    }

    internal class ThermalPoint
    {
        public int X { get; }
        public int Y { get; }

        public ThermalPoint(int x, int y)
        {
            X = x;
            Y = y;
        }

        public ThermalPoint(string input)
        {
            var points = input.Split(',')
                .ToInts()
                .ToList();

            X = points[0];
            Y = points[1];
        }
    }
}
