using System;
using System.Collections.Generic;
using System.Linq;

namespace advent.Days._2015
{
    public class Day06 : Day
    {
        private List<List<int>> _lightsList;


        private void ChangeLight(Tuple<int, int> key, int value)
        {
            _lightsList[key.Item1][key.Item2] = value;
        }

        private void TurnOnLight(Tuple<int, int> key)
        {
            ChangeLight(key, 1);
        }

        private void TurnOffLight(Tuple<int, int> key)
        {
            ChangeLight(key, 0);
        }

        private int GetValue(Tuple<int, int> key)
        {
            return _lightsList[key.Item1][key.Item2];
        }

        private void ToggleLight(Tuple<int, int> key)
        {
            ChangeLight(key, Math.Abs(GetValue(key) - 1));
        }

        private Action<Tuple<int, int>> IncreaseLight(int increment)
        {
            return key =>
            {
                ChangeLight(key, Math.Max(GetValue(key) + increment, 0));
            };
        }

        private static void ActOnLight(string start, string end, Action<Tuple<int, int>> func)
        {
            var starts = start.Split(',');
            var ends = end.Split(',');

            var startX = int.Parse(starts[0]);
            var startY = int.Parse(starts[1]);
            var endX = int.Parse(ends[0]);
            var endY = int.Parse(ends[1]);

            for (var i = startX; i <= endX; ++i)
            {
                for (var j = startY; j <= endY; ++j)
                {
                    var key = new Tuple<int, int>(i, j);
                    func(key);
                }
            }
        }

        private void TurnOn(string start, string end)
        {
            ActOnLight(start, end, TurnOnLight);

        }

        private void TurnOff(string start, string end)
        {
            ActOnLight(start, end, TurnOffLight);
        }

        private void Toggle(string start, string end)
        {
            ActOnLight(start, end, ToggleLight);
        }

        private void Increase(string start, string end)
        {
            Increase(start, end, 1);
        }

        private void Decrease(string start, string end)
        {
            Increase(start, end, -1);
        }

        private void Increase2(string start, string end)
        {
            Increase(start, end, 2);
        }

        private void Increase(string start, string end, int increment)
        {
            ActOnLight(start, end, IncreaseLight(increment));
        }

        private static void ProcessLine0(string input, Action<string, string> turnOnFunc, Action<string, string>turnOffFunc, Action<string, string>toggleFunc)
        {
            var parts = input.Split(" ");

            switch (parts[0])
            {
                case "turn":
                    switch (parts[1])
                    {
                        case "on":
                            turnOnFunc(parts[2], parts[4]);
                            break;
                        case "off":
                            turnOffFunc(parts[2], parts[4]);
                            break;
                    }
                    break;
                case "toggle":
                    toggleFunc(parts[1], parts[3]);
                    break;
            }
        }

        private void ProcessLine1(string input)
        {
            ProcessLine0(input, TurnOn, TurnOff, Toggle);
        }

        private void ProcessLine2(string input)
        {
            ProcessLine0(input, Increase, Decrease, Increase2);
        }

        private int Part0(string input, Action<string> lineFunc)
        {
            _lightsList = new List<List<int>>();

            for (var i = 0; i < 1000; ++i)
            {
                var light = new List<int>();
                _lightsList.Add(light);

                for (var j = 0; j < 1000; ++j)
                {
                    light.Add(0);
                }
            }

            foreach (var line in input.Split("\n"))
            {
                lineFunc(line);
            }

            return _lightsList.Sum(x => x.Sum());
        }

        public override int Part1(string input)
        {
            return Part0(input, ProcessLine1);
        }

        public override long Part2(string input)
        {
            return Part0(input, ProcessLine2);
        }
    }
}
