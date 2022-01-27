using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reading_Numbers_using_For_Each_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variable declaration

            int[] data = new int[4];

            // Read from user

            for (int i = 0; i < data.Length; i++)
            {
                Console.WriteLine("enter any number");
                data[i]=Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("the numbers you have entered are:");

            foreach (int d in data)
                Console.WriteLine(d);
            Console.ReadLine();
        }
    }
}
