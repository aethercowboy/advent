using advent.Days._2015;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace advent.tests.Days._2015
{
    [TestClass]
    public class Day01Tests : DayTests<Day01>
    {
        [TestMethod]
        public void Test01()
        {
            var result = Client.Part1("(())");

            Assert.AreEqual(0, result);

            var result2 = Client.Part1("()()");
            Assert.AreEqual(0, result2);
        }

        [TestMethod]
        public void Test02()
        {
            var result = Client.Part1("(((");

            Assert.AreEqual(3, result);

            var result2 = Client.Part1("(()(()(");
            Assert.AreEqual(3, result2);
        }

        [TestMethod]
        public void Test03()
        {
            var result = Client.Part1("))(((((");

            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void Test04()
        {
            var result = Client.Part1("())");

            Assert.AreEqual(-1, result);

            var result2 = Client.Part1("))(");
            Assert.AreEqual(-1, result2);
        }

        [TestMethod]
        public void Test05()
        {
            var result = Client.Part1(")))");

            Assert.AreEqual(-3, result);

            var result2 = Client.Part1(")())())");
            Assert.AreEqual(-3, result2);
        }

        [TestMethod]
        public void Test06()
        {
            var result = Client.Part2(")");

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void Test07()
        {
            var result = Client.Part2("()())");

            Assert.AreEqual(5, result);
        }
    }
}