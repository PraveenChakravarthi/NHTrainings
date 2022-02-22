using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicLayer;

namespace EmployeeManagementApplication
{
    // Author : Praveen Chakravarthi
    // Purpose : Employee Management Application
    public static class Program
    {
        static void Main(string[] args)
        {
            int a; string b;

            Console.WriteLine("*************************************");
            Console.WriteLine("Employee Management Application");
            Console.WriteLine("*************************************");
            do
            {
                Console.WriteLine("1. Add Employee :");
                Console.WriteLine("2. Get Employee by ID :");
                Console.WriteLine("3. Get Employee by Name :");
                Console.WriteLine("4. Display All Employee :");
                Console.WriteLine("Enter Your Choice :");
                a = Convert.ToInt32(Console.ReadLine());
                switch (a)
                {
                    case 1:
                        AddEmployee();
                        break;
                    case 2:
                        GetEmployeeByID();
                        break;
                    case 3:
                        GetEmployeeByName();
                        break;
                    case 4:
                        DisplayAllEmployees();
                        break;
                    default:
                        Console.WriteLine("Invalid");
                        break;
                }
                Console.WriteLine("Do You want to Continue(y/n): ");
                b = Console.ReadLine();
            }
            while (b == "y");

        }
        /// <summary>
        /// This Method Adds Employees Data
        /// </summary>
        public static void AddEmployee()
        {
            // Reading from User
            int ID; string Name; int Salary; int Age;
            Console.WriteLine("Enter Employee ID :");
            ID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Name :");
            Name = Console.ReadLine();
            Console.WriteLine("Enter Employee Salary :");
            Salary = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Age :");
            Age = Convert.ToInt32(Console.ReadLine());

            // BLL Logic
            var Result = EmployeeBLL.AddEmployee(ID, Name, Salary, Age);
            if (Result)
                Console.WriteLine("Employees Details Added Succesfully");
            else
                Console.WriteLine("Error Occured");
        }
        /// <summary>
        /// This Method is used to Search an Employee by ID
        /// </summary>
        public static void GetEmployeeByID()
        {
            int ID;
            Console.WriteLine("Enter Employee ID to be Searched :");
            ID = Convert.ToInt32(Console.ReadLine());
            var Result = EmployeeBLL.GetEmployeeByID(ID);
                if (Result.Count == 0)
                Console.WriteLine("No Records");
                else
            {
                Result.ForEach(d => Console.WriteLine(d));
            }
        }
        /// <summary>
        /// This Method is used to Search an Employee by Name
        /// </summary>
        public static void GetEmployeeByName()
        {
            string Name;
            Console.WriteLine("Enter Name of the Employee to be Searched :");
            Name = Console.ReadLine();

            var Result = EmployeeBLL.GetEmployeesByName(Name);
            if (Result != null)
                Result.ForEach(d => Console.WriteLine(d));
            else
                Console.WriteLine("No Results");
        }
        /// <summary>
        /// This Method Displays all Employees Data
        /// </summary>
        public static void DisplayAllEmployees()
        {
            var Result = EmployeeBLL.DisplayALlEmployees();
            Result.ToList().ForEach(d => Console.WriteLine(d));
            Console.ReadLine();
        }
    }
}
