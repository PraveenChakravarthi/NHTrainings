using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_8_Project_1
{
    // Author : Praveen Chakravarthi
    // Purpose : Print Even Numbers using Loops 
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> Numb = new List<int>() { 22, 43, 56, 67, 88, 47, 74, 89 };

            // using for Loop
            Console.WriteLine("**************");
            Console.WriteLine("using for loop");
            Console.WriteLine("**************");

            for (int i=0; i<Numb.Count; i++)
            {
                if(Numb[i]%2 == 0)
                Console.WriteLine(Numb[i]);
            }

            // using foreach Loop
            Console.WriteLine("******************");
            Console.WriteLine("using foreach loop");
            Console.WriteLine("******************");

            foreach (var d in Numb)
            {
                if (d%2==0)
                    Console.WriteLine(d);
            }

            // using Lambda Expression
            Console.WriteLine("***********************");
            Console.WriteLine("using Lambda Expression");
            Console.WriteLine("***********************");

            Numb.Where(d => d % 2 == 0).ToList().ForEach(d => Console.WriteLine(d));

            // using Linq Query
            Console.WriteLine("****************");
            Console.WriteLine("using Linq Query");
            Console.WriteLine("****************");

            var Result = from d in Numb
                         where d%2==0
                         select d;
            Result.ToList().ForEach(d => Console.WriteLine(d));
            Console.ReadLine();
        }
    }
}
