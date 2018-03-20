using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.W._2018.Popivnenko._02.ListFilterProj
{
    /// <summary>
    /// Class that allows to filter collection(List) of integers 
    /// and leave only elements that countain specified digit.
    /// </summary>
    public class ListFilter
    {
        /// <summary>
        /// Method that allows to filter List in the way described in class summary.
        /// </summary>
        /// <param name="digit">Digit that will be used to filter the collection.</param>
        /// <param name="list">List of integers.</param>
        /// <returns>Filtered collection.</returns>
        public List<int> FilterDigit(int digit,List<int> list)
        {
            if (list == null)
            {
                throw new ArgumentNullException(nameof(list));
            }
            if ((digit < 0) || (digit >= 9))
            {
                throw new ArgumentOutOfRangeException(nameof(digit));
            }
            List<int> result = new List<int>();
            foreach (var elem in list)
            {
                if (ContainsDigit(digit,elem))
                {
                    result.Add(elem);
                }
            }
            return result;
        }

        private bool ContainsDigit(int digit,int number)
        {
            int buf = number;
            int digitCount = 0;
            while (buf > 0)
            {
                buf /= 10;
                digitCount++;
            }
            digitCount -= 1;

            int currDigit = digitCount;
            while (currDigit >= 0)
            {
                int pow = (int)Math.Pow(10, currDigit);
                int singleDigit = (number / pow) % 10;
                if (singleDigit == digit)
                {
                    return true;
                }
                currDigit--;
            }
            return false;
        }
    }
}
