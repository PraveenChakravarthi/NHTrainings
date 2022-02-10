using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_13_Project_1
{
    // Author : Praveen Chakravarthi
    // Purpose : 2-d Array (2,2)
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] data = new int [2,2];

            // Array initialisation using index

            data[0,0] = 1;
            data[0,1] = 2;
            data[1,0] = 3;
            data[1,1] = 4;

            Console.WriteLine("The given input in the form of Matrix is: ");
            Console.WriteLine("\n");

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(data[i, j] + " ");
                    
                }
                Console.WriteLine("\n");
            }
            Console.ReadLine();
        }
    }
}
