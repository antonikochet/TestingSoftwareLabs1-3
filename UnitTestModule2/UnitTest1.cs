using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab_1_3;
using System.Collections.Generic;

namespace UnitTestModule2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SimpleNumberTest()
        {
            Assert.AreEqual(Module2.SimpleNumber(17), true);
            Assert.AreEqual(Module2.SimpleNumber(15), false);
        }
        [TestMethod]
        public void IsPowerOfTwoTest()
        {
            Assert.AreEqual(Module2.IsPowerOfTwo(16), true);
            Assert.AreEqual(Module2.IsPowerOfTwo(3), false);
            Assert.AreEqual(Module2.IsPowerOfTwo(0), false);
        }
        [TestMethod]
        public void MainConditionTest()
        {
            Assert.AreEqual(Module2.MainCondition(31), true);
            Assert.AreEqual(Module2.MainCondition(127), true);
            Assert.AreEqual(Module2.MainCondition(147), false);
            Assert.AreEqual(Module2.MainCondition(0), false);
            Assert.AreEqual(Module2.MainCondition(255), false);
            Assert.AreEqual(Module2.MainCondition(7), true);
        }
        [TestMethod]
        public void MainsForTest()
        {
            CollectionAssert.AreEqual(Module2.MainsFor(new List<int>() { 486, 475, 127, 745, 74 }),
                                                       new List<int>() { 486, 475, 745, 74 });
            CollectionAssert.AreEqual(Module2.MainsFor(new List<int>() { 471, 845, 578, 186, 748}),
                                                       new List<int>() { 471, 845, 578, 186, 748 });
            CollectionAssert.AreEqual(Module2.MainsFor(new List<int>() { 878, 45, 15, 31, 127, 255, 511 }),
                                                       new List<int>() { 878, 45, 15, 255, 511 });
            CollectionAssert.AreEqual(Module2.MainsFor(new List<int>() { }), new List<int>() { });
        }
    }
}
