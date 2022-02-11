using NUnit.Framework;
using StringCalculatorKata;
using System.Collections.Generic;

namespace StringCalculatorKataTest
{
    public class ConvertNumberTest
    {
        private ConvertNumbers _convertNumbers;

        [SetUp]
        public void Setup()
        {
            _convertNumbers = new ConvertNumbers();
        }

        [Test]
        public void WhenStringArray_UsingGetDelimeters_ResultsReturnsIntList()
        {
            // arrange
            var expected = new List<int> { 1, 8, 16, 40 };
            string[] input = { "1", "8", "16", "40" }; ;

            // act 
            var results = _convertNumbers.ConvertStringArrayToIntList(input);

            // assert
            Assert.AreEqual(expected, results);
        }
    }
}
