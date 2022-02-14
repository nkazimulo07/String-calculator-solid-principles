using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculatorKata
{
    public class SplitNumbers
    {
        private ConvertNumbers _convertNumbers;

        public SplitNumbers()
        {
            _convertNumbers = new ConvertNumbers();
        }

        public List<int> Split(string numbers, string[] delimiters)
        {
            if (numbers.StartsWith("//"))
            {
                numbers = numbers.Substring(numbers.LastIndexOf('\n') + 1);
            }

            string[] result = numbers.Split(delimiters, StringSplitOptions.None);

            return _convertNumbers.ConvertStringArrayToIntList(result);
        }
    }
}
