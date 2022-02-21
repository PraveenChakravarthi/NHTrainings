using MyClientApp.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyClientApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MathOperationsSoapClient MO = new MathOperationsSoapClient();
            Console.WriteLine($"Factorial is : {MO.Factorial(5)}");
            Console.WriteLine($"Sum is : {MO.Add(3,5)}");
            Console.WriteLine($"Product is : {MO.Mul(2,3)}");
            Console.WriteLine($"Difference is : {MO.Sub(5,2)}");
            Console.ReadLine();
        }
    }
}
