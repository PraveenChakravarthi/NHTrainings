using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_13_Project_3
{
    // Author : Praveen Chakravarthi
    // Purpose : Trace of Array
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] data = new int[3, 3];
            int sum=0;
            
            data[0, 0] = 1;
            data[0, 1] = 3;
            data[0, 2] = 2;
            data[1, 0] = 9;
            data[1, 1] = 4;
            data[1, 2] = 5;
            data[2, 0] = 8;
            data[2, 1] = 7;
            data[2, 2] = 6;

            for(int i=0; i<3; i++)
            {
                for (int j=0; j<3; j++)
                {
                    // Condition for Trace
                    if (i == j)
                        sum = sum + data[i, j];
                }
            }
            Console.WriteLine("The Trace of given Input is: ");
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
