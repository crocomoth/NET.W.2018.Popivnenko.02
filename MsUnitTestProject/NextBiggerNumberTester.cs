using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NET.W._2018.Popivnenko._02.ClosestNumberProj;

namespace NET.W._2018.Popivnenko._02.Test
{
    [TestClass]
    public class NextBiggerNumberTester
    {

        Searcher searcher = new Searcher();

        [DataTestMethod]
        [DataRow(456,465)]
        [DataRow(144,414)]
        [DataRow(1234126,1234162)]
        [DataRow(1234321,1241233)]
        [DataRow(3456432, 3462345)]
        [DataRow(10,-1)]
        public void FindNextBiggerNumber_tester(int value,int expectedResult)
        {
            int actualResult = searcher.FindNextBiggerNumber(value);
            Assert.AreEqual(expectedResult, actualResult);
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
