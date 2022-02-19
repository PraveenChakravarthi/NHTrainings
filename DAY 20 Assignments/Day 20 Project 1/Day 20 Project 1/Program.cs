using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_20_Project_1
{
    // Author : Praveen Chakravarthi
    // Purpose : Using Delegates in C# 

    
    internal class Program
    {
        public delegate void Math(int a, int b);

        /// <summary>
        /// This Method Adds the given Numbers
        /// </summary>
        public static void Add(int a, int b)
            {
                Console.WriteLine(a + b);
            }
        /// <summary>
        /// This Method Multiplies the given Numbers
        /// </summary>
            public static void Mul(int a, int b)
            {
                Console.WriteLine(a * b);
            }
        /// <summary>
        /// This Method Divides the given Numbers
        /// </summary>
            public static void Div(int a, int b)
            {
                Console.WriteLine(a/b);
            }
        /// <summary>
        /// This Method Subtracts the given Numbers
        /// </summary>
            public static void Sub(int a, int b)
            {
                Console.WriteLine(a-b);
            }
        static void Main(string[] args)
        {
            // Creating Delegate Object and Initialising Add Method
            Math m = new Math(Add);
            // Adding Methods to the Delegate
            m += Mul;
            m += Div;
            m += Sub;

            // Perfoming all the Methods
            Console.WriteLine("Perfoming All Methods");
            m(6, 3);

            // Removing Div Method from the Delegate
            Console.WriteLine("Removing Div Method");
            m -= Div;
            m(10, 5);

            // Adding the Div Method, Removing Mul Method from the Delegate 
            Console.WriteLine("Removing Mul Method");
            m += Div; m -= Mul;
            m(12, 6);

            Console.ReadLine();
        }
    }
}
