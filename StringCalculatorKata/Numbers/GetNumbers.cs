using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculatorKata
{
    public class GetNumbers
    {
        private ConvertNumbers _convertNumbers;
        private Delimiters _delimiters;

        public GetNumbers()
        {
            _convertNumbers = new ConvertNumbers();
            _delimiters = new Delimiters();
        }

        public List<int> GetListOfNumber(string numbers)
        {
            var delimiters = _delimiters.GetDelimiter(numbers);

            if (numbers.StartsWith("//"))
            {
                numbers = numbers.Substring(numbers.LastIndexOf('\n') + 1);
            }

            string[] result = numbers.Split(delimiters, StringSplitOptions.None);

            return _convertNumbers.ConvertStringArrayToIntList(result);
        }
    }
}
