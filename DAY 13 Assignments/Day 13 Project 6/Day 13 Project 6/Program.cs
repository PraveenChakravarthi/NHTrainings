using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_13_Project_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m ;
            int n ;
           
            Console.WriteLine("enter no of rows in matrix A: ");
            m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter no of columns in matrix A: ");
            n = Convert.ToInt32(Console.ReadLine());
            


            int[,] MatrixA = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine($"Enter the input at ({i},{j}): ");
                    MatrixA[i,j] = Convert.ToInt32(Console.ReadLine());

                }
            }
            Console.WriteLine("\n");
            Console.WriteLine("Matrix A: ");
            Console.WriteLine("\n");

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(MatrixA[i, j] + " ");

                }
                Console.WriteLine("\n");
            }

            Console.WriteLine("enter no of rows in matrix B: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter no of columns in matrix B: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int[,] MatrixB = new int[a, b];

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    Console.WriteLine($"Enter the input at ({i},{j}): ");
                    MatrixB[i, j] = Convert.ToInt32(Console.ReadLine());

                }
            }
            Console.WriteLine("\n");
            Console.WriteLine("Matrix B: ");
            Console.WriteLine("\n");
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    Console.Write(MatrixB[i, j] + " ");

                }
                Console.WriteLine("\n");
            }

            Console.WriteLine("Prouct of A and B is MatrixC: ");
            Console.WriteLine("\n");
            if (n == a)
            {
                int[,] MatrixC = new int[m, b];

                for (int i = 0; i < m; i++)//rows of Matrix C
                {
                    for (int j = 0; j < b; j++)// columns of Matrix C
                    {
                        MatrixC[i,j] = 0;

                        for (int k = 0; k < a; k++)
                        {
                            MatrixC[i,j] += MatrixA[i,k] * MatrixB[k,j];
                           
                        }
                        Console.Write(MatrixC[i, j] + " ");
                    }
                    Console.WriteLine("\n");
                }
            }
            Console.ReadLine();
        }
    }
}
