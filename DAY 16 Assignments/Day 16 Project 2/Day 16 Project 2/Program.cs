using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_16_Project_2
{
    // Author : Praveen Chakravarthi
    // Purpose : Factorial using Class
    internal class Program
    {
        class Factorial
        {
            /// <summary>
            /// This Method Reads a Number and Returns the Factorial 
            /// </summary>
            public static int GetFactorial()
            {
                int n;
                Console.WriteLine("Enter any Numbber: ");
                n = Convert.ToInt32(Console.ReadLine());
                int fact = 1;
                for (int i = 1; i <=n; i++ )
                    fact = fact * i;
                return fact;
                
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine($"Factorial is: { Factorial.GetFactorial()}");
            Console.ReadLine();
            
        }
    }
}
