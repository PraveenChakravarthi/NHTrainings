using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day1project3_by_praveen_chakravarthi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fn, sn, sum=0 ;
            int p = 1;
            fn = 0; 
            Console.WriteLine("enter first number:");
            fn = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter second number:");
            sn = Convert.ToInt32(Console.ReadLine());

            for(int i=1; i <= sn; i++)
            p = p * fn;

            Console.WriteLine("power =" +p);
            Console.ReadLine();

        }
    }
}
