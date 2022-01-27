using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplictaion_using_while_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input, i = 1;
            Console.WriteLine("enter any number");
            input = Convert.ToInt32(Console.ReadLine());
            while(i<=10)
            { 
        Console.WriteLine("{0}x{1}={2}",input,i,input*i);
                i++;
            }
            Console.ReadLine();
        }
    }
}
