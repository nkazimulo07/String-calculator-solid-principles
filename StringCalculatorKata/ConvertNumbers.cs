
namespace StringCalculatorKata
{
    public class ConvertNumbers
    {
        private CheckNegativeNumbers _checkNegativeNumbers;

        public ConvertNumbers()
        {
            _checkNegativeNumbers = new CheckNegativeNumbers();
        }

        public List<int> ConvertStringArrayToIntList(string[] numbers)
        {
            var result = new List<int>();

            for (var i = 0; i < numbers.Length; i++)
            {  
                    result.Add(Convert.ToInt32(numbers[i]));
            }

            return _checkNegativeNumbers.CheckNegatives(result);
        }

    }
}
