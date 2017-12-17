using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using advent.Collections;
using advent.Extensions;

namespace advent.Days._2017
{
    public class Day16 : Day
    {
        public string Dancers = Globals.Alphabet.Substring(0, 16);

        private string Dance(string input, int iterations)
        {
            var dancers = Dancers.ToDancerList();
            var moves = input.Split(',').ToList();

            foreach (var _ in Enumerable.Range(0, iterations))
            {
                foreach (var move in moves)
                {
                    var action = move[0];
                    switch (action)
                    {
                        case 's':
                        {
                            var x = move.Substring(1).ToInt();
                            dancers.Spin(x);
                            break;
                        }
                        case 'x':
                        {
                            var ab = move.Substring(1).Split('/');
                            var a = ab[0].ToInt();
                            var b = ab[1].ToInt();
                            dancers.Exchange(a, b);
                            break;
                        }
                        case 'p':
                        {
                            var ab = move.Substring(1).Split('/');
                            var a = ab[0];
                            var b = ab[1];
                            dancers.Partner(a, b);
                            break;
                        }
                    }
                }
            }

            var d = new List<char>();

            for (var i = 0; i < dancers.Count; ++i)
            {
                d.Add(dancers[i]);
            }

            return new string(d.ToArray());
        }

        public override int Part1(string input)
        {
            var result = Dance(input, 1);

            Console.WriteOutput(result);

            return 0;
        }

        public override int Part2(string input)
        {
            var result = Dance(input, 1_000_000_000);

            Console.WriteOutput(result);

            return 0;
        }


    }

    public class DancerList : Ring<char>
    {
        private int Offset { get; set; }

        public DancerList(IEnumerable<char> collection) : base(collection)
        {
        }

        public new char this[int index]
        {
            get => _list[(index + Offset) % Count];
            set => _list[(index + Offset) % Count] = value;
        }

        public void Spin(int x)
        {
            Offset = Offset + Count - x;

            //var range = this.Skip(offset).ToList();
            //RemoveRange(offset, x);
            //InsertRange(0, range);
        }

        public void Exchange(int a, int b)
        {
            var x = this[a];
            this[a] = this[b];
            this[b] = x;
        }

        public void Partner(string a, string b)
        {
            var idxA = IndexOf(a[0]) - Offset;
            var idxB = IndexOf(b[0]) - Offset;

            Exchange(idxA, idxB);
        }
    }
}
