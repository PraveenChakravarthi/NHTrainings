using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_13_Program_7
{
    // Author : Praveen Chakravarthi
    // Purpose : Jagged Arrays
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] data = new int[4][];
            data[0] = new int[] { 1 };
            data[1] = new int[] { 1, 2, 40 };
            data[2] = new int[] { 1, 2, 3, 5 };
            data[3] = new int[] { 4, 6 };
            
            for (int i=0; i<4; i++)
            {
                for (int j =0;j<data[i].Length; j++)
                {
                    Console.Write(data[i][j] + " ");
                }
                Console.WriteLine("\n");
            }
            Console.ReadLine();
        }
    }
}
