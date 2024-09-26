using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialNumber.Models
{
    internal class Factorial
    {
        //Calculating factorial of a number by linear method
        public static double LinearFactorial(double number)
        {
            double result = 1;
            for (int i = 2; i <= number; i++)
            {
                result = result * i;
            }
            return result;
        }

        //Calculating factorial of a number by recursive method
        public static double RecursiveFactorial(double number)
        {
            if (number <= 0)
            {
                return 1;
            }


            return number * RecursiveFactorial(number - 1);
        }
    }
}
