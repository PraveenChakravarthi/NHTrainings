using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    // Author : Praveen Chakravarthi 
    // Purpose : Business Logic Layer Library
    public static class EmployeeBLL
    {
        /// <summary>
        /// This Method Adds Employees Data
        /// </summary>
        public static bool AddEmployee(int ID, string Name, int Salary, int Age)
        {
            var Result = EmployeeDAL.AddEmployee(ID, Name, Salary, Age);
            return Result;
        }
        /// <summary>
        /// This Method is used to Search an Employee by ID
        /// </summary>
        public static List<string> GetEmployeeByID(int ID)
        {
            var Result = EmployeeDAL.GetEmployeeByID(ID);
            return Result;
        }
        /// <summary>
        /// This Method is used to Search an Employee by Name
        /// </summary>
        public static List<string> GetEmployeesByName(string Name)
        {
            var Result = EmployeeDAL.GetEmployeesByName(Name);
            return Result;
        }
        /// <summary>
        /// This Method Displays all Employees Data
        /// </summary>
        public static string[] DisplayALlEmployees()
        {
            var Result = EmployeeDAL.DisplayALlEmployees();
            return Result;
            
        }
    }
}
