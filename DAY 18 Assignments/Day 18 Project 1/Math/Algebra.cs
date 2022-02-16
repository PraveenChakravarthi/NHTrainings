using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary
{
     // Author : Praveen Chakravarthi
     // Purpose : Layered Architecture, Implementing TDD
    public class Algebra
    {
        /// <summary>
        /// This Method returns Factorial of a Number
        /// </summary>
        public static int Factorial(int n)
        {
            if (n== 0)
                return 1;

            else if (n < 0)
                return -9999;

            else if (n > 7)
                return -999;

            int fact = 1;
            for (int i =1; i <= n; i++)
                fact *= i;
            return fact;
      
        }
        public string Palindrome(int n)
        {
            int m, rem, rev = 0;
            m = n;
            while (m>0)
            {
                rem = m % 10;
                rev = (rev * 10) +rem;
                m = m / 10;
            }
            if (n == rev)
                return "Palindrome";
            else
                return "Not Palindrome";
        }
    }
}
