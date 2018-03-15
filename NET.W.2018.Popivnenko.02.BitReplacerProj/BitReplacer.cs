using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.W._2018.Popivnenko._02.BitReplacerProj
{
    public class BitReplacer
    {
        public int ReplaceBits(int source,int donor,int leftBorder,int rightBorder)
        {
            int sourcedWithNulledBits = 0;
            int mask = 0;
            if ((leftBorder < 0) || (rightBorder <0 ) || (leftBorder < rightBorder))
            {
                return -1;
            }
            sourcedWithNulledBits = NullifyBits(source, leftBorder, rightBorder);
            mask = CreateMask(leftBorder - rightBorder, 0);
            int bitsToReplace = donor & mask;
            bitsToReplace = LeftShifter(bitsToReplace, rightBorder);
            sourcedWithNulledBits = sourcedWithNulledBits | bitsToReplace;
            return sourcedWithNulledBits;
        }


        private int NullifyBits(int num ,int leftBorder,int rightBorder)
        {
            int mask = CreateMask(leftBorder, rightBorder);
            num = (num | mask) ^ mask;
            return num;
        }

        private int CreateMask(int leftBorder,int rightBorder)
        {
            int mask = 1;
            int i = 0;
            int valueToAdd = 0;
            while (i < rightBorder)
            {
                mask = mask << 1;
                i++;
            }
            valueToAdd = mask;
            while (rightBorder < leftBorder)
            {
                mask = mask << 1;
                mask += valueToAdd;
                rightBorder++;
            }
            return mask;
        }

        private int LeftShifter(int number,int shift)
        {
            return number << shift;
        }
    }
}
