using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_7_Project_4
{
    // Author : Praveen Chakravarthi
    // Purpose : Employees class using Arrays and Printing Values using Various loops

    // Class Employee

    class Employee
  
    {
        public int Id;
        public string Name;
        public int Salary;

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] emp = new Employee[]
            {
            new Employee() {Id=1, Name= "Akash", Salary=25000},
            new Employee() {Id=2, Name= "Bhanu", Salary=30000},
            new Employee() {Id=3, Name= "Ramu", Salary=35000},
            new Employee() {Id=4, Name= "Dinesh", Salary=40000},
            new Employee() {Id=5, Name= "Sai", Salary=50000}

            };
            // Printing Values using For Loop
            for (int i = 0; i < emp.Length; i++)
            {
                Console.WriteLine($"Id={emp[i].Id}, Name={emp[i].Name}, Salary={emp[i].Salary}");
            }
            
            // Printing Values using Foreach Loop
            foreach (var e in emp)
            {
                Console.WriteLine($"Id={e.Id}, Name= {e.Name}, Salary= {e.Salary}");
            }

            // Printing Values of using Lambda Expression

            emp.ToList().ForEach(e => Console.WriteLine($"Id={e.Id}, Name= {e.Name}, Salary= {e.Salary}")) ;

            Console.ReadLine();
        }
    }
}
