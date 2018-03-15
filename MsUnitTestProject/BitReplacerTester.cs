using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NET.W._2018.Popivnenko._02.BitReplacerProj;

namespace MsUnitTestProject
{
    [TestClass]
    public class BitReplacerTester
    {
        BitReplacer bitReplacer = new BitReplacer();
        [TestMethod]
        public void BasicTest1()
        {
            
            int someValue = bitReplacer.ReplaceBits(15, 15, 0, 0);
            Assert.AreEqual(15, someValue);
        }

        [TestMethod]
        public void BasicTest2()
        {
            int someValue = bitReplacer.ReplaceBits(8, 15, 0, 0);
            Assert.AreEqual(9, someValue);
        }

        [TestMethod]
        public void BasicTest3()
        {
            int someValue = bitReplacer.ReplaceBits(8, 15, 8, 3);
            Assert.AreEqual(120, someValue);
        }

        [TestMethod]
        public void BasicTest4()
        {
            int someValue = bitReplacer.ReplaceBits(45, 14, 3, 1);
            Assert.AreEqual(45, someValue);
        }

        [TestMethod]
        public void BasicTest5()
        {
            int someValue = bitReplacer.ReplaceBits(15, 15, 0, 0);
            Assert.AreEqual(15, someValue);
        }
    }
}
