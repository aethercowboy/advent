using advent.Enums._2020;
using advent.Extensions;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace advent.Models._2020
{
    public class SeatLayout
    {
        private readonly IDictionary<Vector2, Seat> _seats;
        private readonly int _rows;
        private readonly int _columns;

        public SeatLayout(string input)
        {
            _seats = new Dictionary<Vector2, Seat>();

            var lines = input.Lines().ToList();

            for (var i = 0; i < lines.Count; ++i)
            {
                var line = lines[i];

                for (var j = 0; j < line.Length; ++j)
                {
                    var c = line[j];

                    var status = SeatStatus.Empty;

                    switch (c)
                    {
                        case 'L':
                            status = SeatStatus.Empty;
                            break;
                        case '.':
                            status = SeatStatus.Floor;
                            break;
                        case '#':
                            status = SeatStatus.Occupied;
                            break;
                    }

                    AddSeat(i, j, status);
                }
            }

            _rows = lines.Count;
            _columns = lines[0].Length;
        }

        private void AddSeat(int row, int column, SeatStatus status)
        {
            var seat = new Seat(row, column)
            {
                Status = status
            };

            _seats.Add(seat.GetPosition(), seat);
        }

        public string Process()
        {
            var relativeAdjacents = new List<Vector2>
            {
                new Vector2(-1, -1),
                new Vector2(-1 ,0),
                new Vector2(-1, 1),
                new Vector2(0 ,-1),
                new Vector2(0, 1),
                new Vector2(1, -1),
                new Vector2(1, 0),
                new Vector2(1, 1)
            };

            var previous = new SeatLayout(ToString());

            foreach (var seat in _seats.Values)
            {
                if (seat.Status == SeatStatus.Floor) continue;

                var position = seat.GetPosition();

                var statuses = new List<SeatStatus>();

                foreach (var r in relativeAdjacents)
                {
                    var a = position + r;

                    var status = previous.GetSeatStatus(a.X, a.Y);

                    statuses.Add(status);
                }

                if (statuses.All(x => x == SeatStatus.Empty || x == SeatStatus.Floor))
                {
                    seat.Status = SeatStatus.Occupied;
                }
                else if (statuses.Count(x => x == SeatStatus.Occupied) >= 4)
                {
                    seat.Status = SeatStatus.Empty;
                }
            }

            return ToString();
        }

        public string Process2()
        {
            var previous = new SeatLayout(ToString());

            foreach (var seat in _seats.Values)
            {
                if (seat.Status == SeatStatus.Floor) continue;

                var seen = previous.SeenFrom(seat.Row, seat.Column);

                if (seat.Status == SeatStatus.Occupied && seen.X >= 5)
                {
                    seat.Status = SeatStatus.Empty;
                }
                else if (seat.Status == SeatStatus.Empty && seen.X == 0)
                {
                    seat.Status = SeatStatus.Occupied;
                }
            }

            return ToString();
        }

        private bool IsSeatPositionValid(float row, float column)
        {
            return row >= 0
                && row < _rows
                && column >= 0
                && column < _columns;
        }

        private SeatStatus GetSeatStatus(float row, float column)
        {
            var seat = GetSeat(row, column);

            return (seat?.Status) ?? SeatStatus.Empty;
        }

        private Seat GetSeat(float row, float column)
        {
            if (!IsSeatPositionValid(row, column)) return null;

            var key = new Vector2(row, column);

            return _seats[key];
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            for (var i = 0; i < _rows; ++i)
            {
                for (var j = 0; j < _columns; ++j)
                {
                    var status = GetSeatStatus(i, j);

                    var c = ' ';

                    switch (status)
                    {
                        case SeatStatus.Empty:
                            c = 'L';
                            break;
                        case SeatStatus.Floor:
                            c = '.';
                            break;
                        case SeatStatus.Occupied:
                            c = '#';
                            break;
                    }

                    sb.Append(c);
                }

                sb.AppendLine();
            }

            return sb.ToString().Trim();
        }

        public int OccupiedCount()
        {
            return _seats.Count(x => x.Value.Status == SeatStatus.Occupied);
        }

        public Vector2 SeenFrom(int row, int column)
        {
            var seen = new Vector2();

            var directions = new List<Vector2>
            {
                new Vector2(-1, -1),
                new Vector2(-1 ,0),
                new Vector2(-1, 1),
                new Vector2(0 ,-1),
                new Vector2(0, 1),
                new Vector2(1, -1),
                new Vector2(1, 0),
                new Vector2(1, 1)
            };

            var seat = GetSeat(row, column);

            foreach (var direction in directions)
            {
                var position = seat.GetPosition() + direction;

                var aSeat = GetSeat(position.X, position.Y);

                while (aSeat != null)
                {
                    if (aSeat.Status == SeatStatus.Empty || aSeat.Status == SeatStatus.Occupied)
                    {
                        if (aSeat.Status == SeatStatus.Occupied)
                        {
                            seen.X++;
                        }
                        else if (aSeat.Status == SeatStatus.Empty)
                        {
                            seen.Y++;
                        }

                        break;
                    }

                    position += direction;

                    aSeat = GetSeat(position.X, position.Y);
                }
            }

            return seen;
        }
    }
}
