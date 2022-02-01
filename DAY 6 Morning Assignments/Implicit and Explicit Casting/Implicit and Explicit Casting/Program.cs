using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implicit_and_Explicit_Casting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Implicit Type Casting

            float p = 45.235f;
            double q = p;

            Console.WriteLine(q);

            // Explicit Type Casting

            double a = 78.2455455776888d;
            float b = (float)a;
            Console.WriteLine(b);

            Console.ReadLine();
        }
    }
}
