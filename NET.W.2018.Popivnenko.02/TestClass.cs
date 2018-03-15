using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NET.W._2018.Popivnenko._02.ClosestNumberProj;
using NUnit.Framework;

namespace NET.W._2018.Popivnenko._02
{
    [TestFixture]
    public static class TestClass
    {

        public static BitReplacerProj.BitReplacer bitReplacer = new BitReplacerProj.BitReplacer();

        public static void Main()
        {
            
            int someValue = bitReplacer.ReplaceBits(45, 14, 3, 1);
            someValue = bitReplacer.ReplaceBits(15, 15, 0, 0);
            someValue = bitReplacer.ReplaceBits(8, 15, 0, 0);
            someValue = bitReplacer.ReplaceBits(8, 15, 8, 3);
            someValue = bitReplacer.ReplaceBits(45, 14, 3, 1);

            someValue = bitReplacer.ReplaceBits(-8,11,3,5);
            someValue = bitReplacer.ReplaceBits(13,27,11,5);
            someValue = bitReplacer.ReplaceBits(108,15,3,0);
            someValue = bitReplacer.ReplaceBits(11,28,8,4);
            someValue = bitReplacer.ReplaceBits(-10,-12,3,1);
            someValue = bitReplacer.ReplaceBits(-151,1111,-5,0);
            someValue = bitReplacer.ReplaceBits(-1812,354,8,3);
            



            ClosestNumberProj.Searcher searcher = new Searcher();
            int value1 = 456;
            someValue = searcher.FindNextBiggerNumber(value1);
            someValue = searcher.FindNextBiggerNumber(144);
            someValue = searcher.FindNextBiggerNumber(1234321);
            long timeSpan = searcher.ReturnTime();
            someValue = searcher.FindNextBiggerNumber(1234126);
            someValue = searcher.FindNextBiggerNumber(3456432);
            someValue = searcher.FindNextBiggerNumber(20);
            someValue = searcher.FindNextBiggerNumber(20);

            ListFilterProj.ListFilter listFilter = new ListFilterProj.ListFilter();
            List<int> list = new List<int>();
            list.Add(7);
            list.Add(86);
            list.Add(190);
            list.Add(17);
            list.Add(15);
            list.Add(24);
            List<int> resultList = listFilter.FilterDigit(7, list);
            resultList.Clear();
            resultList = listFilter.FilterDigit(1, list);
            resultList.Clear();


            NewtonProj.RootFinder rootFinder = new NewtonProj.RootFinder();
            double someValue2 = rootFinder.FindRoot(1, 5, 0.0001);
            someValue2 = rootFinder.FindRoot(8, 3, 0.0001);
            someValue2 = rootFinder.FindRoot(0.001, 3, 0.0001);
            someValue2 = rootFinder.FindRoot(0.0081, 4, 0.0001);
            someValue2 = rootFinder.FindRoot(1, 5, 0.0000001);



        }

        [Test]
        public static void TestBitReplacer1()
        {
            int someValue = bitReplacer.ReplaceBits(45, 14, 3, 1);
            Assert.AreEqual(45, someValue);
        }

        [Test]
        public static void TestBitReplacer2()
        {
            int someValue = bitReplacer.ReplaceBits(15, 15, 0, 0);
            Assert.AreEqual(15, someValue);
        }

        [Test]
        public static void TestBitReplacer3()
        {
            int someValue = bitReplacer.ReplaceBits(8, 15, 8, 3);
            Assert.AreEqual(120, someValue);
        }

        [Test]
        public static void TestBitReplacer4()
        {
            int someValue = bitReplacer.ReplaceBits(-8, 11, 3, 5);
            Assert.AreEqual(-1, someValue);
        }

        [Test]
        public static void TestBitReplacer5()
        {
            int someValue = bitReplacer.ReplaceBits(13, 27, 11, 5);
            Assert.AreEqual(877, someValue);
        }

        [Test]
        public static void TestBitReplacer6()
        {
            int someValue = bitReplacer.ReplaceBits(108, 15, 3, 0);
            Assert.AreEqual(111, someValue);
        }

        [Test]
        public static void TestBitReplacer7()
        {
            int someValue = bitReplacer.ReplaceBits(11, 28, 8, 4);
            Assert.AreEqual(459, someValue);
        }

        [Test]
        public static void TestBitReplacer8()
        {
            int someValue = bitReplacer.ReplaceBits(-10, -12, 3, 1);
            Assert.AreEqual(-8, someValue);
        }

        [Test]
        public static void TestBitReplacer9()
        {
            int someValue = bitReplacer.ReplaceBits(-151, 1111, -5, 0);
            Assert.AreEqual(-1, someValue);
        }

        [Test]
        public static void TestBitReplacer10()
        {
            int someValue = bitReplacer.ReplaceBits(-1812, 354, 8, 3);
            Assert.AreEqual(-1772, someValue);
        }

    }
}
