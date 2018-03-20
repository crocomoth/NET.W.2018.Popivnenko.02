namespace NET.W._2018.Popivnenko._02.BitReplacerProj
{
    /// <summary>
    /// Class that replaces specified bits of a number with
    /// corresponding amount of other number strarting from beggining.
    /// </summary>
    public class BitReplacer
    {

        /// <summary>
        /// Method that is called to change bits in number in way specified in class description
        /// </summary>
        /// <param name="source">Number that will be changed.</param>
        /// <param name="donor">Number which bits will be used in replacing.</param>
        /// <param name="leftBorder">Index of the highest bit to be replaced.</param>
        /// <param name="rightBorder">Index of the lowest bit to be replaced.</param>
        /// <returns>Either changed source parameter or -1 in case of an error.</returns>
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
