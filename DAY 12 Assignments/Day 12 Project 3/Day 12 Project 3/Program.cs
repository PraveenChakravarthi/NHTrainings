using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_12_Project_3
{
    // Author : Praveen Chakravarthi
    // Purpose : Finally block Example
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a;
                int b;
                int c;

                Console.WriteLine("Enter any Number: ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter any Number: ");
                b = Convert.ToInt32(Console.ReadLine());

                c = a / b;
                Console.WriteLine($"Result = {c}");

            }

            // Exceptions 

            catch (FormatException)
            {
                Console.WriteLine("Wrong input. Only enter Numbers");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Only numbers between -2147483647 and 2147483647 are allowed");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Number cannot be divide by zero. Undefined");
            }

            // Super Exception

            catch (Exception)
            {
                Console.WriteLine("Some Error Occured. Please contact abc@gmail.com");
            }

            // Finally Block
            finally
            {
                Console.WriteLine("\n\n\n\nDesigned by Praveen Chakravarthi");
                Console.ReadLine();
            }
        }
    }
}
