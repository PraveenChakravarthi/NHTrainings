using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_8_Project_5
{
    // Author : Praveen Chakravarthi
    // Purpose : IPL Class

    class IPL
    {
        public string TeamName;
        public int NoOfWins;
        public string Captain;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IPL> data = new List<IPL>()
            {
                new IPL(){TeamName="SRH", NoOfWins=2, Captain="David Warner"},
                new IPL(){TeamName="CSK", NoOfWins=4, Captain="MS Dhoni"},
                new IPL(){TeamName="MI", NoOfWins=5, Captain="Rohit Sharma"},
                new IPL(){TeamName="RR", NoOfWins=1, Captain="Shane Warne"},
            };

            // using for Loop
            Console.WriteLine("**************");
            Console.WriteLine("using for Loop");
            Console.WriteLine("**************");

            for (int i = 0; i < data.Count; i++)
            {
                if (data[i].NoOfWins >= 2)
                    Console.WriteLine(data[i].TeamName + "-" + data[i].Captain);
            }
            // using foreach Loop
            Console.WriteLine("******************");
            Console.WriteLine("using foreach Loop");
            Console.WriteLine("******************");

            foreach (var d in data)
            {
                if (d.NoOfWins >= 2)
                    Console.WriteLine(d.TeamName + "-" + d.Captain);
            }

            // using Lambda Expression
            Console.WriteLine("***********************");
            Console.WriteLine("using Lambda Expression");
            Console.WriteLine("***********************");

            data.Where(d => d.NoOfWins >= 2).ToList().ForEach(d => Console.WriteLine(d.TeamName + "-" + d.Captain));


            // using Linq Query
            Console.WriteLine("****************");
            Console.WriteLine("using Linq Query");
            Console.WriteLine("****************");

            var Result = from d in data
                         where d.NoOfWins >= 2
                         select d;
            Result.ToList().ForEach(d => Console.WriteLine(d.TeamName + "-" + d.Captain));
           
            var Result1 = from d in data
                         where d.NoOfWins ==5
                         select d;
            Console.WriteLine("*************************************************************************");
            Result1.ToList().ForEach(d => Console.WriteLine("The Most Successful Team is: " + d.TeamName));
            Console.WriteLine("*************************************************************************");
            Console.ReadLine();
        }
    }
}
