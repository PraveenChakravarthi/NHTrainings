using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_14_Project_7
{
    // Author : Praveen Chakravarthi
    // Purpose : Print number which is divisible by 97 just after 1000
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 97;
            int x;
            for (x=1000; x < 1097; x++)
            {
                if (x % n == 0)
                    break;
            }
            Console.WriteLine($"The number divisible by 97 just after 1000 is {x}");
            Console.ReadLine();
        }
    }
}
