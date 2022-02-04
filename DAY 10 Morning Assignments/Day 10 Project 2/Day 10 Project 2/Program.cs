using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_10_Project_2
{
    // Author : Praveen Chakravarthi
    // Purpose : Example Code for Multilevel Inheritance
    class Maths1
    {
        /// <summary>
        /// This Method Adds the given Numbers
        /// </summary>
        /// <returns></returns>
        public int Add(int a, int b)
        {
            return a + b;

        }
    }

    // Inheritance
    class Maths2 : Maths1  // Maths 2 is Child class whereas Maths1 is Parent Class
    {
        /// <summary>
        /// This Method Subtracts the given Numbers
        /// </summary>
        /// <returns></returns>
        public int Sub(int a, int b)
        {
            return a - b;
        }
    }

    // Multilevel Inheritance
    class Maths3 : Maths2   // Maths 3 is Child class whereas Maths2 is Parent Class
    {
        /// <summary>
        /// This Method Multiplies the given Numbers
        /// </summary>
        /// <returns></returns>
        public int Mul(int a, int b)
        {
            return a* b;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Maths3 data = new Maths3();
            Console.WriteLine($"Sum is: {data.Add(8,4)}");
            Console.WriteLine($"Difference is: {data.Sub(8,4)}");
            Console.WriteLine($"Product is: {data.Mul(8,4)}");

            Console.ReadLine();
        }
    }
}
