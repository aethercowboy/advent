using advent.Extensions;
using System.Collections.Generic;
using System.Linq;

namespace advent.Models._2021
{
    internal class HeightMap
    {
        private readonly IDictionary<(int, int), int> _map;
        private readonly int _height, _width;

        public HeightMap(string input)
        {
            _map = new Dictionary<(int, int), int>();

            var lines = input.Lines().ToList();

            for (var i = 0; i < lines.Count; i++)
            {
                string line = lines[i];

                for (int j = 0; j < line.Length; j++)
                {
                    int value = int.Parse(line[j].ToString());
                    _map.Add((i, j), value);
                }
            }

            _width = lines.Count;
            _height = lines[0].Length;
        }

        public int GetRiskLevel()
        {
            return GetLowPoints()
                .Select(x => GetValue(x.Item1, x.Item2) + 1)
                .Sum();
        }

        public int GetBasinSizes()
        {
            return GetBasins()
                .Select(x => x.Size)
                .OrderByDescending(x => x)
                .Take(3)
                .Aggregate(1, (a, b) => a * b)
                ;
        }

        private IEnumerable<Basin> GetBasins()
        {
            foreach (var point in GetLowPoints())
            {
                Basin basin = new(point);

                foreach (var additional in GetBasinPoints(point.Item1, point.Item2))
                {
                    basin.AddPoint(additional);
                }

                yield return basin;
            }
        }

        private IEnumerable<(int, int)> GetBasinPoints(int x, int y, HashSet<(int, int)> points = null)
        {
            if (points == null)
            {
                points = new HashSet<(int, int)>
                {
                    (x, y)
                };
            }

            var adjacents = GetAdjacents(x, y)
                .Where(x => GetValue(x.Item1, x.Item2) < 9 && !points.Contains(x))
                ;

            foreach (var point in adjacents)
            {
                points.Add(point);

                yield return point;

                foreach (var additional in GetBasinPoints(point.Item1, point.Item2, points))
                {
                    points.Add(additional);

                    yield return additional;
                }
            }
        }

        private IEnumerable<(int, int)> GetLowPoints()
        {
            for (int i = 0; i < _width; i++)
            {
                for (int j = 0; j < _height; j++)
                {
                    if (IsLowPoint(i, j))
                    {
                        yield return (i, j);
                    }
                }
            }
        }

        private bool IsLowPoint(int x, int y)
        {
            int value = GetValue(x, y);

            return GetAdjacents(x, y)
                .All(x => value < GetValue(x.Item1, x.Item2))
                ;
        }

        private int GetValue(int x, int y)
        {
            return _map.ContainsKey((x, y))
                ? _map[(x, y)]
                : int.MaxValue;
        }

        private static IEnumerable<(int, int)> GetAdjacents(int x, int y)
        {
            yield return (x - 1, y);
            yield return (x + 1, y);
            yield return (x, y - 1);
            yield return (x, y + 1);
        }
    }

    internal class Basin
    {
        private readonly HashSet<(int, int)> _points;

        public int Size => _points.Count;

        public Basin((int, int) point)
        {
            _points = new HashSet<(int, int)>();

            AddPoint(point);
        }

        public void AddPoint((int, int) point)
        {
            _points.Add(point);
        }
    }
}
