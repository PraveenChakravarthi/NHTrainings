using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_11_Project_2
{
    // Author : Praveen Chakravarthi
    // Purpose : Sample code for Properties

    class Employee
    {
        private int id;
        private string name;
        private string designation;
        private int salary;

        public int Id
        {
            get 
            {
                return id;
            }
            set
            {
                id = value ;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                 name = value;
            }
        }
        public string Designation
        {
            set // Write only
            {
                designation = value;
            }
        }
        public int Salary
        {
            get  // Read only
            {
                salary= (designation == "S")? 30000:50000;
                return salary;
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
