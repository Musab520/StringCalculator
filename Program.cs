using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator
{
    public class Program
    {
        public static void Main()
        {
            IStringCalculator stringCalculator = new StringCalculatorKata();
            int sum = stringCalculator.add(new NumberString("-1,2,-3"));
        }
    }
}
