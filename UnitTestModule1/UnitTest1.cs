using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab_1_3;
using System.Collections.Generic;

namespace UnitTestModule1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ConvertStringToMasStringTest()
        {
            CollectionAssert.AreEqual(Module1.ConvertStringInMasString("157 846 359 749 745"), new string[]{ "157", "846", "359", "749", "745"} );
            CollectionAssert.AreEqual(Module1.ConvertStringInMasString(""), new string[] { });
            CollectionAssert.AreEqual(Module1.ConvertStringInMasString("48 78 186 746"), new string[] { "48", "78", "186", "746" });
        }
        [TestMethod]
        public void ConvertStringToIntTest()
        {
            CollectionAssert.AreEqual(Module1.ConvertStringInInt(new string[] { "157", "475", "895" }), new List<int> { 157, 475, 895 });
            CollectionAssert.AreEqual(Module1.ConvertStringInInt(new string[] { "157", " 74", "0", "748" }), new List<int> { 157, 74, 0, 748 });
        }
        [TestMethod]
        public void CheckListTest()
        {
            Assert.AreEqual(Module1.CheckList(new List<int> { 153, 847, 684,745, 156, 127, 789}), true);
            Assert.AreEqual(Module1.CheckList(new List<int> { 153, 847, 684, 745, 156, 127, 789, 746, 846, 741, 987 }), false);
            Assert.AreEqual(Module1.CheckList(new List<int> { }), false);
            Assert.AreEqual(Module1.CheckList(new List<int> { 153, 847, 684, 745, 15, 127, 789, 746 }) , false);
        }
        [TestMethod]
        public void ConvertListToStringTest()
        {

        }
    }
}
