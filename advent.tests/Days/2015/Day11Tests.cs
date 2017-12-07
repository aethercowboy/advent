using System;
using advent.Days._2015;
using advent.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace advent.tests.Days
{
    [TestClass]
    public class Day11Tests : DayTests<Day11>
    {
        private string _password = string.Empty;

        [TestInitialize]
        public void Initi()
        {
            Client.Console.Wrote += OnWrote;
        }

        [TestMethod]
        public void Test01()
        {
            var result = Client.Part1("abcdefgh");
            Assert.AreEqual(1, result);
            Assert.AreEqual("abcdffaa", _password);
        }

        private void OnWrote(object sender, EventArgs e)
        {
            if (e is ConsoleEventArgs f)
            {
                _password = f.Message;
            }
        }

        [TestMethod]
        public void Test02()
        {
            var result = Client.Part1("ghijklmn");
            Assert.AreEqual(1, result);
            Assert.AreEqual("ghjaabcc", _password);
        }

        [TestMethod]
        public void Test03()
        {
            var result = Client.IsEightCharacters("abcdefgh");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Test04()
        {
            const string input = "hijklmmn";

            var result = Client.HasOneIncreasingStraight(input);
            Assert.IsTrue(result);

            result = Client.DoesNotHaveILO(input);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Test05()
        {
            const string input = "abbceffg";

            var result = Client.HasTwoNonOverlappingPairsOfLetters(input);
            Assert.IsTrue(result);

            result = Client.HasOneIncreasingStraight(input);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Test06()
        {
            const string input = "abbcegjk";

            var result = Client.HasTwoNonOverlappingPairsOfLetters(input);
            Assert.IsFalse(result);
        }
    }
}
