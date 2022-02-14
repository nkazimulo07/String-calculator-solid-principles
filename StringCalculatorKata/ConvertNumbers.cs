
namespace StringCalculatorKata
{
    public class ConvertNumbers
    {
        private CheckNumbers _checkNumbers;

        public ConvertNumbers()
        {
            _checkNumbers = new CheckNumbers();
        }

        public List<int> ConvertStringArrayToIntList(string[] numbers)
        {
            var result = new List<int>();

            for (var i = 0; i < numbers.Length; i++)
            {  
                    result.Add(Convert.ToInt32(numbers[i]));
            }

            return _checkNumbers.CheckNegatives(result);
        }

    }
}
