using NUnit.Framework;
using StringCalculatorKata;

namespace StringCalculatorKataTest
{
    public class DelimitersTest
    {
        private Delimiters delimiters;

        [SetUp]
        public void Setup()
        {
            delimiters = new Delimiters();
        }

        [Test]
        public void WhenStringWithMultipleDelimiter_UsingGetMultipleDelimeters_ResultsReturnsArrayOfDelimiters()
        {
            // arrange
            string[] expected = { "*", "%", ":", ";" };
            const string input = "[*][%][:][;]";

            // act 
            var results = delimiters.GetMultipleDelimiters(input);

            // assert
            Assert.AreEqual(expected, results);
        }
    }
}
