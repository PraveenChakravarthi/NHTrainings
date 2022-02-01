using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printing_List_program_using_various_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> data = new List<string>();
            

            data.Add("Pacific Ocean");
            data.Add("Indian Ocean");
            data.Add("Arctic Ocean");
            data.Add("Atlantic Ocean");
            data.Add("Southern Ocean");

            // printing values using For loop
            Console.WriteLine("****************************");
            Console.WriteLine("using for loop");
            Console.WriteLine("****************************");

            for (int i=0; i<data.Count; i++)

            Console.WriteLine(data[i]);

            // printing values using foreach loop
            Console.WriteLine("****************************");
            Console.WriteLine("using foreach loop");
            Console.WriteLine("****************************");

            foreach (var d in data)

                Console.WriteLine(d);

            // printing values using Lambda Expression
            Console.WriteLine("****************************");
            Console.WriteLine("using lambda exprssion");
            Console.WriteLine("****************************");

            data.ForEach(p=> Console.WriteLine(p));

            Console.ReadLine();
        }
    }
}
