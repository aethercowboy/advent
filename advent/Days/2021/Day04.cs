using advent.Extensions;
using advent.IO;
using advent.Models._2021;
using System.Collections.Generic;
using System.Linq;

namespace advent.Days._2021
{
    public class Day04 : Day
    {
        public readonly IConsole _console;

        public Day04()
        {
        }

        public Day04(IConsole console)
        {
            _console = console;
        }

        public override string Part1(string input)
        {
            var data = input.Blocks()
                .ToList();

            var calls = data[0].Split(',')
                .ToInts()
                .ToList();

            var boards = data.Skip(1).Select(x => new BingoBoard(x))
                .ToList();

            foreach (var call in calls)
            {
                _console?.WriteLine($"Calling: {call}");

                foreach (var board in boards)
                {
                    board.Call(call);

                    _console?.WriteLine(board.ToString());

                    if (board.IsWinner())
                    {
                        return board.Score(call).ToString();
                    }
                }
            }

            return string.Empty;
        }

        public override string Part2(string input)
        {
            var data = input.Blocks().ToList();

            var calls = data[0].Split(',')
                .ToInts()
                .ToList();

            var boards = data.Skip(1).Select(x => new BingoBoard(x))
                .ToList();

            foreach (var call in calls)
            {
                _console?.WriteLine($"Calling: {call}");

                var winners = new List<BingoBoard>();

                foreach (var board in boards)
                {
                    board.Call(call);

                    _console?.WriteLine(board.ToString());

                    if (board.IsWinner())
                    {
                        winners.Add(board);
                    }
                }

                foreach (var board in winners)
                {
                    if (boards.Count > 1)
                    {
                        boards.Remove(board);
                    }
                    else
                    {
                        return boards[0].Score(call).ToString();
                    }
                }
            }

            return string.Empty;
        }
    }
}
