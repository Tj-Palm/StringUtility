using System.ComponentModel.DataAnnotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringUtility;

namespace TestStringUtility
{
    [TestClass]
    public class TestStringUtility
    {
        private StringUtility.StringUtility classUnderTest;

        [TestInitialize]
        public void Init()
        {
            classUnderTest = new StringUtility.StringUtility();
        }

        [TestMethod]
        public void ShouldFindOneYInMysterious()
        {
            string stringToCheck = "Mysterious";
            char stringToFind = 'y';
            int expectedResult = 1;

            int actualResult = classUnderTest.CountOccurences(stringToCheck, stringToFind);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ShouldFindTwoSInMysterious()
        {

            string stringToCheck = "Mysterious";
            char stringToFind = 's';
            int expectedResult = 2;

            int actualResult = classUnderTest.CountOccurences(stringToCheck, stringToFind);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ShouldBeCaseSensitive()
        {
            string stringToCheck = "Arabia";
            char stringToFind = 'A';
            int expectedResult = 3;

            int actualResult = classUnderTest.CountOccurences(stringToCheck, stringToFind);
            Assert.AreEqual(expectedResult, actualResult);
            
        }

        [TestMethod]
        public void ShouldBeNull()
        {
            string stringToCheck = null;
            char stringToFind = 'A';
            int expectedResult = -1;

            int actualResult = classUnderTest.CountOccurences(stringToCheck, stringToFind);
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void ShouldBeSymbol()
        {
            string stringToCheck = "email@email.dk";
            char stringToFind = '@';
            int expectedResult = 1;

            int actualResult = classUnderTest.CountOccurences(stringToCheck, stringToFind);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
