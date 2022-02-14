using NUnit.Framework;
using StringCalculatorKata;
using System.Collections.Generic;

namespace StringCalculatorKataTest
{
    public class CheckNegativesTest
    {
        private CheckNegativeNumbers _checkNegativeNumbers;

        [SetUp]
        public void Setup()
        {
            _checkNegativeNumbers = new CheckNegativeNumbers();
        }

        [Test]
        public void WhenIntList_UsingCheckNegatives_ResultsReturnsException()
        {
            var input = new List<int> {  8, 16, -1 };
            Assert.Throws<System.Exception>(() => _checkNegativeNumbers.CheckNegatives(input));
        }
    }
}
