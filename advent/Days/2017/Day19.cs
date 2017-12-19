using System;
using System.Collections.Generic;
using System.Linq;
using advent.Extensions;

namespace advent.Days._2017
{
    public class Day19 : Day
    {
        private int Part0(string input)
        {
            var maze = new Maze(input);

            var output = new string(maze.Run().ToArray());

            Console.WriteOutput(output);

            return maze.Steps;
        }

        public override int Part1(string input)
        {
            return Part0(input);
        }

        public override int Part2(string input)
        {
            return Part0(input);
        }
    }

    public class Maze
    {
        private IList<IList<char>> Grid { get; }
        private Tuple<int, int> CurrentPosition { get; set; }
        private Tuple<int, int> Direction { get; set; }
        public int Steps { get; set; }

        public Maze(string input)
        {
            Grid = input.Lines()
                .Select(line => line.ToList())
                .Cast<IList<char>>()
                .ToList();

            CurrentPosition = new Tuple<int, int>(0, Grid[0].IndexOf('|'));
            SetDirection(D.Down);
            ++Steps;
        }

        private enum D
        {
            Up,
            Down,
            Left,
            Right
        };

        private void SetDirection(D dir)
        {
            switch (dir)
            {
                case D.Up:
                    Direction = new Tuple<int, int>(-1, 0);
                    break;
                case D.Down:
                    Direction = new Tuple<int, int>(1, 0);
                    break;
                case D.Left:
                    Direction = new Tuple<int, int>(0, -1);
                    break;
                case D.Right:
                    Direction = new Tuple<int, int>(0, 1);
                    break;
            }
        }

        private char GetValueAt(int x, int y)
        {
            if (x >= Grid.Count || y >= Grid[0].Count)
            {
                return ' ';
            }

            return char.ToLower(Grid[x][y]);
        }

        private char Move()
        {
            CurrentPosition = new Tuple<int, int>(
                CurrentPosition.Item1 + Direction.Item1,
                CurrentPosition.Item2 + Direction.Item2
            );

            ++Steps;

            return GetValueAt(CurrentPosition.Item1, CurrentPosition.Item2);
        }

        public IEnumerable<char> Run()
        {
            while (true)
            {
                var c = Move();

                switch (c)
                {
                    case '|':
                        break;
                    case '-':
                        break;
                    case '+':
                        if (Direction.Item1 != 0) // Up/Down
                        {
                            var left = GetValueAt(CurrentPosition.Item1, CurrentPosition.Item2 - 1);
                            var right = GetValueAt(CurrentPosition.Item1, CurrentPosition.Item2 + 1);

                            if (left == '-' || Globals.Alphabet.Contains(left))
                            {
                                SetDirection(D.Left);
                            }
                            else if (right == '-' || Globals.Alphabet.Contains(right))
                            {
                                SetDirection(D.Right);
                            }
                        }
                        else if (Direction.Item2 != 0) // Left/Right
                        {
                            var up = GetValueAt(CurrentPosition.Item1 - 1, CurrentPosition.Item2);
                            var down = GetValueAt(CurrentPosition.Item1 + 1, CurrentPosition.Item2);
                            if (up == '|' || Globals.Alphabet.Contains(up))
                            {
                                SetDirection(D.Up);
                            }
                            else if (down == '|' || Globals.Alphabet.Contains(down))
                            {
                                SetDirection(D.Down);
                            }
                        }
                        break;
                    default:
                        yield return char.ToUpper(c);

                        if (Direction.Item1 != 0) // Up/Down
                        {
                            if (Direction.Item1 < 0) // We're Moving Up and Not at Top
                            {
                                var up = GetValueAt(CurrentPosition.Item1 - 1, CurrentPosition.Item2);
                                if (up != '|' && up != '+')
                                {
                                    if (up == '-')
                                    {
                                        var up2 = GetValueAt(CurrentPosition.Item1 - 2, CurrentPosition.Item2);
                                        if (up2 == '-')
                                        {
                                            break;
                                        }
                                    }
                                    yield break;
                                }
                            }
                            else if (Direction.Item1 > 0)
                            {
                                var down = GetValueAt(CurrentPosition.Item1 + 1, CurrentPosition.Item2);                                if (down != '|' && down != '+')
                                {
                                    if (down == '-')
                                    {
                                        var down2 = GetValueAt(CurrentPosition.Item1 + 2, CurrentPosition.Item2);
                                        if (down2 == '-')
                                        {
                                            break;
                                        }
                                    }
                                    yield break;
                                }
                            }
                        }
                        else if (Direction.Item2 != 0) // Left/Right
                        {
                            if (Direction.Item2 < 0)
                            {
                                var left = GetValueAt(CurrentPosition.Item1, CurrentPosition.Item2 - 1);
                                if (left != '-' && left != '+')
                                {
                                    if (left == '|')
                                    {
                                        var left2 = GetValueAt(CurrentPosition.Item1, CurrentPosition.Item2 - 2);
                                        if (left2 == '-')
                                        {
                                            break;
                                        }
                                    }
                                    yield break;
                                }
                            }
                            else if (Direction.Item2 > 0)
                            {
                                var right = GetValueAt(CurrentPosition.Item1, CurrentPosition.Item2 + 1);
                                if (right != '-' && right != '+')
                                {
                                    if (right == '|')
                                    {
                                        var right2 = GetValueAt(CurrentPosition.Item1, CurrentPosition.Item2 + 2);
                                        if (right2 == '-')
                                        {
                                            break;
                                        }
                                    }
                                    yield break;
                                }
                            }
                        }
                        break;
                }
            }
        }
    }
}