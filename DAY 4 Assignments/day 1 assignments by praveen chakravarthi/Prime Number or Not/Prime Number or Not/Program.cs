using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial_of_3_Numbers_using_Recursion
{
    internal class Program
    {
        public static int Factorial(int n)
        {
            if (n == 0)
                return 1;
            else
                return n * Factorial(n - 1);
    }
        public static void Print(int n)
        {
            Console.WriteLine("Factorial of {0} = {1}", n, Factorial(n));
        }
        static void Main(string[] args)
        {
            int n = 7, n1 = 6, n2 = 5;
            Print(n);
            Print(n1);
            Print(n2);
            Console.ReadLine();
        }
    }
}
