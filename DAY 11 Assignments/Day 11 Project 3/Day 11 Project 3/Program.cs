using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_11_Project_3
{
    // Author : Praveen Chakravarthi
    // Purpose : Employee class with only Properties


    class Employee
    {
        public int Id
        {
            get
            {
                return Id;
            }
            set
            {
                Id = value;
            }
        }
        public string Name
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value;
            }
        }
        public string Designation
        {
            set // Write only
            {
                Designation = value;
            }
        }
        public int Salary
        {
            get
            {
                Salary = (Designation == "S") ? 30000 : 50000;
                return Salary;
            }

        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.Designation = "M";

            Console.WriteLine($"Salary : {emp.Salary}");
            Console.ReadLine();
        }
    }
}
