using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NET.W._2018.Popivnenko._02.BitReplacerProj;

namespace NET.W._2018.Popivnenko._02.Test
{
    [TestClass]
    public class BitReplacerTester
    {
        BitReplacer bitReplacer = new BitReplacer();

        [DataTestMethod]
        [DataRow(15,15,0,0,15)]
        [DataRow(8, 15, 0, 0,9)]
        [DataRow(8, 15, 8, 3,120)]
        [DataRow(45, 14, 3, 1,45)]
        [DataRow(15, 15, 0, 0,15)]
        [DataRow(15, 15, -1, 5,-1)]
        [DataRow(15, 15, 5, -1,-1)]
        [DataRow(15, 15, -1, -100,-1)]
        [DataRow(15, 15, 4, 5,-1)]
        public void ReplaceBits_bitsReplaced(int source,int donor,int leftBorder,int rightborder,int expectedResult)
        {
            int actualResult = bitReplacer.ReplaceBits(source, donor, leftBorder, rightborder);
            Assert.AreEqual(expectedResult, actualResult);
        }

        
    }
}
