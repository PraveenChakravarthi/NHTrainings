using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_8_project_4
{
    // Author : Praveen Chakravarthi
    // Purpose : Department Class (if Condition)

    class Department
    {
        public int Id;
        public string Name;
        public int EmpCount;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Department> Dept = new List<Department>()
            {
                new Department() {Id = 201, Name = "Forest", EmpCount = 65},
                new Department() {Id = 301, Name = "Health", EmpCount = 70},
                new Department() {Id = 401, Name = "IncomeTax", EmpCount = 45},
                new Department() {Id = 501, Name = "Food", EmpCount = 35}
            };

            // using for loop
            Console.WriteLine("**************");
            Console.WriteLine("using for loop");
            Console.WriteLine("**************");

            for (int i = 0; i < Dept.Count; i++)
            {
                if (Dept[i].EmpCount > 50)
                    Console.WriteLine($"Id={Dept[i].Id}, Name={Dept[i].Name}");
            }

            // using foreach Loop
            Console.WriteLine("******************");
            Console.WriteLine("using foreach Loop");
            Console.WriteLine("******************");

            foreach (var d in Dept)
                if (d.EmpCount > 50)
                    Console.WriteLine($"Id={d.Id}, Name={d.Name}");

            // using Lambda Expression
            Console.WriteLine("***********************");
            Console.WriteLine("using Lambda Expression");
            Console.WriteLine("***********************");

            Dept.Where(d => d.EmpCount > 50).ToList().ForEach(d => Console.WriteLine($"Id={d.Id}, Name={d.Name}"));

            // using Linq Query
            Console.WriteLine("****************");
            Console.WriteLine("using Linq Query");
            Console.WriteLine("****************");

            var Result = from d in Dept
                         where d.EmpCount>50
                         select d;
            Result.ToList().ForEach(d => Console.WriteLine($"Id={d.Id}, Name={d.Name}"));
            Console.ReadLine();
        }
    }
}