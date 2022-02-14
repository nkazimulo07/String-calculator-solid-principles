namespace StringCalculatorKata
{
    public class StringCalculator
    {
       
        private Delimiters _delimiters;

        public StringCalculator()
        {
            _delimiters = new Delimiters();
        }
         
        public int Add(string number)
        {
            if (string.IsNullOrEmpty(number))
            {
                return 0;
            }

            var numbers = _delimiters.GetDelimiter(number);

            return SumOfNumbers(numbers);
        }

        public int SumOfNumbers(List<int> numbers)
        {
            return numbers.Sum();
        }
    }
}