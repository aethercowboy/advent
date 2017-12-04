using System.Collections.Generic;
using System.Linq;
using advent2017.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace advent2017.tests.Extensions
{
    [TestClass]
    public class EnumerableExtensionsTests
    {
        [TestMethod]
        public void NthOrDefault_null()
        {
            var result = ((IEnumerable<int>) null).NthOrDefault(1);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void NthOrDefault_Empty()
        {
            var result = Enumerable.Empty<int>().NthOrDefault(1);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void NthOrDefault_First()
        {
            var range = Enumerable.Range(1, 100).ToList();
            var result = range.NthOrDefault(0);
            Assert.AreEqual(range.FirstOrDefault(), result);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void NthOrDefault_OutOfRange()
        {
            var range = Enumerable.Range(1, 100);
            var result = range.NthOrDefault(1000);
            Assert.AreEqual(0, result);
        }
    }
}
