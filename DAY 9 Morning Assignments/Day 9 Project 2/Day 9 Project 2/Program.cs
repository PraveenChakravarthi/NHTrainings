using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_9_Project_2
{
    // Author : Praveen Chakravarthi
    // Purpose : Arithmetic Operations using MathsTasks Class
    class MathsTasks
    {
        private int a;
        private int b;

        /// <summary>
        /// This Method reads input from the user
        /// </summary>
        public void Readinput()
        {
            Console.WriteLine("Enter first Number: ");
            a= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            b= Convert.ToInt32(Console.ReadLine());
        }

        /// <summary>
        /// This Method Adds the given Numbers
        /// </summary>
        /// <returns></returns>
        public int AddNumbers()
        {
            return a + b;
        }

        /// <summary>
        /// This Method Subracts the given Numbers
        /// </summary>
        /// <returns></returns>
        public int SubtractNumbers()
        {
            return a - b;
        }

        /// <summary>
        /// This Method Multiplies the given Numbers 
        /// </summary>
        /// <returns></returns>
        public int MultiplyNumbers()
        {
            return a * b;
        }

        public int DivideNumbers()
        {
            return a/b;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MathsTasks math = new MathsTasks();
            math.Readinput();
            Console.WriteLine(math.AddNumbers());
            Console.WriteLine(math.SubtractNumbers());
            Console.WriteLine(math.MultiplyNumbers());
            Console.WriteLine(math.DivideNumbers());

            Console.ReadLine();

        }
    }
}
