
namespace StringCalculatorKata
{
    public class ConvertNumbers
    {
        public List<int> ConvertStringArrayToIntList(string[] numbers)
        {
            var result = new List<int>();
            var negativeNumbers = "";

            for (var i = 0; i < numbers.Length; i++)
            {
                if (Convert.ToInt32(numbers[i]) < 0)
                {
                    negativeNumbers = negativeNumbers + numbers[i] + " ";
                }
                else
                {
                    result.Add(Convert.ToInt32(numbers[i]));
                }
            }
            if (negativeNumbers != "")
            {
                NegativeNumbers(negativeNumbers);
            }

            return GetNumbersLessThanOneThousand(result);
        }

        public List<int> GetNumbersLessThanOneThousand(List<int> convectedNumbers)
        {
            return convectedNumbers.FindAll(x => x < 1000);
        }

        private string NegativeNumbers(string negativeNumbers)
        {
            throw new Exception("negatives not allowed:  " + negativeNumbers);
        }

    }
}
