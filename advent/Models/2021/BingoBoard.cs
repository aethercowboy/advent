using advent.Extensions;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace advent.Models._2021
{
    internal class BingoBoard
    {
        private readonly IDictionary<(int, int), BingoSpace> _spaces;

        private readonly int _rows, _columns;

        public BingoBoard(string input)
        {
            _spaces = new Dictionary<(int, int), BingoSpace>();

            var lines = input.Lines()
                .ToList();

            _rows = lines.Count;

            for (var i = 0; i < lines.Count; i++)
            {
                var line = lines[i];
                var words = line.Words().ToInts().ToList();

                _columns = words.Count;

                for (var j = 0; j < words.Count; j++)
                {
                    var value = words[j];
                    var space = new BingoSpace(value);
                    _spaces.Add((i, j), space);
                }
            }
        }

        public void Call(int call)
        {
            foreach (var space in _spaces.Values)
            {
                space.Call(call);
            }
        }

        public bool IsWinner()
        {
            // 1. rows

            for (var i = 0; i < _rows; i++)
            {
                var isRow = Enumerable.Range(0, _columns)
                    .Select(x => _spaces[(i, x)])
                    .All(x => x.IsCalled)
                    ;

                if (isRow) return true;
            }

            // 2. cols
            for (var i = 0; i < _columns; i++)
            {
                var isCol = Enumerable.Range(0, _rows)
                    .Select(x => _spaces[(x, i)])
                    .All(x => x.IsCalled);

                if (isCol) return true;
            }

            return false;
        }

        public int Score(int call)
        {
            return call * _spaces.Values.Where(x => !x.IsCalled)
                .Select(x => x.Value)
                .Sum();
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            for (var i = 0; i < _rows; i++)
            {
                for (var j = 0; j < _columns; j++)
                {
                    var space = _spaces[(i, j)];
                    sb.Append(space);
                }
                sb.AppendLine();
            }

            return sb.ToString();
        }
    }

    internal class BingoSpace
    {
        public int Value { get; }
        public bool IsCalled { get; private set; }

        public BingoSpace(int value)
        {
            Value = value;
        }

        public void Call(int value)
        {
            if (Value == value)
            {
                IsCalled = true;
            }
        }

        public override string ToString()
        {
            return IsCalled
                ? $"*{Value}*"
                : $" {Value} ";
        }
    }
}
