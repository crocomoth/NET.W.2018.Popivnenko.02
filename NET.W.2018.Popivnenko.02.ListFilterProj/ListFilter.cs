using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.W._2018.Popivnenko._02.ListFilterProj
{
    public class ListFilter
    {
        public List<int> FilterDigit(int digit,List<int> list)
        {
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
