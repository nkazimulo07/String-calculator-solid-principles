using NUnit.Framework;
using StringCalculatorKata;
using System.Collections.Generic;

namespace StringCalculatorKataTest
{
    public class ConvertNumbersTest
    {
        private CheckNumbersGreaterThanOneThousand _checkNumbersGreaterThanOneThousand;

        [SetUp]
        public void Setup()
        {
            _checkNumbersGreaterThanOneThousand = new CheckNumbersGreaterThanOneThousand();
        }

        [Test]
        public void WhenListOfNumbersAndOneIsGreaterThanOneThousand_UsingGetNumbersLessThanOneThousand_ResultsReturnsList()
        {
            // arrange
            var expected = new List<int> { 200, 10 };
            var input = new List<int>() { 1000, 200, 7000, 10 };

            // act 
            var results = _checkNumbersGreaterThanOneThousand.GetNumbersLessThanOneThousand(input);

            // assert
            Assert.AreEqual(expected, results);
        }
    }
}
