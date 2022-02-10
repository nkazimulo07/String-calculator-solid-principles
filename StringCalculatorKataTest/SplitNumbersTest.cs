using NUnit.Framework;
using StringCalculatorKata;
using System.Collections.Generic;

namespace StringCalculatorKataTest
{
    public class Tests
    {
        private ConvertNumbers _convertNumbers;

        [SetUp]
        public void Setup()
        {
            _convertNumbers = new ConvertNumbers();
        }

        [Test]
        public void WhenListOfNumbersAndOneIsGreaterThanOneThousand_UsingGetNumbersLessThanOneThousand_ResultsReturnsList()
        {
            // arrange
            var expected = new List<int> { 200, 10 };
            var input = new List<int>() { 1000, 200, 7000, 10 };

            // act 
            var results = _convertNumbers.GetNumbersLessThanOneThousand(input);

            // assert
            Assert.AreEqual(expected, results);
        }
    }
}