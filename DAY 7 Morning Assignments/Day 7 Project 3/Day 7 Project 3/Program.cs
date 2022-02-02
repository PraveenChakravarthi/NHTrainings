using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_7_Project_3
{
    // Author : Praveen Chakravarthi
    // Purpose : Initialising values while object creation to Employee Class
    class Employee
    {
        public string Name;
        public int Age;
        public string Address;
    }

    internal class Program
    {
        // Initialising Values at Object Creatiom
        static void Main(string[] args)
        {
            Employee emp1 = new Employee() { Name = "Pranay", Age = 23, Address = "Bangalore" };
            Console.WriteLine($"EmployeeName={emp1.Name}, EmployeeAge={emp1.Age}, EmployeeAddress={emp1.Address}");
            Console.ReadLine();
        }
    }
}
