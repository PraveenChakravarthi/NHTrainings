using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_13_Project_10
{
    internal class Program
    {
        // Author : Praveen Chakravarthi
        // Purpose : Queue 
        static void Main(string[] args)
        {
            Queue<int> data = new Queue<int>();
            data.Enqueue(34);
            data.Enqueue(13);
            data.Enqueue(9);
            data.Enqueue(79);
            data.Enqueue(62);

            // Dequeueing the Values
            Console.WriteLine("Count Before Dequeue");
            Console.WriteLine(data.Count);
            Console.WriteLine("Popping element");
            Console.WriteLine(data.Dequeue());
            Console.WriteLine("Count After Dequeue");
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
