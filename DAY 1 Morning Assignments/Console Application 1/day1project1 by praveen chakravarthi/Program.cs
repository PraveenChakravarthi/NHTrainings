using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day1project1_by_praveen_chakravarthi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fn, sn, sum = 0;
            fn = 10;
            Console.WriteLine("enter first number:");
            fn =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter second number:");

            sn = Convert.ToInt32(Console.ReadLine());

            sum = fn + sn;

            Console.WriteLine("sum="+sum);

            Console.ReadLine();
        }
    }
}
