using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Program_to_find_sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> data = new List<int>();
            int sum = 0;   

            data.Add(10);
            data.Add(20);
            data.Add(30);
            data.Add(40);
            data.Add(50);

            for (int i=0; i< data.Count; i++)
                sum = sum + data[i];
            Console.WriteLine("sum = {0}", sum);
            Console.ReadLine();

        }
    }
}
