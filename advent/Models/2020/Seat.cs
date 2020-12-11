using advent.Enums._2020;
using System.Numerics;

namespace advent.Models._2020
{
    public class Seat
    {
        public int Row { get; }
        public int Column { get; }

        public SeatStatus Status { get; set; }

        public Seat(int row, int column)
        {
            Row = row;
            Column = column;
            Status = SeatStatus.Empty;
        }

        public Vector2 GetPosition()
        {
            return new Vector2(Row, Column);
        }
    }
}
