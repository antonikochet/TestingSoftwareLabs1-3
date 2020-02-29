using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab_1;

namespace IntegrationTests
{
    [TestClass]
    public class IntegrationTest
    {
        private List<int> Methods(string text)
        {
            return Module2.MainsFor(
                    Module1.ConvertStringInInt(
                        Module1.ConvertStringInMasString(text)));
        }
        [TestMethod]
        public void Tests()
        {
            string startText = "";
            CollectionAssert.AreEqual(Methods(startText),
                new List<int>() { });
            startText = "153 745 155 741 895 123";
            CollectionAssert.AreEqual(Methods(startText),
                new List<int>() {153, 745, 155, 741, 895, 123 });
            startText = "125 741 841 127 416 511 746 255";
            CollectionAssert.AreEqual(Methods(startText),
                new List<int>() { 125, 741, 841, 416, 511, 746, 255 });
            startText = "125 745 31 7 127 954 35";
            CollectionAssert.AreEqual(Methods(startText),
                new List<int>() { 125, 745, 954, 35 });



        }
    }
}
