﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.W._2018.Popivnenko._02
{
    public static class TestClass
    {
        
        
        public static void Main()
        {
            BitReplacerProj.BitReplacer bitReplacer = new BitReplacerProj.BitReplacer();
            int someValue = bitReplacer.ReplaceBits(45, 14, 3, 1);
            someValue = bitReplacer.ReplaceBits(15, 15, 0, 0);
            someValue = bitReplacer.ReplaceBits(8, 15, 0, 0);
            someValue = bitReplacer.ReplaceBits(8, 15, 8, 3);
            someValue = bitReplacer.ReplaceBits(45, 14, 3, 1);

        }

    }
}