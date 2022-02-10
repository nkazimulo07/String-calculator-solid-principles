namespace StringCalculatorKata
{
    public class StringCalculator
    {
         SplitNumbers _splitNumbers = new SplitNumbers();
         Delimiters _delimiters = new Delimiters();
         ConvertNumbers _convertNumbers = new ConvertNumbers();

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