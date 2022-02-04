using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_9_Project_3
{
    // Author : Praveen Chakravarthi
    // Purpose : Read and Print from Employee Class

    class Employee
    {
        public int id;
        public string name;
        public int salary;
        public static string company = "Nations Benefits";

            public void ReadEmployee()
        {
            Console.WriteLine("Enter Employee id: ");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter Employee Salary: ");
            salary = Convert.ToInt32(Console.ReadLine());
        }
        
        public void PrintEmployee()
        {
            Console.WriteLine($"Id={id}, Name={name}, Salary={salary} Company={company}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.ReadEmployee();
            emp.PrintEmployee();

            Employee emp1 = new Employee();
            emp1.ReadEmployee();
            emp1.PrintEmployee();

            Console.ReadLine();
        }
    }
}
