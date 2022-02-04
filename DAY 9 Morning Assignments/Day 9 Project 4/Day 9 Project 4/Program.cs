using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_9_Project_4
{
    // Author : Praveen Chakravarthi
    // Purpose : Employeee Class with 2 Constructors

    class Employee
    {
        public int id;
        public string name;
        public int salary;
        public static string company = "Nations Benefits";

        public Employee()
        {
            this.id = 0;
            this.name = null;
            this.salary = 0;
        }
        public Employee(int id, string name, int salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }
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

            Employee emp1 = new Employee(2, "Rohit", 24000);
            emp1.PrintEmployee();
            Console.ReadLine();
        }
    }
}
