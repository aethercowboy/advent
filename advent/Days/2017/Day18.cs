using advent.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace advent.Days._2017
{
    public class Day18 : Day
    {
        public override string Part1(string input)
        {
            var lines = input.Lines().ToList();

            return Duet.Part1(lines).ToString();
        }

        public override string Part2(string input)
        {
            var duet0 = new Duet(0);
            var duet1 = new Duet(1);
            duet0.Partner = duet1;
            duet1.Partner = duet0;

            var duets = new List<Duet>
            {
                duet0,
                duet1
            };

            var lines = input.Lines().ToList();

            BigInteger i = 0;
            BigInteger j = 0;

            while (i < lines.Count && j < lines.Count)
            {
                if (duets.All(x => x.IsWaiting))
                {
                    break;
                }

                var line0 = lines[(int)i];
                var line1 = lines[(int)j];

                var r0 = duet0.ProcessLine(line0);
                var r1 = duet1.ProcessLine(line1);

                i += r0;
                j += r1;
            }

            return duet1.Sends.ToString();
        }

        public class Duet
        {
            private readonly IDictionary<string, BigInteger> _dict = new Dictionary<string, BigInteger>();

            public static Queue<BigInteger> Sounds => new Queue<BigInteger>();
            public int Sends { get; set; }
            public static IDictionary<string, Func<string[], BigInteger?>> Execute => new Dictionary<string, Func<string[], BigInteger?>>();
            public bool IsWaiting { get; set; }
            public Duet Partner { get; set; }

            public Duet()
            {
                Execute.Add("snd", Snd);
                Execute.Add("set", Set);
                Execute.Add("add", Add);
                Execute.Add("mul", Mul);
                Execute.Add("mod", Mod);
                Execute.Add("rcv", Rcv);
                Execute.Add("jgz", Jgz);
            }

            public Duet(int p) : this()
            {
                _dict.Add("p", p);
            }

            private readonly object _lock = new object();

            public BigInteger ProcessLine(string line)
            {
                var words = line.Words().ToList();
                var instruction = words[0];
                var cdr = words.Skip(1).ToArray();

                BigInteger i = 1;

                switch (instruction)
                {
                    case "rcv":
                        {
                            var z = RcvQ(cdr);
                            if (z == null)
                            {
                                i -= 1;
                            }
                            break;
                        }
                    default:
                        var response = Execute[instruction](cdr);
                        if (instruction == "jgz" && response.HasValue)
                        {
                            i += response.Value - 1;
                        }
                        break;
                }

                return i;
            }

            public BigInteger? Dequeue()
            {
                lock (_lock)
                {
                    if (Sounds.Count > 0)
                    {
                        return Sounds.Dequeue();
                    }

                    return null;
                }
            }

            private void InitVal(string x)
            {
                if (!_dict.ContainsKey(x))
                {
                    _dict.Add(x, 0);
                }
            }

            private BigInteger GetVal(string x)
            {
                if (int.TryParse(x, out var y))
                {
                    return y;
                }
                InitVal(x);
                return _dict[x];
            }

            public BigInteger? Snd(params string[] args)
            {
                lock (_lock)
                {
                    var x = args[0];

                    InitVal(x);
                    Sounds.Enqueue(GetVal(x));
                    ++Sends;
                    return GetVal(x);
                }
            }

            public BigInteger? Set(params string[] args)
            {
                var x = args[0];
                var y = args[1];

                InitVal(x);
                _dict[x] = GetVal(y);
                return GetVal(x);
            }

            public BigInteger? Add(params string[] args)
            {
                var x = args[0];
                var y = args[1];

                InitVal(x);
                var z = GetVal(y);
                _dict[x] = GetVal(x) + z;
                return GetVal(x);
            }

            public BigInteger? Mul(params string[] args)
            {
                var x = args[0];
                var y = args[1];

                InitVal(x);
                var z = GetVal(y);
                _dict[x] = GetVal(x) * z;
                return GetVal(x);
            }

            public BigInteger? Mod(params string[] args)
            {
                var x = args[0];
                var y = args[1];

                InitVal(x);
                var z = GetVal(y);
                _dict[x] = GetVal(x) % z;
                return GetVal(x);
            }

            public BigInteger? Rcv(params string[] args)
            {
                var x = args[0];

                InitVal(x);

                if (GetVal(x) == 0) return null;

                lock (_lock)
                {
                    return Sounds.Last();
                }
            }

            public BigInteger? RcvQ(params string[] args)
            {
                var x = args[0];

                InitVal(x);

                var z = Partner.Dequeue();

                if (z.HasValue)
                {
                    _dict[x] = z.Value;
                    IsWaiting = false;
                    return GetVal(x);
                }

                IsWaiting = true;
                return null;
            }

            public BigInteger? Jgz(params string[] args)
            {
                var x = args[0];
                var y = args[1];

                InitVal(x);
                var z = GetVal(y);
                return GetVal(x) > 0 ? z : (BigInteger?)null;
            }

            public static long Part1(IList<string> lines)
            {
                for (BigInteger i = 0; i < lines.Count; ++i)
                {
                    var line = lines[(int)i];
                    var words = line.Words().ToList();
                    var instruction = words[0];
                    var cdr = words.Skip(1).ToArray();

                    var response = Execute[instruction](cdr);

                    if (!response.HasValue) continue;

                    switch (instruction)
                    {
                        case "rcv":
                            return (int)response.Value;
                        case "jgz":
                            i += response.Value - 1;
                            break;
                    }
                }

                return -1;
            }
        }
    }
}