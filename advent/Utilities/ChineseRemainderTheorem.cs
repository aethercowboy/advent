using System.Linq;

namespace advent.Utilities
{
    public static class ChineseRemainderTheorem
    {
        public static long Solve(long[] n, long[] a)
        {
            var prod = n.Aggregate(1, (long i, long j) => i * j);
            long p;
            long sm = 0;

            for (long i = 0; i < n.Length; i++)
            {
                p = prod / n[i];
                sm += a[i] * ModularMultiplicativeInverse(p, n[i]) * p;
            }

            return sm % prod;
        }

        private static long ModularMultiplicativeInverse(long a, long mod)
        {
            long b = a % mod;

            for (long x = 1; x < mod; x++)
            {
                if ((b * x) % mod == 1)
                {
                    return x;
                }
            }

            return 1;
        }
    }
}
