using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_20_Project_3
{
    // Author : Praveen Chakravarthi
    // Purpose : Usage of Out, Ref Parameters in C#
    public class Program
    { 
        public static void Out(out int a)
        {
            a = 5;
        }
        public static void Ref(ref int b)
        {
            b = 10;
        }
        static void Main(string[] args)
        {
            int c;
            int d = 3;

            Out(out c); // Updating the 'c' value using out parameter
            Ref(ref d); // Changing the 'd' value using ref parameter

            Console.WriteLine($"Updated Value is: {c}");
            Console.WriteLine($"Changed Value is: {d}");
            Console.ReadLine();
        }
    }
}
