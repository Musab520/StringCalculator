using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator
{
    public class StringCalculatorKata : IStringCalculator
    {
        public int add(NumberString numberstring)
        {
            string numbers = numberstring.numbers;
            numbers=numbers.Trim();
            numbers = numbers.Replace("\n", ",");
            string[] numbersArray = numbers.Split(numberstring.delimeter);
            int sum = 0;
            for (int i = 0; i < numbersArray.Length; i++)
            {
                sum += int.TryParse("" + numbersArray[i], out int value) ? value : 0;
            }
            return sum;
        }
    }
}
