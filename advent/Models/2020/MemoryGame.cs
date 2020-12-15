using System.Collections.Generic;

namespace advent.Models._2020
{
    public class MemoryGame
    {
        public int LastNumber { get; private set; }

        private readonly IDictionary<int, int> _dictionary;
        private readonly HashSet<int> _said;

        public MemoryGame()
        {
            _dictionary = new Dictionary<int, int>();
            _said = new HashSet<int>();
            LastNumber = -1;
        }

        public int Say(int digit, int turn)
        {
            LastNumber = digit;

            var isSaid = _said.Contains(digit);

            if (isSaid)
            {
                var lastTurn = _dictionary[digit];
                _dictionary[digit] = turn;

                return turn - lastTurn;
            }
            else
            {
                _said.Add(digit);
                _dictionary.Add(digit, turn);

                return 0;
            }
        }
    }
}
