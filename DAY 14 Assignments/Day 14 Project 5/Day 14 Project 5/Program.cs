using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_14_Project_5
{
    // Author : Praveen Chakravarthi
    // Purpose : Prime Number program using Break
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, n;
            Console.WriteLine("Ënter any Number: ");
            n = Convert.ToInt32(Console.ReadLine());

            for ( i = 2; i < n; i++)
            {
                if (n % i == 0)
                    break;
            }
                if (i == n)

                    Console.WriteLine("The Input {0} is Prime Number", n);
                else
                    Console.WriteLine("The Input {0} is Composite Number", n);
            Console.ReadLine();
        }
    }
}
