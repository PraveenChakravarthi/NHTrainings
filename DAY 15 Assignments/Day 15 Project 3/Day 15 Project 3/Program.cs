using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_15_Project_3
{
    // Author : Praveen Chakravarthi
    // Purpose : Appending the Data using StreamWriter Class
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("C:\\Day 15 Assignments\\Day 15 Project 3\\C#.txt", true);
            sw.WriteLine("This is Praveen Chakravarthi");
            sw.WriteLine("We are Learning how to Append text in Files");
            sw.Close();
            Console.WriteLine("File Done");
            Console.ReadLine();
        }
    }
}
