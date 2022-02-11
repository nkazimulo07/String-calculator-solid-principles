namespace StringCalculatorKata
{
    public class StringCalculator
    {
       
        private Delimiters _delimiters;
        private SplitNumbers _splitNumbers;
        private ConvertNumbers _convertNumbers;

        public StringCalculator()
        {
            _splitNumbers = new SplitNumbers();
            _delimiters = new Delimiters();
            _convertNumbers = new ConvertNumbers();
        }
         
        public int Add(string numbers)
        {
            if (string.IsNullOrEmpty(numbers))
            {
                return 0;
            }

            string[] delimiters = _delimiters.GetDelimiter(numbers);
            var splitNumber = _splitNumbers.Split(numbers, delimiters);
            var convertNumbers = _convertNumbers.ConvertStringArrayToIntList(splitNumber);

            return SumOfNumbers(convertNumbers);
        }

        public int SumOfNumbers(List<int> numbers)
        {
            return numbers.Sum();
        }
    }
}