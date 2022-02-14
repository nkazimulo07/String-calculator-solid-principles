namespace StringCalculatorKata
{
    public class CheckNumbersGreaterThanOneThousand
    {
        public List<int> GetNumbersLessThanOneThousand(List<int> convectedNumbers)
        {
            var numbersLessThanOneThousand = new List <int>();

            foreach (int number in convectedNumbers)
            {
                if (number < 1000)
                {
                    numbersLessThanOneThousand.Add(number);
                }
            }

            return numbersLessThanOneThousand;
        }
    }
}
