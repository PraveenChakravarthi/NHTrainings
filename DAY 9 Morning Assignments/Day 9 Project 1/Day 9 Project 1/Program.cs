using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_9_Project_1
{
    // Author : Praveen Chakravarthi
    // Purpose : Mathematical Operations using Classes

    class MathsOperations
    {
        private int input;
        /// <summary>
        /// This method will read input from the user
        /// </summary>
        public void ReadInput()
        {
            Console.WriteLine("Enter input");
            input = Convert.ToInt32(Console.ReadLine());
        }
        /// <summary>
        /// this method will find factorial of a given Number
        /// </summary>
        
        // Factorial 
        public void Factorial()
        {
            int fact = 1;
            for (int i = 1; i <= input; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine($"factorial of {input} is {fact}");
        }
        /// <summary>
        /// This method will find factors of a given number
        /// </summary>
        public void PrintFactors()
        {
            for (int i = 1; i <= input; i++)
            {
                if (input % i == 0)
                    Console.WriteLine(i);
            }
        }
        /// <summary>
        /// This method will find the given number is prime or composite
        /// </summary>
        /// <returns></returns>
        public bool IsPrime()
        {
            int count = 0;
            for (int i = 1; i <= input; i++)
            {
                if (input % i == 0)
                    count++;
            }
            if (count == 2)
                return true;
            else
                return false;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        MathsOperations obj = new MathsOperations();
        obj.ReadInput();
        obj.Factorial();
        obj.PrintFactors();
        if (obj.IsPrime())
            Console.WriteLine("The input Number is Prime");
        else
            Console.WriteLine("The input number is Composite");


        Console.ReadLine();
    }
    }
}
