using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_11_Project_4
{
    // Author : Praveen Chakravarthi
    // Purpose : Mathematics Class with 3 static methods

    class Mathematics
    {
        public static int Add(int a, int b)

        { 
            return a + b; 
        }

        public static int Sub(int a, int b)
        {
            return a - b;
        }

        public static int Mul(int a, int b)
        {
            return a * b;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Mathematics mt = new Mathematics();
            Console.WriteLine($"Sum= {Mathematics.Add(6,4)}");
            Console.WriteLine($"Difference= {Mathematics.Sub(5,3)}");
            Console.WriteLine($"Product= {Mathematics.Mul(4,3)}");
            Console.ReadLine();
        }
    }
}
