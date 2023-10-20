using advent.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace advent.Models._2021
{
    internal class OctopusGarden
    {
        private readonly IDictionary<(int, int), Octopus> _octopuses;
        private readonly int _x, _y;

        public OctopusGarden(string input)
        {
            _octopuses = new Dictionary<(int, int), Octopus>();

            var lines = input.Lines()
                .ToList();

            _x = lines.Count;
            _y = lines[0].Length;

            for (var i = 0; i < lines.Count; i++)
            {
                var line = lines[i]
                    .Select(x => x.ToString())
                    .ToInts()
                    .ToList();

                for (var j = 0; j < line.Count; j++)
                {
                    var value = line[j];
                    _octopuses.Add((i, j), new Octopus(i, j, value));
                }
            }
        }

        public int GetFlashes(int days)
        {
            var value = 0;

            for (var i = 0; i < days; i++)
            {
                foreach (var octopus in _octopuses.Values)
                {
                    octopus.Increase();
                }

                while (_octopuses.Values.Any(x => x.Value >= 9 && !x.HasFlashed))
                {
                    foreach (var octopus in _octopuses.Values.Where(x => x.Value >= 9 && !x.HasFlashed).ToList())
                    {
                        value += octopus.Flash();

                        foreach (var neighbor in GetNeighbors(octopus))
                        {
                            neighbor.Increase();
                        }
                    }
                }

                foreach (var octopus in _octopuses.Values)
                {
                    octopus.Reset();
                }
            }

            return value;
        }

        private IEnumerable<Octopus> GetNeighbors(Octopus o)
        {
            for (var i = -1; i < 2; i++)
            {
                for (var j = -1; j < 2; j++)
                {
                    if (i == 0 && j == 0) continue;

                    var x = o.X + i;
                    var y = o.Y + j;

                    if (_octopuses.ContainsKey((x, y)))
                    {
                        yield return _octopuses[(x, y)];
                    }
                }
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            for (var i = 0; i < _x; i++)
            {
                for (var j = 0; j < _y; j++)
                {
                    var value = Math.Min(_octopuses[(i, j)].Value, 9);

                    sb.Append(value);
                }

                sb.AppendLine();
            }

            return sb.ToString();
        }
    }

    internal class Octopus
    {
        public int Value { get; private set; }
        public bool HasFlashed { get; private set; }
        public int X { get; }
        public int Y { get; }

        public Octopus(int x, int y, int value)
        {
            X = x;
            Y = y;
            Value = value;
        }

        public void Increase()
        {
            Value++;
        }

        public int Flash()
        {
            HasFlashed = true;

            return 1;
        }

        public void Reset()
        {
            HasFlashed = false;

            if (Value >= 9)
            {
                Value = 0;
            }
        }
    }
}
