using FactorialNumber.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number:");
            double number = double.Parse(Console.ReadLine());

            Console.WriteLine($"=====The factorial by liner method=====");
            Console.WriteLine(Factorial.LinearFactorial(number));
            Console.WriteLine();

            Console.WriteLine($"=====The factorial by Recursive method=====");
            Console.WriteLine(Factorial.RecursiveFactorial(number));
        }
    }
}
