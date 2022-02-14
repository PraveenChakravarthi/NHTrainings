using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_16_Project_7
{
    // Author : Praveen Chakravarthi
    // Purpose : Palindrome using OOPS Concept
    internal class Program
    {
        class Palindrome
        { 
            /// <summary>
            /// This Method States whether the input is Palindrome or not
            /// </summary>
            public static void GetPalindrome()
            {
                int n, m, rem, rev = 0;

                Console.WriteLine("Enter a Number: ");
                n = Convert.ToInt32(Console.ReadLine());

                m = n;
                while (m > 0)
                {
                    rem = m % 10;
                    rev = (rev * 10) + rem;
                    m = m / 10;
                }
                if (n == rev)
                    Console.WriteLine("The Number {0} is a palindrome",n);
                else
                    Console.WriteLine("The Number {0} is not a Palindrome",n);
            }
        }
        static void Main(string[] args)
        {
            Palindrome.GetPalindrome();
            Console.ReadLine();
        }
    }
}
