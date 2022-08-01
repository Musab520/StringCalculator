using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator
{
    public class NumberString
    {
        public string numbers { get; set; }
        public string delimeter { get; set; }
        public NumberString(string numbers)
        {
            this.numbers = numbers;
            if (numbers.StartsWith("//"))
            {
                delimeter= numbers.Substring(2,3);
            }
            else
            {
                delimeter=",";
            }
        }
    }
}
