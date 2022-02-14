using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PraveenChakravarthiLibrary;
using PublicLibrary;

namespace ClientApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Product = {Mathematics.GetMul(9, 3)}\nDifference = {Mathematics.GetDiff(4,2)}\nFormula for Methane = {Chemistry.GetMethane()}\nFormula for Benzene = {Chemistry.GetBenzene()}");
            Console.WriteLine($"Division : {Mathematics.GetDiv(10,5)}");
            Console.ReadLine();
        }
    }
}
