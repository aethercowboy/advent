using System;
using advent2017.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace advent2017.tests.Extensions
{
    [TestClass]
    public class TupleExtensionsTests
    {
        private Tuple<int, int> _tuple;

        [TestInitialize]
        public void Setup()
        {
            _tuple = new Tuple<int, int>(0, 0);
        }

        [TestMethod]
        public void MoveRight_null()
        {
            var result = ((Tuple<int, int>) null).MoveRight();
            Assert.IsNull(result);
        }

        [TestMethod]
        public void MoveRight_Tuple()
        {
            var result = _tuple.MoveRight();
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.Item1);
            Assert.AreEqual(0, result.Item2);
        }

        [TestMethod]
        public void MoveLeft_null()
        {
            var result = ((Tuple<int, int>) null).MoveLeft();
            Assert.IsNull(result);
        }

        [TestMethod]
        public void MoveLeft_Tuple()
        {
            var result = _tuple.MoveLeft();
            Assert.IsNotNull(result);
            Assert.AreEqual(-1, result.Item1);
            Assert.AreEqual(0, result.Item2);
        }

        [TestMethod]
        public void MoveUp_null()
        {
            var result = ((Tuple<int, int>) null).MoveUp();
            Assert.IsNull(result);
        }

        [TestMethod]
        public void MoveUp_Tuple()
        {
            var result = _tuple.MoveUp();
            Assert.IsNotNull(result);
            Assert.AreEqual(0, result.Item1);
            Assert.AreEqual(1, result.Item2);
        }

        [TestMethod]
        public void MoveDown_null()
        {
            var result = ((Tuple<int, int>) null).MoveDown();
            Assert.IsNull(result);
        }

        [TestMethod]
        public void MoveDown_Tuple()
        {
            var result = _tuple.MoveDown();
            Assert.IsNotNull(result);
            Assert.AreEqual(0, result.Item1);
            Assert.AreEqual(-1, result.Item2);
        }

        [TestMethod]
        public void MoveInCircle()
        {
            var result = _tuple.MoveUp().MoveLeft().MoveDown().MoveRight();
            Assert.IsNotNull(result);
            Assert.AreEqual(result, _tuple);
        }
    }
}