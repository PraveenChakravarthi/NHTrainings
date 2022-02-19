using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_20_Project_2
{
    // Author : Praveen Chakravarthi
    // Purpose : Nullable Types in C#
    internal class Program
    {
        static void Main(string[] args)
        {
            int? ID = 3; // Declaring Nullable to Value Type using '?'
            
            if (ID.HasValue) // Checks if ID has a Value
                Console.WriteLine($"ID is {ID}");
            else
                Console.WriteLine("No Value");
            Console.ReadLine();
        }
    }
}
