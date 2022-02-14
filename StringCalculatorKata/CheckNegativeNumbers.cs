using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculatorKata
{
    public class CheckNegativeNumbers
    {
        private CheckNumbersGreaterThanOneThousand _checkNumbersGreaterThanOneThousand;

        public CheckNegativeNumbers()
        {
            _checkNumbersGreaterThanOneThousand = new CheckNumbersGreaterThanOneThousand();
        }

        public List<int> CheckNegatives(List<int> numbers)
        {
            var negativeNumbers = "";

            foreach (var number in numbers)
            {
                if (number < 0)
                {
                    negativeNumbers += number + " ";
                }
            }

            if (negativeNumbers != "")
            {
                NegativeNumbers(negativeNumbers);
            }

            return _checkNumbersGreaterThanOneThousand.GetNumbersLessThanOneThousand(numbers);
        }

        private void NegativeNumbers(string negativeNumbers)
        {
            throw new Exception("negatives not allowed:  " + negativeNumbers);
        }
    }
}
