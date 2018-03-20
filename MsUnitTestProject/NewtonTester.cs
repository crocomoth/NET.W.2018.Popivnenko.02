using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NET.W._2018.Popivnenko._02.NewtonProj;

namespace NET.W._2018.Popivnenko._02.Test
{

    

    [TestClass]
    public class NewtonTester
    {


        RootFinder rootFinder = new RootFinder();
        const double epsilon = 0.01;

        [DataTestMethod]
        [DataRow(1,5,0.001,1)]
        [DataRow(8,3,0.001,2)]
        [DataRow(0.001, 3, 0.00001,0.1)]
        [DataRow(0.0081, 4, 0.00001, 0.3)]
        [DataRow(121, 2, 0.001, 11)]
        [DataRow(216, 3, 0.001, 6)]

        public void FindRoot_tester(double number,int root,double accuracy,double expectedResult)
        {
            double actualResult = rootFinder.FindRoot(number, root, accuracy);
            Assert.IsTrue((actualResult < expectedResult + epsilon) && (actualResult > expectedResult - epsilon));
        }

       
    }
}
