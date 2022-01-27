using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addition_using_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // variable declaration
            double sum =0, average=0;
            double [] data = new double [5];

            // read data from user

            for (int i = 0; i < data.Length; i++)
            {
                Console.WriteLine("Enter Number:");
                data[i] =Convert.ToInt32(Console.ReadLine());
            }
                // logic

                for (int i=0; i <data.Length; i++)
                {
                    sum = sum + data[i];
                }
                average = sum / data.Length;
                
                Console.WriteLine(sum);
            Console.WriteLine(average);
               
            Console.ReadLine();
            }
        }
    }

