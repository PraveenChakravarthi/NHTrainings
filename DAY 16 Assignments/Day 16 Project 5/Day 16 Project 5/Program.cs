using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CPraveenLibrary;

namespace Day_16_Project_5
{
    // Author : Pravee Chakravarthi
    // Purpose : Various Methods using Libraries
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Division is: {Mathematics.GetDiv(10, 5)}\nDistance is : {Physics.GetDistance(10, 4)}\nFormula for Gypsum : {Chemistry.GetGypsum()}");
            
            Console.ReadLine();
        }
    }
}
