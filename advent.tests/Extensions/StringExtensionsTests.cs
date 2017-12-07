using System;
using System.Collections.Generic;
using System.Linq;
using advent.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace advent.tests.Extensions
{
    [TestClass]
    public class StringExtensionsTests
    {
        [TestMethod]
        public void Lines_null()
        {
            var result = ((string) null).Lines();
            Assert.IsNotNull(result);
            Assert.IsFalse(result.Any());
        }

        [TestMethod]
        public void Lines_Empty()
        {
            var result = string.Empty.Lines();
            Assert.IsNotNull(result);
            Assert.IsFalse(result.Any());
        }

        [TestMethod]
        public void Lines_OneLine()
        {
            var result = "This is a line".Lines().ToList();
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Any());
            Assert.AreEqual(1, result.Count);
        }

        [TestMethod]
        public void Lines_TwoLines()
        {
            var result = @"This is a line
as is this".Lines().ToList();
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Any());
            Assert.AreEqual(2, result.Count);
        }

        [TestMethod]
        public void Lines_NewLine()
        {
            var result = "This is a line\nas is this".Lines().ToList();
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Any());
            Assert.AreEqual(2, result.Count);
        }

        [TestMethod]
        public void Lines_RandomLines()
        {
            var rnd = new Random();
            var i = Math.Abs(rnd.Next(1000));
            var str = string.Join("\n", Enumerable.Range(0, i).Select(x => "this is a line"));
            var result = str.Lines().ToList();
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Any());
            Assert.AreEqual(i, result.Count);
        }

        [TestMethod]
        public void Lines_CRLF()
        {
            var result = "This is a line\r\nas is this".Lines().ToList();
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Any());
            Assert.AreEqual(2, result.Count);
            Assert.AreEqual(result.First().Length, 14);
        }

        [TestMethod]
        public void Lines_CR()
        {
            var result = "This is a line\ras is this".Lines().ToList();
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Any());
            Assert.AreEqual(2, result.Count);
        }

        [TestMethod]
        public void IsNullOrEmpty_null()
        {
            var result = ((string) null).IsNullOrEmpty();
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsNullOrEmpty_Empty()
        {
            var result = string.Empty.IsNullOrEmpty();
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsNullOrEmpty_Whitespace()
        {
            var result = "   ".IsNullOrEmpty();
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsNullOrEmpty_String()
        {
            var result = "this is a string".IsNullOrEmpty();
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsNullOrWhitespace_null()
        {
            var result = ((string) null).IsNullOrWhitespace();
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsNullOrWhitespace_Empty()
        {
            var result = string.Empty.IsNullOrWhitespace();
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsNullOrWhitespace_Whitespace()
        {
            var result = "   ".IsNullOrWhitespace();
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsNullOrWhitespace_String()
        {
            var result = "this is a string".IsNullOrWhitespace();
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Words_null()
        {
            var result = ((string) null).Words();
            Assert.IsNotNull(result);
            Assert.IsFalse(result.Any());
        }

        [TestMethod]
        public void Words_Empty()
        {
            var result = string.Empty.Words();
            Assert.IsNotNull(result);
            Assert.IsFalse(result.Any());
        }

        [TestMethod]
        public void Words_OneWord()
        {
            var result = "one".Words().ToList();
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Any());
            Assert.AreEqual(1, result.Count);
        }

        [TestMethod]
        public void Words_TwoWords()
        {
            var result = "two words".Words().ToList();
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Any());
            Assert.AreEqual(2, result.Count);
        }

        [TestMethod]
        public void Words_LotsOfSpace()
        {
            var result = "lots                of                  spaaaaaaaaaaaaaaace".Words().ToList();
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Any());
            Assert.AreEqual(3, result.Count);
        }

        [TestMethod]
        public void ToInt_null()
        {
            var result = ((string) null).ToInt();
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void ToInt_Empty()
        {
            var result = string.Empty.ToInt();
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void ToInt_One()
        {
            var result = "1".ToInt();
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void ToInt_Random()
        {
            var rnd = new Random();
            var i = rnd.Next();
            var result = i.ToString().ToInt();
            Assert.AreEqual(i, result);
        }

        [TestMethod]
        public void ToInt_NotInt()
        {
            var result = "NaN".ToInt();
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void ToInts_null()
        {
            var result = ((IEnumerable<string>) null).ToInts();
            Assert.IsNotNull(result);
            Assert.IsFalse(result.Any());
        }

        [TestMethod]
        public void ToInts_Empty()
        {
            var result = Enumerable.Empty<string>().ToInts();
            Assert.IsNotNull(result);
            Assert.IsFalse(result.Any());
        }

        [TestMethod]
        public void ToInts_One()
        {
            var result = new[] {"1"}.ToInts().ToList();
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Any());
            Assert.AreEqual(1, result.Count);
            Assert.AreEqual(1, result.Sum());
        }

        [TestMethod]
        public void ToInts_OneTwoThreeFour()
        {
            var result = new[] {"1", "2", "3", "4"}.ToInts().ToList();
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Any());
            Assert.AreEqual(4, result.Count);
            Assert.AreEqual(10, result.Sum());
        }

        [TestMethod]
        public void ToInts_OneTwoZeeFour()
        {
            var result = new[] {"1", "2", "z", "4"}.ToInts().ToList();
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Any());
            Assert.AreEqual(4, result.Count);
            Assert.AreEqual(7, result.Sum());
        }
    }
}