using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DataAccessLayer
{
    // Author : Praveen Chakravarthi
    // Purpose : Data Access Layer Library
    public static class EmployeeDAL
    {
        public static string FilePath = "C:\\Day 22 Project\\Emolyees.txt";
        /// <summary>
        /// This Method Adds Employees Data
        /// </summary>
        public static bool AddEmployee(int ID, string Name, int Salary, int Age)
        {
            try
            {
                string Content = string.Concat(ID, ",", Name, ",", Salary, ",", Age);
                File.AppendAllText(FilePath, Content + Environment.NewLine);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// This Method is used to Search an Employee by ID
        /// </summary>
        public static List<string> GetEmployeeByID(int ID)
        {
            var AllEmployees = File.ReadAllLines(FilePath);
            bool FileFound = false;
            List<string> EmployeeFound = new List<string>();

            foreach (var Employee in AllEmployees)
            {
                var Details = Employee.Split(',');
                if (Convert.ToInt32(Details[0]) == ID)
                {
                    FileFound = true;
                    EmployeeFound.Add(Employee);
                    break;
                }
            }
            return EmployeeFound;
        }
        /// <summary>
        /// This Method is used to Search an Employee by Name
        /// </summary>
        public static List<string> GetEmployeesByName(string Name)
        {
            var AllEmployees = File.ReadAllLines(FilePath);
            List<string> EmployeeFound = new List<string>();

            foreach (var Employee in AllEmployees)
            {
                var Details = Employee.Split(',');
                if (Details[1].Contains(Name))
                {
                    EmployeeFound.Add(Employee);
                }
            }

            if (EmployeeFound.Count > 0)
            {
                foreach (var Employee in EmployeeFound)
                {
                    Console.WriteLine(Employee);
                    break;
                }
            }
            return EmployeeFound;
        }
        /// <summary>
        /// This Method Displays all Employees Data
        /// </summary>
        public static string[] DisplayALlEmployees()
        {
            var Employees = File.ReadAllLines(FilePath);
            return Employees;
        }
    }
}
