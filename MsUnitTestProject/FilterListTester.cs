using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NET.W._2018.Popivnenko._02.ListFilterProj;

namespace NET.W._2018.Popivnenko._02.Test
{
    [TestClass]
    public class FilterListTester
    {

        ListFilter listFilter;
        static List<int> list;
        static List<int> listWithResults;

        private void InitList()
        {
            if (listFilter == null)
            {
                listFilter = new ListFilter();
                list = new List<int>();
                listWithResults = new List<int>();
                list.Add(1);
                list.Add(315);
                list.Add(812);
                list.Add(152);
                list.Add(14);
                list.Add(5);
                listWithResults.Add(315);
                listWithResults.Add(152);
                listWithResults.Add(5);
            }
        }

       /* [DataTestMethod]
        [DataRow(5, list, listWithResults)]
        public void FilterDigit_tester(int digit, List<int> src, List<int> result)
        {
            this.InitList();
            List<int> actualResult = listFilter.FilterDigit(digit, src);
            Assert.AreEqual(result, actualResult);
        } */

        [TestMethod]
        public void FilterDigit_ReturnsNotNull()
        {
            InitList();
            List<int> list = new List<int>();
            list.Add(1);
            list = listFilter.FilterDigit(1, list);
            Assert.IsNotNull(list);
        }

        
    }
}
