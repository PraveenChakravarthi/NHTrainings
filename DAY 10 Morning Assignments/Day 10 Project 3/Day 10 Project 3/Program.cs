using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_10_Project_3
{
    // Author : Praveen Chakravarthi
    // Purpose : Sample Code for Method Overloading

    class MO
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public float Add(float a, float b)
        {
            return a + b;
        }
    
        public int Add(int a, int b, int c)
        {
                return a + b +  c;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MO data = new MO();
            Console.WriteLine($"Sum is : {data.Add(2.4f,4.5f)}");

            Console.ReadLine();
        }
    }
}
