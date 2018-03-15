using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NET.W._2018.Popivnenko._02.ClosestNumberProj;

namespace MsUnitTestProject
{
    [TestClass]
    public class NextBiggerNumberTester
    {

        Searcher searcher = new Searcher();

        [TestMethod]
        public void BNTest1()
        {
            int someValue = searcher.FindNextBiggerNumber(456);
            Assert.AreEqual(465, someValue);
        }

        [TestMethod]
        public void BNTest2()
        {
            int someValue = searcher.FindNextBiggerNumber(144);
            Assert.AreEqual(414, someValue);
        }

        [TestMethod]
        public void BNTest3()
        {
            int someValue = searcher.FindNextBiggerNumber(1234126);
            Assert.AreEqual(1234162, someValue);
        }

        [TestMethod]
        public void BNTest4()
        {
            int someValue = searcher.FindNextBiggerNumber(1234321);
            Assert.AreEqual(someValue, 1241233);
        }

        [TestMethod]
        public void BNTest5()
        {
            int someValue = searcher.FindNextBiggerNumber(3456432);
            Assert.AreEqual(someValue, 3462345);
        }

        [TestMethod]
        public void BNTest6()
        {
            int someValue = searcher.FindNextBiggerNumber(20);
            Assert.AreEqual(someValue, -1);
        }

        [TestMethod]
        public void BNTest7()
        {
            int someValue = searcher.FindNextBiggerNumber(15137);
            Assert.AreEqual(someValue, 15173);
        }

        [TestMethod]
        public void BNTest8()
        {
            int someValue = searcher.FindNextBiggerNumber(4584);
            Assert.AreEqual(someValue, 4845);
        }
        [TestMethod]
        public void BNTest9()
        {
            int someValue = searcher.FindNextBiggerNumber(3112);
            Assert.AreEqual(someValue, 3121);
        }

        [TestMethod]
        public void BNTest10()
        {
            int someValue = searcher.FindNextBiggerNumber(681195);
            Assert.AreEqual(someValue, 681519);
        }

        [TestMethod]
        public void BNTimerTest1()
        {
            long someValue = searcher.ReturnTime();
            Assert.IsTrue(someValue < 1000);
        }

        [TestMethod]
        public void BNTimerTest2()
        {
            int buf = searcher.FindNextBiggerNumber(34);
            long someValue = searcher.ReturnTime();
            Assert.IsTrue(someValue < 1000);
        }

        [TestMethod]
        public void BNTimerTest3()
        {
            int buf = searcher.FindNextBiggerNumber(10);
            long someValue = searcher.ReturnTime();
            Assert.IsTrue(someValue < 100);
        }
    }
}
