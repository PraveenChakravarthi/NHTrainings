using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_10_Project_2
{
    // Author : Praveen Chakravarthi
    // Purpose : Another Sample Code for Abstraction


    abstract class Company
    {
        public string GetName()
        {
            return ("NB HealthCare");
        }
        public string GetLoc()
        {
            return ("Hitech city");
        }

        public abstract int GetId();
        public abstract int GetSalary();
    }
    class Developer : Company
    {
        public override int GetId()
        {
            return 101;
        }

        public override int GetSalary()
        {
            return 70000;
        }
    }

    class Analyst : Company
    {
        public override int GetId()
        {
            return 201;
        }

        public override int GetSalary()
        {
            return 50000;
        }
    }

    class Tester : Company
    {
        public override int GetId()
        {
            return 301;
        }

        public override int GetSalary()
        {
            return 40000;
        }
    }
    class Designer : Company
    {
        public override int GetId()
        {
            return 401;
        }

        public override int GetSalary()
        {
            return 55000;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Object for Developer

            // Object for Analyst

            // Object for Tester

            // Object for Designer

            Console.WriteLine("Processing Completed");

            Console.ReadLine();
        }
    }
}
