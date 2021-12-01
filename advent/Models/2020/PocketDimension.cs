using advent.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace advent.Models._2020
{
    public class PocketDimension
    {
        private IDictionary<int, DimensionSlice> Slices;

        public PocketDimension(string input)
        {
            Slices = new Dictionary<int, DimensionSlice>();

            var slice = new DimensionSlice(0, input);

            Slices.Add(0, slice);
        }

        public bool GetState(int x, int y, int z)
        {
            var slice = GetSlice(x);

            return slice.GetState(y, z);
        }

        private DimensionSlice GetSlice(int i)
        {
            if (!Slices.ContainsKey(i))
            {
                var slice = new DimensionSlice(i);
                Slices.Add(i, slice);
            }

            return Slices[i];
        }

        private Cube GetCube(int x, int y, int z)
        {
            return GetSlice(x).GetCube(y, z);
        }

        private IEnumerable<Cube> GetCubes()
        {
            throw new NotImplementedException();
        }

        public void Process()
        {
            foreach (var cube in GetCubes())
            {
            }
        }
    }

    internal class DimensionSlice
    {
        private IDictionary<int, CubeRow> CubeRows;

        private int Position;

        internal DimensionSlice(int position)
        {
            Position = position;

            CubeRows = new Dictionary<int, CubeRow>();
        }

        public DimensionSlice(int position, string input) : this(position)
        {
            var lines = input.Lines().ToList();

            for (var i = 0; i < lines.Count; i++)
            {
                AddRow(i, lines[i]);
            }
        }

        private void AddRow(int i, string line)
        {
            var position = new Vector2(Position, i);

            var cubeRow = new CubeRow(position, line);

            CubeRows.Add(i, cubeRow);
        }

        private CubeRow GetRow(int i)
        {
            if (!CubeRows.ContainsKey(i))
            {
                var position = new Vector2(Position, i);

                var cubeRow = new CubeRow(position);

                CubeRows.Add(i, cubeRow);
            }

            return CubeRows[i];
        }

        public bool GetState(int y, int z)
        {
            var cubeRow = GetRow(y);

            return cubeRow.GetState(z);
        }

        internal Cube GetCube(int y, int z)
        {
            return GetRow(y).GetCube(z);
        }
    }

    internal class CubeRow
    {
        private IDictionary<int, Cube> Cubes;
        private Vector2 Position;

        internal CubeRow(Vector2 position)
        {
            Cubes = new Dictionary<int, Cube>();
            Position = position;
        }

        public CubeRow(Vector2 position, string line) : this(position)
        {
            for (var i = 0; i < line.Length; i++)
            {
                AddCube(i, line[i]);
            }
        }

        private void AddCube(int i, char c)
        {
            var position = new Vector3(Position.X, Position.Y, i);

            var cube = new Cube(position, c);

            Cubes.Add(i, cube);
        }

        internal Cube GetCube(int i)
        {
            if (!Cubes.ContainsKey(i))
            {
                var position = new Vector3(Position.X, Position.Y, i);

                var cube = new Cube(position);
                Cubes.Add(i, cube);
            }

            return Cubes[i];
        }

        public bool GetState(int z)
        {
            var cube = GetCube(z);

            return cube.GetState();
        }
    }

    internal class Cube
    {
        private bool State;
        private Vector3 Position;

        internal Cube(Vector3 position)
        {
            Position = position;
        }

        public Cube(Vector3 position, char c) : this(position)
        {
            switch (c)
            {
                case '.':
                    State = false;
                    break;
                case '#':
                    State = true;
                    break;
            }
        }

        public bool GetState()
        {
            return State;
        }

        public Vector3 GetPosition()
        {
            return Position;
        }
    }
}
