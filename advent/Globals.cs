using advent.Collections;
using System.Linq;
using advent.Extensions;

namespace advent
{
    public static class Globals
    {
        public const string Alphabet = "abcdefghijklmnopqrstuvwxyz";
        public static IRing<int> Ring = Enumerable.Range(0, 256).ToRing();
    }
}
