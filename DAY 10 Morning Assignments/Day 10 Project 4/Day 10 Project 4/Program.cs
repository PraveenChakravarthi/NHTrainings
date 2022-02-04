using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_10_Project_4
{
    // Author : Praveen Chakravarthi
    // Purpose : Sample Code for Method OverRiding

    class Hyderabad
    { 
        public void PrintHi()
        {
            Console.WriteLine("HI");
        }
        
        public void PrintHello()
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
        public new void PrintHello()
        {
            Console.WriteLine("Jullay");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Ladakh data = new Ladakh();
            data.PrintHi();
            data.PrintHello();
            data.PrintWU(); 
            

            Console.ReadLine();
        }
    }
}
