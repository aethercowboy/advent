using advent.Collections;
using advent.Extensions;
using System.Collections.Generic;
using System.Linq;

namespace advent.Days._2017
{
    public class Day16 : Day
    {
        public string Dancers { get; set; } = Globals.Alphabet.Substring(0, 16);

        private static void Dance(DancerList dancers, IList<string> moves)
        {
            foreach (var move in moves)
            {
                switch (move[0])
                {
                    case 's':
                        {
                            var x = move[1..].ToInt();
                            dancers.Spin(x);
                            break;
                        }
                    case 'x':
                        {
                            var ab = move[1..].Split('/');
                            var a = ab[0].ToInt();
                            var b = ab[1].ToInt();
                            dancers.Exchange(a, b);
                            break;
                        }
                    case 'p':
                        {
                            var ab = move[1..].Split('/');
                            var a = ab[0];
                            var b = ab[1];
                            dancers.Partner(a, b);
                            break;
                        }
                }
            }
        }

        public string Dance(string input, int iterations)
        {
            var dancers = Dancers.ToDancerList();
            var moves = input.Split(',').ToList();

            var i = 0;

            foreach (var _ in Enumerable.Range(0, iterations))
            {
                i++;

                Dance(dancers, moves);

                var output = dancers.ToString();

                if (output == Dancers) break;
            }

            foreach (var _ in Enumerable.Range(0, iterations % i))
            {
                Dance(dancers, moves);
            }

            return dancers.ToString();
        }

        public override string Part1(string input)
        {
            var result = Dance(input, 1);

            return result;
        }

        public override string Part2(string input)
        {
            var result = Dance(input, 1_000_000_000);

            return result;
        }
    }

    public class DancerList : Ring<char>
    {
        private int Offset { get; set; }
        private IDictionary<char, int> Indices { get; }

        public DancerList(IList<char> collection) : base(collection)
        {
            Indices = new Dictionary<char, int>();
            var i = 0;
            foreach (var c in collection)
            {
                Indices.Add(c, i++);
            }
        }

        public new char this[int index]
        {
            get => _list[(index + Offset) % Count];
            set => _list[(index + Offset) % Count] = value;
        }

        public void Spin(int x)
        {
            Offset = (Offset + Count - x) % Count;
        }

        public void Exchange(int a, int b)
        {
            var x = this[a];
            var y = this[b];
            this[a] = y;
            this[b] = x;
            Indices[x] = (b + Offset) % Count;
            Indices[y] = (a + Offset) % Count;
        }

        public void Partner(string a, string b)
        {
            var idxA = Indices[a[0]] - Offset;
            var idxB = Indices[b[0]] - Offset;

            Exchange(idxA, idxB);
        }

        public override string ToString()
        {
            var d = new List<char>();

            for (var i = 0; i < Count; ++i)
            {
                d.Add(this[i]);
            }

            return new string(d.ToArray());
        }
    }
}
