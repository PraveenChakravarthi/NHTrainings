using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_7_Project_1
{
    // Author : Praveen Chakravarthi
    // Purpose : Employee Class Program

        // Class
        class Employee
        {
            public string Name;
            public int Age;
            public string Address;

            // Methods
            public void ReadEmployee()
            {
                Console.WriteLine("Enter the Name: ");
                Name = Console.ReadLine();

                Console.WriteLine("Enter the Age: ");
                Age = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the Address: ");
                Address = Console.ReadLine();
            }

            public void PrintEmployee()
            {
                Console.WriteLine($"Name={Name},Age={Age},Address={Address}");
            }

        }
    internal class Program
    {

        static void Main(string[] args)
        {
            Employee emp1 = new Employee();

            emp1.ReadEmployee();
            emp1.PrintEmployee();

            Console.ReadLine();
        }
    }
}
