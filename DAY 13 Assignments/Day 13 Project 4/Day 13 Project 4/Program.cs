using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_13_Project_4
{
    // Author : Praveen Chakravarthi
    // Purpose : Reading Array Values from User
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] data = new int[2, 2];

            // Reading data from User
            for (int i = 0; i < 2; i++) 
            {
                for (int j = 0; j < 2; j++) 
                {
                    Console.WriteLine("Enter Number at {0}: ",(i,j));
                    data[i,j]=Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("\n");

            // Printing the data given by the user
            Console.WriteLine("The input in Matrix form is: ");
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
