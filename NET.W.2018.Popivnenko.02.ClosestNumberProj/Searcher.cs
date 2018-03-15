using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.W._2018.Popivnenko._02.ClosestNumberProj
{
    public class Searcher
    {

        private struct Digits
        {
            public int source;
            public int dest;
        }

        public int FindNextBiggerNumber(int number)
        {
            if (number <= 0)
            {
                return -1;
            }
            Digits digits = FindDigitsToReplace(number);
            if (digits.source == -1)
            {
                return -1;
            }
            
            return DoReplaceDigits(number,digits);
        }

        private Digits FindDigitsToReplace(int number)
        {
            int digitCount = 0;
            int buf = number;
            List<int> knownDigits = new List<int>();
            while (buf > 0)
            {
                buf /= 10;
                digitCount++;
            }
            digitCount -= 1;
            int currentDigitNumber = 0;
            while (currentDigitNumber <= digitCount)
            {
                int pow = (int)Math.Pow(10,currentDigitNumber);
                int digit = (number / pow) % 10;
                int currIndex = 0;
                int maxIndex = -1;
                int max = Int32.MaxValue;
                foreach (var elem in knownDigits)
                {
                    if ((elem > digit) && (elem < max))
                    {
                        maxIndex = currIndex;
                        max = elem;
                    }
                    currIndex++;
                }
                if (maxIndex == -1)
                {
                    knownDigits.Add(digit);
                }
                else
                {
                    Digits result = new Digits();
                    result.source = currentDigitNumber;
                    result.dest = maxIndex;
                    return result;
                }
                currentDigitNumber++;
            }
            Digits digits = new Digits();
            digits.source = -1;
            return digits;
            
        }


        private int DoReplaceDigits(int number,Digits digits)
        {
            int digitToBeReplaced = 0;
            int digiToReplace = 0;
            int buf = number;
            int digitCount = 0;
            while (buf > 0)
            {
                buf /= 10;
                digitCount++;
            }
            digitCount -= 1;

            int tempPow = (int)Math.Pow(10, digits.source);
            digitToBeReplaced = (number / tempPow) % 10;
            tempPow = (int)Math.Pow(10, digits.dest);
            digiToReplace = (number / tempPow) % 10;

            int currDigit = 0;
            buf = 0;
            while (currDigit <= digitCount)
            {
                
                int pow = (int)Math.Pow(10, currDigit);
                int digit = (number / pow) % 10;
                if (currDigit == digits.source)
                {
                    digit = digiToReplace;
                }
                if (currDigit == digits.dest)
                {
                    digit = digitToBeReplaced;
                }
                buf += digit * pow;
                currDigit++;


            }
            return buf;
        }
    }
}
