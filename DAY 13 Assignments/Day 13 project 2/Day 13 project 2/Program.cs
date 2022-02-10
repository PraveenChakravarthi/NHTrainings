using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_13_project_2
{
    // Author : Praveen Chakravarthi
    // Purpose : 2-d Array (3,2)
    internal class Program
    {
        static void Main(string[] args)
        {
            // Initialising values in same the line 

            int[,] data = new int[,] { { 2, 3 },{ 3, 2 },{ 4, 5 } };

            Console.WriteLine("The given input in the form of Matrix: ");
            Console.WriteLine("\n");

            for (int i=0; i<3; i++)
            {
                for (int j=0; j<2;j++)
                {
                    Console.Write(data[i,j] + " ");
                }
                Console.WriteLine("\n");
            }
            Console.ReadLine();
        }
    }
}
