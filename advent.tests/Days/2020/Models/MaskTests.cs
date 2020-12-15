using advent.Models._2020;
using System.Collections.Generic;
using Xunit;

namespace advent.tests.Days._2020.Models
{
    public class MaskTests
    {
        [Theory]
        [InlineData("XXXXXXXXXXXXXXXXXXXXXXXXXXXXX1XXXX0X", 11, 73)]
        [InlineData("XXXXXXXXXXXXXXXXXXXXXXXXXXXXX1XXXX0X", 101, 101)]
        [InlineData("XXXXXXXXXXXXXXXXXXXXXXXXXXXXX1XXXX0X", 0, 64)]
        public void TestMasks(string mask, int input, int expected)
        {
            var m = new Mask(mask);

            var result = m.Apply(input);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("000000000000000000000000000000X1001X", 42, "000000000000000000000000000000X1101X")]
        [InlineData("00000000000000000000000000000000X0XX", 26, "00000000000000000000000000000001X0XX")]
        public void TestAddressMasksA(string mask, long input, string expected)
        {
            var m = new Mask(mask);

            var result = m.Apply2a(input);

            Assert.Equal(expected, result);
        }

        public static List<object[]> AddressMaskBData = new List<object[]>
        {
            new object[] { "000000000000000000000000000000X1101X", new List<long> { 26, 27, 58, 59 } },
            new object[] { "00000000000000000000000000000001X0XX", new List<long> { 16, 17, 18, 19, 24, 25, 26, 27 } }
        };

        [Theory]
        [MemberData(nameof(AddressMaskBData))]
        public void TestAddressMasksB(string mask, List<long> expected)
        {
            var result = Mask.Apply2b(mask);

            Assert.Equal(expected.Count, result.Count);

            foreach (var e in expected)
            {
                Assert.Contains(e, result);
            }
        }
    }
}
