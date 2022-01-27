using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_of_n_natural_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variable declaration
            int i, input, sum = 0;

            //read from user
            
            Console.WriteLine("enter any Number");
            input = Convert.ToInt32(Console.ReadLine());

            //logic

            for (i = 0; i <= input; i++)
                sum = sum + i;

            //output
            Console.WriteLine(sum);
            Console.ReadLine();

        }
    }
}
