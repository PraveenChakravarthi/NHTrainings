using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPraveenLibrary
{
    public class Mathematics
    {
        int n;
        public static int GetFactorial()
        {
            int n; int fact = 1;
            Console.WriteLine("Ënter any Number: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
                fact = fact * i;
            return fact;
        }

        public static int GetMul(int a, int b)
        {

            return a * b;
        }

        public static int GetDiv(int a, int b)
        {
            return a / b;
        }
    }
}
