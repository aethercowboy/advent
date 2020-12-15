using advent.Collections;
using advent.Extensions;
using System.Linq;

namespace advent
{
    public static class Globals
    {
        public const string Alphabet = "abcdefghijklmnopqrstuvwxyz";
        public readonly static IRing<int> Ring = Enumerable.Range(0, 256).ToRing();
    }
}
