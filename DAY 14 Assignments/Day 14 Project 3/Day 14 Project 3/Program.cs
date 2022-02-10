using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_14_Project_3
{
    // Author : Praveen Chakravarthi
    // Purpose : Auto-implemented Properties
    internal class Program
    {
        class SimpleInterest
        {
            private int principle;
            private int time;
            private int rate;

            public int Principle
            {
                set
                {
                    principle = value;
                }
            }
            public int Time
            {
                set
                {
                    time = value;
                }
            }
            public int Rate
            {
                set
                {
                    rate = value;
                }
            }

            // Auto-implmented Property
            public int SI
            {
                get
                {
                   return  (principle * time * rate) / 100;
                   
                }
            }

        }
        static void Main(string[] args)
        {
            SimpleInterest sit = new SimpleInterest();
            sit.Principle = 20;
            sit.Time = 3;
            sit.Rate = 30;

            Console.WriteLine($"Simple Interest is : {sit.SI}");
            Console.ReadLine();
        }
    }
}
