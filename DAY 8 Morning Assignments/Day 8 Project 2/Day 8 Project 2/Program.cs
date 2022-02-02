using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_8_Project_2
{
    // Author : Praveen Chakravarthi
    // Purpose : Employee Class list

    class Employee
    {
        public int id;
        public string Name;
        public int Salary;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> emp = new List<Employee>()
            {
              new Employee(){id=101, Name="Sandeep", Salary=2000},
              new Employee(){id=102, Name="Adarsh", Salary=4000},
              new Employee(){id=103, Name="Ravi", Salary=6000},
              new Employee(){id=104, Name="Sanjay", Salary=7000},
              new Employee(){id=105, Name="Bunty", Salary=10000}
            };

            // using for Loop
            Console.WriteLine("**************");
            Console.WriteLine("using for Loop");
            Console.WriteLine("**************");

            for (int i = 0; i < emp.Count; i++)
            {
                Console.WriteLine($"id={emp[i].id}, Name={emp[i].Name}, Salary={emp[i].Salary}");
            }

            // using foreach Loop
            Console.WriteLine("******************");
            Console.WriteLine("using foreach Loop");
            Console.WriteLine("******************");

            foreach (var e in emp)
            {
                Console.WriteLine($"id={e.id}, Name={e.Name}, Salary={e.Salary}");
            }

            // using Lambda Expression
            Console.WriteLine("***********************");
            Console.WriteLine("using Lambda Expression");
            Console.WriteLine("***********************");

            emp.ToList().ForEach(e => Console.WriteLine($"id={e.id}, Name={e.Name}, Salary={e.Salary}"));

            // using Linq Query
            Console.WriteLine("****************");
            Console.WriteLine("using Linq Query");
            Console.WriteLine("****************");

            var Result= from e in emp
                        select e;
            Result.ToList().ForEach(e => Console.WriteLine($"id={e.id}, Name={e.Name}, Salary={e.Salary}"));

            Console.ReadLine();
        }
    }
}
