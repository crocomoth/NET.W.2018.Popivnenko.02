using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.W._2018.Popivnenko._02.NewtonProj
{
    public class RootFinder
    {
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
