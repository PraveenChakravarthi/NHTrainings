using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial_of_a_number_using_Function
{
    internal class Program
    {
        public static void printOutput(int n)
        {
            Console.WriteLine("Factorial of {0} = {1}", n, factorial(n));
        }
        public static int factorial(int n)
        {
            int fact = 1;
            for (int i = 1; i <= n; i++)
                fact *= i;
            return fact;    
        }
            static void Main(string[] args)
        {
            int n = 4, n1 = 6, n2 = 5;

            printOutput(n);
            printOutput(n1);
            printOutput(n2);

            Console.ReadLine();
        }
    }
}
