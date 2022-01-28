using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial_of_a_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variable declaration

            int input, product =1, i;

            // User Input

            Console.WriteLine("enter any Number");
            input=Convert.ToInt32(Console.ReadLine());

            // Logic
            for (i = 1; i <= input; i++)
            {
                product = product * i;
            }
            // output

            Console.WriteLine(product);
                Console.ReadLine();
        }
    }
}
