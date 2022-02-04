using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_10_Project_1
{
    // Author : Praveen Chakravarthi
    // Purpose : Example Code for Single Inheritance

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
        
    internal class Program
    {
        static void Main(string[] args)
        {
            Maths2 data = new Maths2();
            Console.WriteLine($"Sum is: {data.Add(2,4)}");
            Console.WriteLine($"Difference is: {data.Sub(4,2)}");
            Console.ReadLine();

        }
    }
}
