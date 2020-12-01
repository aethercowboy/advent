using advent.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace advent.tests.Extensions
{
    public class StringExtensionsTests
    {
        [Fact]
        public void Lines_null()
        {
            var result = ((string)null).Lines();
            Assert.NotNull(result);
            Assert.False(result.Any());
        }

        [Fact]
        public void Lines_Empty()
        {
            var result = string.Empty.Lines();
            Assert.NotNull(result);
            Assert.False(result.Any());
        }

        [Fact]
        public void Lines_OneLine()
        {
            var result = "This is a line".Lines().ToList();
            Assert.NotNull(result);
            Assert.True(result.Any());
            Assert.Equal(1, result.Count);
        }

        [Fact]
        public void Lines_TwoLines()
        {
            var result = @"This is a line
as is this".Lines().ToList();
            Assert.NotNull(result);
            Assert.True(result.Any());
            Assert.Equal(2, result.Count);
        }

        [Fact]
        public void Lines_NewLine()
        {
            var result = "This is a line\nas is this".Lines().ToList();
            Assert.NotNull(result);
            Assert.True(result.Any());
            Assert.Equal(2, result.Count);
        }

        [Fact]
        public void Lines_RandomLines()
        {
            var rnd = new Random();
            var i = Math.Abs(rnd.Next(1000));
            var str = string.Join("\n", Enumerable.Range(0, i).Select(x => "this is a line"));
            var result = str.Lines().ToList();
            Assert.NotNull(result);
            Assert.True(result.Any());
            Assert.Equal(i, result.Count);
        }

        [Fact]
        public void Lines_CRLF()
        {
            var result = "This is a line\r\nas is this".Lines().ToList();
            Assert.NotNull(result);
            Assert.True(result.Any());
            Assert.Equal(2, result.Count);
            Assert.Equal(result.First().Length, 14);
        }

        [Fact]
        public void Lines_CR()
        {
            var result = "This is a line\ras is this".Lines().ToList();
            Assert.NotNull(result);
            Assert.True(result.Any());
            Assert.Equal(2, result.Count);
        }

        [Fact]
        public void IsNullOrEmpty_null()
        {
            var result = ((string)null).IsNullOrEmpty();
            Assert.True(result);
        }

        [Fact]
        public void IsNullOrEmpty_Empty()
        {
            var result = string.Empty.IsNullOrEmpty();
            Assert.True(result);
        }

        [Fact]
        public void IsNullOrEmpty_Whitespace()
        {
            var result = "   ".IsNullOrEmpty();
            Assert.False(result);
        }

        [Fact]
        public void IsNullOrEmpty_String()
        {
            var result = "this is a string".IsNullOrEmpty();
            Assert.False(result);
        }

        [Fact]
        public void IsNullOrWhitespace_null()
        {
            var result = ((string)null).IsNullOrWhitespace();
            Assert.True(result);
        }

        [Fact]
        public void IsNullOrWhitespace_Empty()
        {
            var result = string.Empty.IsNullOrWhitespace();
            Assert.True(result);
        }

        [Fact]
        public void IsNullOrWhitespace_Whitespace()
        {
            var result = "   ".IsNullOrWhitespace();
            Assert.True(result);
        }

        [Fact]
        public void IsNullOrWhitespace_String()
        {
            var result = "this is a string".IsNullOrWhitespace();
            Assert.False(result);
        }

        [Fact]
        public void Words_null()
        {
            var result = ((string)null).Words();
            Assert.NotNull(result);
            Assert.False(result.Any());
        }

        [Fact]
        public void Words_Empty()
        {
            var result = string.Empty.Words();
            Assert.NotNull(result);
            Assert.False(result.Any());
        }

        [Fact]
        public void Words_OneWord()
        {
            var result = "one".Words().ToList();
            Assert.NotNull(result);
            Assert.True(result.Any());
            Assert.Equal(1, result.Count);
        }

        [Fact]
        public void Words_TwoWords()
        {
            var result = "two words".Words().ToList();
            Assert.NotNull(result);
            Assert.True(result.Any());
            Assert.Equal(2, result.Count);
        }

        [Fact]
        public void Words_LotsOfSpace()
        {
            var result = "lots                of                  spaaaaaaaaaaaaaaace".Words().ToList();
            Assert.NotNull(result);
            Assert.True(result.Any());
            Assert.Equal(3, result.Count);
        }

        [Fact]
        public void ToInt_null()
        {
            var result = ((string)null).ToInt();
            Assert.Equal(0, result);
        }

        [Fact]
        public void ToInt_Empty()
        {
            var result = string.Empty.ToInt();
            Assert.Equal(0, result);
        }

        [Fact]
        public void ToInt_One()
        {
            var result = "1".ToInt();
            Assert.Equal(1, result);
        }

        [Fact]
        public void ToInt_Random()
        {
            var rnd = new Random();
            var i = rnd.Next();
            var result = i.ToString().ToInt();
            Assert.Equal(i, result);
        }

        [Fact]
        public void ToInt_NotInt()
        {
            var result = "NaN".ToInt();
            Assert.Equal(0, result);
        }

        [Fact]
        public void ToInts_null()
        {
            var result = ((IEnumerable<string>)null).ToInts();
            Assert.NotNull(result);
            Assert.False(result.Any());
        }

        [Fact]
        public void ToInts_Empty()
        {
            var result = Enumerable.Empty<string>().ToInts();
            Assert.NotNull(result);
            Assert.False(result.Any());
        }

        [Fact]
        public void ToInts_One()
        {
            var result = new[] { "1" }.ToInts().ToList();
            Assert.NotNull(result);
            Assert.True(result.Any());
            Assert.Equal(1, result.Count);
            Assert.Equal(1, result.Sum());
        }

        [Fact]
        public void ToInts_OneTwoThreeFour()
        {
            var result = new[] { "1", "2", "3", "4" }.ToInts().ToList();
            Assert.NotNull(result);
            Assert.True(result.Any());
            Assert.Equal(4, result.Count);
            Assert.Equal(10, result.Sum());
        }

        [Fact]
        public void ToInts_OneTwoZeeFour()
        {
            var result = new[] { "1", "2", "z", "4" }.ToInts().ToList();
            Assert.NotNull(result);
            Assert.True(result.Any());
            Assert.Equal(4, result.Count);
            Assert.Equal(7, result.Sum());
        }
    }
}