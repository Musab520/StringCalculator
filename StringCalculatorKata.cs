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
            string negativeNumberCheck = "";
            int sum = 0;
            for (int i = 0; i < numbersArray.Length; i++)
            {
               
                int number= int.TryParse("" + numbersArray[i], out int value) ? value : 0;
                if (number < 0)
                {
                    negativeNumberCheck += ""+numbersArray[i]+",";
                }
                if (number > 1000)
                {
                    number = 0;
                }
                sum +=number;
            }
            if (!string.IsNullOrEmpty(negativeNumberCheck))
            {
                throw new ArgumentException("Negatives not Allowed: "+negativeNumberCheck);
            }
            return sum;
        }
    }
}
