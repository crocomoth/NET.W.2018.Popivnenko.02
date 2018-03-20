using System;
using System.Collections.Generic;

namespace NET.W._2018.Popivnenko._02.ClosestNumberProj
{
    /// <summary>
    /// Class that allows to seek for a closest bigger number to the specified value
    /// which will consist only of a digits from the value.
    /// </summary>
    public class Searcher
    {
        private System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();

        private struct Digits
        {
            public int source;
            public int dest;
        }

        /// <summary>
        /// Method allows to get information about last operation's execution time.
        /// </summary>
        /// <returns>Execution time of a last operation in ticks.</returns>
        public long ReturnTime()
        {
            return stopwatch.ElapsedTicks;
        }

        /// <summary>
        /// Method allows to find a closest bigger number to the specified value
        /// or returns -1 in case it doesn't have any.
        /// </summary>
        /// <param name="number">Number which will be used in calculation.</param>
        /// <returns>Either closest bigger number or -1.</returns>
        public int FindNextBiggerNumber(int number)
        {
            stopwatch.Reset();
            stopwatch.Start();
            
            if (number <= 0)
            {
                return -1;
            }
            Digits digits = FindDigitsToReplace(number);
            if (digits.source == -1)
            {
                return -1;
            }
            
            int result = DoReplaceDigits(number,digits);
            stopwatch.Stop();
            return result;
        }


        #region WeirdLogic
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
            List<int> pool = new List<int>();
            int digitToBeReplaced = 0;
            int digiToReplace = 0;
            int buf = number;
            int digitCount = 0;
            int semiFullNumber = 0;
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
            bool digitAfterWhichReplacementsToBeMadeFound = false;
            int currDigit = digitCount;
            buf = 0;
            while (currDigit >= 0)
            {
                
                int pow = (int)Math.Pow(10, currDigit);
                int digit = (number / pow) % 10;
                if (currDigit == digits.source)
                {
                    digit = digiToReplace;
                    digitAfterWhichReplacementsToBeMadeFound = true;
                    semiFullNumber += digit * pow;
                }   
                if (currDigit == digits.dest)
                {
                    digit = digitToBeReplaced;
                }
                buf += digit * pow;
                if (digitAfterWhichReplacementsToBeMadeFound == false)
                {
                    semiFullNumber += digit * pow;
                }
                currDigit--;


            }
            currDigit = 0;
            while (currDigit < digits.source)
            {
                int pow = (int)Math.Pow(10, currDigit);
                int digit = (buf / pow) % 10;
                pool.Add(digit);
                currDigit++;
            }
            pool.Sort();
            pool.Reverse();
            currDigit = 0;
            foreach (var elem in pool)
            {
                int pow = (int)Math.Pow(10, currDigit);
                int digit = elem * pow;
                semiFullNumber += digit;
                currDigit++;
            }
            return semiFullNumber;
        }
        #endregion //WeirdLogic
    }
}
