using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NET.W._2018.Popivnenko._02.NewtonProj;

namespace MsUnitTestProject
{

    

    [TestClass]
    public class NewtonTester
    {


        RootFinder rootFinder = new RootFinder();

        [TestMethod]
        public void NewtonTester1()
        {
            double value = rootFinder.FindRoot(1, 5, 0.001);
            Assert.IsTrue((value > 0.99) && (value < 1.01));
        }

        [TestMethod]
        public void NewtonTester2()
        {
            double value = rootFinder.FindRoot(8, 3, 0.001);
            Assert.IsTrue((value > 1.99) && (value < 2.01));
        }

        [TestMethod]
        public void NewtonTester3()
        {
            double value = rootFinder.FindRoot(0.001, 3, 0.00001);
            Assert.IsTrue((value > 0.09) && (value < 0.11));
        }

        [TestMethod]
        public void NewtonTester4()
        {
            double value = rootFinder.FindRoot(0.0081, 4, 0.00001);
            Assert.IsTrue((value > 0.29) && (value < 0.31));
        }

        [TestMethod]
        public void NewtonTester5()
        {
            double value = rootFinder.FindRoot(1, 5, 0.0001);
            Assert.IsTrue((value > 0.99) && (value < 1.01));
        }

        [TestMethod]
        public void NewtonTester6()
        {
            double value = rootFinder.FindRoot(121, 2, 0.001);
            Assert.IsTrue((value > 10.99) && (value < 11.01));
        }

        [TestMethod]
        public void NewtonTester7()
        {
            double value = rootFinder.FindRoot(211, 3, 0.001);
            Assert.IsTrue((value > 5.9) && (value < 6.01));
        }

        [TestMethod]
        public void NewtonTester8()
        {
            double value = rootFinder.FindRoot(200, 2, 0.001);
            Assert.IsTrue((value > 14.1) && (value < 14.3));
        }

        [TestMethod]
        public void NewtonTester9()
        {
            double value = rootFinder.FindRoot(0.04, 8, 0.0001);
            Assert.IsTrue((value > 0.6) && (value < 0.7));
        }

        [TestMethod]
        public void NewtonTester10()
        {
            double value = rootFinder.FindRoot(0.0187, 3, 0.00001);
            Assert.IsTrue((value > 0.25) && (value < 0.28));
        }
    }
}
