using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Program_to_find_sum_using_various_loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> data = new List<int>();
            int sum = 0, sum1 = 0, sum2 = 0;
            int temp;


            // read from the user
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("enter any number: ");
                temp = Convert.ToInt32(Console.ReadLine());
                data.Add(temp);
            }

            // finding sum using for loop
            for (int i=0; i<data.Count; i++)
                sum = sum + data[i];

            // finding sum using foreach loop
            foreach (var d in data)
                sum1 = sum1 + d;

            // finding sum using Lamba Expression
            data.ForEach(d=> sum2 = sum2 + d);

            Console.WriteLine("sum using for loop = {0}", sum);
            Console.WriteLine("sum using foreach loop = {0}", sum1);
            Console.WriteLine("sum using Lambda Expression = {0}", sum2);
            Console.ReadLine();

        }
    }
}
