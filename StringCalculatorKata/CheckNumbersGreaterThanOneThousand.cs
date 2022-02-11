namespace StringCalculatorKata
{
    public class CheckNumbersGreaterThanOneThousand
    {
        public List<int> GetNumbersLessThanOneThousand(List<int> convectedNumbers)
        {
            return convectedNumbers.FindAll(x => x < 1000);
        }
    }
}
