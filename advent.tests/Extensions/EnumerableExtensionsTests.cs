using advent.Extensions;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace advent.tests.Extensions
{
    public class EnumerableExtensionsTests
    {
        [Fact]
        public void NthOrDefault_null()
        {
            var result = ((IEnumerable<int>)null).NthOrDefault(1);
            Assert.Equal(0, result);
        }

        [Fact]
        public void NthOrDefault_Empty()
        {
            var result = Enumerable.Empty<int>().NthOrDefault(1);
            Assert.Equal(0, result);
        }

        [Fact]
        public void NthOrDefault_First()
        {
            var range = Enumerable.Range(1, 100).ToList();
            var result = range.NthOrDefault(0);
            Assert.Equal(range.FirstOrDefault(), result);
            Assert.Equal(1, result);
        }

        [Fact]
        public void NthOrDefault_OutOfRange()
        {
            var range = Enumerable.Range(1, 100);
            var result = range.NthOrDefault(1000);
            Assert.Equal(0, result);
        }
    }
}
