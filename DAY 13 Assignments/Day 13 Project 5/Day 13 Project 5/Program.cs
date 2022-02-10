using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_13_Project_5
{
    // Author : Praveen Chakravarthi
    // Purpose : Sum of two 2-d Arrays
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] data1 = new int[2,2];
            for (int i = 0;i<2; i++)
            {
                for (int j = 0;j<2;j++)
                {
                    Console.WriteLine($"Enter the input at ({i},{j}): ");
                    data1[i, j] = Convert.ToInt32(Console.ReadLine());

                }
            }
            Console.WriteLine("\n");
            Console.WriteLine("Matrix A: ");
            Console.WriteLine("\n");

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(data1[i, j] + " ");

                }
                Console.WriteLine("\n");
            }

            int[,] data2 = new int[2, 2];

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine($"Enter the input at ({i},{j}): ");
                    data2[i, j] = Convert.ToInt32(Console.ReadLine());

                }
            }
            Console.WriteLine("\n");
            Console.WriteLine("Matrix B: ");
            Console.WriteLine("\n");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(data2[i, j] + " ");

                }
                Console.WriteLine("\n");
            }

            int[,] sum = new int[2, 2];
            for (int i=0; i < 2; i++)
            {
                for (int j=0;j<2;j++)
                {
                    // Adding the Matrices
                    sum[i, j] = data1[i, j] + data2[i, j];
                }
            }
            Console.WriteLine("The sum of Matrices : ");
            Console.WriteLine("\n");
            for (int i = 0;i < 2; i++)
            {
                for (int j=0;j<2;j++)
                {
                    Console.Write(sum[i,j] + " ");
                }
                Console.WriteLine("\n");
            }
            Console.ReadLine();
        }
    }
}
