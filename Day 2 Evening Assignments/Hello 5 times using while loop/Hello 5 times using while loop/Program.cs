using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_5_times_using_while_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // variable declaration

            int i=1;

            while(i<=5)
            {
                Console.WriteLine("Hello");
                i++;
            }
            Console.ReadLine(); 
        }
    }
}
