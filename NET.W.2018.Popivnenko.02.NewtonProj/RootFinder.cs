using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.W._2018.Popivnenko._02.NewtonProj
{
    /// <summary>
    /// Class that allows to get a nth root of a number
    /// with specified accuracy.
    /// </summary>
    public class RootFinder
    {
        /// <summary>
        /// Method that allows to get a nth root of a number 
        /// with specified accuracy. 
        /// </summary>
        /// <param name="number">Number which root will be calculated.</param>
        /// <param name="root">Root of a number to be calculatrd.</param>
        /// <param name="accuracy">Accuracy wit which result will be calculated.</param>
        /// <returns>Nth root of a number with specified accuracy.</returns>
        public double FindRoot(double number,int root,double accuracy)
        {
            if (accuracy < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            double rootValue = number / 2;
            double iterationValue = 1.0 / root * ((root - 1) * rootValue + (number / Math.Pow(rootValue, root - 1)));
            double lastIterationValue = 0;
            do
            {
                lastIterationValue = iterationValue;
                iterationValue = iterationValue = 1.0 / root * ((root - 1) * lastIterationValue + (number / Math.Pow(lastIterationValue, root - 1)));
            }
            while (Math.Abs(lastIterationValue - iterationValue) > accuracy);
            return iterationValue;
        }
    }
}
