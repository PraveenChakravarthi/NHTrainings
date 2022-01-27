using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Initializing_Array_with_5_values_and_adding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum=0;
            int [] data = new int[]{5,10,15};

            foreach (int d in data)
                Console.WriteLine(d);
            foreach (int d in data)
                sum = sum + d;
            Console.WriteLine("The Sum of the Given Numbers is:{0}",sum); 
            Console.ReadLine();
        }
    }
}
