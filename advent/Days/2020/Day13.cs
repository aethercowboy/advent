using advent.Extensions;
using System.Linq;

namespace advent.Days._2020
{
    public class Day13 : Day
    {
        public override string Part1(string input)
        {
            var lines = input.Lines().ToList();

            var index = int.Parse(lines[0]);

            var busses = lines[1].Split(',').Where(x => x != "x").ToInts();

            var i = index;

            while (!busses.Any(x => i % x == 0))
            {
                i++;
            }

            return (busses.FirstOrDefault(x => i % x == 0) * (i - index)).ToString();
        }

        public override string Part2(string input)
        {
            var busSchedules = input.Lines()
                .Skip(1)
                .First()
                .Split(',')
                .ToList();

            var busDepartures = busSchedules
                 .Select((x, i) => new
                 {
                     Number = x,
                     Value = x == "x" ? 1 : int.Parse(x),
                     Index = i
                 })
                 .Where(x => x.Number != "x")
                 .ToList();

            var firstBus = busDepartures[0];

            var startTime = GetNextDepartureTime(0, firstBus.Value);

            long incrementAmount = firstBus.Value;
            int lockedIn = 0;

            for (long testTime = startTime; ; testTime += incrementAmount)
            {
                var nextBusIndex = lockedIn + 1;
                var nextBus = busDepartures[nextBusIndex];
                var requiredDepartureTime = testTime + nextBus.Index;
                var nearestDepartureTime = GetNextDepartureTime(requiredDepartureTime, nextBus.Value);

                if (requiredDepartureTime == nearestDepartureTime)
                {
                    incrementAmount *= nextBus.Value;
                    lockedIn = nextBusIndex;

                    if (lockedIn == busDepartures.Count - 1)
                    {
                        return testTime.ToString();
                    }
                }
            }
        }

        private static long GetNextDepartureTime(long startTime, int busNumber)
        {
            var quotient = startTime / busNumber;
            var remainder = startTime % busNumber;

            if (remainder > 0)
            {
                quotient++;
            }

            return quotient * busNumber;
        }
    }
}
