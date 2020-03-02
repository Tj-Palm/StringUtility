using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestStringUtility
{
    [TestClass]
    public class TestStringUtility2
    {
        private StringUtility.StringUtility2 classUnderTest;

        [TestInitialize]
        public void Init()
        {
            classUnderTest = new StringUtility.StringUtility2();
        }

        [TestMethod]
        public void ShouldBeNull()
        {
            string stringToCheck = null;
            string stringToFind = "A";
            int expectedResult = -1;

            int actualResult = classUnderTest.CountOccurences(stringToCheck, stringToFind);
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void ShouldBeEmptyToCheck()
        {
            string stringToCheck = "";
            string stringToFind = "A";
            int expectedResult = 0;

            int actualResult = classUnderTest.CountOccurences(stringToCheck, stringToFind);
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void ShouldBeEmptyToFind()
        {
            string stringToCheck = "Arabia";
            string stringToFind = "";
            int expectedResult = 0;

            int actualResult = classUnderTest.CountOccurences(stringToCheck, stringToFind);
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void ShouldBeMoreThan1StringToFind()
        {
            string stringToCheck = "Arabia";
            string stringToFind = "Ara";
            int expectedResult = 1;

            int actualResult = classUnderTest.CountOccurences(stringToCheck, stringToFind);
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void ShouldBe()
        {
            string stringToCheck = "ArabiaArabiaArabia";
            string stringToFind = "AbabiaArabiaArabia";
            int expectedResult = 0;

            int actualResult = classUnderTest.CountOccurences(stringToCheck, stringToFind);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
