using System;
using System.Collections.Generic;
using System.Linq;
using advent.Extensions;

namespace advent.Days._2015
{
    public class Day14 : Day
    {
        public int Runtime { get; set; } = 2503;

        private class Deer
        {
            public string Name { get; set; }
            public int Speed { get; set; }
            public int Time { get; set; }
            public int Rest { get; set; }
            public int Distance { get; set; }
            public int Cooldown { get; set; }
            public int Ticks { get; set; }
            public int Score { get; set; }

        }

        private static IList<Deer> PopulateRates(string input)
        {
            return input.Lines()
                .Select(line => line.Words().ToList())
                .Select(t => new Deer
                {
                    Name = t[0],
                    Speed = t[3].ToInt(),
                    Time = t[6].ToInt(),
                    Rest = t[13].ToInt()
                })
                .ToList();
        }

        private void RunRace(IList<Deer> list)
        {
            foreach (var _ in Enumerable.Range(0, Runtime))
            {
                foreach (var deer in list)
                {
                    if (deer.Cooldown != 0)
                    {
                        deer.Cooldown--;
                    }
                    else
                    {
                        deer.Ticks++;
                        deer.Distance += deer.Speed;

                        if (deer.Ticks != deer.Time) continue;

                        deer.Cooldown = deer.Rest;
                        deer.Ticks = 0;
                    }
                }

                var max = list.Max(x => x.Distance);

                foreach (var deer in list.Where(x => x.Distance == max))
                {
                    deer.Score++;
                }
            }
        }

        private static int GetWinning(IEnumerable<Deer> list, Func<Deer, int> winningFunc)
        {
            return list.Max(winningFunc);
        }

        private static int GetWinningDistance(IEnumerable<Deer> list)
        {
            return GetWinning(list, x => x.Distance);
        }

        private static int GetWinningScore(IEnumerable<Deer> list)
        {
            return GetWinning(list, x => x.Score);
        }

        private int Part0(string input, Func<IEnumerable<Deer>, int> winningFunc)
        {
            var list = PopulateRates(input);

            RunRace(list);

            return winningFunc(list);
        }

        public override int Part1(string input)
        {
            return Part0(input, GetWinningDistance);
        }

        public override int Part2(string input)
        {
            return Part0(input, GetWinningScore);
        }
    }
}
