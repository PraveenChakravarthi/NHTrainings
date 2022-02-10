using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_13_Project_9
{
    // Author : Praveen Chakravarthi
    // Purpose : Stack
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> data = new Stack<int>();
            data.Push(12);
            data.Push(23);
            data.Push(20);
            data.Push(7);

            // Popping the Values
            Console.WriteLine("Count Before Pop");
            Console.WriteLine(data.Count);
            Console.WriteLine("Popping element");
            Console.WriteLine(data.Pop());
            Console.WriteLine("Count After Pop");
            Console.WriteLine(data.Count);

            // Peeking the Values
            Console.WriteLine("\n");
            Console.WriteLine("Count Before Peek");
            Console.WriteLine(data.Count);
            Console.WriteLine("Peeking element");
            Console.WriteLine(data.Peek());
            Console.WriteLine("Count After Peek");
            Console.WriteLine(data.Count);
            Console.ReadLine();


        }
    }
}
