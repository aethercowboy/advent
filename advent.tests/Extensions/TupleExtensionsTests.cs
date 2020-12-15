using advent.Extensions;
using System;
using Xunit;

namespace advent.tests.Extensions
{
    public class TupleExtensionsTests
    {
        private readonly Tuple<int, int> _tuple;
        public TupleExtensionsTests()
        {
            _tuple = new Tuple<int, int>(0, 0);
        }

        [Fact]
        public void MoveRight_null()
        {
            var result = ((Tuple<int, int>)null).MoveRight();
            Assert.Null(result);
        }

        [Fact]
        public void MoveRight_Tuple()
        {
            var result = _tuple.MoveRight();
            Assert.NotNull(result);
            Assert.Equal(1, result.Item1);
            Assert.Equal(0, result.Item2);
        }

        [Fact]
        public void MoveLeft_null()
        {
            var result = ((Tuple<int, int>)null).MoveLeft();
            Assert.Null(result);
        }

        [Fact]
        public void MoveLeft_Tuple()
        {
            var result = _tuple.MoveLeft();
            Assert.NotNull(result);
            Assert.Equal(-1, result.Item1);
            Assert.Equal(0, result.Item2);
        }

        [Fact]
        public void MoveUp_null()
        {
            var result = ((Tuple<int, int>)null).MoveUp();
            Assert.Null(result);
        }

        [Fact]
        public void MoveUp_Tuple()
        {
            var result = _tuple.MoveUp();
            Assert.NotNull(result);
            Assert.Equal(0, result.Item1);
            Assert.Equal(1, result.Item2);
        }

        [Fact]
        public void MoveDown_null()
        {
            var result = ((Tuple<int, int>)null).MoveDown();
            Assert.Null(result);
        }

        [Fact]
        public void MoveDown_Tuple()
        {
            var result = _tuple.MoveDown();
            Assert.NotNull(result);
            Assert.Equal(0, result.Item1);
            Assert.Equal(-1, result.Item2);
        }

        [Fact]
        public void MoveInCircle()
        {
            var result = _tuple.MoveUp().MoveLeft().MoveDown().MoveRight();
            Assert.NotNull(result);
            Assert.Equal(result, _tuple);
        }
    }
}