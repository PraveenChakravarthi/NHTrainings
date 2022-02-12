using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Schedular_Program
{
    // Author : Praveen Chakravarthi
    // Purpose : Task Schedular Program
    internal class Program
    {
        static void Main(string[] args)
        {
            File.Copy("C:\\Day 15 Assignments\\Score.txt", "C:\\New folder\\Score2.txt");
            Console.WriteLine("The File is Copied");
            Console.ReadLine();
        }
    }
}
