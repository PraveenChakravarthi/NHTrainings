using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_10_Project_5
{
    // Author : Praveen Chakravarthi
    // Purpose : Sample Code for Method OverRiding using keywords

    class Hyderabad
    {
        public void PrintHi()
        {
            Console.WriteLine("Hi");
        }

        public virtual void PrintHello()
        {
            Console.WriteLine("Hello");
        }

        public void PrintWU()
        {
            Console.WriteLine("What's up");
        }
    }

    class Ladakh : Hyderabad
    {
        public override void PrintHello()
        {
            Console.WriteLine("Jullay");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Ladakh data = new Ladakh();

            Console.WriteLine("*********************");
            Console.WriteLine("using Keywords");
            Console.WriteLine("*********************");
            data.PrintHi();
            data.PrintHello();
            data.PrintWU();


            Console.ReadLine();
        }
    }
}
