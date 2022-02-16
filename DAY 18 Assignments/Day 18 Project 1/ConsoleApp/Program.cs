using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathLibrary;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{Algebra.Factorial(4)}\n" +
                              $" {Algebra.Factorial(0)}\n" +
                              $" {Algebra.Factorial(-3)}\n" +
                              $" {Algebra.Factorial(9)}"); 
            Console.ReadLine();
        }
    }
}
