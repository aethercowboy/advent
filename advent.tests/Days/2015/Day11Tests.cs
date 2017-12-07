using advent.Days._2015;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace advent.tests.Days._2015
{
    [TestClass]
    public class Day11Tests : DayTests<Day11>
    {
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
            Assert.AreEqual("abcdffaa", Output);
        }

        [TestMethod]
        public void Test02()
        {
            var result = Client.Part1("ghijklmn");
            Assert.AreEqual(1, result);
            Assert.AreEqual("ghjaabcc", Output);
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
