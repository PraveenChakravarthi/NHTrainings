using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChakravarthiLibrary
{
    public class Mathematics
    {
        int n;
        public void ReadInput()
        { 
            Console.WriteLine("Enter any Number: ");
            n = Convert.ToInt32(Console.ReadLine());
        }
            public int GetFactorial()
            {
                int fact = 1;
                for (int i = 1; i <= n; i++)
                    fact = fact * i;
                 return fact; 
        }
    }
}

