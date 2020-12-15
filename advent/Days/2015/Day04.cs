using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace advent.Days._2015
{
    public class Day04 : Day
    {
        private readonly MD5 _md5 = MD5.Create();

        private string GetHash(string input)
        {
            var bytes = Encoding.ASCII.GetBytes(input);
            var hash = _md5.ComputeHash(bytes);
            var hashStr = string.Join("", hash.Select(x => x.ToString("X2")));


            return hashStr;
        }

        private int Part0(string input, int zeroes)
        {
            var startString = 0.ToString($"D{zeroes}");

            for (var i = 0; i < 10000000; i++)
            {
                var str = $"{input}{i}";

                var hashStr = GetHash(str);

                if (hashStr.StartsWith(startString))
                {
                    return i;
                }
            }

            return -1;
        }

        public override long Part1(string input)
        {
            return Part0(input, 5);
        }

        public override long Part2(string input)
        {
            return Part0(input, 6);
        }
    }
}
