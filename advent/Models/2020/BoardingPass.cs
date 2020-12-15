namespace advent.Models._2020
{
    public class BoardingPass
    {
        public int Row { get; }
        public int Column { get; }
        public int SeatId { get; }

        private readonly int rowCount = 128;
        private readonly int colCount = 8;

        public BoardingPass(string input)
        {
            var maxRow = rowCount - 1;
            var minRow = 0;

            var maxCol = colCount - 1;
            var minCol = 0;

            foreach (var d in input)
            {
                switch (d)
                {
                    case 'F':
                        maxRow -= (maxRow - minRow + 1) / 2;
                        break;
                    case 'B':
                        minRow += (maxRow - minRow + 1) / 2;
                        break;
                    case 'L':
                        maxCol -= (maxCol - minCol + 1) / 2;
                        break;
                    case 'R':
                        minCol += (maxCol - minCol + 1) / 2;
                        break;
                }
            }

            Row = maxRow;
            Column = maxCol;
            SeatId = (Row * 8) + Column;
        }
    }
}
