using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_List_Program_to_Find_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList data = new ArrayList();
            int sum=0;

            data.Add(10);
            data.Add(20);
            data.Add(30);
            data.Add(40);
            data.Add(50);

            for (int i = 0; i < data.Count; i++)
                sum = sum + (int)data[i];

            Console.WriteLine("sum = {0}", sum);

            Console.ReadLine();

        }
    }
}
