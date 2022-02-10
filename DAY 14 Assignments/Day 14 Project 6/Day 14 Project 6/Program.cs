using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_14_Project_6
{
    // Author : Praveen Chakravarthi
    // Purpose : Printing Numbers between 1 & 30 and skip numbers divisible by 3 using continue
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;

            for (i = 1; i <30; i++)
            {
                if (i % 3 == 0)
                    continue;
                Console.WriteLine(i);
            }
            
            Console.ReadLine();
        }
    }
}
