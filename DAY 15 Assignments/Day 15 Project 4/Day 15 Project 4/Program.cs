using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_15_Project_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Content in the file is: ");
            Console.WriteLine(File.ReadAllText("C:\\Day 15 Assignments\\Day 15 Project 4\\Read.txt"));
            Console.ReadLine();
        }
    }
}
