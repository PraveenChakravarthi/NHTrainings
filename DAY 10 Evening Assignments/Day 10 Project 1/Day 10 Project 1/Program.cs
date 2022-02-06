using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_10_Project_1
{
    // Author : Praveen Chakravarthi
    // Purpose : Sample Code for Abstraction


    abstract class Salary
    {
        public int GetPF(int basic)
        {
            return 12 * basic / 100;
        }

        public int GetHRA(int basic)
        {
            return 40 * basic / 100;
        }

        public abstract int GetCA();
        public abstract int GetSA();
    }
    class Amazon : Salary
    {
        public override int GetCA()
        {
            return 6000;
        }

        public override int GetSA()
        {
            return 7000;
        }
    }

    class Tata : Salary
        {
            public override int GetCA()
            {
                return 3000;
            }

            public override int GetSA()
            {
                return 6000;
            }
        }

            class Facebook : Salary
            {
                public override int GetCA()
                {
                    return 7000;
                }

                public override int GetSA()
                {
                    return 9000;
                }
            }
                class Microsoft : Salary
                {
                    public override int GetCA()
                    {
                        return 2000;
                    }

                    public override int GetSA()
                    {
                        return 6000;
                    }
                }
    internal class Program
    {
        static void Main(string[] args)
        {
            // object for Amazon

            // object for Tata 

            // object for Facebook

            // object for Microsoft

            Console.WriteLine("Completed Processing");
            Console.ReadLine();
        }
    }
}
