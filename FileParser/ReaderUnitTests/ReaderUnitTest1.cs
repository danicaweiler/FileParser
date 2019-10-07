// -----------------------------------------------
// File   : UnitTest.cs
// By     : Danica Weiler
// Date   : May 8, 2019
// Purpose: Happy Path Unit testing for Orientation exercise
// -----------------------------------------------


using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ReaderUnitTest
{
    [TestClass]
    public class UnitTest1
    {

        string[] HappyTestContent =
        {
            "1234567890",
            "abcdefghijklmnopqrstuvwxyz",
            "ABCDEFGHIJKLMNOPQRSTUVWXYZ",
            ",./;'!",
            "One Two Three Four Five"
        };

        int[] ExpectedResults =
        {
            10,
            26,
            26,
            6,
            5
        };

        [TestMethod]
        public void TestCountNumbers()
        {
            int result = FileReadParser.ParseContent.CountNumbers(HappyTestContent[0]);
            Assert.AreEqual(ExpectedResults[0], result);
        }

        [TestMethod]
        public void TestCountLower()
        {
            int result = FileReadParser.ParseContent.CountLower(HappyTestContent[1]);
            Assert.AreEqual(ExpectedResults[1], result);
        }

        [TestMethod]
        public void TestCountUpper()
        {
            int result = FileReadParser.ParseContent.CountUpper(HappyTestContent[2]);
            Assert.AreEqual(ExpectedResults[2], result);
        }

        [TestMethod]
        public void TestCountOtherChar()
        {
            int result = FileReadParser.ParseContent.CountOtherChar(HappyTestContent[3]);
            Assert.AreEqual(ExpectedResults[3], result);
        }

        [TestMethod]
        public void TestCountWords()
        {
            int result = FileReadParser.ParseContent.CountWords(HappyTestContent[4]);
            Assert.AreEqual(ExpectedResults[4], result);
        }
    }
}
