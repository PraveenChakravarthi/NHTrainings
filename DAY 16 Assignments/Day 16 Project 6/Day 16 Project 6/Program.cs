using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_16_Project_6
{
    // Author : Praveen Chakravarthi
    // Purpose : Multiplication using OOPS Concept
    internal class Program
    {
        class MultiplicationTable
        {
            /// <summary>
            /// This Method gives the Multiplication of a given Number
            /// </summary>
            public static void GetMultiplication(int n)
            {
                
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"{n} x {i} = {n*i}");
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Multiplication table for 10: \n");
            MultiplicationTable.GetMultiplication(10);
            Console.ReadLine();
        }
    }
}
