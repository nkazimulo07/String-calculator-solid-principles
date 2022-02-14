namespace StringCalculatorKata
{
    public class StringCalculator
    {
       
        private GetNumbers _getNumbers;

        public StringCalculator()
        {
            _getNumbers = new GetNumbers();
        }
         
        public int Add(string number)
        {
            if (string.IsNullOrEmpty(number))
            {
                return 0;
            }

            var numbers = _getNumbers.GetListOfNumber(number);

            return SumOfNumbers(numbers);
        }

        public int SumOfNumbers(List<int> numbers)
        {
            return numbers.Sum();
        }
    }
}