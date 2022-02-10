using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculatorKata
{
    public class Delimiters
    {
        public string[] GetDelimiter(string numbers)
        {
            var list = new List<string> { ",", "\n" };

            if (numbers.StartsWith("//"))
            {
                var myDelimiter = numbers.Substring(2, numbers.IndexOf('\n') - 2);
                if (myDelimiter.Contains("["))
                {
                    list.AddRange(GetMultipleDelimiters(myDelimiter));
                }
                else
                {
                    list.Add(myDelimiter);
                }
            }

            return list.ToArray();
        }

        public List<string> GetMultipleDelimiters(string delimiter)
        {
            char[] charsToTrim = { '[', ']' };
            string cleanDelimiter = delimiter.Trim(charsToTrim);
            string[] delimiters = cleanDelimiter.Split(new string[] { "][" }, StringSplitOptions.RemoveEmptyEntries);

            return delimiters.ToList();
        }
    }
}
