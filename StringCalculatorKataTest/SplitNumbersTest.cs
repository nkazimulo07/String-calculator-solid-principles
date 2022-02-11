using NUnit.Framework;
using StringCalculatorKata;
using System.Collections.Generic;

namespace StringCalculatorKataTest
{
    public class Tests
    {
        private SplitNumbers  _splitNumbers;

        [SetUp]
        public void Setup()
        {
            _splitNumbers = new SplitNumbers();
        }

        [Test]
        public void WhenStringWithNumbersAndArrayWithDelimiters_UsingSplit_ResultsReturnsSplitsNumbers()
        {
            // arrange
            string[] expected = { "1", "8", "16", "40" };
            const string input = "//[*][%][;]\n1*8%16;40";
            string[] input2= { "*", "%", ";"};

            // act 
            var results = _splitNumbers.Split(input, input2);

            // assert
            Assert.AreEqual(expected, results);
        }

    }
}