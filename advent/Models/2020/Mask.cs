using System;
using System.Collections.Generic;
using System.Text;

namespace advent.Models._2020
{
    public class Mask
    {
        private readonly string _mask;

        public Mask(string mask)
        {
            _mask = mask;
        }

        public long Apply(long input)
        {
            var binary = Convert.ToString(input, 2)
                .PadLeft(_mask.Length, '0');

            var sb = new StringBuilder(binary);

            for (var i = 0; i < _mask.Length; ++i)
            {
                switch (_mask[i])
                {
                    case 'X':
                        continue;
                    case '0':
                        sb[i] = '0';
                        break;
                    case '1':
                        sb[i] = '1';
                        break;
                }
            }

            return Convert.ToInt64(sb.ToString(), 2);
        }

        public List<long> Apply2(long input)
        {
            var str = Apply2a(input);

            return Apply2b(str);
        }

        internal string Apply2a(long input)
        {
            var binary = Convert.ToString(input, 2)
                .PadLeft(_mask.Length, '0');

            var sb = new StringBuilder(binary);

            for (var i = 0; i < _mask.Length; ++i)
            {
                switch (_mask[i])
                {
                    case 'X':
                        sb[i] = 'X';
                        continue;
                    case '0':
                        break;
                    case '1':
                        sb[i] = '1';
                        break;
                }
            }

            return sb.ToString();
        }

        internal static List<long> Apply2b(string input)
        {
            List<StringBuilder> elements = new List<StringBuilder>
            {
                new StringBuilder()
            };

            foreach (var c in input)
            {
                switch (c)
                {
                    case '0':
                    case '1':
                        foreach (var s in elements)
                        {
                            s.Append(c);
                        }
                        break;
                    case 'X':
                        var newElements = new List<StringBuilder>();

                        foreach (var s in elements)
                        {
                            var s1 = new StringBuilder(s.ToString());
                            var s2 = new StringBuilder(s.ToString());

                            s1.Append('0');
                            s2.Append('1');

                            newElements.Add(s1);
                            newElements.Add(s2);
                        }

                        elements.Clear();
                        elements.AddRange(newElements);
                        break;
                }
            }

            return elements.ConvertAll(x => Convert.ToInt64(x.ToString(), 2));
        }
    }
}
