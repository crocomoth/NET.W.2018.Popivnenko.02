using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NET.W._2018.Popivnenko._02.ClosestNumberProj;

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


            ClosestNumberProj.Searcher searcher = new Searcher();
            int value1 = 456;
            someValue = searcher.FindNextBiggerNumber(value1);
            someValue = searcher.FindNextBiggerNumber(144);
            someValue = searcher.FindNextBiggerNumber(1234321);
            long timeSpan = searcher.ReturnTime();
            someValue = searcher.FindNextBiggerNumber(1234126);
            someValue = searcher.FindNextBiggerNumber(3456432);
            someValue = searcher.FindNextBiggerNumber(20);
            someValue = searcher.FindNextBiggerNumber(20);

            ListFilterProj.ListFilter listFilter = new ListFilterProj.ListFilter();
            List<int> list = new List<int>();
            list.Add(7);
            list.Add(86);
            list.Add(190);
            list.Add(17);
            list.Add(15);
            list.Add(24);
            List<int> resultList = listFilter.FilterDigit(7, list);
            resultList.Clear();
            resultList = listFilter.FilterDigit(1, list);
            resultList.Clear();


        }

    }
}
