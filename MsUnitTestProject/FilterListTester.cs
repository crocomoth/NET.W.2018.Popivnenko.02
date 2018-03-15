using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NET.W._2018.Popivnenko._02.ListFilterProj;

namespace MsUnitTestProject
{
    /// <summary>
    /// Summary description for FilterListTester
    /// </summary>
    [TestClass]
    public class FilterListTester
    {

        ListFilter listFilter = new ListFilter();

        public FilterListTester()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void TestMethod1()
        {
            List<int> list = new List<int>();
            list.Add(1);
            list = listFilter.FilterDigit(1, list);
            Assert.IsNotNull(list);
        }

        [TestMethod]
        public void TestMethod2()
        {
            List<int> list = new List<int>();
            list.Add(1);
            list = listFilter.FilterDigit(2, list);
            Assert.IsNotNull(list);
        }

        [TestMethod]
        public void TestMethod3()
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(315);
            list.Add(812);
            list.Add(152);
            list.Add(14);
            list.Add(5);
            list = listFilter.FilterDigit(5, list);
            List<int> list2 = new List<int>();
            list2.Add(315);
            list2.Add(152);
            list2.Add(5);
            Assert.AreEqual(list[1],list2[1]);
        }

        [TestMethod]
        public void TestMethod4()
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(315);
            list.Add(812);
            list.Add(152);
            list.Add(14);
            list.Add(5);
            list = listFilter.FilterDigit(5, list);
            List<int> list2 = new List<int>();
            list2.Add(315);
            list2.Add(152);
            list2.Add(5);
            Assert.AreEqual(list[0], list2[0]);
        }

        [TestMethod]
        public void TestMethod5()
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(315);
            list.Add(812);
            list.Add(152);
            list.Add(14);
            list.Add(5);
            list = listFilter.FilterDigit(5, list);
            List<int> list2 = new List<int>();
            list2.Add(315);
            list2.Add(152);
            list2.Add(5);
            Assert.AreEqual(list[2], list2[2]);
        }

        [TestMethod]
        public void TestMethod6()
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(315);
            list.Add(812);
            list.Add(152);
            list.Add(14);
            list.Add(5);
            list = listFilter.FilterDigit(5, list);
            List<int> list2 = new List<int>();
            list2.Add(315);
            list2.Add(152);
            list2.Add(5);
            Assert.AreNotSame(list, list2);
        }

        [TestMethod]
        public void TestMethod7()
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(315);
            list.Add(812);
            list.Add(152);
            list.Add(14);
            list.Add(5);
            list = listFilter.FilterDigit(8, list);
            List<int> list2 = new List<int>();
            list2.Add(812);
            list2.Add(152);
            list2.Add(5);
            Assert.AreEqual(list[0], list2[0]);
        }

        [TestMethod]
        public void TestMethod8()
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(315);
            list.Add(812);
            list.Add(152);
            list.Add(14);
            list.Add(5);
            list = listFilter.FilterDigit(2, list);
            List<int> list2 = new List<int>();
            list2.Add(812);
            list2.Add(152);
            list2.Add(5);
            Assert.AreEqual(list[0], list2[0]);
        }

        [TestMethod]
        public void TestMethod9()
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(315);
            list.Add(812);
            list.Add(152);
            list.Add(14);
            list.Add(5);
            list = listFilter.FilterDigit(2, list);
            List<int> list2 = new List<int>();
            list2.Add(812);
            list2.Add(152);
            list2.Add(5);
            Assert.AreEqual(list[1], list2[1]);
        }

        [TestMethod]
        public void TestMethod10()
        {
            List<int> list = new List<int>();
            list.Add(1);

            list = listFilter.FilterDigit(1, list);
            Assert.IsNotNull(list);
        }
    }
}
