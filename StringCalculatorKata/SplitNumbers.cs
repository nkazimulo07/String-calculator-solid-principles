using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculatorKata
{
    public class SplitNumbers
    {
        public string[] Split(string numbers, string[] delimiters)
        {
            if (numbers.StartsWith("//"))
            {
                numbers = numbers.Substring(numbers.LastIndexOf('\n') + 1);
            }

            string[] result = numbers.Split(delimiters, StringSplitOptions.None);

            return result;
        }
    }
}
